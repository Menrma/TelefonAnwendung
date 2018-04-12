using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonAnwendung.Model
{
    public class Speicherzugriff
    {
        const string pfadDefaultLand = "Ressourcen/DefaultLaendervorwahl.csv";
        const string pfadLaenderkuerzel = "Ressourcen/Laenderkuerzel.csv";
        List<LaenderKuerzel> laenderkuerzelVorwahl = new List<LaenderKuerzel>();
        List<LaenderKuerzel> defaultLandVorwahl = new List<LaenderKuerzel>();

        public Speicherzugriff()
        {
            leseDefaultLaenderVorwahl();
            leseLaenderkuerzelMitVorwahl();
        }

        public string ermittleLaenderkuerzel(string vorwahl) {
            var kuerzel = laenderkuerzelVorwahl.Find(land => land.Vorwahl == vorwahl).Laenderkuerzel;
            return kuerzel;
        }

        public string ermittleVorwahll(string laenderkuerzel) {
            var vorwahl = laenderkuerzelVorwahl.Find(vwahl => vwahl.Laenderkuerzel == laenderkuerzel).Vorwahl;
            return vorwahl;
        }

        private void leseDefaultLaenderVorwahl()
        {
            defaultLandVorwahl = leseCSVDatei(pfadDefaultLand);           
        }

        private void leseLaenderkuerzelMitVorwahl() {
            laenderkuerzelVorwahl = leseCSVDatei(pfadLaenderkuerzel);
        }

        private List<LaenderKuerzel> leseCSVDatei(string pfadDatei)
        {
            string[] inhalte = { "", ""};
            List<LaenderKuerzel> laenderkuerzelVorwahl = new List<LaenderKuerzel>();
            string line;
 
            System.IO.StreamReader file =  new System.IO.StreamReader(pfadDatei);

            while ((line = file.ReadLine()) != null)
            {
                inhalte = line.Split(';');
                LaenderKuerzel temp = new LaenderKuerzel();
                temp.Laenderkuerzel = inhalte[0];
                temp.Vorwahl = inhalte[1];
                laenderkuerzelVorwahl.Add(temp);
            }

            file.Close();

            return laenderkuerzelVorwahl;
        }

    }
}
