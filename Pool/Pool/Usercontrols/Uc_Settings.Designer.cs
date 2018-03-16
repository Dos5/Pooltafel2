namespace Pool
{
    partial class Settings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GbxTaal = new System.Windows.Forms.GroupBox();
            this.RbtnDuits = new System.Windows.Forms.RadioButton();
            this.RbtnEngels = new System.Windows.Forms.RadioButton();
            this.RbtnNederlands = new System.Windows.Forms.RadioButton();
            this.BtnTerug = new System.Windows.Forms.Button();
            this.BtnBevestig = new System.Windows.Forms.Button();
            this.GbxTaal.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbxTaal
            // 
            this.GbxTaal.Controls.Add(this.RbtnDuits);
            this.GbxTaal.Controls.Add(this.RbtnEngels);
            this.GbxTaal.Controls.Add(this.RbtnNederlands);
            this.GbxTaal.Location = new System.Drawing.Point(8, 24);
            this.GbxTaal.Name = "GbxTaal";
            this.GbxTaal.Size = new System.Drawing.Size(200, 100);
            this.GbxTaal.TabIndex = 0;
            this.GbxTaal.TabStop = false;
            this.GbxTaal.Text = "Taal";
            // 
            // RbtnDuits
            // 
            this.RbtnDuits.AutoSize = true;
            this.RbtnDuits.Location = new System.Drawing.Point(16, 80);
            this.RbtnDuits.Name = "RbtnDuits";
            this.RbtnDuits.Size = new System.Drawing.Size(47, 17);
            this.RbtnDuits.TabIndex = 2;
            this.RbtnDuits.Text = "duits";
            this.RbtnDuits.UseVisualStyleBackColor = true;
            // 
            // RbtnEngels
            // 
            this.RbtnEngels.AutoSize = true;
            this.RbtnEngels.Location = new System.Drawing.Point(16, 48);
            this.RbtnEngels.Name = "RbtnEngels";
            this.RbtnEngels.Size = new System.Drawing.Size(56, 17);
            this.RbtnEngels.TabIndex = 1;
            this.RbtnEngels.Text = "engels";
            this.RbtnEngels.UseVisualStyleBackColor = true;
            // 
            // RbtnNederlands
            // 
            this.RbtnNederlands.AutoSize = true;
            this.RbtnNederlands.Location = new System.Drawing.Point(16, 16);
            this.RbtnNederlands.Name = "RbtnNederlands";
            this.RbtnNederlands.Size = new System.Drawing.Size(77, 17);
            this.RbtnNederlands.TabIndex = 0;
            this.RbtnNederlands.Text = "nederlands";
            this.RbtnNederlands.UseVisualStyleBackColor = true;
            // 
            // BtnTerug
            // 
            this.BtnTerug.Location = new System.Drawing.Point(144, 136);
            this.BtnTerug.Name = "BtnTerug";
            this.BtnTerug.Size = new System.Drawing.Size(80, 32);
            this.BtnTerug.TabIndex = 1;
            this.BtnTerug.Text = "Terug";
            this.BtnTerug.UseVisualStyleBackColor = true;
            this.BtnTerug.Click += new System.EventHandler(this.BtnTerug_Click);
            // 
            // BtnBevestig
            // 
            this.BtnBevestig.Location = new System.Drawing.Point(16, 136);
            this.BtnBevestig.Name = "BtnBevestig";
            this.BtnBevestig.Size = new System.Drawing.Size(80, 32);
            this.BtnBevestig.TabIndex = 2;
            this.BtnBevestig.Text = "Bevestig";
            this.BtnBevestig.UseVisualStyleBackColor = true;
            this.BtnBevestig.Click += new System.EventHandler(this.BtnBevestig_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.BtnBevestig);
            this.Controls.Add(this.BtnTerug);
            this.Controls.Add(this.GbxTaal);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(252, 188);
            this.GbxTaal.ResumeLayout(false);
            this.GbxTaal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbxTaal;
        private System.Windows.Forms.Button BtnTerug;
        private System.Windows.Forms.Button BtnBevestig;
        private System.Windows.Forms.RadioButton RbtnDuits;
        private System.Windows.Forms.RadioButton RbtnEngels;
        private System.Windows.Forms.RadioButton RbtnNederlands;
    }
}
