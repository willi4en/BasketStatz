using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasketStatz.Helpers;
using System.Windows.Input;
using MySql.Data.MySqlClient;
using System.Data;
using BasketStatz.Models;
using System.Collections.ObjectModel;
using System.Windows;
using System.ComponentModel;

namespace BasketStatz.ViewModels
{
    class Menu_VM : Base_VM
    {        
        public Menu_VM ()
        {             
            TeamList = Get_SQLTeams();
        }

        #region Constructors
        private IList<string> _teamList;
        public IList<string> TeamList
        {
            get { return _teamList; }
            set { _teamList = value; NotifyPropertyChanged(); }
        }

        private string _homeTeamSelected;
        public string HomeTeamSelected
        {
            get { return _homeTeamSelected; }
            set { _homeTeamSelected = value; NotifyPropertyChanged(); }
        }

        private string _awayTeamSelected;
        public string AwayTeamSelected
        {
            get { return _awayTeamSelected; }
            set { _awayTeamSelected = value; NotifyPropertyChanged(); }
        }

        private string _teamName = "Team Name...";
        public string TeamName
        {
            get { return _teamName; }
            set { _teamName = value; NotifyPropertyChanged(); }
        }

        private ObservableCollection<NewPlayer> _newPlayers = new ObservableCollection<NewPlayer>();
        public ObservableCollection<NewPlayer> NewPlayers
        {
            get { return _newPlayers; }
            set { _newPlayers = value; NotifyPropertyChanged(); }
        }

        private bool _gameInSession = false;
        public bool GameInSession
        {
            get { return _gameInSession; }
            set { _gameInSession = value; NotifyPropertyChanged(); }
        }


        #endregion

        #region Commands

        #region Add Player

        public ICommand AddPlayerCommand
        {
            get { return new RelayCommand(AddPlayer); }
        }

        private void AddPlayer()
        {
            NewPlayer newPlayer = new NewPlayer();
            _newPlayers.Add(newPlayer);            
        }

        #endregion

        #region Add Team
        public ICommand AddTeamCommand
        {
            get { return new RelayCommand(AddTeam); }
        }

        private void AddTeam()
        {
            // _newPlayers.Count >= 5 && 
            if (_teamName != "" && _teamName != "Team Name..." && _teamName != null)
            {
                List<Player> playerList = new List<Player>();
                foreach (NewPlayer newplayer in _newPlayers)
                {
                    Player player = new Player();
                    player.Name = newplayer.Name;
                    player.Number = newplayer.Number;
                    player.Age = newplayer.Age;
                    player.Height = newplayer.Height;
                    player.Team = _teamName;
                    playerList.Add(player);
                }
                AddTeamToDatabase(playerList);

                // Updates UI
                TeamName = "Team Name...";
                NewPlayers = new ObservableCollection<NewPlayer>();
                TeamList = Get_SQLTeams();

            }
            //else if (_newPlayers.Count < 5)
            //{
            //    MessageBox.Show("Please have a minimum of 5 players.", "Warning!", MessageBoxButton.OK, MessageBoxImage.Warning);
            //}
            else if (_teamName == "" || _teamName == "Team Name..." || _teamName == null)
            {
                MessageBox.Show("Please enter a team Name.", "Warning!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        #endregion

        #region New Game
        public ICommand NewGameCommand
        {
            get { return new RelayCommand(NewGame); }
        }

        private void NewGame()
        {
            if (HomeTeamSelected != null && AwayTeamSelected != null)
            {
                GameInSession = true;
            }
            else
            {
                MessageBox.Show("Please select teams to play in game.", "Warning!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        #endregion

        #region End Game
        public ICommand EndGameCommand
        {
            get { return new RelayCommand(EndGame); }
        }

        private void EndGame()
        {
            GameInSession = false;
        }
        #endregion

        #endregion

        #region MySQL Database

        #region Add Team To Database

        private void AddTeamToDatabase (List<Player> playerList)
        {
            MySqlConnection sqlConn = new MySqlConnection();
            MySqlCommand sqlCmd = new MySqlCommand();
            sqlConn.ConnectionString = SQLInfo.fullConnection;
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;

            sqlCmd.Parameters.Add("@name", MySqlDbType.VarChar);
            sqlCmd.Parameters.Add("@number", MySqlDbType.Int32);
            sqlCmd.Parameters.Add("@team", MySqlDbType.VarChar);
            sqlCmd.Parameters.Add("@height", MySqlDbType.VarChar);
            sqlCmd.Parameters.Add("@age", MySqlDbType.Int32);

            foreach (Player player in playerList)
            {
                sqlCmd.CommandText = "INSERT INTO player (name, number, team, height, age) " +
                "VALUES (@name, @number, @team, @height, @age)";

                sqlCmd.Parameters["@name"].Value = player.Name;
                sqlCmd.Parameters["@number"].Value = player.Number;
                sqlCmd.Parameters["@team"].Value = player.Team;
                sqlCmd.Parameters["@height"].Value = player.Height;
                sqlCmd.Parameters["@age"].Value = player.Age;

                sqlCmd.ExecuteNonQuery();
            }
            
            sqlConn.Close();
        }

        #endregion

        #region Get SQL Teams
        private List<string> Get_SQLTeams()
        {
            List<string> teams = new List<string>();

            MySqlConnection sqlConn = new MySqlConnection();
            MySqlCommand sqlCmd = new MySqlCommand();
            MySqlDataAdapter dataAdt = new MySqlDataAdapter();
            MySqlDataReader dataRead;
            DataTable sqlData = new DataTable();

            sqlConn.ConnectionString = SQLInfo.fullConnection;
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = "SELECT DISTINCT team FROM player";
            dataRead = sqlCmd.ExecuteReader();
            sqlData.Load(dataRead);
            dataRead.Close();
            sqlConn.Close();

            teams = sqlData.AsEnumerable().Select(x => x.Field<string>("team")).ToList();

            return teams;
        }
        #endregion

        #endregion


    }
}
