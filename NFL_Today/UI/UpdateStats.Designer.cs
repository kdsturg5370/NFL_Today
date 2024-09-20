namespace NFL_Today.UI
{
    partial class UpdateStats
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
            this.btnUpdPassStat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUpdPassStat
            // 
            this.btnUpdPassStat.Location = new System.Drawing.Point(419, 147);
            this.btnUpdPassStat.Name = "btnUpdPassStat";
            this.btnUpdPassStat.Size = new System.Drawing.Size(152, 43);
            this.btnUpdPassStat.TabIndex = 0;
            this.btnUpdPassStat.Text = "Update Passing Stats";
            this.btnUpdPassStat.UseVisualStyleBackColor = true;
            this.btnUpdPassStat.Click += new System.EventHandler(this.btnUpdPassStat_Click);
            // 
            // UpdateStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdPassStat);
            this.Name = "UpdateStats";
            this.Text = "UpdateStats";
            this.ResumeLayout(false);

        }

        #endregion

        public Button btnUpdPassStat;
    }
}