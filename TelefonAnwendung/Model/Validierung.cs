using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonAnwendung.Model
{
    public class Validierung
    {
        // Ziffern, Zeichen (Klammern usw.) werden nicht beachtet
        const int minimaleZiffern = 4;
        const int maximaleZiffern = 20;

        public bool validiereNummer(string nummer)
        {
            // 0 heißt kein Fehler; Rest wird durch Main mit den Texten gematcht
            bool korrekteNummer = true;

            bool korrekteLaenge = pruefeLaenge(nummer);

            if (korrekteLaenge)
            {
                korrekteNummer = pruefeZeichen(nummer);
            }
            else
            {
                korrekteNummer = false;
            }

            return korrekteNummer;
        }

        private bool pruefeLaenge(string nummer)
        {
            int anzahlZiffern = 0;
            foreach (char zeichen in nummer)
            {
                if (char.IsDigit(zeichen))
                {
                    anzahlZiffern += 1;
                }
            }

            if (anzahlZiffern >= minimaleZiffern && anzahlZiffern <= maximaleZiffern)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool pruefeZeichen(string nummer) {
            bool korrekteNummer = true;
            foreach (char c in nummer)
            {
                if (char.IsDigit(c))
                {
                    // solang es eine Ziffer ist, ist ok
                    korrekteNummer = korrekteNummer & true;
                }
                else if (isErlaubtesZeichen(c))
                {
                    // solange ein Zeichen erlaubt ist, ist ok
                    korrekteNummer = korrekteNummer & true;
                }
                else
                {
                    // nicht-erlaubtes Zeichen erkannt
                    korrekteNummer = korrekteNummer & false;
                }
            }
            return korrekteNummer;
        }

        private bool isErlaubtesZeichen(char zeichen)
        {
            bool erlaubt = false;
            List<char> erlaubteZeichen = new List<char>(new char[] { '+', '-', '/', '(', ')', '[', ']', ' ' });
            erlaubt = erlaubteZeichen.Contains(zeichen);
            return erlaubt;
        }
    }
}
