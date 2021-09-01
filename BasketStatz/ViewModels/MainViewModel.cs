using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasketStatz.Models;
using BasketStatz.Helpers;
using System.Windows.Input;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using MySql.Data.MySqlClient;
using System.Data;

namespace BasketStatz.ViewModels
{   

    internal class MainViewModel : Base_VM
    {
        #region View Models Initialization
        Base_VM _currentViewModel;
        Menu_VM _menuVM = new Menu_VM();
        PlayerStatInput_VM _playerStatInputVM = new PlayerStatInput_VM();
        PlayerCareerStats_VM _playerCareerStatsVM = new PlayerCareerStats_VM();
        TeamGameStats_VM _teamGameStatsVM = new TeamGameStats_VM();
        TeamSeasonStats_VM _teamSeasonStatsVM = new TeamSeasonStats_VM();
        #endregion

        public MainViewModel()
        {
            CurrentViewModel = _menuVM;
            _menuVM.PropertyChanged += SessionPropertyChanged;            
        }

        #region Constructors
        public Base_VM CurrentViewModel
        {
            get { return _currentViewModel; }
            set { _currentViewModel = value; NotifyPropertyChanged(); }
        }

        private int _homeScore = 0;
        public int HomeScore
        {
            get { return _homeScore; }
            set { _homeScore = value; NotifyPropertyChanged(); }
        }

        private int _awayScore = 0;
        public int AwayScore
        {
            get { return _awayScore; }
            set { _awayScore = value; NotifyPropertyChanged(); }
        }

        private List<Player> _gamePlayers;
        public List<Player> GamePlayers
        {
            get { return _gamePlayers; }
            set { _gamePlayers = value; NotifyPropertyChanged(); }
            
        }

        // Messenger to PlayerStatInput ViewModel
        public Player SelectedPlayer
        {
            get { return _playerStatInputVM.SelectedPlayer; }
            set { _playerStatInputVM.SelectedPlayer = value; NotifyPropertyChanged(); }
        }

        #endregion

        #region Event Handlers
        protected void SessionPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(_menuVM.GameInSession))
            {
                if (_menuVM.GameInSession == true)
                {
                    GamePlayers = FillGamePlayers();
                }
                else if (_menuVM.GameInSession == false)
                {
                    GamePlayers = new List<Player>();
                    MessageBox.Show("Game NOT in session");
                }
            }
        }
        #endregion

        #region MySQL Data

        #region Fill Game Players
        public List<Player> FillGamePlayers()
        {
            List<Player> playerList = new List<Player>();

            MySqlConnection sqlConn = new MySqlConnection();
            MySqlCommand sqlCmd = new MySqlCommand();
            MySqlDataAdapter dataAdt = new MySqlDataAdapter();
            MySqlDataReader dataRead;
            DataTable sqlData = new DataTable();

            sqlConn.ConnectionString = SQLInfo.fullConnection;
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = "SELECT * FROM player WHERE team LIKE @teamName";
            sqlCmd.Parameters.AddWithValue("@teamName", _menuVM.HomeTeamSelected);
            dataRead = sqlCmd.ExecuteReader();
            sqlData.Load(dataRead);
            dataRead.Close();
            sqlConn.Close();

            foreach (DataRow rows in sqlData.Rows)
            {
                Player player = new Player();

                player.Id = Convert.ToInt32(rows["player_id"]);
                player.Name = rows["name"].ToString();
                player.Number = Convert.ToInt32(rows["number"]);
                player.Team = rows["team"].ToString();
                player.Height = rows["height"].ToString();
                player.Age = Convert.ToInt32(rows["age"]);
                player.PTS = Convert.ToInt32(rows["points"]);
                player.FGM = Convert.ToInt32(rows["field_goals_made"]);
                player.FGA = Convert.ToInt32(rows["field_goals_attempted"]);
                player.FGP = Convert.ToDouble(rows["field_goal_percentage"]);
                player.FTM = Convert.ToInt32(rows["free_throws_made"]);
                player.FTA = Convert.ToInt32(rows["free_throws_attempted"]);
                player.FTP = Convert.ToDouble(rows["free_throws_percentage"]);
                player.ThreeFGM = Convert.ToInt32(rows["3_point_made"]);
                player.ThreeFGA = Convert.ToInt32(rows["3_point_attempted"]);
                player.ThreeFGP = Convert.ToDouble(rows["3_point_percentage"]);
                player.REB = Convert.ToInt32(rows["rebounds"]);
                player.OREB = Convert.ToInt32(rows["offensive_rebounds"]);
                player.DREB = Convert.ToInt32(rows["defensive_rebounds"]);
                player.AST = Convert.ToInt32(rows["assists"]);
                player.STL = Convert.ToInt32(rows["steals"]);
                player.BLK = Convert.ToInt32(rows["blocks"]);
                player.TO = Convert.ToInt32(rows["turnovers"]);
                player.PF = Convert.ToInt32(rows["personal_fouls"]);

                playerList.Add(player);
            }

            return playerList;
        }
        #endregion

        #endregion

        #region Commands

        #region Add to Home Score
        public ICommand AddToHomeScore
        {
            get { return new RelayCommand(AddHomeScore); }
        }

        private void AddHomeScore()
        {
            HomeScore++;
        }
        #endregion

        #region Add to Away Score
        public ICommand AddToAwayScore
        {
            get { return new RelayCommand(AddAwayScore); }
        }

        private void AddAwayScore()
        {
            AwayScore++;
        }
        #endregion

        #region ChangeToMenu
        public ICommand ChangeToMenu
        {
            get { return new RelayCommand(LoadMenu); }
        }

        private void LoadMenu()
        {
            CurrentViewModel = _menuVM;
        }
        #endregion

        #region ChangeToPlayerStat
        public ICommand ChangeToPlayerStat
        {
            get { return new RelayCommand(LoadPlayerStat); }
        }

        private void LoadPlayerStat()
        {
            CurrentViewModel = _playerStatInputVM;
        }
        #endregion

        #region ChangeToPlayerCareerStat
        public ICommand ChangeToPlayerCareerStat
        {
            get { return new RelayCommand(LoadPlayerCareerStat); }
        }

        private void LoadPlayerCareerStat()
        {
            CurrentViewModel = _playerCareerStatsVM;
        }
        #endregion

        #region ChangeToTeamGameStat
        public ICommand ChangeToTeamGameStat
        {
            get { return new RelayCommand(LoadTeamGameStat); }
        }

        private void LoadTeamGameStat()
        {
            CurrentViewModel = _teamGameStatsVM;
        }
        #endregion

        #region ChangeToTeamSeasonStat
        public ICommand ChangeToTeamSeasonStat
        {
            get { return new RelayCommand(LoadTeamSeasonStat); }
        }

        private void LoadTeamSeasonStat()
        {
            CurrentViewModel = _teamSeasonStatsVM;
        }
        #endregion

        #endregion
    }
}
