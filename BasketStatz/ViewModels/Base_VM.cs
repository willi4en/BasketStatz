using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasketStatz.Helpers;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BasketStatz.ViewModels
{
    class Base_VM : INotifyPropertyChanged
    {
        public Base_VM() { }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
