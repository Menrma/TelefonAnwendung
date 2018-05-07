using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace TelefonAnwendung.Model
{
    public class Speicherzugriff
    {
        const string pfadDefaultLand = @"C:\Users\Yvette\Desktop\DefaultLandVorwahl.csv";
        const string pfadLaenderkuerzel = "Ressourcen/Laenderkuerzel.csv";
        public List<KuerzelVorwahl> laenderkuerzelVorwahl { get; private set; }
        public KuerzelVorwahl defaultWertLandVorwahl { get; private set; }

        public Speicherzugriff()
        {
            leseDefaultLaenderVorwahl();
            leseLaenderkuerzelMitVorwahl();
        }

        public string ermittleLaenderkuerzel(string vorwahl) {
            var kuerzel = laenderkuerzelVorwahl.Find(land => land.Vorwahl == vorwahl)?.Laenderkuerzel;
            return kuerzel;
        }

        public string ermittleVorwahl(string laenderkuerzel) {
            var vorwahl = laenderkuerzelVorwahl.Find(vwahl => vwahl.Laenderkuerzel == laenderkuerzel)?.Vorwahl;
            return vorwahl;
        }

        public void setzeDefaultWert(KuerzelVorwahl neuerDefault) {
            string zuSchreiben = neuerDefault.Laenderkuerzel + ";" + neuerDefault.Vorwahl;
            Properties.Settings.Default.DefaultLand = zuSchreiben;
            Properties.Settings.Default.Save();
            defaultWertLandVorwahl = neuerDefault;
        }

        private void leseDefaultLaenderVorwahl()
        {
            string gespeicherterWert = Properties.Settings.Default.DefaultLand;
            string[] gesp = gespeicherterWert.Split(';');
            KuerzelVorwahl defaultWert = new KuerzelVorwahl();
            defaultWert.Laenderkuerzel = gesp[0];
            defaultWert.Vorwahl = gesp[1];
            defaultWertLandVorwahl = defaultWert;
        }

        private void leseLaenderkuerzelMitVorwahl() {
            laenderkuerzelVorwahl = leseCSVDatei(pfadLaenderkuerzel);
        }

        private List<KuerzelVorwahl> leseCSVDatei(string pfadDatei)
        {
            string[] inhalte = { "", ""};
            List<KuerzelVorwahl> laenderkuerzelVorwahl = new List<KuerzelVorwahl>();
            string line;
 
            System.IO.StreamReader file =  new System.IO.StreamReader(pfadDatei);

            while ((line = file.ReadLine()) != null)
            {
                inhalte = line.Split(';');
                KuerzelVorwahl temp = new KuerzelVorwahl();
                temp.Laenderkuerzel = inhalte[0];
                temp.Vorwahl = inhalte[1];
                laenderkuerzelVorwahl.Add(temp);
            }

            file.Close();

            return laenderkuerzelVorwahl;
        }

    }
}
