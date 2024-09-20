

namespace NFL_Today.UI
{
    partial class SeasonStandings : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPlayerLookup = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPlayerLookup = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvPlayerLookup = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayerLookup)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPlayerLookup);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnPlayerLookup);
            this.groupBox1.Location = new System.Drawing.Point(261, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 134);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Standings Lookup";
            // 
            // txtPlayerLookup
            // 
            this.txtPlayerLookup.Location = new System.Drawing.Point(150, 54);
            this.txtPlayerLookup.Name = "txtPlayerLookup";
            this.txtPlayerLookup.Size = new System.Drawing.Size(217, 23);
            this.txtPlayerLookup.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Team";
            // 
            // btnPlayerLookup
            // 
            this.btnPlayerLookup.Location = new System.Drawing.Point(419, 46);
            this.btnPlayerLookup.Name = "btnPlayerLookup";
            this.btnPlayerLookup.Size = new System.Drawing.Size(75, 41);
            this.btnPlayerLookup.TabIndex = 0;
            this.btnPlayerLookup.Text = "Search";
            this.btnPlayerLookup.UseVisualStyleBackColor = true;
            this.btnPlayerLookup.Click += new System.EventHandler(this.btnPlayerLookup_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(188, 697);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(99, 55);
            this.btnShowAll.TabIndex = 1;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(520, 697);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 55);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(820, 697);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 55);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvPlayerLookup
            // 
            this.dgvPlayerLookup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayerLookup.Location = new System.Drawing.Point(76, 217);
            this.dgvPlayerLookup.Name = "dgvPlayerLookup";
            this.dgvPlayerLookup.RowTemplate.Height = 25;
            this.dgvPlayerLookup.Size = new System.Drawing.Size(925, 459);
            this.dgvPlayerLookup.TabIndex = 4;
            // 
            // SeasonStandings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 764);
            this.Controls.Add(this.dgvPlayerLookup);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.groupBox1);
            this.Name = "SeasonStandings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Season Standings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayerLookup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtPlayerLookup;
        private Label label1;
        private Button btnPlayerLookup;
        private Button btnShowAll;
        private Button btnClear;
        private Button btnClose;
        private DataGridView dgvPlayerLookup;
    }
}