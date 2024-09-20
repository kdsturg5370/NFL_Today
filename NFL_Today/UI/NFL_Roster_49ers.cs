//using Microsoft.EntityFrameworkCore;
//using NFL_Today.Manager;
//using NFL_Today.Models;
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
//using NFL_Today.Gateway;
using NFL_Today.Manager.NFL_Today.Manager;
using System.Windows.Forms;
//using System.Xml.Linq;

namespace Eagles_Roster
{
    public partial class NFL_Roster_49ers : Form
    {
        public NFL_Roster_49ers()
            //string Name, string Pos,int No, int Rating, int Ranking, string Height, int Weight, int Age, string Birthday, int Exp, int Drafted, int DraftRound, int DraftPick, string College)
        {
            InitializeComponent();

            //dgvPlayerInfo.Rows.Add();
            //dgvPlayerInfo.Rows[0].Cells[0].Value = Name;
            //dgvPlayerInfo.Rows[0].Cells[1].Value = Pos;
            //dgvPlayerInfo.Rows[0].Cells[2].Value = No;
            //dgvPlayerInfo.Rows[0].Cells[3].Value = Rating;
            //dgvPlayerInfo.Rows[0].Cells[4].Value = Ranking;
            //dgvPlayerInfo.Rows[0].Cells[5].Value = Height;
            //dgvPlayerInfo.Rows[0].Cells[6].Value = Weight;
            //dgvPlayerInfo.Rows[0].Cells[7].Value = Age;
            //dgvPlayerInfo.Rows[0].Cells[8].Value = Birthday;
            //dgvPlayerInfo.Rows[0].Cells[9].Value = Exp;
            //dgvPlayerInfo.Rows[0].Cells[10].Value = Drafted;
            //dgvPlayerInfo.Rows[0].Cells[11].Value = DraftRound;
            //dgvPlayerInfo.Rows[0].Cells[12].Value = DraftPick;
            //dgvPlayerInfo.Rows[0].Cells[13].Value = College;
        }

        private bool IsPlayerNameValid()
        {
            if (txtPlayer.Text == "")
            {
                MessageBox.Show("Please enter a name.");
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool IsSFPlayerNameValid()
        {
            if (txtPlaySearch.Text == "")
            {
                MessageBox.Show("Please enter a name.");
                return false;
            }
            else
            {
                return true;
            }
        }

        /// Clears the form data.

        private void ClearForm()
        {
            txtTeam.Clear();
            txtSeason.Clear();
            txtPosition.Clear();
            txtPlayer.Clear();
            txtNumber.Clear();
            txtRating.Clear();
            txtRank.Clear();
            txtHeight.Clear();
            txtWeight.Clear();  
            txtCollege.Clear();
            txtDraftPick.Clear();
            txtDraftRd.Clear();
            txtYrDrafted.Clear();
            txtYrsInNFL.Clear();    
            txtDOB.Clear();
            txtAge.Clear();
            txtPlaySearch.Clear();
            dgvPlayerInfo.ClearSelection();
        }


        private void btnPlayer_Click(object sender, EventArgs e)
        {
            if (IsPlayerNameValid())
            {
                try
                {
                    if (MessageBox.Show("Do you want to add this player?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        SQLiteConnection conn = new SQLiteConnection(@"Data Source = C:\Users\kdstu\source\repos\NFL_Today\DB\NFLDB.db");
                        conn.Open();

                        SQLiteCommand sqlCommand = new SQLiteCommand("INSERT INTO 'Team_Roster'(Team,Season,Name,Pos,No,Rating,Ranking,Height,Weight,Age,Birthday,Exp,Drafted,DraftRound,DraftPick,College)Values(@Team,@Season,@Player,@Position,@Number,@Rating,@Rank,@Height,@Weight,@Age,@DOB,@YrsInNFL,@Drafted,@DraftRd,@DraftPick,@College)", conn);
                        sqlCommand.Parameters.AddWithValue("@Team", txtTeam.Text);
                        sqlCommand.Parameters.AddWithValue("@Season", txtSeason.Text);
                        sqlCommand.Parameters.AddWithValue("@Player", txtPlayer.Text);
                        sqlCommand.Parameters.AddWithValue("@Position", txtPosition.Text);
                        sqlCommand.Parameters.AddWithValue("@Number", txtNumber.Text);
                        sqlCommand.Parameters.AddWithValue("@Rating", txtRating.Text);
                        sqlCommand.Parameters.AddWithValue("@Rank", txtRank.Text);
                        sqlCommand.Parameters.AddWithValue("@Height", txtHeight.Text);
                        sqlCommand.Parameters.AddWithValue("@Weight", txtWeight.Text);
                        sqlCommand.Parameters.AddWithValue("@Age", txtAge.Text);
                        sqlCommand.Parameters.AddWithValue("@DOB", txtDOB.Text);
                        sqlCommand.Parameters.AddWithValue("@YrsInNFL", txtYrsInNFL.Text);
                        sqlCommand.Parameters.AddWithValue("@Drafted", txtYrDrafted.Text);
                        sqlCommand.Parameters.AddWithValue("@DraftRd", txtDraftRd.Text);
                        sqlCommand.Parameters.AddWithValue("@DraftPick", txtDraftPick.Text);
                        sqlCommand.Parameters.AddWithValue("@College", txtCollege.Text);
                        


                        sqlCommand.ExecuteNonQuery();
                        ClearForm();
                        txtPlayer.Focus();
                        conn.Close();

                        MessageBox.Show("New player has been added successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Player has not been added.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearForm();
            dgvPlayerInfo.DataSource = null;
            dgvPlayerInfo.Rows.Clear();
            dgvPlayerInfo.Refresh();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            
            
                try
                {
                    SQLiteConnection conn = new SQLiteConnection(@"Data Source = C:\Users\kdstu\source\repos\NFL_Today\DB\NFLDB.db");
                    conn.Open();

                    string query = "Select Id,Team,Season,Name,Pos,No,Rating,Ranking,Height,Weight,Age,Birthday,Exp,Drafted,DraftRound,DraftPick,College From 'Team_Roster'";
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);

                    DataTable dt = new DataTable();

                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);

                    adapter.Fill(dt);

                    dgvPlayerInfo.DataSource = dt;

                    conn.Close();
                    dgvPlayerInfo.ReadOnly = true;
                    //gvPlayerInfo.DataSource = ds.Tables[0];
                }
                catch
                {
                    MessageBox.Show("The requested player list could not be loaded into the form.");
                }
                //finally
                //{
                //    // Close the connection.
                //    conn.Close();
                //}
            
        }

        private void btnFindPlayer_Click(object sender, EventArgs e)
        {
            if (IsSFPlayerNameValid())
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
                        string query = "SELECT Id,Team,Season,Name,Pos,No,Rating,Ranking,Height,Weight,Age,Birthday,Exp,Drafted,DraftRound,DraftPick,College FROM 'Team_Roster' WHERE Name LIKE '%" + txtPlaySearch.Text + "%'";
                        using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                        {
                            DataTable dt = new DataTable();

                            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);

                            adapter.Fill(dt);

                            dgvPlayerInfo.DataSource = dt;



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
        //public class SFRosterManager
        //{
        //    SFRosterManager _sfRosterManager = new SFRosterManager();
        //    public bool Delete(int id)
        //    {
        //        return _sfRosterManager.Delete(id);
        //    }
        //}
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TeamRosterManager _teamRosterManager = new TeamRosterManager();

                DataGridViewRow dr = dgvPlayerInfo.SelectedRows[0];
                if (MessageBox.Show("Do you want to delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = (int)(long)dr.Cells[0].Value;
                    //int id = (int)dr.Cells[0].Value;
                    //string id = (string)dr.Cells[0].Value;
                    bool isDelete = _teamRosterManager.Delete(id);
                    if (isDelete)
                    {
                        MessageBox.Show("Player has been removed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //ssLoadData();
                        dgvPlayerInfo.Rows.Remove(dr);
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

        private void dgvPlayerInfo_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)//would like this to bring up the stats of the player that is clicked on in the datagrid
        {
            try
            {
                DataGridViewRow dr = dgvPlayerInfo.SelectedRows[0];
                RosterDetail form = new RosterDetail();
                //this.Hide();
                //form.Show();
                form.IdLabel.Text = dr.Cells[0].Value.ToString();
                form.txtTeam.Text = dr.Cells[1].Value.ToString();
                form.txtSeason.Text = dr.Cells[2].Value.ToString();
                form.txtPlayer.Text = dr.Cells[3].Value.ToString();
                form.txtPosition.Text = dr.Cells[4].Value.ToString();
                form.txtNumber.Text = dr.Cells[5].Value.ToString();
                form.txtRating.Text = dr.Cells[6].Value.ToString();
                form.txtRanking.Text = dr.Cells[7].Value.ToString();
                form.txtHeight.Text = dr.Cells[8].Value.ToString();
                form.txtWeight.Text = dr.Cells[9].Value.ToString();
                form.txtAge.Text = dr.Cells[10].Value.ToString();
                form.txtDOB.Text = dr.Cells[11].Value.ToString();
                form.txtYrsInNFL.Text = dr.Cells[12].Value.ToString();
                form.txtDrafted.Text = dr.Cells[13].Value.ToString();
                form.txtDraftRound.Text = dr.Cells[14].Value.ToString();
                form.txtDraftPick.Text = dr.Cells[15].Value.ToString();
                form.txtCollege.Text = dr.Cells[16].Value.ToString();
                

                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
