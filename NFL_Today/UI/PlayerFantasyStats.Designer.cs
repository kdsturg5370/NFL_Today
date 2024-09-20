namespace NFL_Today.UI
{
    partial class PlayerFantasyStats
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
            this.components = new System.ComponentModel.Container();
            this.dgvFanPlayStats = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFindPlayer = new System.Windows.Forms.TextBox();
            this.btnFindPlayer = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFanPlayStats)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFanPlayStats
            // 
            this.dgvFanPlayStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFanPlayStats.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvFanPlayStats.Location = new System.Drawing.Point(29, 120);
            this.dgvFanPlayStats.Name = "dgvFanPlayStats";
            this.dgvFanPlayStats.RowTemplate.Height = 25;
            this.dgvFanPlayStats.Size = new System.Drawing.Size(1029, 534);
            this.dgvFanPlayStats.TabIndex = 0;
            this.dgvFanPlayStats.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFanPlayStats_RowHeaderMouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFindPlayer);
            this.groupBox1.Controls.Add(this.btnFindPlayer);
            this.groupBox1.Location = new System.Drawing.Point(292, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 75);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fantasy Player Lookup";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Player";
            // 
            // txtFindPlayer
            // 
            this.txtFindPlayer.Location = new System.Drawing.Point(92, 27);
            this.txtFindPlayer.Name = "txtFindPlayer";
            this.txtFindPlayer.Size = new System.Drawing.Size(159, 23);
            this.txtFindPlayer.TabIndex = 1;
            // 
            // btnFindPlayer
            // 
            this.btnFindPlayer.Location = new System.Drawing.Point(282, 22);
            this.btnFindPlayer.Name = "btnFindPlayer";
            this.btnFindPlayer.Size = new System.Drawing.Size(123, 31);
            this.btnFindPlayer.TabIndex = 2;
            this.btnFindPlayer.Text = "Find Player";
            this.btnFindPlayer.UseVisualStyleBackColor = true;
            this.btnFindPlayer.Click += new System.EventHandler(this.btnFindPlayer_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(222, 677);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(111, 53);
            this.btnShowAll.TabIndex = 2;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(481, 677);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 53);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear Form";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(729, 677);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(95, 53);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // PlayerFantasyStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 742);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvFanPlayStats);
            this.Name = "PlayerFantasyStats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Player Fantasy Statistics    ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFanPlayStats)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvFanPlayStats;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtFindPlayer;
        private Button btnFindPlayer;
        private Button btnShowAll;
        private Button btnClear;
        private Button btnClose;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem deleteToolStripMenuItem;
    }
}