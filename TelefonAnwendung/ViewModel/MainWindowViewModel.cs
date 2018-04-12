using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using TelefonAnwendung.Framework;
using TelefonAnwendung.Model;

namespace TelefonAnwendung.ViewModel
{
    public class MainWindowViewModel
    {

        #region Properties
        private Speicherzugriff _speicherzugriff = new Speicherzugriff();
        private string _telefonnummerEingabe = String.Empty;
        private Visibility _callButtonIsVisible = Visibility.Visible;
        private string _landKuerzel = "DE";
        private KuerzelVorwahl _selectedLandKuerzel;
        private ObservableCollection<KuerzelVorwahl> _listeLandKuerzel;
        #endregion

        public MainWindowViewModel()
        {
            ladeDropDown();
            ladeDefaultWert();
            SpeichereDefaultCommand = new RelayCommand(SpeichereDefaultCommandExecute);
        }

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
        public string LandKuerzel
        {
            get { return _landKuerzel; }
            set { _landKuerzel = value; }
        }
        public KuerzelVorwahl SelectedLandKuerzel
        {
            get { return _selectedLandKuerzel; }
            set { _selectedLandKuerzel = value;}
        }
        public ObservableCollection<KuerzelVorwahl> ListeLandKuerzel
        {
            get { return _listeLandKuerzel; }
            set { _listeLandKuerzel = value; }
        }
        #endregion

        #region Commands
        public ICommand SpeichereDefaultCommand { get; set; }

        private void SpeichereDefaultCommandExecute(object obj)
        {
            _speicherzugriff.setzeDefaultWert(SelectedLandKuerzel);
            ladeDefaultWert();
        }
        #endregion

        #region Methods
        private void ladeDropDown()
        {
            ListeLandKuerzel = new ObservableCollection<KuerzelVorwahl>(_speicherzugriff.laenderkuerzelVorwahl);
        }

        private void ladeDefaultWert()
        {
            var aktuellerDefaultWert = _speicherzugriff.defaultWertLandVorwahl.Laenderkuerzel;
            SelectedLandKuerzel = ListeLandKuerzel.First(s => s.Laenderkuerzel == aktuellerDefaultWert);
        }
        #endregion
    }
}
