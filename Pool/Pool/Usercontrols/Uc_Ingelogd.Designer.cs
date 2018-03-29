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
            this.Btn_Terug = new System.Windows.Forms.Button();
            this.Btn_Regels = new System.Windows.Forms.Button();
            this.Btn_Verder = new System.Windows.Forms.Button();
            this.Gbx_Spelkeus = new System.Windows.Forms.GroupBox();
            this.Rbtn_9ball = new System.Windows.Forms.RadioButton();
            this.Rbtn_8ball = new System.Windows.Forms.RadioButton();
            this.Gbx_Variant = new System.Windows.Forms.GroupBox();
            this.Rbtn_Toernooi = new System.Windows.Forms.RadioButton();
            this.Rbtn_Duel = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Gbx_Spelkeus.SuspendLayout();
            this.Gbx_Variant.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Terug
            // 
            this.Btn_Terug.BackColor = System.Drawing.Color.Navy;
            this.Btn_Terug.ForeColor = System.Drawing.Color.White;
            this.Btn_Terug.Location = new System.Drawing.Point(226, 177);
            this.Btn_Terug.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Terug.Name = "Btn_Terug";
            this.Btn_Terug.Size = new System.Drawing.Size(87, 48);
            this.Btn_Terug.TabIndex = 8;
            this.Btn_Terug.Text = "Terug";
            this.Btn_Terug.UseVisualStyleBackColor = false;
            this.Btn_Terug.Click += new System.EventHandler(this.Btn_Terug_Click);
            // 
            // Btn_Regels
            // 
            this.Btn_Regels.BackColor = System.Drawing.Color.Navy;
            this.Btn_Regels.ForeColor = System.Drawing.Color.White;
            this.Btn_Regels.Location = new System.Drawing.Point(107, 177);
            this.Btn_Regels.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Regels.Name = "Btn_Regels";
            this.Btn_Regels.Size = new System.Drawing.Size(113, 48);
            this.Btn_Regels.TabIndex = 7;
            this.Btn_Regels.Text = "Spelregels";
            this.Btn_Regels.UseVisualStyleBackColor = false;
            this.Btn_Regels.Click += new System.EventHandler(this.Btn_Regels_Click);
            // 
            // Btn_Verder
            // 
            this.Btn_Verder.BackColor = System.Drawing.Color.Navy;
            this.Btn_Verder.ForeColor = System.Drawing.Color.White;
            this.Btn_Verder.Location = new System.Drawing.Point(11, 177);
            this.Btn_Verder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Verder.Name = "Btn_Verder";
            this.Btn_Verder.Size = new System.Drawing.Size(87, 48);
            this.Btn_Verder.TabIndex = 6;
            this.Btn_Verder.Text = "Verder";
            this.Btn_Verder.UseVisualStyleBackColor = false;
            this.Btn_Verder.Click += new System.EventHandler(this.Btn_Verder_Click);
            // 
            // Gbx_Spelkeus
            // 
            this.Gbx_Spelkeus.Controls.Add(this.Rbtn_9ball);
            this.Gbx_Spelkeus.Controls.Add(this.Rbtn_8ball);
            this.Gbx_Spelkeus.Location = new System.Drawing.Point(32, 0);
            this.Gbx_Spelkeus.Margin = new System.Windows.Forms.Padding(4);
            this.Gbx_Spelkeus.Name = "Gbx_Spelkeus";
            this.Gbx_Spelkeus.Padding = new System.Windows.Forms.Padding(4);
            this.Gbx_Spelkeus.Size = new System.Drawing.Size(213, 69);
            this.Gbx_Spelkeus.TabIndex = 9;
            this.Gbx_Spelkeus.TabStop = false;
            this.Gbx_Spelkeus.Text = "Spelvorm";
            // 
            // Rbtn_9ball
            // 
            this.Rbtn_9ball.AutoSize = true;
            this.Rbtn_9ball.Location = new System.Drawing.Point(107, 30);
            this.Rbtn_9ball.Margin = new System.Windows.Forms.Padding(4);
            this.Rbtn_9ball.Name = "Rbtn_9ball";
            this.Rbtn_9ball.Size = new System.Drawing.Size(65, 21);
            this.Rbtn_9ball.TabIndex = 1;
            this.Rbtn_9ball.Text = "9-Ball";
            this.Rbtn_9ball.UseVisualStyleBackColor = true;
            // 
            // Rbtn_8ball
            // 
            this.Rbtn_8ball.AutoSize = true;
            this.Rbtn_8ball.Checked = true;
            this.Rbtn_8ball.Location = new System.Drawing.Point(11, 30);
            this.Rbtn_8ball.Margin = new System.Windows.Forms.Padding(4);
            this.Rbtn_8ball.Name = "Rbtn_8ball";
            this.Rbtn_8ball.Size = new System.Drawing.Size(65, 21);
            this.Rbtn_8ball.TabIndex = 0;
            this.Rbtn_8ball.TabStop = true;
            this.Rbtn_8ball.Text = "8-Ball";
            this.Rbtn_8ball.UseVisualStyleBackColor = true;
            // 
            // Gbx_Variant
            // 
            this.Gbx_Variant.Controls.Add(this.Rbtn_Toernooi);
            this.Gbx_Variant.Controls.Add(this.Rbtn_Duel);
            this.Gbx_Variant.Location = new System.Drawing.Point(32, 98);
            this.Gbx_Variant.Margin = new System.Windows.Forms.Padding(4);
            this.Gbx_Variant.Name = "Gbx_Variant";
            this.Gbx_Variant.Padding = new System.Windows.Forms.Padding(4);
            this.Gbx_Variant.Size = new System.Drawing.Size(213, 69);
            this.Gbx_Variant.TabIndex = 10;
            this.Gbx_Variant.TabStop = false;
            this.Gbx_Variant.Text = "Duel of toernooi?";
            // 
            // Rbtn_Toernooi
            // 
            this.Rbtn_Toernooi.AutoSize = true;
            this.Rbtn_Toernooi.Location = new System.Drawing.Point(107, 30);
            this.Rbtn_Toernooi.Margin = new System.Windows.Forms.Padding(4);
            this.Rbtn_Toernooi.Name = "Rbtn_Toernooi";
            this.Rbtn_Toernooi.Size = new System.Drawing.Size(86, 21);
            this.Rbtn_Toernooi.TabIndex = 1;
            this.Rbtn_Toernooi.Text = "Toernooi";
            this.Rbtn_Toernooi.UseVisualStyleBackColor = true;
            // 
            // Rbtn_Duel
            // 
            this.Rbtn_Duel.AutoSize = true;
            this.Rbtn_Duel.Checked = true;
            this.Rbtn_Duel.Location = new System.Drawing.Point(21, 30);
            this.Rbtn_Duel.Margin = new System.Windows.Forms.Padding(4);
            this.Rbtn_Duel.Name = "Rbtn_Duel";
            this.Rbtn_Duel.Size = new System.Drawing.Size(58, 21);
            this.Rbtn_Duel.TabIndex = 0;
            this.Rbtn_Duel.TabStop = true;
            this.Rbtn_Duel.Text = "Duel";
            this.Rbtn_Duel.UseVisualStyleBackColor = true;
            // 
            // Ingelogd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.Controls.Add(this.Gbx_Variant);
            this.Controls.Add(this.Gbx_Spelkeus);
            this.Controls.Add(this.Btn_Terug);
            this.Controls.Add(this.Btn_Regels);
            this.Controls.Add(this.Btn_Verder);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Ingelogd";
            this.Size = new System.Drawing.Size(570, 350);
            this.Gbx_Spelkeus.ResumeLayout(false);
            this.Gbx_Spelkeus.PerformLayout();
            this.Gbx_Variant.ResumeLayout(false);
            this.Gbx_Variant.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Terug;
        private System.Windows.Forms.Button Btn_Regels;
        private System.Windows.Forms.Button Btn_Verder;
        private System.Windows.Forms.GroupBox Gbx_Spelkeus;
        private System.Windows.Forms.RadioButton Rbtn_9ball;
        private System.Windows.Forms.RadioButton Rbtn_8ball;
        private System.Windows.Forms.GroupBox Gbx_Variant;
        private System.Windows.Forms.RadioButton Rbtn_Toernooi;
        private System.Windows.Forms.RadioButton Rbtn_Duel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
