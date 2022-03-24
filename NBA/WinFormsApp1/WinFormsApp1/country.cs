using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Country
    {
        string countryCode;
        string countryName;

        public void Set(string countryCode, string countryName)
        {
            this.countryCode = countryCode;
            this.countryName = countryName;
        }
           
    }
}
