namespace Pool
{
    partial class Register
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
            this.LbWachtwoord = new System.Windows.Forms.Label();
            this.LbNaam = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.Tb_wachtwoord = new System.Windows.Forms.TextBox();
            this.Tb_naam = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Tb_email = new System.Windows.Forms.TextBox();
            this.Tb_mobiel = new System.Windows.Forms.TextBox();
            this.Lb_email = new System.Windows.Forms.Label();
            this.Lb_mobiel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LbWachtwoord
            // 
            this.LbWachtwoord.AutoSize = true;
            this.LbWachtwoord.Location = new System.Drawing.Point(11, 78);
            this.LbWachtwoord.Name = "LbWachtwoord";
            this.LbWachtwoord.Size = new System.Drawing.Size(86, 17);
            this.LbWachtwoord.TabIndex = 15;
            this.LbWachtwoord.Text = "Wachtwoord";
            // 
            // LbNaam
            // 
            this.LbNaam.AutoSize = true;
            this.LbNaam.Location = new System.Drawing.Point(52, 47);
            this.LbNaam.Name = "LbNaam";
            this.LbNaam.Size = new System.Drawing.Size(45, 17);
            this.LbNaam.TabIndex = 14;
            this.LbNaam.Text = "Naam";
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(168, 167);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(112, 48);
            this.BtnExit.TabIndex = 13;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnRegister
            // 
            this.BtnRegister.Location = new System.Drawing.Point(55, 167);
            this.BtnRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(107, 48);
            this.BtnRegister.TabIndex = 11;
            this.BtnRegister.Text = "Register";
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // Tb_wachtwoord
            // 
            this.Tb_wachtwoord.Location = new System.Drawing.Point(103, 73);
            this.Tb_wachtwoord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tb_wachtwoord.Name = "Tb_wachtwoord";
            this.Tb_wachtwoord.Size = new System.Drawing.Size(177, 22);
            this.Tb_wachtwoord.TabIndex = 10;
            this.Tb_wachtwoord.TextChanged += new System.EventHandler(this.TextWw_TextChanged);
            // 
            // Tb_naam
            // 
            this.Tb_naam.Location = new System.Drawing.Point(103, 47);
            this.Tb_naam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tb_naam.Name = "Tb_naam";
            this.Tb_naam.Size = new System.Drawing.Size(177, 22);
            this.Tb_naam.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 69);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 0);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Tb_email
            // 
            this.Tb_email.Location = new System.Drawing.Point(103, 100);
            this.Tb_email.Name = "Tb_email";
            this.Tb_email.Size = new System.Drawing.Size(177, 22);
            this.Tb_email.TabIndex = 18;
            // 
            // Tb_mobiel
            // 
            this.Tb_mobiel.Location = new System.Drawing.Point(103, 128);
            this.Tb_mobiel.Name = "Tb_mobiel";
            this.Tb_mobiel.Size = new System.Drawing.Size(177, 22);
            this.Tb_mobiel.TabIndex = 19;
            // 
            // Lb_email
            // 
            this.Lb_email.AutoSize = true;
            this.Lb_email.Location = new System.Drawing.Point(44, 103);
            this.Lb_email.Name = "Lb_email";
            this.Lb_email.Size = new System.Drawing.Size(46, 17);
            this.Lb_email.TabIndex = 20;
            this.Lb_email.Text = "E mail";
            // 
            // Lb_mobiel
            // 
            this.Lb_mobiel.AutoSize = true;
            this.Lb_mobiel.Location = new System.Drawing.Point(41, 131);
            this.Lb_mobiel.Name = "Lb_mobiel";
            this.Lb_mobiel.Size = new System.Drawing.Size(49, 17);
            this.Lb_mobiel.TabIndex = 21;
            this.Lb_mobiel.Text = "mobiel";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Lb_mobiel);
            this.Controls.Add(this.Lb_email);
            this.Controls.Add(this.Tb_mobiel);
            this.Controls.Add(this.Tb_email);
            this.Controls.Add(this.LbWachtwoord);
            this.Controls.Add(this.LbNaam);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.Tb_wachtwoord);
            this.Controls.Add(this.Tb_naam);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Register";
            this.Size = new System.Drawing.Size(306, 238);
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbWachtwoord;
        private System.Windows.Forms.Label LbNaam;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.TextBox Tb_wachtwoord;
        private System.Windows.Forms.TextBox Tb_naam;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Tb_email;
        private System.Windows.Forms.TextBox Tb_mobiel;
        private System.Windows.Forms.Label Lb_email;
        private System.Windows.Forms.Label Lb_mobiel;
    }
}
