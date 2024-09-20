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
    public partial class DepthCharts : Form
    {
        public DepthCharts()
        {
            InitializeComponent();
        }
        private bool IsPlayerNameValid()
        {
            if (txtPlayerLookup.Text == "")
            {
                MessageBox.Show("Please enter a name.","Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void ClearForm()
        {
            txtPlayerLookup.Clear();

            dgvPlayerLookup.ClearSelection();
        }

        private void btnPlayerLookup_Click(object sender, EventArgs e)
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
                        string query = "SELECT * FROM Snap_Counts WHERE Name LIKE '%" + txtPlayerLookup.Text + "%'";
                        using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                        {
                            DataTable dt = new DataTable();

                            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);

                            adapter.Fill(dt);

                            dgvPlayerLookup.DataSource = dt;



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

                string query = "Select * From Snap_Counts";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);

                DataTable dt = new DataTable();

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);

                adapter.Fill(dt);

                dgvPlayerLookup.DataSource = dt;

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
            dgvPlayerLookup.DataSource = null;
            dgvPlayerLookup.Rows.Clear();
            dgvPlayerLookup.Refresh();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
