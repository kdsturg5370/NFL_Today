using NFL_Today.Manager;
using NFL_Today.Models;
//using NFL_Today.Gateway;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

namespace NFL_Today.UI
{
    public partial class frmTeamDetail : Form
    {
        MainForm frm;
        public frmTeamDetail(MainForm frm)
        {
            InitializeComponent();
            this.frm = frm; 
        }
        //frmStudent frm;
        //public frmStudentDetail()
        //{
        //    InitializeComponent();
        //    this.frm = frm;
        //}
        TeamManager _TeamManager=new TeamManager();
        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Nametextbox.Text))
                {
                    MessageBox.Show("Please enter a name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Nametextbox.Focus();
                    return;
                }
                //if (string.IsNullOrEmpty(PointstextBox.Text))
                //{
                //    MessageBox.Show("Please enter a number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    PointstextBox.Focus();
                //    return;
                //}
                //if (string.IsNullOrEmpty(FPTStextBox.Text))
                //{
                //    MessageBox.Show("Please enter a number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    FPTStextBox.Focus();
                //    return;
                //}
                Teams Team = new Teams();
                Team.Id = Convert.ToInt32(IdLabel.Text);
                Team.Name = Nametextbox.Text;
                Team.Season = Convert.ToInt32(txtSeason.Text);
                Team.PTS = Convert.ToInt32(PointstextBox.Text);
                Team.FPTS = Convert.ToInt32(FPTStextBox.Text);
                Team.Plays = Convert.ToInt32(PlaystextBox.Text);
                Team.Yds = Convert.ToInt32(YdstextBox.Text);
                Team.Int = Convert.ToInt32(InttextBox.Text);
                Team.Pass_Yds = Convert.ToInt32(PassYdstextBox.Text);
                Team.Pass_Att = Convert.ToInt32(PassAtttextBox.Text);
                Team.Pass_Comp = Convert.ToInt32(PassComptextBox.Text);
                Team.Pass_TD = Convert.ToInt32(PassTDtextBox.Text);
                Team.Rush_Yds = Convert.ToInt32(RushYdstextBox.Text);
                Team.Rush_Att = Convert.ToInt32(RushAtttextBox.Text);
                Team.Rush_TD = Convert.ToInt32(RushTDtextBox.Text);
                Team.TD = Convert.ToInt32(TDtextBox.Text);
                Team.RZ_Att = Convert.ToInt32(RZAtttextBox.Text);
                Team.RZ_TD = Convert.ToInt32(RZTDtextBox.Text);
                Team.RZ_TD1 = Convert.ToInt32(RZTD1textBox.Text);
                Team.RZ_2D = Convert.ToInt32(RZTD2textBox.Text);
                Team.RZ_3D = Convert.ToInt32(RZ3DtextBox.Text);
                Team.RZ_4D = Convert.ToInt32(RZ4DtextBox.Text);
                Team.TO = Convert.ToInt32(TOtextBox.Text);
                Team.SCKS_Allow = Convert.ToInt32(SCKSAllowtextBox.Text);
                // _DbContext.Teams.Add(student);  
                if (_TeamManager.Update(Team))
                {
                    MessageBox.Show("Data has been modified.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    //frm.LoadData();
                }
                else
                {
                    MessageBox.Show("Data modification failed", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
