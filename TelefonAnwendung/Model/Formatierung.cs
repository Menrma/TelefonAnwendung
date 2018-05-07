using libphonenumber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonAnwendung.Model
{
    public class Formatierung
    {
        public Formatierung() {
            
        }

        public string formatiere(string nummer, string landKuerzel)
        {
            if (String.IsNullOrEmpty(nummer) || String.IsNullOrEmpty(landKuerzel)) return String.Empty;

            var phoneNumberUtil = PhoneNumberUtil.Instance;

            try
            {
                var number1 = phoneNumberUtil.Parse(nummer, landKuerzel);
                var formatted = number1.Format(PhoneNumberUtil.PhoneNumberFormat.INTERNATIONAL);

                return formatted;
            }
            catch(Exception e)
            {
                return String.Empty;
            }
        }
    }
}
