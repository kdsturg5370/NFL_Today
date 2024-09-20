//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
using System.Data.SQLite;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

namespace NFL_Today.UI
{
    public partial class PlayerFantasyDetail : Form
    {
        public PlayerFantasyDetail()
        {
            InitializeComponent();
        }
        private bool IsDPlayerNameValid()
        {
            if (txtDPlayerDet.Text == "")
            {
                MessageBox.Show("Please enter a name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDPlayerDet.Focus();
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
            txtDPlayerDet.Clear();
            txtDTeamDet.Clear();
            txtDPosDet.Clear();
            txtPPRPointsDet.Clear();
            txtPPRPtsPGDet.Clear();
            txtSnapsPGDet.Clear();
            txtGPDet.Clear();
            txtRZSnapsPGDet.Clear();
            txtPctTeamRZSnapsDet.Clear();
            txtPctTeamSnapsDet.Clear();
            txtPctTeam1SnapsDet.Clear();
            txtPctTeam2SnapsDet.Clear();
            txtPctTeam3SnapsDet.Clear();
            txtFPOEDet.Clear();
            txtFPOEPGDet.Clear();
            txtExpPassFptsDet.Clear();
            txtExpPassFptsPGDet.Clear();
            txtExpRushFptsDet.Clear();
            txtExpRushFptsPGDet.Clear();
            txtExpFptsDet.Clear();
            txtExpFptsPGDet.Clear();
            txtExpRecFptsDet.Clear();
            txtExpRecFptsPGDet.Clear();

        }
        private void btnCloseDet_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (IsDPlayerNameValid())

            {

                try
                    
                {
                    SQLiteConnection conn = new SQLiteConnection(@"Data Source = C:\Users\kdstu\source\repos\NFL_Today\DB\NFLDB.db");
                    //conn.Open();
                    if (MessageBox.Show("Do you want to update?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        SQLiteCommand sqlCommand = new SQLiteCommand("UPDATE Player_Fantasy_Stats SET Full_Name=@Player," +
                            "Team=@Team," +
                            "Position=@POS," +
                            "Games=@GP," +
                            "Snaps_PG=@SnapsPG," +
                            "Pct_Team_Snaps=@PctTeamSnaps," +
                            "Pct_Team_First_Snaps=@PctTeam1Snaps," +
                            "Pct_Team_Second_Snaps=@PctTeam2Snaps," +
                            "Pct_Team_Third_Snaps=@PctTeam3Snaps," +
                            "RZ_Snaps_PG=@RZSnapsPG," +
                            "Pct_Team_RZ_Snaps=@PctTeamRZSnaps," +
                            "Ppr_Points=@PPRPoints," +
                            "Ppr_Points_PG=@PPRPtsPG," +
                            "Exp_Fpts=@ExpFpts," +
                            "Exp_Fpts_PG=@ExpFptsPG," +
                            "Fpoe=@FPOE," +
                            "Fpoe_PG=@FPOEPG," +
                            "Exp_Pass_Fpts=@ExpPassFpts," +
                            "Exp_Pass_Fpts_PG=@ExpPassFptsPG," +
                            "Exp_Rush_Fpts=@ExpRushFpts," +
                            "Exp_Rush_Fpts_PG=@ExpRushFptsPG," +
                            "Exp_Rec_Fpts=@ExpRecFpts," +
                            "Exp_Rec_Fpts_PG=@ExpRecFptsPG " +
                            "WHERE Full_Name=@Player", conn);
                        
                        sqlCommand.Parameters.AddWithValue("@Player", txtDPlayerDet.Text);
                        sqlCommand.Parameters.AddWithValue("@Team", txtDTeamDet.Text);
                        sqlCommand.Parameters.AddWithValue("@POS", txtDPosDet.Text);
                        sqlCommand.Parameters.AddWithValue("@GP", txtGPDet.Text);
                        sqlCommand.Parameters.AddWithValue("@SnapsPG", txtSnapsPGDet.Text);//
                        sqlCommand.Parameters.AddWithValue("@PctTeamSnaps", txtPctTeamSnapsDet.Text);
                        sqlCommand.Parameters.AddWithValue("@PctTeam1Snaps", txtPctTeam1SnapsDet.Text);
                        sqlCommand.Parameters.AddWithValue("@PctTeam2Snaps", txtPctTeam2SnapsDet.Text);
                        sqlCommand.Parameters.AddWithValue("@PctTeam3Snaps", txtPctTeam3SnapsDet.Text);
                        sqlCommand.Parameters.AddWithValue("@RZSnapsPG", txtRZSnapsPGDet.Text);
                        sqlCommand.Parameters.AddWithValue("@PctTeamRZSnaps", txtPctTeamRZSnapsDet.Text);
                        sqlCommand.Parameters.AddWithValue("@PPRPoints", txtPPRPointsDet.Text);
                        sqlCommand.Parameters.AddWithValue("@PPRPtsPG", txtPPRPtsPGDet.Text);
                        sqlCommand.Parameters.AddWithValue("@ExpFpts", txtExpFptsDet.Text);
                        sqlCommand.Parameters.AddWithValue("@ExpFptsPG", txtExpFptsPGDet.Text);
                        sqlCommand.Parameters.AddWithValue("@FPOE", txtFPOEDet.Text);
                        sqlCommand.Parameters.AddWithValue("@FPOEPG", txtFPOEPGDet.Text);
                        sqlCommand.Parameters.AddWithValue("@ExpPassFpts", txtExpPassFptsDet.Text);
                        sqlCommand.Parameters.AddWithValue("@ExpPassFptsPG", txtExpPassFptsPGDet.Text);
                        sqlCommand.Parameters.AddWithValue("@ExpRushFpts", txtExpRushFptsDet.Text);
                        sqlCommand.Parameters.AddWithValue("@ExpRushFptsPG", txtExpRushFptsPGDet.Text);
                        sqlCommand.Parameters.AddWithValue("@ExpRecFpts", txtExpRecFptsDet.Text);
                        sqlCommand.Parameters.AddWithValue("@ExpRecFptsPG", txtExpRecFptsPGDet.Text);

                        conn.Open();
                        sqlCommand.ExecuteNonQuery();
                        DialogResult dialogResult = MessageBox.Show("Player has been updated.", "Update Successful");
                        ClearForm();
                        txtDPlayerDet.Focus();
                        conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("Player info was not updated.", "Update Player Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
