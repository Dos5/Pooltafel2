using System;

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
            this.Btn_Login = new System.Windows.Forms.Button();
            this.Btn_Registreren = new System.Windows.Forms.Button();
            this.Btn_Afsluiten = new System.Windows.Forms.Button();
            this.Btn_Settings = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Settings)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Login
            // 
            this.Btn_Login.BackColor = System.Drawing.Color.Navy;
            this.Btn_Login.ForeColor = System.Drawing.Color.White;
            this.Btn_Login.Location = new System.Drawing.Point(153, 25);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(95, 40);
            this.Btn_Login.TabIndex = 0;
            this.Btn_Login.Text = "Inloggen";
            this.Btn_Login.UseVisualStyleBackColor = false;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // Btn_Registreren
            // 
            this.Btn_Registreren.BackColor = System.Drawing.Color.Navy;
            this.Btn_Registreren.ForeColor = System.Drawing.Color.White;
            this.Btn_Registreren.Location = new System.Drawing.Point(153, 93);
            this.Btn_Registreren.Name = "Btn_Registreren";
            this.Btn_Registreren.Size = new System.Drawing.Size(95, 40);
            this.Btn_Registreren.TabIndex = 1;
            this.Btn_Registreren.Text = "Registreren";
            this.Btn_Registreren.UseVisualStyleBackColor = false;
            this.Btn_Registreren.Click += new System.EventHandler(this.Btn_Registreren_Click);
            // 
            // Btn_Afsluiten
            // 
            this.Btn_Afsluiten.BackColor = System.Drawing.Color.Navy;
            this.Btn_Afsluiten.ForeColor = System.Drawing.Color.White;
            this.Btn_Afsluiten.Location = new System.Drawing.Point(153, 166);
            this.Btn_Afsluiten.Name = "Btn_Afsluiten";
            this.Btn_Afsluiten.Size = new System.Drawing.Size(95, 40);
            this.Btn_Afsluiten.TabIndex = 2;
            this.Btn_Afsluiten.Text = "Afsluiten";
            this.Btn_Afsluiten.UseVisualStyleBackColor = false;
            this.Btn_Afsluiten.Click += new System.EventHandler(this.Btn_Afsluiten_Click);
            // 
            // Btn_Settings
            // 
            this.Btn_Settings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Btn_Settings.Image = global::Pool.Properties.Resources.Gear;
            this.Btn_Settings.Location = new System.Drawing.Point(415, 1);
            this.Btn_Settings.Name = "Btn_Settings";
            this.Btn_Settings.Size = new System.Drawing.Size(33, 33);
            this.Btn_Settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Btn_Settings.TabIndex = 3;
            this.Btn_Settings.TabStop = false;
            this.Btn_Settings.Click += new System.EventHandler(this.Btn_Settings_Click);
            // 
            // PooltafelMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(449, 261);
            this.Controls.Add(this.Btn_Settings);
            this.Controls.Add(this.Btn_Afsluiten);
            this.Controls.Add(this.Btn_Registreren);
            this.Controls.Add(this.Btn_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "PooltafelMain";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                 Pooltafel-Application";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Settings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Login;
        private System.Windows.Forms.Button Btn_Registreren;
        private System.Windows.Forms.Button Btn_Afsluiten;
        private System.Windows.Forms.PictureBox Btn_Settings;
    }
}

