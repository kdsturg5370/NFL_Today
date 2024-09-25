using Eagles_Roster;
using NFL_Today.Manager;
using NFL_Today.Models;
using System.Data.SQLite;
using System.Data;
using NFL_Today.UI;

namespace NFL_Today
{
    public partial class MainForm : Form //this allows for the use of a main form Gateway and Manager classes to break up the code efficiently
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private bool IsQueryValid()
        {
            if (txtRankNumber.Text == "")
            {
                MessageBox.Show("Please enter a query before saving.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRankNumber.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool IsTeamNameValid()
        {
            if (txtTeamSearch.Text == "")
            {
                MessageBox.Show("Please enter a team name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTeamSearch.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        TeamManager _TeamManager = new TeamManager(); //each new module has to be declared. This pulls from the TeamManager class 

        private void ClearForm()
        {
            txtTeamSearch.Clear();
            txtRankNumber.Clear();
            cbSeason.SelectedIndex = -1;
            comboBox16.SelectedIndex = -1;
            lblTotal.Text = "";
            comboBox8.SelectedIndex = -1;
            comboBox10.SelectedIndex = -1;
            comboBox12.SelectedIndex = -1;
            comboBox14.SelectedIndex = -1;
            comboBox17.SelectedIndex = -1;
            comboBox7.SelectedIndex = -1;
            comboBox9.SelectedIndex = -1;
            comboBox11.SelectedIndex = -1;
            comboBox13.SelectedIndex = -1;
            comboBox15.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox6.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            cbTeam.SelectedIndex = -1;
            cbRankCategory.SelectedIndex = -1;
            Nametextbox.Clear();
            PointstextBox.Clear();
            FPTStextBox.Clear();
            PlaystextBox.Clear();
            YdstextBox.Clear();
            InttextBox.Clear();
            PassYdstextBox.Clear();
            PassAtttextBox.Clear();
            PassComptextBox.Clear();
            PassTDtextBox.Clear();
            RushYdstextBox.Clear();
            RushAtttextBox.Clear();
            RushTDtextBox.Clear();
            TDtextBox.Clear();
            RZAtttextBox.Clear();
            RZTDtextBox.Clear();
            RZTD1textBox.Clear();
            RZTD2textBox.Clear();
            RZ3DtextBox.Clear();
            RZ4DtextBox.Clear();
            TOtextBox.Clear();
            SCKSAllowtextBox.Clear();
            txtNameQuery.Clear();


            TeamDataGridView.ClearSelection();
        }

        private void Savebutton_Click(object sender, EventArgs e) //this allows for entering all new rank data for a new team and saving it to the NFLDB
        {
            try
            {

                if (string.IsNullOrEmpty(Nametextbox.Text))
                {
                    MessageBox.Show("Please enter a team name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Nametextbox.Focus();
                    return;
                }

                Teams Team = new Teams();
                Team.Name = Nametextbox.Text;
                if (PointstextBox != null && !string.IsNullOrWhiteSpace(PointstextBox.Text)) Team.PTS = Convert.ToInt32(PointstextBox.Text);
                if (FPTStextBox != null && !string.IsNullOrWhiteSpace(FPTStextBox.Text)) Team.FPTS = Convert.ToInt32(FPTStextBox.Text);
                if (PlaystextBox != null && !string.IsNullOrWhiteSpace(PlaystextBox.Text)) Team.Plays = Convert.ToInt32(PlaystextBox.Text);
                if (YdstextBox != null && !string.IsNullOrWhiteSpace(YdstextBox.Text)) Team.Yds = Convert.ToInt32(YdstextBox.Text);
                if (InttextBox != null && !string.IsNullOrWhiteSpace(InttextBox.Text)) Team.Int = Convert.ToInt32(InttextBox.Text);
                if (PassYdstextBox != null && !string.IsNullOrWhiteSpace(PassYdstextBox.Text)) Team.Pass_Yds = Convert.ToInt32(PassYdstextBox.Text);
                if (PassAtttextBox != null && !string.IsNullOrWhiteSpace(PassAtttextBox.Text)) Team.Pass_Att = Convert.ToInt32(PassAtttextBox.Text);
                if (PassComptextBox != null && !string.IsNullOrWhiteSpace(PassComptextBox.Text)) Team.Pass_Comp = Convert.ToInt32(PassComptextBox.Text);
                if (PassTDtextBox != null && !string.IsNullOrWhiteSpace(PassTDtextBox.Text)) Team.Pass_TD = Convert.ToInt32(PassTDtextBox.Text);
                if (RushYdstextBox != null && !string.IsNullOrWhiteSpace(RushYdstextBox.Text)) Team.Rush_Yds = Convert.ToInt32(RushYdstextBox.Text);
                if (RushAtttextBox != null && !string.IsNullOrWhiteSpace(RushAtttextBox.Text)) Team.Rush_Att = Convert.ToInt32(RushAtttextBox.Text);
                if (RushTDtextBox != null && !string.IsNullOrWhiteSpace(RushTDtextBox.Text)) Team.Rush_TD = Convert.ToInt32(RushTDtextBox.Text);
                if (TDtextBox != null && !string.IsNullOrWhiteSpace(TDtextBox.Text)) Team.TD = Convert.ToInt32(TDtextBox.Text);
                if (RZAtttextBox != null && !string.IsNullOrWhiteSpace(RZAtttextBox.Text)) Team.RZ_Att = Convert.ToInt32(RZAtttextBox.Text);
                if (RZTDtextBox != null && !string.IsNullOrWhiteSpace(RZTDtextBox.Text)) Team.RZ_TD = Convert.ToInt32(RZTDtextBox.Text);
                if (RZTD1textBox != null && !string.IsNullOrWhiteSpace(RZTD1textBox.Text)) Team.RZ_TD1 = Convert.ToInt32(RZTD1textBox.Text);
                if (RZTD2textBox != null && !string.IsNullOrWhiteSpace(RZTD2textBox.Text)) Team.RZ_2D = Convert.ToInt32(RZTD2textBox.Text);
                if (RZ3DtextBox != null && !string.IsNullOrWhiteSpace(RZ3DtextBox.Text)) Team.RZ_3D = Convert.ToInt32(RZ3DtextBox.Text);
                if (RZ4DtextBox != null && !string.IsNullOrWhiteSpace(RZ4DtextBox.Text)) Team.RZ_4D = Convert.ToInt32(RZ4DtextBox.Text);
                if (TOtextBox != null && !string.IsNullOrWhiteSpace(TOtextBox.Text)) Team.TO = Convert.ToInt32(TOtextBox.Text);
                if (SCKSAllowtextBox != null && !string.IsNullOrWhiteSpace(SCKSAllowtextBox.Text)) Team.SCKS_Allow = Convert.ToInt32(SCKSAllowtextBox.Text);

                if (_TeamManager.Add(Team))
                {
                    MessageBox.Show("Data has been saved.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
                else
                {
                    MessageBox.Show("Data save failed", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Reset()
        {
            Nametextbox.Text = string.Empty;
            PointstextBox.Clear();
            FPTStextBox.Clear();
            PlaystextBox.Clear();
            YdstextBox.Clear();
            InttextBox.Clear();
            PassYdstextBox.Clear();
            PassAtttextBox.Clear();
            PassComptextBox.Clear();
            PassTDtextBox.Clear();
            RushYdstextBox.Clear();
            RushAtttextBox.Clear();
            RushTDtextBox.Clear();
            TDtextBox.Clear();
            RZAtttextBox.Clear();
            RZTDtextBox.Clear();
            RZTD1textBox.Clear();
            RZTD2textBox.Clear();
            RZ3DtextBox.Clear();
            RZ4DtextBox.Clear();
            TOtextBox.Clear();
            SCKSAllowtextBox.Clear();
            txtTeamSearch.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //private void TeamDataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        private void TeamDataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) // this brings up the individual rank stats on a detail form and is accessed by right-clicking within the datagrid once team stats have been called up either by the Show All button or by the txtTeamSearch text box and clicking the Search button. Would like to change this to bring up the Team Roster form that would pop with the team double-clicked on 
        {
            try
            {
                DataGridViewRow dr = TeamDataGridView.SelectedRows[0];

                frmTeamDetail frm = new frmTeamDetail(this);

                frm.IdLabel.Text = dr.Cells[0].Value.ToString();
                frm.Nametextbox.Text = dr.Cells[1].Value.ToString();
                frm.txtSeason.Text = dr.Cells[2].Value.ToString();
                frm.PointstextBox.Text = dr.Cells[3].Value.ToString();
                frm.FPTStextBox.Text = dr.Cells[4].Value.ToString();
                frm.PlaystextBox.Text = dr.Cells[5].Value.ToString();
                frm.YdstextBox.Text = dr.Cells[6].Value.ToString();
                frm.InttextBox.Text = dr.Cells[7].Value.ToString();
                frm.PassYdstextBox.Text = dr.Cells[8].Value.ToString();
                frm.PassAtttextBox.Text = dr.Cells[9].Value.ToString();
                frm.PassComptextBox.Text = dr.Cells[10].Value.ToString();
                frm.PassTDtextBox.Text = dr.Cells[11].Value.ToString();
                frm.RushYdstextBox.Text = dr.Cells[12].Value.ToString();
                frm.RushAtttextBox.Text = dr.Cells[13].Value.ToString();
                frm.RushTDtextBox.Text = dr.Cells[14].Value.ToString();
                frm.TDtextBox.Text = dr.Cells[15].Value.ToString();
                frm.RZAtttextBox.Text = dr.Cells[16].Value.ToString();
                frm.RZTDtextBox.Text = dr.Cells[17].Value.ToString();
                frm.RZTD1textBox.Text = dr.Cells[18].Value.ToString();
                frm.RZTD2textBox.Text = dr.Cells[19].Value.ToString();
                frm.RZ3DtextBox.Text = dr.Cells[20].Value.ToString();
                frm.RZ4DtextBox.Text = dr.Cells[21].Value.ToString();
                frm.TOtextBox.Text = dr.Cells[22].Value.ToString();
                frm.SCKSAllowtextBox.Text = dr.Cells[23].Value.ToString();

                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e) //this allows for deleting a team's rank stats from the NFLDB and is accessed by right-clicking on the row of the team that was searched in the txtTeamSearch text box that popped in the datagrid
        {
            try
            {
                TeamManager _teamManager = new TeamManager();

                DataGridViewRow dr = TeamDataGridView.SelectedRows[0];
                if (MessageBox.Show("Do you want to delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = (int)(long)dr.Cells[0].Value;
                    bool isDelete = _teamManager.Delete(id);
                    if (isDelete)
                    {
                        MessageBox.Show("Selected entry has been removed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TeamDataGridView.Rows.Remove(dr);
                        Reset();
                    }
                    else
                    {
                        MessageBox.Show("Selected entry removal failed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e) // this takes the user input from the txtTeamSearch.Text box and pops the datagrid with just that team's rank stats
        {
            if (IsTeamNameValid())
            {
                try
                {

                    SQLiteConnection conn = new SQLiteConnection(@"Data Source = C:\Users\kdstu\source\repos\NFL_Today\DB\NFLDB.db");
                    conn.Open();

                    string query = "SELECT * FROM Teams WHERE Name LIKE '%" + txtTeamSearch.Text + "%'";
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);

                    DataTable dt = new DataTable();

                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);

                    adapter.Fill(dt);

                    TeamDataGridView.DataSource = dt;
                    lblTotal.Text = (TeamDataGridView.RowCount).ToString();
                    label24.Text = String.Format("Total Number of Teams:", label24.Text);
                    conn.Close();

                }
                catch (Exception)
                {
                    MessageBox.Show("Team search failed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnShowTeams_Click(object sender, EventArgs e)  //this is the Show All button that populates the datagrid on the main form with Team Rankings
        {
            try
            {

                SQLiteConnection conn = new SQLiteConnection(@"Data Source = C:\Users\kdstu\source\repos\NFL_Today\DB\NFLDB.db");
                conn.Open();

                string query = "Select id,name,season,pts,fpts,plays,yds,int,pass_yds,pass_att,pass_comp,pass_td,rush_yds,rush_att,rush_td,td,rz_att,rz_td,rz_td1,rz_2d,rz_3d,rz_4d,[TO],scks_allow From Teams";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);

                DataTable dt = new DataTable();

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);

                adapter.Fill(dt);

                TeamDataGridView.DataSource = dt;

                lblTotal.Text = (TeamDataGridView.RowCount).ToString();
                label24.Text = String.Format("Total Number of Teams:", label24.Text);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured." + ex.ToString(), "Error!");
            }

        }

        private void fantasyPlayersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayerFantasyStats frm = new PlayerFantasyStats();
            frm.Show();
        }

        private void qBStatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QB_Stats frm = new QB_Stats();
            frm.Show();
        }

        private void qBStatsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            QB_Stats frm = new QB_Stats();
            frm.Show();
        }

        private void defenseStatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Def_Player_Stats frm = new Def_Player_Stats();
            frm.Show();
        }

        private void fantasyStatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayerFantasyStats frm = new PlayerFantasyStats();
            frm.Show();
        }

        private void teamRosterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NFL_Roster_49ers frm = new NFL_Roster_49ers();
            frm.Show();
        }

        private void snapCountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SnapCounts frm = new SnapCounts();
            frm.Show();
        }

        private void bettingOddsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Betting_Odds frm = new Betting_Odds();
            frm.Show();
        }

        private void targetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Targets frm = new Targets();
            frm.Show();
        }

        private void teamStatsStandingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Team_Stats frm = new Team_Stats();
            frm.Show();
        }

        private void offenseStatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OffenseStats frm = new OffenseStats();
            frm.Show();
        }

        private void depthChartsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepthCharts frm = new DepthCharts();
            frm.Show();
        }

        private void dLListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DLList frm = new DLList();
            frm.Show();
        }

        private void statsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Team_Stats frm = new Team_Stats();
            frm.Show();
        }

        private void seasonStandingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeasonStandings frm = new SeasonStandings();
            frm.Show();
        }

        private void runningBacksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RB_Stats frm = new RB_Stats();
            frm.Show();
        }

        private void wideReceiversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WR_Stats frm = new WR_Stats();
            frm.Show();
        }

        private void tightEndsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TE_Stats frm = new TE_Stats();
            frm.Show();
        }

        private void kickingTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kicker_Stats frm = new Kicker_Stats();
            frm.Show();
        }

        private void quarterbacksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QB_Stats frm = new QB_Stats();
            frm.Show();
        }

        private void analyticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Analytics frm = new Analytics();
            frm.Show();
        }

        //private void updateAllStatsToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Update_All frm = new Update_All();
        //    frm.Show();
        //}

        private void btnInstruction_Click(object sender, EventArgs e)
        {
            Query_Help frm = new Query_Help();
            frm.Show();
        }

        private void glossaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Glossary frm = new Glossary();
            frm.Show();
        }
        //private void btnLookup_Click(object sender, EventArgs e)
        //{


        //        SQLiteConnection conn = new SQLiteConnection(@"Data Source = C:\Users\kdsturg5370\source\repos\NFL_Today\DB\NFLDB.db"); //create a database connection to query for getting the ranking number
        //        conn.Open();

        //        string query = "SELECT '" + cbRankCategory.ValueMember + "' FROM Teams WHERE Name = '" + cbTeam.ValueMember + "'" + " AND Season = '" + cbSeason.ValueMember + "';"; //create the query variable to pass to the database

        //        SQLiteCommand cmd = new SQLiteCommand(query, conn); //Sqlite needs a process to execute the command to run the query using the connection string created previously
        //        SQLiteDataReader adapter = cmd.ExecuteReader(); // SQLite also needs a process to read the data once it has been queried 

        //    //try
        //    //{

        //        //adapter = cmd.ExecuteReader();

        //    if (adapter.Read())
        //        {

        //            //TextBox dt = new TextBox();
        //            //TextBox.DataSource = dt;
        //            //adapter.Fill(dt);
        //            //TextBox dt = new TextBox();

        //            //string RankCategory = adapter.GetInt32(cbRankCategory.Text).ToString();//creating a method via a variable for taking the value chosen in the cb and making it available to the Execute Reader method
        //            //string Season = adapter.GetInt32(cbSeason.Text).ToString();
        //            //string Team = adapter.GetString(cbTeam.Text);
        //            //cbRankCategory.Items.Add(RankCategory);
        //            //cbSeason.Items.Add(Season);
        //            //cbTeam.Items.Add(Team);
        //            txtRankNumber.Text = adapter["cbRankCategory"].ToString();

        //            //cbRankCategory.DataSource = dt;
        //            //adapter.Fill(dt);
        //            //cmd.ExecuteNonQuery();

        //        }

        //    conn.Close();
        //    //}

        //    //catch (Exception ex)
        //    //{
        //       // MessageBox.Show("An error occured." + ex.ToString(), "Error!");
        //   // }
        //}







        //private void cbTeam_SelectedValueChanged(object sender, EventArgs e)
        //{
        //    SQLiteConnection conn = new SQLiteConnection(@"Data Source = C:\Users\kdsturg5370\source\repos\NFL_Today\DB\NFLDB.db"); //create a database connection to query for getting the ranking number
        //    conn.Open();

        //    string query = "SELECT PTS FROM Teams WHERE Name = '" + cbTeam.ValueMember + "'"; //create the query variable to pass to the database

        //    SQLiteCommand cmd = new SQLiteCommand(query, conn); //Sqlite needs a process to execute the command to run the query using the connection string created previously
        //    SQLiteDataReader adapter = cmd.ExecuteReader(); // SQLite also needs a process to read the data once it has been queried 

        //    //try
        //    //{

        //    //adapter = cmd.ExecuteReader();

        //    if (adapter.Read())
        //    {

        //        //TextBox dt = new TextBox();
        //        //TextBox.DataSource = dt;
        //        //adapter.Fill(dt);
        //        //TextBox dt = new TextBox();

        //        //string RankCategory = adapter.GetInt32(cbRankCategory.Text).ToString();//creating a method via a variable for taking the value chosen in the cb and making it available to the Execute Reader method
        //        //string Season = adapter.GetInt32(cbSeason.Text).ToString();
        //        //string Team = adapter.GetString(cbTeam.Text);
        //        //cbRankCategory.Items.Add(RankCategory);
        //        //cbSeason.Items.Add(Season);
        //        //cbTeam.Items.Add(Team);
        //        txtRankNumber.Text = adapter["PTS"].ToString();

        //        //cbRankCategory.DataSource = dt;
        //        //adapter.Fill(dt);
        //        //cmd.ExecuteNonQuery();
        //    }

        //}

        private void btnLookup_Click(object sender, EventArgs e)
        {
            try
            {

                SQLiteConnection conn = new SQLiteConnection(@"Data Source = C:\Users\kdstu\source\repos\NFL_Today\DB\NFLDB.db");
                SQLiteDataAdapter adapter;
                DataSet ds;

                string sql = txtRankNumber.Text;

                adapter = new SQLiteDataAdapter(sql, conn);

                ds = new DataSet();
                adapter.Fill(ds);

                if (string.IsNullOrEmpty(txtRankNumber.Text))
                {
                    MessageBox.Show("Please enter a query.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtRankNumber.Focus();
                    return;
                }


                conn.Close();

                if (ds.Tables[0].Rows.Count != 0)
                {
                    TeamDataGridView.DataSource = ds.Tables[0];
                    lblTotal.Text = (TeamDataGridView.RowCount).ToString();
                    label24.Text = String.Format("Total Number of Results:", label24.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured." + ex.ToString(), "Error!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearForm();
            TeamDataGridView.DataSource = null;
            TeamDataGridView.Rows.Clear();
            TeamDataGridView.Refresh();
        }

        private void updateAllStatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateStats frm = new UpdateStats();
            frm.Show();
        }

        private void btnSaveQuery_Click(object sender, EventArgs e)
        {
            if (IsQueryValid())
            {
                try
                {
                    if (MessageBox.Show("Do you want to save this query?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        SQLiteConnection conn = new SQLiteConnection(@"Data Source = C:\Users\kdstu\source\repos\NFL_Today\DB\NFLDB.db");
                        conn.Open();

                        SQLiteCommand sqlCommand = new SQLiteCommand("INSERT INTO 'Query_Archive'(Query_Text,Query_Name)Values(@QText,@QName)", conn);
                        sqlCommand.Parameters.AddWithValue("@QText", txtRankNumber.Text);
                      
                        sqlCommand.Parameters.AddWithValue("@QName", txtNameQuery.Text);


                        sqlCommand.ExecuteNonQuery();
                        //ClearForm();
                        txtRankNumber.Focus();
                        conn.Close();

                        MessageBox.Show("New query has been added successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Query has not been added.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

       
    }
}

