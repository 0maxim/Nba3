namespace WinFormsApp1
{
    public partial class NBA : Form
    {
        // ImgList
        Country[] countries = new Country[5];
        Player[] players = new Player[5];
        Team1[] teams1 = new Team1[5];
        Position[] positions = new Position[5];
        PositionP[] positionsp = new PositionP[5];
    
    
        String[] imgList = new string[] { "2.JPG", "3.JPG", "4.JPG", "5.JPG", "6.JPG", "7.JPG", "8.JPG", "9.JPG", "10.JPG", "11.JPG" };
        int index = 0;
        public NBA()
        {
            InitializeComponent();

            pictureBox2.Load("../../../../Pictures/" + imgList[0]);
            pictureBox3.Load("../../../../Pictures/" + imgList[1]);
            pictureBox4.Load("../../../../Pictures/" + imgList[2]);

            Country country = new Country();
            country.Set("ARG", "Argentina");
            countries[0] = country;

            country.Set("AT", "Austria");
            countries[1] = country;

            country.Set("AUS", "Australia");
            countries[2] = country;

            country.Set("BI", "Bosnia");
            countries[3] = country;

            country.Set("BIH", "Bosnia Herzegovina");
            countries[4] = country;

            Player player = new Player();
            player.Set("1", "Mo Williams", "a", "b", "c", "d", "e", "t", "i", "g");
            players[0] = player;
            player.Set("2", "Alonzo Edward Gee", "g", "h", "fg", "f", "d", "wsc", "ff", "ff");
            players[1] = player;
            player.Set("3", "Johnny O'Bryant", "ff", "ff", "ff", "f", "nduldsl", "dff", "dd", "n");
            players[2] = player;
            player.Set("4", "Danilo Gallinari", "ddd", "gg", "gh", "ffff", "f", "s", "e", "v");
            players[3] = player;
            player.Set("5", "Darrell Arthur", "vf", "vv", "dd", "ss", "aa", "ddd", "dre", "ddg");
            players[4] = player;

            Team1 team1 = new Team1();
            team1.set("1", "Miami Heat","1", "2");
            teams1[0] = team1;
            team1.set("2", "Orlando Magic", "3", "4");
            teams1[1] = team1;
            team1.set("3", "Atlanta Hawks", "5", "6");
            teams1[2] = team1;
            team1.set("4", "Washington Wizards", "7", "8");
            teams1[3] = team1;
            team1.set("5", "Charlotte Hornets", "9", "10");
            teams1[4] = team1;

            Position position = new Position();
            position.set("1", "SmallForward");
            positions[0] = position;
            position.set("2", "PowerForward");
            positions[1] = position;
            position.set("3", "Center");
            positions[2] = position;
            position.set("4", "ShootingGuard");
            positions[3] = position;
            position.set("5", "PointGuard");
            positions[4] = position;

            PositionP positionp = new PositionP();

            positionp.set("1", "SF");
            positionsp[0] = positionp;
            positionp.set("2", "PF");
            positionsp[1] = positionp;
            positionp.set("3", "C");
            positionsp[2] = positionp;
            positionp.set("4", "SG");
            positionsp[3] = positionp;
            positionp.set("5", "PG");
            positionsp[4] = positionp;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form admin = new admin();
            admin.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form visitor = new visitor();
            visitor.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            index = index + 1;
            if (index + 3 > imgList.Length) index = 0;
            pictureBox2.Load("../../../../Pictures/" + imgList[index + 0]);
            pictureBox3.Load("../../../../Pictures/" + imgList[index + 1]);
            pictureBox4.Load("../../../../Pictures/" + imgList[index + 2]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            index = index - 1;
            if (index < 0) index = imgList.Length - 3;
            pictureBox2.Load("../../../../Pictures/" + imgList[index + 0]);
            pictureBox3.Load("../../../../Pictures/" + imgList[index + 1]);
            pictureBox4.Load("../../../../Pictures/" + imgList[index + 2]);
        }
    }
}