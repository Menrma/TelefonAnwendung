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

        public bool formatiere(string nummer, string landKuerzel)
        {
            var phoneNumberUtil = PhoneNumberUtil.Instance;
            var number1 = phoneNumberUtil.Parse(nummer, landKuerzel);

            var formatted = number1.Format(PhoneNumberUtil.PhoneNumberFormat.INTERNATIONAL);

            return true;
        }
    }
}
