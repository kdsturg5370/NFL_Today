using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NFL_Today.UI
{
    public partial class Team_Stats : Form
    {
        public Team_Stats()
        {
            InitializeComponent();
        }
        private bool IsPlayerNameValid()
        {
            if (txtPlayerLookup.Text == "")
            {
                MessageBox.Show("Please enter a name.");
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

        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            try
            {

                SQLiteConnection conn = new SQLiteConnection(@"Data Source = C:\Users\kdsturg5370\source\repos\NFL_Today\DB\NFLDB.db");
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
