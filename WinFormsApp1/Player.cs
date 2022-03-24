using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Player
    {
        string playerId;
        string lastName;
        string firstname;
        string gender;
        string height;
        string weight;
        string shirtNumber;
        string email;
        string countryCode;
        string teamLd;
        public void Set(string playerId, string lastName, string firstname, string gender, string height, string weight, string shirtNumber, string email, string countryCode, string teamLd)

        {
            this.playerId = playerId;   
            this.lastName = lastName;
            this.firstname = firstname;
            this.gender = gender;
            this.height = height;
            this.weight = weight;
            this.shirtNumber = shirtNumber;
            this.email = email;
            this.countryCode = countryCode;
            this.teamLd = teamLd;
        }


    }
}
