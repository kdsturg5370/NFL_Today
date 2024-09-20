//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
using System.Data.SQLite;

namespace NFL_Today.UI
{
    public partial class RosterDetail : Form
    {
        public RosterDetail()
        {
            InitializeComponent();
        }
        private bool IsDPlayerNameValid()
        {
            if (txtPlayer.Text == "")
            {
                MessageBox.Show("Please enter a name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPlayer.Focus();
                //    return;
                return false;
            }
            else
            {
                return true;
            }
        }

        private void ClearForm()
        {
            txtTeam.Clear();
            txtSeason.Clear();
            txtPlayer.Clear();
            txtPosition.Clear();
            txtNumber.Clear();
            txtRating.Clear();
            txtRanking.Clear();
            txtHeight.Clear();
            txtWeight.Clear();
            txtAge.Clear();
            txtDOB.Clear();
            txtYrsInNFL.Clear();
            txtDrafted.Clear();
            txtDraftRound.Clear();
            txtDraftPick.Clear();
            txtCollege.Clear();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (IsDPlayerNameValid())

            {

                try

                {
                    SQLiteConnection conn = new SQLiteConnection(@"Data Source = C:\Users\kdsturg5370\source\repos\NFL_Today\DB\NFLDB.db");
                    //conn.Open();
                    if (MessageBox.Show("Do you want to update?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        SQLiteCommand sqlCommand = new SQLiteCommand("UPDATE Team_Roster SET Team=@Team,Season=@Season, Name=@Player,Pos=@Position,No=@Number,Rating=@Rating,Ranking=@Ranking,Height=@Height,Weight=@Weight,Age=@Age,Birthday=@DOB,Exp=@YrsInNFL,Drafted=@Drafted,DraftRound=@DraftRound,DraftPick=@DraftPick,College=@College WHERE Name=@Player", conn);
                        sqlCommand.Parameters.AddWithValue("@Team", txtTeam.Text);
                        sqlCommand.Parameters.AddWithValue("@Season", txtSeason.Text);
                        sqlCommand.Parameters.AddWithValue("@Player", txtPlayer.Text);
                        sqlCommand.Parameters.AddWithValue("@Position", txtPosition.Text);
                        sqlCommand.Parameters.AddWithValue("@Number", txtNumber.Text);
                        sqlCommand.Parameters.AddWithValue("@Rating", txtRating.Text);
                        sqlCommand.Parameters.AddWithValue("@Ranking", txtRanking.Text);
                        sqlCommand.Parameters.AddWithValue("@Height", txtHeight.Text);
                        sqlCommand.Parameters.AddWithValue("@Weight", txtWeight.Text);
                        sqlCommand.Parameters.AddWithValue("@Age", txtAge.Text);
                        sqlCommand.Parameters.AddWithValue("@DOB", txtDOB.Text);
                        sqlCommand.Parameters.AddWithValue("@YrsInNFL", txtYrsInNFL.Text);
                        sqlCommand.Parameters.AddWithValue("@Drafted", txtDrafted.Text);
                        sqlCommand.Parameters.AddWithValue("@DraftRound", txtDraftRound.Text);
                        sqlCommand.Parameters.AddWithValue("@DraftPick", txtDraftPick.Text);
                        sqlCommand.Parameters.AddWithValue("@College", txtCollege.Text);
                        

                        conn.Open();
                        sqlCommand.ExecuteNonQuery();
                        DialogResult dialogResult = MessageBox.Show("Player has been updated.", "Update Successful");
                        ClearForm();
                        txtPlayer.Focus();
                        conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("Player info was not updated.", "Update Player Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
