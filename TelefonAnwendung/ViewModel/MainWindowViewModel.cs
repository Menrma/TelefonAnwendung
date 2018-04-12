using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TelefonAnwendung.ViewModel
{
    public class MainWindowViewModel
    {
        #region Properties
        private string _telefonnummerEingabe = String.Empty;
        private Visibility _callButtonIsVisible = Visibility.Hidden;
        #endregion

        #region Dependecy Properties
        public string TelefonnummerEingabe
        {
            get { return _telefonnummerEingabe; }
            set { _telefonnummerEingabe = value; }
        }
        public Visibility CallButtonIsVisible
        {
            get { return _callButtonIsVisible; }
            set { _callButtonIsVisible = value; }
        }

        #endregion
    }
}
