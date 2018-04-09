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
            this.Tb_Naam = new System.Windows.Forms.TextBox();
            this.Tb_Wachtwoord = new System.Windows.Forms.TextBox();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.Btn_Wachtwoord = new System.Windows.Forms.Button();
            this.Btn_Terug = new System.Windows.Forms.Button();
            this.Lb_Naam = new System.Windows.Forms.Label();
            this.Lb_Wachtwoord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 87);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 0);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Tb_Naam
            // 
            this.Tb_Naam.Location = new System.Drawing.Point(166, 80);
            this.Tb_Naam.Margin = new System.Windows.Forms.Padding(2);
            this.Tb_Naam.Name = "Tb_Naam";
            this.Tb_Naam.Size = new System.Drawing.Size(134, 20);
            this.Tb_Naam.TabIndex = 1;
            // 
            // Tb_Wachtwoord
            // 
            this.Tb_Wachtwoord.Location = new System.Drawing.Point(166, 120);
            this.Tb_Wachtwoord.Margin = new System.Windows.Forms.Padding(2);
            this.Tb_Wachtwoord.Name = "Tb_Wachtwoord";
            this.Tb_Wachtwoord.Size = new System.Drawing.Size(134, 20);
            this.Tb_Wachtwoord.TabIndex = 2;
            // 
            // Btn_Login
            // 
            this.Btn_Login.BackColor = System.Drawing.Color.Navy;
            this.Btn_Login.ForeColor = System.Drawing.Color.White;
            this.Btn_Login.Location = new System.Drawing.Point(22, 209);
            this.Btn_Login.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(65, 39);
            this.Btn_Login.TabIndex = 3;
            this.Btn_Login.Text = "Login";
            this.Btn_Login.UseVisualStyleBackColor = false;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // Btn_Wachtwoord
            // 
            this.Btn_Wachtwoord.BackColor = System.Drawing.Color.Navy;
            this.Btn_Wachtwoord.ForeColor = System.Drawing.Color.White;
            this.Btn_Wachtwoord.Location = new System.Drawing.Point(168, 209);
            this.Btn_Wachtwoord.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Wachtwoord.Name = "Btn_Wachtwoord";
            this.Btn_Wachtwoord.Size = new System.Drawing.Size(85, 39);
            this.Btn_Wachtwoord.TabIndex = 4;
            this.Btn_Wachtwoord.Text = "Wachtwoord vergeten";
            this.Btn_Wachtwoord.UseVisualStyleBackColor = false;
            this.Btn_Wachtwoord.Click += new System.EventHandler(this.Btn_Wachtwoord_Click);
            // 
            // Btn_Terug
            // 
            this.Btn_Terug.BackColor = System.Drawing.Color.Navy;
            this.Btn_Terug.ForeColor = System.Drawing.Color.White;
            this.Btn_Terug.Location = new System.Drawing.Point(326, 209);
            this.Btn_Terug.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Terug.Name = "Btn_Terug";
            this.Btn_Terug.Size = new System.Drawing.Size(65, 39);
            this.Btn_Terug.TabIndex = 5;
            this.Btn_Terug.Text = "Terug";
            this.Btn_Terug.UseVisualStyleBackColor = false;
            this.Btn_Terug.Click += new System.EventHandler(this.Btn_Terug_Click);
            // 
            // Lb_Naam
            // 
            this.Lb_Naam.AutoSize = true;
            this.Lb_Naam.ForeColor = System.Drawing.Color.White;
            this.Lb_Naam.Location = new System.Drawing.Point(128, 80);
            this.Lb_Naam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lb_Naam.Name = "Lb_Naam";
            this.Lb_Naam.Size = new System.Drawing.Size(35, 13);
            this.Lb_Naam.TabIndex = 6;
            this.Lb_Naam.Text = "Naam";
            // 
            // Lb_Wachtwoord
            // 
            this.Lb_Wachtwoord.AutoSize = true;
            this.Lb_Wachtwoord.ForeColor = System.Drawing.Color.White;
            this.Lb_Wachtwoord.Location = new System.Drawing.Point(97, 122);
            this.Lb_Wachtwoord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lb_Wachtwoord.Name = "Lb_Wachtwoord";
            this.Lb_Wachtwoord.Size = new System.Drawing.Size(68, 13);
            this.Lb_Wachtwoord.TabIndex = 7;
            this.Lb_Wachtwoord.Text = "Wachtwoord";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.Controls.Add(this.Lb_Wachtwoord);
            this.Controls.Add(this.Lb_Naam);
            this.Controls.Add(this.Btn_Terug);
            this.Controls.Add(this.Btn_Wachtwoord);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.Tb_Wachtwoord);
            this.Controls.Add(this.Tb_Naam);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(414, 261);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Tb_Naam;
        private System.Windows.Forms.TextBox Tb_Wachtwoord;
        private System.Windows.Forms.Button Btn_Login;
        private System.Windows.Forms.Button Btn_Wachtwoord;
        private System.Windows.Forms.Button Btn_Terug;
        private System.Windows.Forms.Label Lb_Naam;
        private System.Windows.Forms.Label Lb_Wachtwoord;
    }
}
