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
            this.GrboxSpelkeus = new System.Windows.Forms.GroupBox();
            this.Radiobtn9ball = new System.Windows.Forms.RadioButton();
            this.Radiobtn8ball = new System.Windows.Forms.RadioButton();
            this.GrboxVariant = new System.Windows.Forms.GroupBox();
            this.RadiobtnToernooi = new System.Windows.Forms.RadioButton();
            this.RadiobtnDuel = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.GrboxSpelkeus.SuspendLayout();
            this.GrboxVariant.SuspendLayout();
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
            // GrboxSpelkeus
            // 
            this.GrboxSpelkeus.Controls.Add(this.Radiobtn9ball);
            this.GrboxSpelkeus.Controls.Add(this.Radiobtn8ball);
            this.GrboxSpelkeus.Location = new System.Drawing.Point(24, 0);
            this.GrboxSpelkeus.Name = "GrboxSpelkeus";
            this.GrboxSpelkeus.Size = new System.Drawing.Size(160, 56);
            this.GrboxSpelkeus.TabIndex = 9;
            this.GrboxSpelkeus.TabStop = false;
            this.GrboxSpelkeus.Text = "Spelvorm";
            // 
            // Radiobtn9ball
            // 
            this.Radiobtn9ball.AutoSize = true;
            this.Radiobtn9ball.Location = new System.Drawing.Point(80, 24);
            this.Radiobtn9ball.Name = "Radiobtn9ball";
            this.Radiobtn9ball.Size = new System.Drawing.Size(51, 17);
            this.Radiobtn9ball.TabIndex = 1;
            this.Radiobtn9ball.TabStop = true;
            this.Radiobtn9ball.Text = "9-Ball";
            this.Radiobtn9ball.UseVisualStyleBackColor = true;
            // 
            // Radiobtn8ball
            // 
            this.Radiobtn8ball.AutoSize = true;
            this.Radiobtn8ball.Location = new System.Drawing.Point(8, 24);
            this.Radiobtn8ball.Name = "Radiobtn8ball";
            this.Radiobtn8ball.Size = new System.Drawing.Size(51, 17);
            this.Radiobtn8ball.TabIndex = 0;
            this.Radiobtn8ball.TabStop = true;
            this.Radiobtn8ball.Text = "8-Ball";
            this.Radiobtn8ball.UseVisualStyleBackColor = true;
            // 
            // GrboxVariant
            // 
            this.GrboxVariant.Controls.Add(this.RadiobtnToernooi);
            this.GrboxVariant.Controls.Add(this.RadiobtnDuel);
            this.GrboxVariant.Location = new System.Drawing.Point(24, 80);
            this.GrboxVariant.Name = "GrboxVariant";
            this.GrboxVariant.Size = new System.Drawing.Size(160, 56);
            this.GrboxVariant.TabIndex = 10;
            this.GrboxVariant.TabStop = false;
            this.GrboxVariant.Text = "Duel of toernooi?";
            // 
            // RadiobtnToernooi
            // 
            this.RadiobtnToernooi.AutoSize = true;
            this.RadiobtnToernooi.Location = new System.Drawing.Point(80, 24);
            this.RadiobtnToernooi.Name = "RadiobtnToernooi";
            this.RadiobtnToernooi.Size = new System.Drawing.Size(67, 17);
            this.RadiobtnToernooi.TabIndex = 1;
            this.RadiobtnToernooi.TabStop = true;
            this.RadiobtnToernooi.Text = "Toernooi";
            this.RadiobtnToernooi.UseVisualStyleBackColor = true;
            // 
            // RadiobtnDuel
            // 
            this.RadiobtnDuel.AutoSize = true;
            this.RadiobtnDuel.Location = new System.Drawing.Point(16, 24);
            this.RadiobtnDuel.Name = "RadiobtnDuel";
            this.RadiobtnDuel.Size = new System.Drawing.Size(47, 17);
            this.RadiobtnDuel.TabIndex = 0;
            this.RadiobtnDuel.TabStop = true;
            this.RadiobtnDuel.Text = "Duel";
            this.RadiobtnDuel.UseVisualStyleBackColor = true;
            // 
            // Ingelogd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GrboxVariant);
            this.Controls.Add(this.GrboxSpelkeus);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnRegels);
            this.Controls.Add(this.BtnVerder);
            this.Name = "Ingelogd";
            this.Size = new System.Drawing.Size(248, 203);
            this.GrboxSpelkeus.ResumeLayout(false);
            this.GrboxSpelkeus.PerformLayout();
            this.GrboxVariant.ResumeLayout(false);
            this.GrboxVariant.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnRegels;
        private System.Windows.Forms.Button BtnVerder;
        private System.Windows.Forms.GroupBox GrboxSpelkeus;
        private System.Windows.Forms.RadioButton Radiobtn9ball;
        private System.Windows.Forms.RadioButton Radiobtn8ball;
        private System.Windows.Forms.GroupBox GrboxVariant;
        private System.Windows.Forms.RadioButton RadiobtnToernooi;
        private System.Windows.Forms.RadioButton RadiobtnDuel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
