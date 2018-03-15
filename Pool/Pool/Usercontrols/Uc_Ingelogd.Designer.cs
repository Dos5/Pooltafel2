namespace Pool
{
    partial class Ingelogd
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
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnRegels = new System.Windows.Forms.Button();
            this.BtnVerder = new System.Windows.Forms.Button();
            this.GbxSpelkeus = new System.Windows.Forms.GroupBox();
            this.Rbtn9ball = new System.Windows.Forms.RadioButton();
            this.Rbtn8ball = new System.Windows.Forms.RadioButton();
            this.GbxVariant = new System.Windows.Forms.GroupBox();
            this.RbtnToernooi = new System.Windows.Forms.RadioButton();
            this.RbtnDuel = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.GbxSpelkeus.SuspendLayout();
            this.GbxVariant.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(176, 144);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(2);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(65, 39);
            this.BtnExit.TabIndex = 8;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnRegels
            // 
            this.BtnRegels.Location = new System.Drawing.Point(80, 144);
            this.BtnRegels.Margin = new System.Windows.Forms.Padding(2);
            this.BtnRegels.Name = "BtnRegels";
            this.BtnRegels.Size = new System.Drawing.Size(85, 39);
            this.BtnRegels.TabIndex = 7;
            this.BtnRegels.Text = "Spelregels";
            this.BtnRegels.UseVisualStyleBackColor = true;
            this.BtnRegels.Click += new System.EventHandler(this.BtnRegels_Click);
            // 
            // BtnVerder
            // 
            this.BtnVerder.Location = new System.Drawing.Point(8, 144);
            this.BtnVerder.Margin = new System.Windows.Forms.Padding(2);
            this.BtnVerder.Name = "BtnVerder";
            this.BtnVerder.Size = new System.Drawing.Size(65, 39);
            this.BtnVerder.TabIndex = 6;
            this.BtnVerder.Text = "Verder";
            this.BtnVerder.UseVisualStyleBackColor = true;
            this.BtnVerder.Click += new System.EventHandler(this.BtnVerder_Click);
            // 
            // GbxSpelkeus
            // 
            this.GbxSpelkeus.Controls.Add(this.Rbtn9ball);
            this.GbxSpelkeus.Controls.Add(this.Rbtn8ball);
            this.GbxSpelkeus.Location = new System.Drawing.Point(24, 0);
            this.GbxSpelkeus.Name = "GbxSpelkeus";
            this.GbxSpelkeus.Size = new System.Drawing.Size(160, 56);
            this.GbxSpelkeus.TabIndex = 9;
            this.GbxSpelkeus.TabStop = false;
            this.GbxSpelkeus.Text = "Spelvorm";
            // 
            // Rbtn9ball
            // 
            this.Rbtn9ball.AutoSize = true;
            this.Rbtn9ball.Location = new System.Drawing.Point(80, 24);
            this.Rbtn9ball.Name = "Rbtn9ball";
            this.Rbtn9ball.Size = new System.Drawing.Size(51, 17);
            this.Rbtn9ball.TabIndex = 1;
            this.Rbtn9ball.TabStop = true;
            this.Rbtn9ball.Text = "9-Ball";
            this.Rbtn9ball.UseVisualStyleBackColor = true;
            // 
            // Rbtn8ball
            // 
            this.Rbtn8ball.AutoSize = true;
            this.Rbtn8ball.Location = new System.Drawing.Point(8, 24);
            this.Rbtn8ball.Name = "Rbtn8ball";
            this.Rbtn8ball.Size = new System.Drawing.Size(51, 17);
            this.Rbtn8ball.TabIndex = 0;
            this.Rbtn8ball.TabStop = true;
            this.Rbtn8ball.Text = "8-Ball";
            this.Rbtn8ball.UseVisualStyleBackColor = true;
            // 
            // GbxVariant
            // 
            this.GbxVariant.Controls.Add(this.RbtnToernooi);
            this.GbxVariant.Controls.Add(this.RbtnDuel);
            this.GbxVariant.Location = new System.Drawing.Point(24, 80);
            this.GbxVariant.Name = "GbxVariant";
            this.GbxVariant.Size = new System.Drawing.Size(160, 56);
            this.GbxVariant.TabIndex = 10;
            this.GbxVariant.TabStop = false;
            this.GbxVariant.Text = "Duel of toernooi?";
            // 
            // RbtnToernooi
            // 
            this.RbtnToernooi.AutoSize = true;
            this.RbtnToernooi.Location = new System.Drawing.Point(80, 24);
            this.RbtnToernooi.Name = "RbtnToernooi";
            this.RbtnToernooi.Size = new System.Drawing.Size(67, 17);
            this.RbtnToernooi.TabIndex = 1;
            this.RbtnToernooi.TabStop = true;
            this.RbtnToernooi.Text = "Toernooi";
            this.RbtnToernooi.UseVisualStyleBackColor = true;
            // 
            // RbtnDuel
            // 
            this.RbtnDuel.AutoSize = true;
            this.RbtnDuel.Location = new System.Drawing.Point(16, 24);
            this.RbtnDuel.Name = "RbtnDuel";
            this.RbtnDuel.Size = new System.Drawing.Size(47, 17);
            this.RbtnDuel.TabIndex = 0;
            this.RbtnDuel.TabStop = true;
            this.RbtnDuel.Text = "Duel";
            this.RbtnDuel.UseVisualStyleBackColor = true;
            // 
            // Ingelogd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GbxVariant);
            this.Controls.Add(this.GbxSpelkeus);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnRegels);
            this.Controls.Add(this.BtnVerder);
            this.Name = "Ingelogd";
            this.Size = new System.Drawing.Size(248, 203);
            this.GbxSpelkeus.ResumeLayout(false);
            this.GbxSpelkeus.PerformLayout();
            this.GbxVariant.ResumeLayout(false);
            this.GbxVariant.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnRegels;
        private System.Windows.Forms.Button BtnVerder;
        private System.Windows.Forms.GroupBox GbxSpelkeus;
        private System.Windows.Forms.RadioButton Rbtn9ball;
        private System.Windows.Forms.RadioButton Rbtn8ball;
        private System.Windows.Forms.GroupBox GbxVariant;
        private System.Windows.Forms.RadioButton RbtnToernooi;
        private System.Windows.Forms.RadioButton RbtnDuel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
