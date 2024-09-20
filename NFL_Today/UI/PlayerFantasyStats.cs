
using NFL_Today.Manager;
using NFL_Today.Models;
using System.Data;
using System.Data.SQLite;

namespace NFL_Today.UI
{
    public partial class PlayerFantasyStats : Form
    {
        ApplicationDbContext _dbContext = new ApplicationDbContext();
        public PlayerFantasyStats()
        {
            InitializeComponent();
        }
        FanPlayStatsManager _FanPlayStatsManager = new FanPlayStatsManager();
        private bool IsPlayerNameValid()
        {
            if (txtFindPlayer.Text == "")
            {
                MessageBox.Show("Please enter a player's name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }
        private void ClearForm()
        {
            txtFindPlayer.Clear();
            dgvFanPlayStats.ClearSelection();
        }

        private void btnFindPlayer_Click(object sender, EventArgs e)
        {
            if (IsPlayerNameValid())
            {
                try
                {
                    using (SQLiteConnection conn = new SQLiteConnection(@"Data Source = C:\Users\kdstu\source\repos\NFL_Today\DB\NFLDB.db"))
                    {
                        conn.Open();
                        //string qry = "SELECT COUNT(Player) FROM Def_Stats WHERE Player LIKE '%" + txtPlayer.Text + "%'";
                        //using (SQLiteCommand cmdRC = new SQLiteCommand(qry, conn))
                        //{
                        //    if(DataTableCollection.Equals 0) 
                        //    //cmdRC.Parameters.AddWithValue("txtPlayer.Text", txtPlayer.Text);
                        //    //var ctStart = (int)cmdRC.ExecuteScalar();

                        //    //if (ctStart < 1)
                        //    {
                        //        MessageBox.Show("Name does not exist in the database. Please check the name and try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //        return;
                        //    }
                        //    //cmdRC.ExecuteNonQuery()
                        //    else
                        //    {
                        string query = "SELECT * FROM Player_Fantasy_Stats WHERE Full_Name LIKE '%" + txtFindPlayer.Text + "%'";
                        using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                        {
                            DataTable dt = new DataTable();

                            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);

                            adapter.Fill(dt);

                            dgvFanPlayStats.DataSource = dt;



                        }
                        conn.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Player search failed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            try
            {

                SQLiteConnection conn = new SQLiteConnection(@"Data Source = C:\Users\kdstu\source\repos\NFL_Today\DB\NFLDB.db");
                conn.Open();

                string query = "Select * FROM Player_Fantasy_Stats";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);

                DataTable dt = new DataTable();

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);

                adapter.Fill(dt);

                dgvFanPlayStats.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured." + ex.ToString(), "Error!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearForm();
            dgvFanPlayStats.DataSource = null;
            dgvFanPlayStats.Rows.Clear();
            dgvFanPlayStats.Refresh();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvFanPlayStats_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow dr = dgvFanPlayStats.SelectedRows[0];
                PlayerFantasyDetail form = new PlayerFantasyDetail();
                //this.Hide();
                //form.Show();
                form.Idlabel.Text = dr.Cells[0].Value.ToString();
                form.txtDPlayerDet.Text = dr.Cells[1].Value.ToString();
                form.txtDTeamDet.Text = dr.Cells[2].Value.ToString();
                form.txtDPosDet.Text = dr.Cells[3].Value.ToString();
                form.txtGPDet.Text = dr.Cells[4].Value.ToString();
                form.txtSnapsPGDet.Text = dr.Cells[5].Value.ToString();
                form.txtPctTeamSnapsDet.Text = dr.Cells[6].Value.ToString();
                form.txtPctTeam1SnapsDet.Text = dr.Cells[7].Value.ToString();
                form.txtPctTeam2SnapsDet.Text = dr.Cells[8].Value.ToString();
                form.txtPctTeam3SnapsDet.Text = dr.Cells[9].Value.ToString();
                form.txtRZSnapsPGDet.Text = dr.Cells[10].Value.ToString();
                form.txtPctTeamRZSnapsDet.Text = dr.Cells[11].Value.ToString();
                form.txtPPRPointsDet.Text = dr.Cells[12].Value.ToString();
                form.txtPPRPtsPGDet.Text = dr.Cells[13].Value.ToString();
                form.txtExpFptsDet.Text = dr.Cells[14].Value.ToString();
                form.txtExpFptsPGDet.Text = dr.Cells[15].Value.ToString();
                form.txtFPOEDet.Text = dr.Cells[16].Value.ToString();
                form.txtFPOEPGDet.Text = dr.Cells[17].Value.ToString();
                form.txtExpPassFptsDet.Text = dr.Cells[18].Value.ToString();
                form.txtExpPassFptsPGDet.Text = dr.Cells[19].Value.ToString();
                form.txtExpRushFptsDet.Text = dr.Cells[20].Value.ToString();
                form.txtExpRushFptsPGDet.Text = dr.Cells[21].Value.ToString();
                form.txtExpRecFptsDet.Text = dr.Cells[22].Value.ToString();
                form.txtExpRecFptsPGDet.Text = dr.Cells[23].Value.ToString();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = dgvFanPlayStats.SelectedRows[0];
                if (MessageBox.Show("Do you want to delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = (int)(long)dr.Cells[0].Value;
                    bool isDelete = _FanPlayStatsManager.Delete(id);
                    if (isDelete)
                    {
                        MessageBox.Show("Player has been removed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //ssLoadData();
                        dgvFanPlayStats.Rows.Remove(dr);
                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("Player removal failed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
