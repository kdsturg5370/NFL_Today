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
    public partial class DefStatsDetail : Form
    {
        public DefStatsDetail()
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
            
            //txtQBHitsDet.Clear();
            txtFumTDDet.Clear();
            txtFumRecovDet.Clear();
            txtRetTDDet.Clear();
            txtIntRetYdsDet.Clear();
            txtPassDefDet.Clear();
            txtSackYdsDet.Clear();
            txtTtlTacksDet.Clear();
            txtSolosDet.Clear();
            txtDPosDet.Clear();
            txtDTeamDet.Clear();
            //txtIntForTDDet.Clear();
            //txtSnapsDet.Clear();
            //txtFumRecYdsDet.Clear();
            txtForceFumDet.Clear();
            txtLongIntDet.Clear();
            txtIntDet.Clear();
            txtTackLossDet.Clear();
            txtSacksDet.Clear();
            txtAsstTacksDet.Clear();
            txtGPDet.Clear();
            txtDRankDet.Clear();
            
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
                        sqlCommand.Parameters.AddWithValue("@Rank", txtDRankDet.Text);
                        sqlCommand.Parameters.AddWithValue("@Team", txtDTeamDet.Text);
                        sqlCommand.Parameters.AddWithValue("@Player", txtDPlayerDet.Text);
                        sqlCommand.Parameters.AddWithValue("@Position", txtDPosDet.Text);
                        sqlCommand.Parameters.AddWithValue("@GamesPlayed", txtGPDet.Text);
                        sqlCommand.Parameters.AddWithValue("@SoloTackles", txtSolosDet.Text);
                        sqlCommand.Parameters.AddWithValue("@AssistedTackles", txtAsstTacksDet.Text);
                        sqlCommand.Parameters.AddWithValue("@TotalTackles", txtTtlTacksDet.Text);
                        sqlCommand.Parameters.AddWithValue("@Sacks", txtSacksDet.Text);
                        sqlCommand.Parameters.AddWithValue("@SackYards", txtSackYdsDet.Text);
                        sqlCommand.Parameters.AddWithValue("@TacklesforLoss", txtTackLossDet.Text);
                        sqlCommand.Parameters.AddWithValue("@PassesDefended", txtPassDefDet.Text);
                        sqlCommand.Parameters.AddWithValue("@Interceptions", txtIntDet.Text);
                        sqlCommand.Parameters.AddWithValue("@InterceptionReturnYards", txtIntRetYdsDet.Text);
                        sqlCommand.Parameters.AddWithValue("@LongInterception", txtLongIntDet.Text);
                        sqlCommand.Parameters.AddWithValue("@ReturnTouchdowns", txtRetTDDet.Text);
                        sqlCommand.Parameters.AddWithValue("@ForcedFumbles", txtForceFumDet.Text);
                        sqlCommand.Parameters.AddWithValue("@FumblesRecovered", txtFumRecovDet.Text);
                        sqlCommand.Parameters.AddWithValue("@FumbleTouchdown", txtFumTDDet.Text);

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
