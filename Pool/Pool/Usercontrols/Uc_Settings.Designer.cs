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
            this.Btn_Terug = new System.Windows.Forms.Button();
            this.Btn_Bevestig = new System.Windows.Forms.Button();
            this.Gbx_Taal.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gbx_Taal
            // 
            this.Gbx_Taal.Controls.Add(this.Rbtn_NL);
            this.Gbx_Taal.Controls.Add(this.Rbtn_Duits);
            this.Gbx_Taal.Controls.Add(this.Rbtn_Engels);
            this.Gbx_Taal.ForeColor = System.Drawing.Color.White;
            this.Gbx_Taal.Location = new System.Drawing.Point(127, 57);
            this.Gbx_Taal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Gbx_Taal.Name = "Gbx_Taal";
            this.Gbx_Taal.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Gbx_Taal.Size = new System.Drawing.Size(267, 123);
            this.Gbx_Taal.TabIndex = 0;
            this.Gbx_Taal.TabStop = false;
            this.Gbx_Taal.Text = "Taal";
            // 
            // Rbtn_NL
            // 
            this.Rbtn_NL.AutoSize = true;
            this.Rbtn_NL.Location = new System.Drawing.Point(32, 89);
            this.Rbtn_NL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Rbtn_NL.Name = "Rbtn_NL";
            this.Rbtn_NL.Size = new System.Drawing.Size(102, 21);
            this.Rbtn_NL.TabIndex = 2;
            this.Rbtn_NL.TabStop = true;
            this.Rbtn_NL.Text = "Nederlands";
            this.Rbtn_NL.UseVisualStyleBackColor = true;
            // 
            // Rbtn_Duits
            // 
            this.Rbtn_Duits.AutoSize = true;
            this.Rbtn_Duits.Location = new System.Drawing.Point(32, 59);
            this.Rbtn_Duits.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Rbtn_Duits.Name = "Rbtn_Duits";
            this.Rbtn_Duits.Size = new System.Drawing.Size(61, 21);
            this.Rbtn_Duits.TabIndex = 1;
            this.Rbtn_Duits.TabStop = true;
            this.Rbtn_Duits.Text = "Duits";
            this.Rbtn_Duits.UseVisualStyleBackColor = true;
            // 
            // Rbtn_Engels
            // 
            this.Rbtn_Engels.AutoSize = true;
            this.Rbtn_Engels.Location = new System.Drawing.Point(32, 30);
            this.Rbtn_Engels.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Rbtn_Engels.Name = "Rbtn_Engels";
            this.Rbtn_Engels.Size = new System.Drawing.Size(72, 21);
            this.Rbtn_Engels.TabIndex = 0;
            this.Rbtn_Engels.TabStop = true;
            this.Rbtn_Engels.Text = "Engels";
            this.Rbtn_Engels.UseVisualStyleBackColor = true;
            // 
            // Btn_Terug
            // 
            this.Btn_Terug.BackColor = System.Drawing.Color.Navy;
            this.Btn_Terug.ForeColor = System.Drawing.Color.White;
            this.Btn_Terug.Location = new System.Drawing.Point(415, 262);
            this.Btn_Terug.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Terug.Name = "Btn_Terug";
            this.Btn_Terug.Size = new System.Drawing.Size(87, 48);
            this.Btn_Terug.TabIndex = 1;
            this.Btn_Terug.Text = "Terug";
            this.Btn_Terug.UseVisualStyleBackColor = false;
            this.Btn_Terug.Click += new System.EventHandler(this.Btn_Terug_Click);
            // 
            // Btn_Bevestig
            // 
            this.Btn_Bevestig.BackColor = System.Drawing.Color.Navy;
            this.Btn_Bevestig.ForeColor = System.Drawing.Color.White;
            this.Btn_Bevestig.Location = new System.Drawing.Point(50, 262);
            this.Btn_Bevestig.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Bevestig.Name = "Btn_Bevestig";
            this.Btn_Bevestig.Size = new System.Drawing.Size(87, 48);
            this.Btn_Bevestig.TabIndex = 2;
            this.Btn_Bevestig.Text = "Bevestig";
            this.Btn_Bevestig.UseVisualStyleBackColor = false;
            this.Btn_Bevestig.Click += new System.EventHandler(this.Btn_Bevestig_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.Controls.Add(this.Btn_Bevestig);
            this.Controls.Add(this.Btn_Terug);
            this.Controls.Add(this.Gbx_Taal);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(810, 321);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.Gbx_Taal.ResumeLayout(false);
            this.Gbx_Taal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gbx_Taal;
        private System.Windows.Forms.RadioButton Rbtn_NL;
        private System.Windows.Forms.RadioButton Rbtn_Duits;
        private System.Windows.Forms.RadioButton Rbtn_Engels;
        private System.Windows.Forms.Button Btn_Terug;
        private System.Windows.Forms.Button Btn_Bevestig;
    }
}
