namespace Pool
{
    partial class Regels
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
            this.BtnTerug = new System.Windows.Forms.Button();
            this.LbxRegels = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BtnTerug
            // 
            this.BtnTerug.Location = new System.Drawing.Point(0, 152);
            this.BtnTerug.Name = "BtnTerug";
            this.BtnTerug.Size = new System.Drawing.Size(75, 32);
            this.BtnTerug.TabIndex = 0;
            this.BtnTerug.Text = "Terug";
            this.BtnTerug.UseVisualStyleBackColor = true;
            this.BtnTerug.Click += new System.EventHandler(this.BtnTerug_Click);
            // 
            // LbxRegels
            // 
            this.LbxRegels.FormattingEnabled = true;
            this.LbxRegels.Location = new System.Drawing.Point(40, 16);
            this.LbxRegels.Name = "LbxRegels";
            this.LbxRegels.ScrollAlwaysVisible = true;
            this.LbxRegels.Size = new System.Drawing.Size(160, 134);
            this.LbxRegels.TabIndex = 1;
            // 
            // Regels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LbxRegels);
            this.Controls.Add(this.BtnTerug);
            this.Name = "Regels";
            this.Size = new System.Drawing.Size(248, 203);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnTerug;
        private System.Windows.Forms.ListBox LbxRegels;
    }
}
