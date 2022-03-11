using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA
{
    internal class Country
    {
        String countryCode;
        String countryName;

        public void setCountryCode(String countryCode)
            { this.countryCode = countryCode;
        }
        public void setCountryName(String countryName)
            { this.countryName = countryName; }
    }
}
