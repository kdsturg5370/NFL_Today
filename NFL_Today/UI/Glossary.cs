//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.DirectoryServices.ActiveDirectory;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

namespace NFL_Today.UI
{
    public partial class Glossary : Form
    {
        public Glossary()
        {
            InitializeComponent();
        }

        private void Glossary_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.RichTextBox GlossaryTextBox = new System.Windows.Forms.RichTextBox();
            GlossaryTextBox.Location = new Point(100, 51);
            GlossaryTextBox.Size = new Size(600, 300);
            GlossaryTextBox.BorderStyle = BorderStyle.Fixed3D;
            //GlossaryTextBox.ForeColor = Color.DarkOliveGreen;
            GlossaryTextBox.WordWrap = true;
            GlossaryTextBox.Text += Environment.NewLine + "POS - Player's position";
            GlossaryTextBox.Text += Environment.NewLine + "Rating (RTG) - a numeric value placed on the player's overall performance based on points assigned ";
            GlossaryTextBox.Text += Environment.NewLine + "PTS - number of points scored by the team";
            GlossaryTextBox.Text += Environment.NewLine + "FPTS - number of fantasy points awarded for a given category";
            GlossaryTextBox.Text += Environment.NewLine + "to each category within their field and then added together";
            GlossaryTextBox.Text += Environment.NewLine + "Ranking - a numeric value placed on a player's performance as compared to all others in their field based on their rating";
            GlossaryTextBox.Text += Environment.NewLine + "Exp - years of experience in the NFL";
            GlossaryTextBox.Text += Environment.NewLine + "GP or G - number of games played";
            GlossaryTextBox.Text += Environment.NewLine + "GS - number of games started";
            GlossaryTextBox.Text += Environment.NewLine + "FGM - field goals made";
            GlossaryTextBox.Text += Environment.NewLine + "FGA - field goals attempted";
            GlossaryTextBox.Text += Environment.NewLine + "XPM - extra points made by kicker";
            GlossaryTextBox.Text += Environment.NewLine + "XPA - extra points attempted";
            GlossaryTextBox.Text += Environment.NewLine + "FGM(0-19) - field goals made from 0 to 19 yds out";
            GlossaryTextBox.Text += Environment.NewLine + "FGA/G - field goals attempted per game";
            GlossaryTextBox.Text += Environment.NewLine + "FG% - % of field goals made";
            GlossaryTextBox.Text += Environment.NewLine + "XP% - % of extra points made";
            GlossaryTextBox.Text += Environment.NewLine + "PF - points for or the number of points scored by a particular team";
            GlossaryTextBox.Text += Environment.NewLine + "PA - points against or number of points scored against a particular team";
            GlossaryTextBox.Text += Environment.NewLine + "Ply - total number of offensive plays including pass attempts + rush attempts + times sacked";
            GlossaryTextBox.Text += Environment.NewLine + "Y/P - yards per offensive play";
            GlossaryTextBox.Text += Environment.NewLine + "Y/A - yards per pass attempt";
            GlossaryTextBox.Text += Environment.NewLine + "AY/A - adjusted yds per pass attempt (pass yds + 20 * passing tds - 45 * int)";
            GlossaryTextBox.Text += Environment.NewLine + "Y/C - yards per pass completion";
            GlossaryTextBox.Text += Environment.NewLine + "Y/G - yards gained per game";
            GlossaryTextBox.Text += Environment.NewLine + "YL - yards lost due to sacks";
            GlossaryTextBox.Text += Environment.NewLine + "NY/A - yards gained per pass attempt";
            GlossaryTextBox.Text += Environment.NewLine + "ANY/A - adjusted net yds per pass attempt (pass yds - sack yds + 20 * passing tds - 45 * int / pass attempts + times sacked)";
            GlossaryTextBox.Text += Environment.NewLine + "4QC - 4th quarter comebacks";
            GlossaryTextBox.Text += Environment.NewLine + "GWD - game winning drives";
            GlossaryTextBox.Text += Environment.NewLine + "TO - turnovers lost";
            GlossaryTextBox.Text += Environment.NewLine + "FL - fumbles lost";
            GlossaryTextBox.Text += Environment.NewLine + "SCKS_Allow - number of sacks a defense allows";
            GlossaryTextBox.Text += Environment.NewLine + "1stD - number of first downs";
            GlossaryTextBox.Text += Environment.NewLine + "1D - number of first downs passing";
            GlossaryTextBox.Text += Environment.NewLine + "Cmp - passes completed";
            GlossaryTextBox.Text += Environment.NewLine + "Att - passes attempted";
            GlossaryTextBox.Text += Environment.NewLine + "Yds - total passing yards, for teams, sack yardage is deducted from this total";
            GlossaryTextBox.Text += Environment.NewLine + "TD - passing touchdowns";
            GlossaryTextBox.Text += Environment.NewLine + "Int - interceptions thrown";
            GlossaryTextBox.Text += Environment.NewLine + "NY/A - net yards gained per pass attempt (Passing Yards - Sack Yards) / (Passes Attempted + Times Sacked)";
            GlossaryTextBox.Text += Environment.NewLine + "#DR - number of drives";
            GlossaryTextBox.Text += Environment.NewLine + "Sc% - % of drives ending in offensive score";
            GlossaryTextBox.Text += Environment.NewLine + "TO% - % of drives ending in turnover";
            GlossaryTextBox.Text += Environment.NewLine + "Start - avg starting field position";
            GlossaryTextBox.Text += Environment.NewLine + "Time - avg time in possession during an offensive drive";
            GlossaryTextBox.Text += Environment.NewLine + "PEN - Penalties committed by team and accepted"; 
            GlossaryTextBox.Text += Environment.NewLine + "1stPy - First Downs by Penalty";
            GlossaryTextBox.Text += Environment.NewLine + "Sp.Tms - special teams";
            GlossaryTextBox.Text += Environment.NewLine + "Rec - team's win-loss record";
            GlossaryTextBox.Text += Environment.NewLine + "Red Zone - starting at the 20 yd line and going to the end zone";
            GlossaryTextBox.Text += Environment.NewLine + "RZ-Att - red zone attempts";
            GlossaryTextBox.Text += Environment.NewLine + "RZ-TD - touchdowns scored after team entered the red zone";
            GlossaryTextBox.Text += Environment.NewLine + "RZ-TD1 - team scores on the first down in the red zone";
            GlossaryTextBox.Text += Environment.NewLine + "RZ-2D - team scores on the second down in the red zone";
            GlossaryTextBox.Text += Environment.NewLine + "RZ-3D - team scores on the third down in the red zone";
            GlossaryTextBox.Text += Environment.NewLine + "RZ-4D - team scores on the fourth down in the red zone";
            GlossaryTextBox.Text += Environment.NewLine + "RZ-PCT - % of time a team enters the red zone and scores";
            GlossaryTextBox.Text += Environment.NewLine + "Ppr - fantasy points per reception";
            GlossaryTextBox.Text += Environment.NewLine + "Exp_Fpts - fantasy points for experience at a position";
            GlossaryTextBox.Text += Environment.NewLine + "FPOE - fantasy points over expected";
            GlossaryTextBox.Text += Environment.NewLine + "Fum - total number of fumbles, lost or recovered";
            GlossaryTextBox.Text += Environment.NewLine + "FumL - total number of fumbles lost";
            GlossaryTextBox.Text += Environment.NewLine + "Depth - refers to the string a player is scheduled for - 1st, 2nd, 3rd, etc";
            GlossaryTextBox.Text += Environment.NewLine + "TMSnap% - a player's snap count % or the number of plays they are involved in";
            GlossaryTextBox.Text += Environment.NewLine + "YAC - yards gained after a catch";
            GlossaryTextBox.Text += Environment.NewLine + "Drop - dropped passes";
            GlossaryTextBox.Text += Environment.NewLine + "TGT - number of times a player is targeted for a pass or handoff";
            GlossaryTextBox.Text += Environment.NewLine + "SFTY - safety";
            GlossaryTextBox.Text += Environment.NewLine + "OSK - on-side kick";
            GlossaryTextBox.Text += Environment.NewLine + "OOB - kick out of bounds";
            GlossaryTextBox.Text += Environment.NewLine + "2PM - 2 point conversion made";
            GlossaryTextBox.Text += Environment.NewLine + "2PA - 2 point conversion attempted";
            GlossaryTextBox.Text += Environment.NewLine + "D2P - defensive 2 point conversion";
            GlossaryTextBox.Text += Environment.NewLine + "PD - passes defended by a defensive player";
            GlossaryTextBox.Text += Environment.NewLine + "QBRec - team record with a starting QB";
            GlossaryTextBox.Text += Environment.NewLine + "QBR - ESPN's QB rating";

            GlossaryTextBox.Multiline = true;
            GlossaryTextBox.Name = "GlossaryTextBox";
            //GlossaryTextBox.Text = "Enter City Name...";

            this.Controls.Add(GlossaryTextBox);
        }
    }
}
