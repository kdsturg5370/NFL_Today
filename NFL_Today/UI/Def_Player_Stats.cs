
//using Microsoft.EntityFrameworkCore;
using NFL_Today.Manager;
using NFL_Today.Models;
//using NFL_Today;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
using System.Data;
//using System.Data.Common;
//using System.Data.SqlClient;
//using System.Drawing;
//using System.Drawing.Text;
//using System.Linq;
//using System.Reflection.Emit;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SQLite;
//using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using NFL_Today.UI;

namespace Eagles_Roster
{

    public partial class Def_Player_Stats : Form
    {
        ApplicationDbContext _dbContext = new ApplicationDbContext();
        public Def_Player_Stats()
        {
            InitializeComponent();
        }
        DefStatsManager _DefStatsManager = new DefStatsManager();
        private bool IsPlayerNameValid()
        {
            if (txtPlayer.Text == "")
            {
                MessageBox.Show("Please enter a player's name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool IsDPlayerNameValid()
        {
            if (txtDPlayer.Text == "")
            {
                MessageBox.Show("Please enter a player's name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool IsTeamNameValid()
        {
            if (txtFindTeam.Text == "")
            {
                MessageBox.Show("Please enter a team name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void ClearForm()
        {
            txtDPlayer.Clear();
            txtPlayer.Clear();
            //txtQBHits.Clear();
            txtFumTD.Clear();
            txtFumRecov.Clear();
            txtRetTD.Clear();
            txtIntRetYds.Clear();
            txtPassDef.Clear();
            txtSackYds.Clear();
            txtTtlTacks.Clear();
            txtSolos.Clear();
            txtDPos.Clear();
            txtDTeam.Clear();
            //txtIntForTD.Clear();
            //txtSnaps.Clear();
            //txtFumRecYds.Clear();
            txtForceFum.Clear();
            txtLongInt.Clear();
            txtInt.Clear();
            txtTackLoss.Clear();
            txtSacks.Clear();
            txtAsstTacks.Clear();
            txtGP.Clear();
            txtDRank.Clear();
            txtFindTeam.Clear();


            dgvDefStats.ClearSelection();
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnClearForm_Click(object sender, EventArgs e)
        {
            this.ClearForm();
            dgvDefStats.DataSource = null;
            dgvDefStats.Rows.Clear();
            dgvDefStats.Refresh();
        }

        DefStatsManager _defStatsManager = new DefStatsManager();
 
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            try
            {

                SQLiteConnection conn = new SQLiteConnection(@"Data Source = C:\Users\kdsturg5370\source\repos\NFL_Today\DB\NFLDB.db");
                conn.Open();

                string query = "Select Id,Rank,Team,Player,Position,GamesPlayed,SoloTackles,AssistedTackles,TotalTackles,Sacks,SackYards,TacklesforLoss,PassesDefended,Interceptions,InterceptionReturnYards,LongInterception,ReturnTouchdowns,ForcedFumbles,FumblesRecovered,FumbleTouchdown From Def_Stats";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);

                DataTable dt = new DataTable();

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);

                adapter.Fill(dt);

                dgvDefStats.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured." + ex.ToString(), "Error!");
            }

        }

        private void btnFindDefPlayer_Click_1(object sender, EventArgs e)
        {
            if (IsPlayerNameValid())
            {
                try
                {
                    using (SQLiteConnection conn = new SQLiteConnection(@"Data Source = C:\Users\kdsturg5370\source\repos\NFL_Today\DB\NFLDB.db"))
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
                                string query = "SELECT Id,Rank,Team,Player,Position,GamesPlayed,SoloTackles,AssistedTackles,TotalTackles,Sacks,SackYards,TacklesforLoss,PassesDefended,Interceptions,InterceptionReturnYards,LongInterception,ReturnTouchdowns,ForcedFumbles,FumblesRecovered,FumbleTouchdown FROM Def_Stats WHERE Player LIKE '%" + txtPlayer.Text + "%'";
                                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                                {
                                    DataTable dt = new DataTable();

                                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);

                                    adapter.Fill(dt);

                                    dgvDefStats.DataSource = dt;


                                    
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

        private void btnTeamStats_Click(object sender, EventArgs e)
        {
            if (IsTeamNameValid())
            {
                try
                {

                    SQLiteConnection conn = new SQLiteConnection(@"Data Source = C:\Users\kdsturg5370\source\repos\NFL_Today\DB\NFLDB.db");
                    conn.Open();

                    string query = "SELECT * FROM Def_Stats WHERE Team LIKE '%" + txtFindTeam.Text + "%'";
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);

                    DataTable dt = new DataTable();

                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);

                    adapter.Fill(dt);

                    dgvDefStats.DataSource = dt;
                    conn.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Team search failed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void deletePlayerToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = dgvDefStats.SelectedRows[0];
                if (MessageBox.Show("Do you want to delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = (int)(long)dr.Cells[0].Value;
                    bool isDelete = _DefStatsManager.Delete(id);
                    if (isDelete)
                    {
                        MessageBox.Show("Player has been removed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //ssLoadData();
                        dgvDefStats.Rows.Remove(dr);
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

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            if (IsDPlayerNameValid())

            {

                try
                {
                    if (MessageBox.Show("Do you want to add this player?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        SQLiteConnection conn = new SQLiteConnection(@"Data Source = C:\Users\kdsturg5370\source\repos\NFL_Today\DB\NFLDB.db");
                        conn.Open();
                    
                        SQLiteCommand sqlCommand = new SQLiteCommand("INSERT INTO Def_Stats(Rank,Team,Player,Position,GamesPlayed,SoloTackles,AssistedTackles,TotalTackles,Sacks,SackYards,TacklesforLoss,PassesDefended,Interceptions,InterceptionReturnYards,LongInterception,ReturnTouchdowns,ForcedFumbles,FumblesRecovered,FumbleTouchdown)Values(@Rank,@Team,@Player,@Position,@GamesPlayed,@SoloTackles,@AssistedTackles,@TotalTackles,@Sacks,@SackYards,@TacklesforLoss,@PassesDefended,@Interceptions,@InterceptionReturnYards,@LongInterception,@ReturnTouchdowns,@ForcedFumbles,@FumblesRecovered,@FumbleTouchdown)", conn);
                        sqlCommand.Parameters.AddWithValue("@Rank", txtDRank.Text);
                        sqlCommand.Parameters.AddWithValue("@Team", txtDTeam.Text);
                        sqlCommand.Parameters.AddWithValue("@Player", txtDPlayer.Text);
                        sqlCommand.Parameters.AddWithValue("@Position", txtDPos.Text);
                        sqlCommand.Parameters.AddWithValue("@GamesPlayed", txtGP.Text);
                        sqlCommand.Parameters.AddWithValue("@SoloTackles", txtSolos.Text);
                        sqlCommand.Parameters.AddWithValue("@AssistedTackles", txtAsstTacks.Text);
                        sqlCommand.Parameters.AddWithValue("@TotalTackles", txtTtlTacks.Text);
                        sqlCommand.Parameters.AddWithValue("@Sacks", txtSacks.Text);
                        sqlCommand.Parameters.AddWithValue("@SackYards", txtSackYds.Text);
                        sqlCommand.Parameters.AddWithValue("@TacklesforLoss", txtTackLoss.Text);
                        sqlCommand.Parameters.AddWithValue("@PassesDefended", txtPassDef.Text);
                        sqlCommand.Parameters.AddWithValue("@Interceptions", txtInt.Text);
                        sqlCommand.Parameters.AddWithValue("@InterceptionReturnYards", txtIntRetYds.Text);
                        sqlCommand.Parameters.AddWithValue("@LongInterception", txtLongInt.Text);
                        sqlCommand.Parameters.AddWithValue("@ReturnTouchdowns", txtRetTD.Text);
                        sqlCommand.Parameters.AddWithValue("@ForcedFumbles", txtForceFum.Text);
                        sqlCommand.Parameters.AddWithValue("@FumblesRecovered", txtFumRecov.Text);
                        sqlCommand.Parameters.AddWithValue("@FumbleTouchdown", txtFumTD.Text);

                        
                        sqlCommand.ExecuteNonQuery();
                        ClearForm();
                        conn.Close();

                        MessageBox.Show("New player has been added.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                else
                    {
                        MessageBox.Show("Team removal failed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnPlayerStats_Click(object sender, EventArgs e)
        {
            if (IsDPlayerNameValid())

            {
                SQLiteConnection conn = new SQLiteConnection(@"Data Source = C:\Users\kdsturg5370\source\repos\NFL_Today\DB\NFLDB.db");
                //conn.Open();
                {
                    string sql = "SELECT Player,Rank,GamesPlayed,AssistedTackles,Sacks,TacklesforLoss,Interceptions,LongInterception,ForcedFumbles," +
                    "Team,Position,SoloTackles,TotalTackles,SackYards,PassesDefended,InterceptionReturnYards," +
                    "ReturnTouchdowns,FumblesRecovered,FumbleTouchdown FROM Def_Stats WHERE Player Like '%" + txtDPlayer.Text + "%'";
                    SQLiteCommand sqlCommand = new SQLiteCommand(sql, conn);
                    {
                        sqlCommand.Parameters.Add(new SQLiteParameter("@Player", (DbType)SqlDbType.NVarChar, 50));
                        sqlCommand.Parameters["@Player"].Value = txtDPlayer.Text;
                        try
                        {
                            

                            conn.Open();
                            SQLiteDataReader reader = sqlCommand.ExecuteReader();   
                            if (reader.Read())
                            {
                                txtDRank.Text = reader.GetValue(1).ToString();
                                txtGP.Text = reader.GetValue(2).ToString();
                                txtAsstTacks.Text = reader.GetValue(3).ToString();
                                txtSacks.Text = reader.GetValue(4).ToString();
                                txtTackLoss.Text = reader.GetValue(5).ToString();
                                txtInt.Text = reader.GetValue(6).ToString();
                                txtLongInt.Text = reader.GetValue(7).ToString();
                                txtForceFum.Text = reader.GetValue(8).ToString();
                                //txtFumRecYds.Text = reader.GetValue(9).ToString();
                                //txtSnaps.Text = reader.GetValue(10).ToString();
                                //txtIntForTD.Text = reader.GetValue(11).ToString();
                                txtDTeam.Text = reader.GetValue(9).ToString();
                                txtDPos.Text = reader.GetValue(10).ToString();
                                txtSolos.Text = reader.GetValue(11).ToString();
                                txtTtlTacks.Text = reader.GetValue(12).ToString();
                                txtSackYds.Text = reader.GetValue(13).ToString();
                                txtPassDef.Text = reader.GetValue(14).ToString();
                                txtIntRetYds.Text = reader.GetValue(15).ToString();
                                txtRetTD.Text = reader.GetValue(16).ToString();
                                txtFumRecov.Text = reader.GetValue(17).ToString();
                                txtFumTD.Text = reader.GetValue(18).ToString();
                                //txtQBHits.Text = reader.GetValue(22).ToString();

                                reader.Close();
                            }
                            sqlCommand.ExecuteNonQuery();

                            conn.Close();


                            //if (string.IsNullOrEmpty(txtDPlayer.Text))
                            //{
                            //    MessageBox.Show("Please enter a name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            //    txtDPlayer.Focus();
                            //    return;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    } 
                }
            }

        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (IsDPlayerNameValid())

            {

                try
                {
                    if (MessageBox.Show("Do you want to update this player's stats?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        
                    //conn.Open();
                    {
                        SQLiteConnection conn = new SQLiteConnection(@"Data Source = C:\Users\kdsturg5370\source\repos\NFL_Today\DB\NFLDB.db");
                        SQLiteCommand sqlCommand = new SQLiteCommand("UPDATE Def_Stats SET Rank=@Rank," +
                            "Team=@Team," +
                            "Player=@Player," +
                            "Position=@Position," +
                            "GamesPlayed=@GamesPlayed," +
                            "SoloTackles=@SoloTackles," +
                            "AssistedTackles=@AssistedTackles," +
                            "TotalTackles=@TotalTackles," +
                            "Sacks=@Sacks," +
                            "SackYards=@SackYards," +
                            "TacklesforLoss=@TacklesforLoss," +
                            "PassesDefended=@PassesDefended," +
                            "Interceptions=@Interceptions," +
                            "InterceptionReturnYards=@InterceptionReturnYards," +
                            "LongInterception=@LongInterception," +
                            "ReturnTouchdowns=@ReturnTouchdowns," +
                            "ForcedFumbles=@ForcedFumbles," +
                            "FumblesRecovered=@FumblesRecovered," +
                            "FumbleTouchdown=@FumbleTouchdown " +
                            "WHERE Player=@Player", conn);
                        sqlCommand.Parameters.AddWithValue("@Rank", txtDRank.Text);
                        sqlCommand.Parameters.AddWithValue("@Team", txtDTeam.Text);
                        sqlCommand.Parameters.AddWithValue("@Player", txtDPlayer.Text);
                        sqlCommand.Parameters.AddWithValue("@Position", txtDPos.Text);
                        sqlCommand.Parameters.AddWithValue("@GamesPlayed", txtGP.Text);
                        sqlCommand.Parameters.AddWithValue("@SoloTackles", txtSolos.Text);
                        sqlCommand.Parameters.AddWithValue("@AssistedTackles", txtAsstTacks.Text);
                        sqlCommand.Parameters.AddWithValue("@TotalTackles", txtTtlTacks.Text);
                        sqlCommand.Parameters.AddWithValue("@Sacks", txtSacks.Text);
                        sqlCommand.Parameters.AddWithValue("@SackYards", txtSackYds.Text);
                        sqlCommand.Parameters.AddWithValue("@TacklesforLoss", txtTackLoss.Text);
                        sqlCommand.Parameters.AddWithValue("@PassesDefended", txtPassDef.Text);
                        sqlCommand.Parameters.AddWithValue("@Interceptions", txtInt.Text);
                        sqlCommand.Parameters.AddWithValue("@InterceptionReturnYards", txtIntRetYds.Text);
                        sqlCommand.Parameters.AddWithValue("@LongInterception", txtLongInt.Text);
                        sqlCommand.Parameters.AddWithValue("@ReturnTouchdowns", txtRetTD.Text);
                        sqlCommand.Parameters.AddWithValue("@ForcedFumbles", txtForceFum.Text);
                        sqlCommand.Parameters.AddWithValue("@FumblesRecovered", txtFumRecov.Text);
                        sqlCommand.Parameters.AddWithValue("@FumbleTouchdown", txtFumTD.Text);

                        conn.Open();
                        sqlCommand.ExecuteNonQuery();

                       
                        
                        MessageBox.Show("Player update succeeded.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        

                        ClearForm();
                        txtDPlayer.Focus();
                        conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("Player update failed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    //if (string.IsNullOrEmpty(txtDPlayer.Text))
                    //{
                    //    MessageBox.Show("Please enter a name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //    txtDPlayer.Focus();
                    //    return;
                    //}

                }


                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void dgvDefStats_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow dr = dgvDefStats.SelectedRows[0];
                DefStatsDetail form = new DefStatsDetail();
                //this.Hide();
                //form.Show();
                form.IdLabel.Text = dr.Cells[0].Value.ToString();
                form.txtDRankDet.Text = dr.Cells[1].Value.ToString();
                form.txtDTeamDet.Text = dr.Cells[2].Value.ToString();
                form.txtDPlayerDet.Text = dr.Cells[3].Value.ToString();
                form.txtDPosDet.Text = dr.Cells[4].Value.ToString();
                form.txtGPDet.Text = dr.Cells[5].Value.ToString();
                form.txtSolosDet.Text = dr.Cells[6].Value.ToString();
                form.txtAsstTacksDet.Text = dr.Cells[7].Value.ToString();
                form.txtTtlTacksDet.Text = dr.Cells[8].Value.ToString();
                form.txtSacksDet.Text = dr.Cells[9].Value.ToString();
                form.txtSackYdsDet.Text = dr.Cells[10].Value.ToString();
                form.txtTackLossDet.Text = dr.Cells[11].Value.ToString();
                form.txtPassDefDet.Text = dr.Cells[12].Value.ToString();
                form.txtIntDet.Text = dr.Cells[13].Value.ToString();
                form.txtIntRetYdsDet.Text = dr.Cells[14].Value.ToString();
                form.txtLongIntDet.Text = dr.Cells[15].Value.ToString();
                form.txtRetTDDet.Text = dr.Cells[16].Value.ToString();
                form.txtForceFumDet.Text = dr.Cells[17].Value.ToString();
                form.txtFumRecovDet.Text = dr.Cells[18].Value.ToString();
                form.txtFumTDDet.Text = dr.Cells[19].Value.ToString();
 
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
        
}

