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




        public Dictionary<string, string> leseDefaultLaenderVorwahl()
        {
            Dictionary<string, string> defaultLandVorwahl = leseCSVDatei(pfadDefaultLand);           
            return defaultLandVorwahl;
        }

        public Dictionary<string, string> leseLaenderkuerzelMitVorwahl() {
            Dictionary<string, string> laenderkuerzelVorwahl = leseCSVDatei(pfadLaenderkuerzel);
            return laenderkuerzelVorwahl;
        }

        private Dictionary<string, string> leseCSVDatei(string pfadDatei)
        {
            string[] inhalte = { "", ""};
            Dictionary<string, string> laenderkuerzelVorwahl = new Dictionary<string, string>();
            string line;
 
            System.IO.StreamReader file =  new System.IO.StreamReader(pfadDatei);

            while ((line = file.ReadLine()) != null)
            {
                inhalte = line.Split(';');
                laenderkuerzelVorwahl.Add(inhalte[0], inhalte[1]);
            }

            file.Close();

            return laenderkuerzelVorwahl;
        }

    }
}
