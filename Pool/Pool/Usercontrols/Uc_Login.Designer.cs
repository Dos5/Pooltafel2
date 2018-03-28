namespace Pool
{
    partial class Login
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
            this.button1 = new System.Windows.Forms.Button();
            this.Tb_naam = new System.Windows.Forms.TextBox();
            this.Tb_wachtwoord = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnWachtwoord = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.LbNaam = new System.Windows.Forms.Label();
            this.LbWachtwoord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 55);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 0);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Tb_naam
            // 
            this.Tb_naam.Location = new System.Drawing.Point(101, 47);
            this.Tb_naam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tb_naam.Name = "Tb_naam";
            this.Tb_naam.Size = new System.Drawing.Size(177, 22);
            this.Tb_naam.TabIndex = 1;
            // 
            // Tb_wachtwoord
            // 
            this.Tb_wachtwoord.Location = new System.Drawing.Point(101, 96);
            this.Tb_wachtwoord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tb_wachtwoord.Name = "Tb_wachtwoord";
            this.Tb_wachtwoord.Size = new System.Drawing.Size(177, 22);
            this.Tb_wachtwoord.TabIndex = 2;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(3, 167);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(87, 48);
            this.BtnLogin.TabIndex = 3;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnWachtwoord
            // 
            this.BtnWachtwoord.Location = new System.Drawing.Point(109, 167);
            this.BtnWachtwoord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnWachtwoord.Name = "BtnWachtwoord";
            this.BtnWachtwoord.Size = new System.Drawing.Size(113, 48);
            this.BtnWachtwoord.TabIndex = 4;
            this.BtnWachtwoord.Text = "Wachtwoord vergeten";
            this.BtnWachtwoord.UseVisualStyleBackColor = true;
            this.BtnWachtwoord.Click += new System.EventHandler(this.BtnWachtwoord_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(240, 167);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(87, 48);
            this.BtnExit.TabIndex = 5;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LbNaam
            // 
            this.LbNaam.AutoSize = true;
            this.LbNaam.Location = new System.Drawing.Point(51, 47);
            this.LbNaam.Name = "LbNaam";
            this.LbNaam.Size = new System.Drawing.Size(45, 17);
            this.LbNaam.TabIndex = 6;
            this.LbNaam.Text = "Naam";
            // 
            // LbWachtwoord
            // 
            this.LbWachtwoord.AutoSize = true;
            this.LbWachtwoord.Location = new System.Drawing.Point(9, 98);
            this.LbWachtwoord.Name = "LbWachtwoord";
            this.LbWachtwoord.Size = new System.Drawing.Size(86, 17);
            this.LbWachtwoord.TabIndex = 7;
            this.LbWachtwoord.Text = "Wachtwoord";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LbWachtwoord);
            this.Controls.Add(this.LbNaam);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnWachtwoord);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.Tb_wachtwoord);
            this.Controls.Add(this.Tb_naam);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(331, 250);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Tb_naam;
        private System.Windows.Forms.TextBox Tb_wachtwoord;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnWachtwoord;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label LbNaam;
        private System.Windows.Forms.Label LbWachtwoord;
    }
}
