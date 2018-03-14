namespace Pool
{
    partial class Form1
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
            this.BtnSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(96, 32);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(95, 40);
            this.BtnLogin.TabIndex = 0;
            this.BtnLogin.Text = "Inloggen";
            this.BtnLogin.UseVisualStyleBackColor = true;
            // 
            // BtnRegistreren
            // 
            this.BtnRegistreren.Location = new System.Drawing.Point(96, 80);
            this.BtnRegistreren.Name = "BtnRegistreren";
            this.BtnRegistreren.Size = new System.Drawing.Size(95, 40);
            this.BtnRegistreren.TabIndex = 1;
            this.BtnRegistreren.Text = "Registreren";
            this.BtnRegistreren.UseVisualStyleBackColor = true;
            // 
            // BtnAfsluiten
            // 
            this.BtnAfsluiten.Location = new System.Drawing.Point(96, 128);
            this.BtnAfsluiten.Name = "BtnAfsluiten";
            this.BtnAfsluiten.Size = new System.Drawing.Size(95, 40);
            this.BtnAfsluiten.TabIndex = 2;
            this.BtnAfsluiten.Text = "Afsluiten";
            this.BtnAfsluiten.UseVisualStyleBackColor = true;
            // 
            // BtnSettings
            // 
            this.BtnSettings.Location = new System.Drawing.Point(272, 0);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(40, 32);
            this.BtnSettings.TabIndex = 3;
            this.BtnSettings.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 212);
            this.Controls.Add(this.BtnSettings);
            this.Controls.Add(this.BtnAfsluiten);
            this.Controls.Add(this.BtnRegistreren);
            this.Controls.Add(this.BtnLogin);
            this.Name = "Form1";
            this.Text = "                 Pooltafel-Application";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnRegistreren;
        private System.Windows.Forms.Button BtnAfsluiten;
        private System.Windows.Forms.Button BtnSettings;
    }
}

