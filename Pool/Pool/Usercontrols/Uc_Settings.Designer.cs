namespace Pool
{
    partial class Settings
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
            this.BoxTaal = new System.Windows.Forms.GroupBox();
            this.RadiobtnNl = new System.Windows.Forms.RadioButton();
            this.RadiobtnDuits = new System.Windows.Forms.RadioButton();
            this.RadiobtnEngels = new System.Windows.Forms.RadioButton();
            this.BtnTerug = new System.Windows.Forms.Button();
            this.BtnBevestig = new System.Windows.Forms.Button();
            this.BoxTaal.SuspendLayout();
            this.SuspendLayout();
            // 
            // BoxTaal
            // 
            this.BoxTaal.Controls.Add(this.RadiobtnNl);
            this.BoxTaal.Controls.Add(this.RadiobtnDuits);
            this.BoxTaal.Controls.Add(this.RadiobtnEngels);
            this.BoxTaal.Location = new System.Drawing.Point(8, 24);
            this.BoxTaal.Name = "BoxTaal";
            this.BoxTaal.Size = new System.Drawing.Size(200, 100);
            this.BoxTaal.TabIndex = 0;
            this.BoxTaal.TabStop = false;
            this.BoxTaal.Text = "Taal";
            // 
            // RadiobtnNl
            // 
            this.RadiobtnNl.AutoSize = true;
            this.RadiobtnNl.Location = new System.Drawing.Point(24, 72);
            this.RadiobtnNl.Name = "RadiobtnNl";
            this.RadiobtnNl.Size = new System.Drawing.Size(79, 17);
            this.RadiobtnNl.TabIndex = 2;
            this.RadiobtnNl.TabStop = true;
            this.RadiobtnNl.Text = "Nederlands";
            this.RadiobtnNl.UseVisualStyleBackColor = true;
            // 
            // RadiobtnDuits
            // 
            this.RadiobtnDuits.AutoSize = true;
            this.RadiobtnDuits.Location = new System.Drawing.Point(24, 48);
            this.RadiobtnDuits.Name = "RadiobtnDuits";
            this.RadiobtnDuits.Size = new System.Drawing.Size(49, 17);
            this.RadiobtnDuits.TabIndex = 1;
            this.RadiobtnDuits.TabStop = true;
            this.RadiobtnDuits.Text = "Duits";
            this.RadiobtnDuits.UseVisualStyleBackColor = true;
            // 
            // RadiobtnEngels
            // 
            this.RadiobtnEngels.AutoSize = true;
            this.RadiobtnEngels.Location = new System.Drawing.Point(24, 24);
            this.RadiobtnEngels.Name = "RadiobtnEngels";
            this.RadiobtnEngels.Size = new System.Drawing.Size(57, 17);
            this.RadiobtnEngels.TabIndex = 0;
            this.RadiobtnEngels.TabStop = true;
            this.RadiobtnEngels.Text = "Engels";
            this.RadiobtnEngels.UseVisualStyleBackColor = true;
            // 
            // BtnTerug
            // 
            this.BtnTerug.Location = new System.Drawing.Point(144, 136);
            this.BtnTerug.Name = "BtnTerug";
            this.BtnTerug.Size = new System.Drawing.Size(80, 32);
            this.BtnTerug.TabIndex = 1;
            this.BtnTerug.Text = "Terug";
            this.BtnTerug.UseVisualStyleBackColor = true;
            this.BtnTerug.Click += new System.EventHandler(this.BtnTerug_Click);
            // 
            // BtnBevestig
            // 
            this.BtnBevestig.Location = new System.Drawing.Point(16, 136);
            this.BtnBevestig.Name = "BtnBevestig";
            this.BtnBevestig.Size = new System.Drawing.Size(80, 32);
            this.BtnBevestig.TabIndex = 2;
            this.BtnBevestig.Text = "Bevestig";
            this.BtnBevestig.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.BtnBevestig);
            this.Controls.Add(this.BtnTerug);
            this.Controls.Add(this.BoxTaal);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(252, 188);
            this.BoxTaal.ResumeLayout(false);
            this.BoxTaal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox BoxTaal;
        private System.Windows.Forms.RadioButton RadiobtnNl;
        private System.Windows.Forms.RadioButton RadiobtnDuits;
        private System.Windows.Forms.RadioButton RadiobtnEngels;
        private System.Windows.Forms.Button BtnTerug;
        private System.Windows.Forms.Button BtnBevestig;
    }
}
