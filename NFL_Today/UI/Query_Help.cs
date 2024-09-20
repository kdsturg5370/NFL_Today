//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NFL_Today.UI
{
    public partial class Query_Help : Form
    {
        public Query_Help()
        {
            InitializeComponent();
        }

       
        private void Query_Help_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.RichTextBox HelpTextBox = new System.Windows.Forms.RichTextBox();
            HelpTextBox.Location = new Point(100, 51);
            HelpTextBox.Size = new Size(600, 300);
            HelpTextBox.BorderStyle = BorderStyle.Fixed3D;
            //HelpTextBox.ForeColor = Color.DarkOliveGreen;
            HelpTextBox.WordWrap = true;
            HelpTextBox.Text += Environment.NewLine + "Select the desired drop down from each combo box selection in the Category Selections";
            HelpTextBox.Text += Environment.NewLine + "and Team/Rank/Player Lookup groups to find category members for your manual queries.";
            HelpTextBox.Text += Environment.NewLine + "";
            HelpTextBox.Text += Environment.NewLine + "You can save your custom queries to the database to avoid having to rewrite them.";
            HelpTextBox.Text += Environment.NewLine + "Query using SELECT * FROM Query_Archive table found in the Tables Names drop down list to retrieve your query.";
            HelpTextBox.Text += Environment.NewLine + "";
            HelpTextBox.Text += Environment.NewLine + "When querying the different tables for specific statistics, use the following syntax:";
            HelpTextBox.Text += Environment.NewLine + "";
            HelpTextBox.Text += Environment.NewLine + "SELECT <categoryname, categoryname> FROM <table name>";
            HelpTextBox.Text += Environment.NewLine + "";
            HelpTextBox.Text += Environment.NewLine + "Example: SELECT Team, Pos, Name, Ranking FROM Team_Roster (use the Roster Categories drop down to find these categories)";
            HelpTextBox.Text += Environment.NewLine + "";
            HelpTextBox.Text += Environment.NewLine + "To filter by any column, use: SELECT <category> FROM <table name> WHERE<category> = '<category name>' ";
            HelpTextBox.Text += Environment.NewLine + "";
            HelpTextBox.Text += Environment.NewLine + "Example: SELECT Team, Pos, Name, Ranking FROM Team_Roster WHERE Team = 'SF'";
            HelpTextBox.Text += Environment.NewLine + "";
            HelpTextBox.Text += Environment.NewLine + "To filter by any column with a type of wildcard search,";
            HelpTextBox.Text += Environment.NewLine + "use: SELECT <category> FROM <table name> WHERE <category>" + "LIKE '%<category name>%' ";
            HelpTextBox.Text += Environment.NewLine + "";
            HelpTextBox.Text += Environment.NewLine + "Example: SELECT Team, Pos, Name, Ranking FROM Team_Roster WHERE Name LIKE '%Jim%'";
            HelpTextBox.Text += Environment.NewLine + "";
            HelpTextBox.Text += Environment.NewLine + "To limit the number of records you want returned from your query,";
            HelpTextBox.Text += Environment.NewLine + "use: SELECT <category> FROM <table name> LIMIT <enter desired number> ";
            HelpTextBox.Text += Environment.NewLine + "";
            HelpTextBox.Text += Environment.NewLine + "Example: SELECT Team, Pos, Name, Ranking FROM Team_Roster LIMIT 5";

            //HelpTextBox.AutoSize = true;
            HelpTextBox.Multiline = true;
            HelpTextBox.Name = "HelpTextBox";
            //HelpTextBox.Text = "Enter City Name...";

            
            this.Controls.Add(HelpTextBox);
        }
    }
}


