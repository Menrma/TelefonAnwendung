using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonAnwendung.Model
{
    class LaenderKuerzel
    {
        private string laenderkuerzel;
        private string vorwahl;

        public string Laenderkuerzel
        {
            get
            {
                return laenderkuerzel;
            }

            set
            {
                laenderkuerzel = value;
            }
        }

        public string Vorwahl
        {
            get
            {
                return vorwahl;
            }

            set
            {
                vorwahl = value;
            }
        }
    }
}
