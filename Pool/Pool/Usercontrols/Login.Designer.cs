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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnWachtwoord = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.LbNaam = new System.Windows.Forms.Label();
            this.LbWachtwoord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 45);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 0);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 27);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(76, 67);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(134, 20);
            this.textBox2.TabIndex = 2;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(2, 139);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(65, 39);
            this.BtnLogin.TabIndex = 3;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            // 
            // BtnWachtwoord
            // 
            this.BtnWachtwoord.Location = new System.Drawing.Point(82, 139);
            this.BtnWachtwoord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnWachtwoord.Name = "BtnWachtwoord";
            this.BtnWachtwoord.Size = new System.Drawing.Size(85, 39);
            this.BtnWachtwoord.TabIndex = 4;
            this.BtnWachtwoord.Text = "Wachtwoord vergeten";
            this.BtnWachtwoord.UseVisualStyleBackColor = true;
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(180, 139);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(65, 39);
            this.BtnExit.TabIndex = 5;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LbNaam
            // 
            this.LbNaam.AutoSize = true;
            this.LbNaam.Location = new System.Drawing.Point(38, 27);
            this.LbNaam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbNaam.Name = "LbNaam";
            this.LbNaam.Size = new System.Drawing.Size(35, 13);
            this.LbNaam.TabIndex = 6;
            this.LbNaam.Text = "Naam";
            // 
            // LbWachtwoord
            // 
            this.LbWachtwoord.AutoSize = true;
            this.LbWachtwoord.Location = new System.Drawing.Point(7, 69);
            this.LbWachtwoord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbWachtwoord.Name = "LbWachtwoord";
            this.LbWachtwoord.Size = new System.Drawing.Size(68, 13);
            this.LbWachtwoord.TabIndex = 7;
            this.LbWachtwoord.Text = "Wachtwoord";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LbWachtwoord);
            this.Controls.Add(this.LbNaam);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnWachtwoord);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(248, 203);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnWachtwoord;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label LbNaam;
        private System.Windows.Forms.Label LbWachtwoord;
    }
}
