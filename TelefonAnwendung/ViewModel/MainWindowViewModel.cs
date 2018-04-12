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
        private Visibility _callButtonIsVisible = Visibility.Visible;
        #endregion

        #region Dependecy Properties
        public string TestText { get; set; } = "Das ist ein Test";
        public Visibility CallButtonIsVisible
        {
            get { return _callButtonIsVisible; }
            set { _callButtonIsVisible = value; }
        }
        #endregion
    }
}
