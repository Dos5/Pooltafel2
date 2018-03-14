namespace Pool
{
    partial class PooltafelMain
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
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnRegistreren = new System.Windows.Forms.Button();
            this.BtnAfsluiten = new System.Windows.Forms.Button();
            this.BtnSettings = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BtnLogin.Location = new System.Drawing.Point(128, 39);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(127, 49);
            this.BtnLogin.TabIndex = 0;
            this.BtnLogin.Text = "Inloggen";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnRegistreren
            // 
            this.BtnRegistreren.Location = new System.Drawing.Point(128, 98);
            this.BtnRegistreren.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnRegistreren.Name = "BtnRegistreren";
            this.BtnRegistreren.Size = new System.Drawing.Size(127, 49);
            this.BtnRegistreren.TabIndex = 1;
            this.BtnRegistreren.Text = "Registreren";
            this.BtnRegistreren.UseVisualStyleBackColor = true;
            this.BtnRegistreren.Click += new System.EventHandler(this.BtnSettings_Click_1);
            // 
            // BtnAfsluiten
            // 
            this.BtnAfsluiten.Location = new System.Drawing.Point(128, 158);
            this.BtnAfsluiten.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnAfsluiten.Name = "BtnAfsluiten";
            this.BtnAfsluiten.Size = new System.Drawing.Size(127, 49);
            this.BtnAfsluiten.TabIndex = 2;
            this.BtnAfsluiten.Text = "Afsluiten";
            this.BtnAfsluiten.UseVisualStyleBackColor = true;
            this.BtnAfsluiten.Click += new System.EventHandler(this.BtnAfsluiten_Click);
            // 
            // BtnSettings
            // 
            this.BtnSettings.Image = global::Pool.Properties.Resources.Gear;
            this.BtnSettings.Location = new System.Drawing.Point(373, 0);
            this.BtnSettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(43, 39);
            this.BtnSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnSettings.TabIndex = 3;
            this.BtnSettings.TabStop = false;
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click_2);
            // 
            // PooltafelMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(419, 229);
            this.Controls.Add(this.BtnSettings);
            this.Controls.Add(this.BtnAfsluiten);
            this.Controls.Add(this.BtnRegistreren);
            this.Controls.Add(this.BtnLogin);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PooltafelMain";
            this.Text = "                 Pooltafel-Application";
            ((System.ComponentModel.ISupportInitialize)(this.BtnSettings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnRegistreren;
        private System.Windows.Forms.Button BtnAfsluiten;
        private System.Windows.Forms.PictureBox BtnSettings;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

