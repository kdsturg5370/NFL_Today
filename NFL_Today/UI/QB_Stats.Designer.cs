namespace NFL_Today.UI
{
    partial class QB_Stats
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
            this.txtQBSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchQB = new System.Windows.Forms.Button();
            this.dgvQBStats = new System.Windows.Forms.DataGridView();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPassStats = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQBStats)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtQBSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSearchQB);
            this.groupBox1.Location = new System.Drawing.Point(281, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 107);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quarterback Stats Lookup";
            // 
            // txtQBSearch
            // 
            this.txtQBSearch.Location = new System.Drawing.Point(121, 44);
            this.txtQBSearch.Name = "txtQBSearch";
            this.txtQBSearch.Size = new System.Drawing.Size(182, 23);
            this.txtQBSearch.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quarterback";
            // 
            // btnSearchQB
            // 
            this.btnSearchQB.Location = new System.Drawing.Point(329, 37);
            this.btnSearchQB.Name = "btnSearchQB";
            this.btnSearchQB.Size = new System.Drawing.Size(113, 34);
            this.btnSearchQB.TabIndex = 0;
            this.btnSearchQB.Text = "Search";
            this.btnSearchQB.UseVisualStyleBackColor = true;
            this.btnSearchQB.Click += new System.EventHandler(this.btnSearchQB_Click);
            // 
            // dgvQBStats
            // 
            this.dgvQBStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQBStats.Location = new System.Drawing.Point(63, 213);
            this.dgvQBStats.Name = "dgvQBStats";
            this.dgvQBStats.RowTemplate.Height = 25;
            this.dgvQBStats.Size = new System.Drawing.Size(954, 434);
            this.dgvQBStats.TabIndex = 1;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(362, 697);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(96, 50);
            this.btnShowAll.TabIndex = 2;
            this.btnShowAll.Text = "QB Stats";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(617, 697);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(106, 50);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(874, 697);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(92, 50);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPassStats
            // 
            this.btnPassStats.Location = new System.Drawing.Point(105, 697);
            this.btnPassStats.Name = "btnPassStats";
            this.btnPassStats.Size = new System.Drawing.Size(115, 46);
            this.btnPassStats.TabIndex = 5;
            this.btnPassStats.Text = "All Passing Stats";
            this.btnPassStats.UseVisualStyleBackColor = true;
            this.btnPassStats.Click += new System.EventHandler(this.btnPassStats_Click);
            // 
            // QB_Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 771);
            this.Controls.Add(this.btnPassStats);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.dgvQBStats);
            this.Controls.Add(this.groupBox1);
            this.Name = "QB_Stats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quarterbacks";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQBStats)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtQBSearch;
        private Label label1;
        private Button btnSearchQB;
        private DataGridView dgvQBStats;
        private Button btnShowAll;
        private Button btnClear;
        private Button btnClose;
        private Button btnPassStats;
    }
}