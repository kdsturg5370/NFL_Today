//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

namespace NFL_Today.UI
{
    public partial class RankLookup : Form
    {
        public RankLookup()
        {
            InitializeComponent();
        }

        private void RankLookup_Load(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection(@"Data Source = C:\Users\kdsturg5370\source\repos\NFL_Today\DB\NFLDB.db");
            string sql = "select * from Teams";
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            conn.Open();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            //DataTable dt1 = new DataTable();
            adapter.Fill(dt);
            cbTeam.DisplayMember = "Name";
            cbTeam.ValueMember = "ID";
            cbTeam.DataSource = dt;

            //cbCategory.DisplayMember = "PTS";
            //cbCategory.ValueMember = "ID";
            //cbCategory.DataSource = dt;
        }

        private void cbTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection(@"Data Source = C:\Users\kdsturg5370\source\repos\NFL_Today\DB\NFLDB.db");
            string sql = "select ID, Name, Season, PTS FROM Teams WHERE Name = '" + cbTeam.Text + "'";
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            conn.Open();
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtID.Text = reader[0].ToString();
                txtTeamName.Text = reader[1].ToString();
                txtSeason.Text = reader[2].ToString();
                txtRank.Text = reader[3].ToString();    
            }
            //adapter = new SQLiteDataAdapter("SELECT PTS FROM Teams", conn);
            //dt = new DataTable();
            //adapter.Fill(dt);
            //txtRankNumber.Text = "PTS";
            //txtRankNumber.= dt;

            conn.Close();
        }

        //private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    SQLiteConnection conn = new SQLiteConnection(@"Data Source = C:\Users\kdsturg5370\source\repos\NFL_Today\DB\NFLDB.db");
        //    string sql = "SELECT PTS FROM Teams WHERE Name = '" + cbTeam.Text + "'";
        //    SQLiteCommand cmd = new SQLiteCommand(sql, conn);
        //    conn.Open();
        //    SQLiteDataReader reader = cmd.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        txtRank.Text = reader[4].ToString();
        //    }
        //}
    }
}
