using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasketStatz.Helpers;
using System.ComponentModel;
using BasketStatz.Models;

namespace BasketStatz.ViewModels
{
    class PlayerStatInput_VM : Base_VM
    {
        public PlayerStatInput_VM()
        {
            
        }

        private Player _selectedPlayer;
        public Player SelectedPlayer
        {
            get { return _selectedPlayer; }
            set { _selectedPlayer = value; NotifyPropertyChanged(); }
        }

        protected void SelectedPlayerChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(SelectedPlayer))
            {
                
            }
        }
    }
}
