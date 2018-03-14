namespace Pool
{
    partial class WachtwoordVergeten
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
            this.BtnVerander = new System.Windows.Forms.Button();
            this.TextWw = new System.Windows.Forms.TextBox();
            this.TextNaam = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbWachtwoord
            // 
            this.LbWachtwoord.AutoSize = true;
            this.LbWachtwoord.Location = new System.Drawing.Point(8, 88);
            this.LbWachtwoord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbWachtwoord.Name = "LbWachtwoord";
            this.LbWachtwoord.Size = new System.Drawing.Size(68, 13);
            this.LbWachtwoord.TabIndex = 15;
            this.LbWachtwoord.Text = "Wachtwoord";
            // 
            // LbNaam
            // 
            this.LbNaam.AutoSize = true;
            this.LbNaam.Location = new System.Drawing.Point(39, 46);
            this.LbNaam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbNaam.Name = "LbNaam";
            this.LbNaam.Size = new System.Drawing.Size(35, 13);
            this.LbNaam.TabIndex = 14;
            this.LbNaam.Text = "Naam";
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(180, 136);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(2);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(65, 39);
            this.BtnExit.TabIndex = 13;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnVerander
            // 
            this.BtnVerander.Location = new System.Drawing.Point(2, 136);
            this.BtnVerander.Margin = new System.Windows.Forms.Padding(2);
            this.BtnVerander.Name = "BtnVerander";
            this.BtnVerander.Size = new System.Drawing.Size(65, 39);
            this.BtnVerander.TabIndex = 11;
            this.BtnVerander.Text = "Verander";
            this.BtnVerander.UseVisualStyleBackColor = true;
            // 
            // TextWw
            // 
            this.TextWw.Location = new System.Drawing.Point(77, 86);
            this.TextWw.Margin = new System.Windows.Forms.Padding(2);
            this.TextWw.Name = "TextWw";
            this.TextWw.Size = new System.Drawing.Size(134, 20);
            this.TextWw.TabIndex = 10;
            // 
            // TextNaam
            // 
            this.TextNaam.Location = new System.Drawing.Point(77, 46);
            this.TextNaam.Margin = new System.Windows.Forms.Padding(2);
            this.TextNaam.Name = "TextNaam";
            this.TextNaam.Size = new System.Drawing.Size(134, 20);
            this.TextNaam.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 40);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 0);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // WachtwoordVergeten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LbWachtwoord);
            this.Controls.Add(this.LbNaam);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnVerander);
            this.Controls.Add(this.TextWw);
            this.Controls.Add(this.TextNaam);
            this.Controls.Add(this.button1);
            this.Name = "WachtwoordVergeten";
            this.Size = new System.Drawing.Size(248, 203);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbWachtwoord;
        private System.Windows.Forms.Label LbNaam;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnVerander;
        private System.Windows.Forms.TextBox TextWw;
        private System.Windows.Forms.TextBox TextNaam;
        private System.Windows.Forms.Button button1;
    }
}
