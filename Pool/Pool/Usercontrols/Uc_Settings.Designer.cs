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
            this.Gbx_Taal = new System.Windows.Forms.GroupBox();
            this.Rbtn_NL = new System.Windows.Forms.RadioButton();
            this.Rbtn_Duits = new System.Windows.Forms.RadioButton();
            this.Rbtn_Engels = new System.Windows.Forms.RadioButton();
            this.BtnTerug = new System.Windows.Forms.Button();
            this.BtnBevestig = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Gbx_Taal.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gbx_Taal
            // 
            this.Gbx_Taal.Controls.Add(this.Rbtn_NL);
            this.Gbx_Taal.Controls.Add(this.Rbtn_Duits);
            this.Gbx_Taal.Controls.Add(this.Rbtn_Engels);
            this.Gbx_Taal.ForeColor = System.Drawing.Color.White;
            this.Gbx_Taal.Location = new System.Drawing.Point(95, 46);
            this.Gbx_Taal.Name = "Gbx_Taal";
            this.Gbx_Taal.Size = new System.Drawing.Size(200, 100);
            this.Gbx_Taal.TabIndex = 0;
            this.Gbx_Taal.TabStop = false;
            this.Gbx_Taal.Text = "Taal";
            // 
            // Rbtn_NL
            // 
            this.Rbtn_NL.AutoSize = true;
            this.Rbtn_NL.Location = new System.Drawing.Point(24, 72);
            this.Rbtn_NL.Name = "Rbtn_NL";
            this.Rbtn_NL.Size = new System.Drawing.Size(79, 17);
            this.Rbtn_NL.TabIndex = 2;
            this.Rbtn_NL.TabStop = true;
            this.Rbtn_NL.Text = "Nederlands";
            this.Rbtn_NL.UseVisualStyleBackColor = true;
            // 
            // Rbtn_Duits
            // 
            this.Rbtn_Duits.AutoSize = true;
            this.Rbtn_Duits.Location = new System.Drawing.Point(24, 48);
            this.Rbtn_Duits.Name = "Rbtn_Duits";
            this.Rbtn_Duits.Size = new System.Drawing.Size(49, 17);
            this.Rbtn_Duits.TabIndex = 1;
            this.Rbtn_Duits.TabStop = true;
            this.Rbtn_Duits.Text = "Duits";
            this.Rbtn_Duits.UseVisualStyleBackColor = true;
            // 
            // Rbtn_Engels
            // 
            this.Rbtn_Engels.AutoSize = true;
            this.Rbtn_Engels.Location = new System.Drawing.Point(24, 24);
            this.Rbtn_Engels.Name = "Rbtn_Engels";
            this.Rbtn_Engels.Size = new System.Drawing.Size(57, 17);
            this.Rbtn_Engels.TabIndex = 0;
            this.Rbtn_Engels.TabStop = true;
            this.Rbtn_Engels.Text = "Engels";
            this.Rbtn_Engels.UseVisualStyleBackColor = true;
            // 
            // BtnTerug
            // 
            this.BtnTerug.BackColor = System.Drawing.Color.Navy;
            this.BtnTerug.ForeColor = System.Drawing.Color.White;
            this.BtnTerug.Location = new System.Drawing.Point(297, 201);
            this.BtnTerug.Name = "BtnTerug";
            this.BtnTerug.Size = new System.Drawing.Size(80, 32);
            this.BtnTerug.TabIndex = 1;
            this.BtnTerug.Text = "Terug";
            this.BtnTerug.UseVisualStyleBackColor = false;
            this.BtnTerug.Click += new System.EventHandler(this.Btn_Terug_Click);
            // 
            // BtnBevestig
            // 
            this.BtnBevestig.BackColor = System.Drawing.Color.Navy;
            this.BtnBevestig.ForeColor = System.Drawing.Color.White;
            this.BtnBevestig.Location = new System.Drawing.Point(31, 201);
            this.BtnBevestig.Name = "BtnBevestig";
            this.BtnBevestig.Size = new System.Drawing.Size(80, 32);
            this.BtnBevestig.TabIndex = 2;
            this.BtnBevestig.Text = "Bevestig";
            this.BtnBevestig.UseVisualStyleBackColor = false;
            this.BtnBevestig.Click += new System.EventHandler(this.Btn_Bevestig_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnBevestig);
            this.Controls.Add(this.BtnTerug);
            this.Controls.Add(this.Gbx_Taal);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(414, 261);
            this.Gbx_Taal.ResumeLayout(false);
            this.Gbx_Taal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gbx_Taal;
        private System.Windows.Forms.RadioButton Rbtn_NL;
        private System.Windows.Forms.RadioButton Rbtn_Duits;
        private System.Windows.Forms.RadioButton Rbtn_Engels;
        private System.Windows.Forms.Button BtnTerug;
        private System.Windows.Forms.Button BtnBevestig;
        private System.Windows.Forms.Button button1;
    }
}
