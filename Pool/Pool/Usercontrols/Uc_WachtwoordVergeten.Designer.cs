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
            this.Lb_Wachtwoord = new System.Windows.Forms.Label();
            this.Lb_Naam = new System.Windows.Forms.Label();
            this.Btn_Terug = new System.Windows.Forms.Button();
            this.Btn_Verander = new System.Windows.Forms.Button();
            this.Tb_Wachtwoord = new System.Windows.Forms.TextBox();
            this.Tb_Naam = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lb_Wachtwoord
            // 
            this.Lb_Wachtwoord.AutoSize = true;
            this.Lb_Wachtwoord.Location = new System.Drawing.Point(9, 98);
            this.Lb_Wachtwoord.Name = "Lb_Wachtwoord";
            this.Lb_Wachtwoord.Size = new System.Drawing.Size(86, 17);
            this.Lb_Wachtwoord.TabIndex = 15;
            this.Lb_Wachtwoord.Text = "Wachtwoord";
            // 
            // Lb_Naam
            // 
            this.Lb_Naam.AutoSize = true;
            this.Lb_Naam.Location = new System.Drawing.Point(51, 47);
            this.Lb_Naam.Name = "Lb_Naam";
            this.Lb_Naam.Size = new System.Drawing.Size(45, 17);
            this.Lb_Naam.TabIndex = 14;
            this.Lb_Naam.Text = "Naam";
            // 
            // Btn_Terug
            // 
            this.Btn_Terug.Location = new System.Drawing.Point(240, 167);
            this.Btn_Terug.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Terug.Name = "Btn_Terug";
            this.Btn_Terug.Size = new System.Drawing.Size(87, 48);
            this.Btn_Terug.TabIndex = 13;
            this.Btn_Terug.Text = "Terug";
            this.Btn_Terug.UseVisualStyleBackColor = true;
            this.Btn_Terug.Click += new System.EventHandler(this.Btn_Terug_Click);
            // 
            // Btn_Verander
            // 
            this.Btn_Verander.Location = new System.Drawing.Point(3, 167);
            this.Btn_Verander.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Verander.Name = "Btn_Verander";
            this.Btn_Verander.Size = new System.Drawing.Size(87, 48);
            this.Btn_Verander.TabIndex = 11;
            this.Btn_Verander.Text = "Verander";
            this.Btn_Verander.UseVisualStyleBackColor = true;
            this.Btn_Verander.Click += new System.EventHandler(this.Btn_Verander_Click);
            // 
            // Tb_Wachtwoord
            // 
            this.Tb_Wachtwoord.Location = new System.Drawing.Point(101, 96);
            this.Tb_Wachtwoord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tb_Wachtwoord.Name = "Tb_Wachtwoord";
            this.Tb_Wachtwoord.Size = new System.Drawing.Size(177, 22);
            this.Tb_Wachtwoord.TabIndex = 10;
            // 
            // Tb_Naam
            // 
            this.Tb_Naam.Location = new System.Drawing.Point(101, 47);
            this.Tb_Naam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tb_Naam.Name = "Tb_Naam";
            this.Tb_Naam.Size = new System.Drawing.Size(177, 22);
            this.Tb_Naam.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 49);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 0);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // WachtwoordVergeten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Lb_Wachtwoord);
            this.Controls.Add(this.Lb_Naam);
            this.Controls.Add(this.Btn_Terug);
            this.Controls.Add(this.Btn_Verander);
            this.Controls.Add(this.Tb_Wachtwoord);
            this.Controls.Add(this.Tb_Naam);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "WachtwoordVergeten";
            this.Size = new System.Drawing.Size(331, 250);
            this.Load += new System.EventHandler(this.WachtwoordVergeten_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lb_Wachtwoord;
        private System.Windows.Forms.Label Lb_Naam;
        private System.Windows.Forms.Button Btn_Terug;
        private System.Windows.Forms.Button Btn_Verander;
        private System.Windows.Forms.TextBox Tb_Wachtwoord;
        private System.Windows.Forms.TextBox Tb_Naam;
        private System.Windows.Forms.Button button1;
    }
}
