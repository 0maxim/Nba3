﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NBA
{
    public partial class Form1 : Form 
    { //imglist 
        Country [] countries = new Country [6];
        Players [] players = new Players [6];
        Team [] teams = new Team [6];

        String[] imgList = new String[] 
        { "0.JPG", "1.JPG", "2.JPG", "3.JPG", "4.JPG", "5.JPG", "6.JPG", "7.JPG", "8.JPG", "9.JPG", "10.JPG" };
        int index = 0;
        public Form1()
        {
            InitializeComponent();  
            Team team = new Team ();
            Team team = new Team();
            team.setTeamId(1);
            team.setName("Miami Heat");
            team.setAbbr("MIA");
            team.setLogo("1.jpg");
            teams[0] = team;

            team.setTeamId(2);
            team.setName("Orlando Magic");
            team.setAbbr("ORL");
            team.setLogo("2.jpg");
            teams[1] = team;

            team.setTeamId(3);
            team.setName("Atlanta Hawks");
            team.setAbbr("ATL");
            team.setLogo("3.jpg");
            teams[2] = team;

            team.setTeamId(4);
            team.setName("Washington Wizards");
            team.setAbbr("WSH");
            team.setLogo("4.jpg");
            teams[3] = team;

            team.setTeamId(5);
            team.setName("Charlotte Hornets");
            team.setAbbr("CHA");
            team.setLogo("5.jpg");
            teams[4] = team;

            POSITIONNAME pOSITIONNAME = new POSITIONNAME();
            pOSITIONNAME.setPositionId("1");
            pOSITIONNAME.setName("SmallForward");
            pOSITIONNAMEs[0] = pOSITIONNAME;

            pOSITIONNAME.setPositionId("2");
            pOSITIONNAME.setName("PowerForward");
            pOSITIONNAMEs[1] = pOSITIONNAME;

            pOSITIONNAME.setPositionId("3");
            pOSITIONNAME.setName("Center");
            pOSITIONNAMEs[2] = pOSITIONNAME;

            pOSITIONNAME.setPositionId("4");
            pOSITIONNAME.setName("ShootingGuard");
            pOSITIONNAMEs[3] = pOSITIONNAME;

            pOSITIONNAME.setPositionId("5");
            pOSITIONNAME.setName("PointGuard");
            pOSITIONNAMEs[4] = pOSITIONNAME;

            teams[0] = team;
            
            


            players = new Players [6];
            players[0] = players;
            

            Country country = new Country ();
            country.setCountryCode("ARG");
            country.setCountryName("Argentina");
            countries[0] = country;

            country.setCountryCode("AT");
            country.setCountryName("Austria");
            countries[1] = country;

            country.setCountryCode("AUS");
            country.setCountryName("Australia");
            countries[2] = country;

            country.setCountryCode("BI");
            country.setCountryName("Bosnia");
            countries[3] = country;

            country.setCountryCode("BIH");
            country.setCountryName("Bosnia Herzegovina");
            countries[4] = country;

            country.setCountryCode("BR");
            country.setCountryName("Brazil");
            countries[5] = country;

            pictureBox3.Load("../../../../pictures/" + imgList[0]);
            pictureBox4.Load("../../../../pictures/" + imgList[1]);
            pictureBox5.Load("../../../../pictures/" + imgList[2]);
        }
   

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form adminForm = new Form2();
            adminForm.Show();
        }

     

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            index = index + 1;
            if (index +3 >= imgList.Length) index = 0;
            pictureBox3.Load("../../../../pictures/" + imgList[index + 0]);
            pictureBox4.Load("../../../../pictures/" + imgList[index + 1]);
            pictureBox5.Load("../../../../pictures/" + imgList[index + 2]);
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            index = index + 1;
            if (index +3 >= imgList.Length) index = 0;
            pictureBox3.Load("../../../../pictures/" + imgList[index + 0]);
            pictureBox4.Load("../../../../pictures/" + imgList[index + 1]);
            pictureBox5.Load("../../../../pictures/" + imgList[index + 2]);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Visitor_Click(object sender, EventArgs e)
        {
            Form adminForm = new Form2();
            adminForm.Show();
        }

        private void bitton1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
