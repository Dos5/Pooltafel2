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
            this.ListboxRegels = new System.Windows.Forms.ListBox();
            this.Lbx_beschrijving = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BtnTerug
            // 
            this.BtnTerug.Location = new System.Drawing.Point(0, 187);
            this.BtnTerug.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnTerug.Name = "BtnTerug";
            this.BtnTerug.Size = new System.Drawing.Size(100, 39);
            this.BtnTerug.TabIndex = 0;
            this.BtnTerug.Text = "Terug";
            this.BtnTerug.UseVisualStyleBackColor = true;
            this.BtnTerug.Click += new System.EventHandler(this.BtnTerug_Click);
            // 
            // ListboxRegels
            // 
            this.ListboxRegels.FormattingEnabled = true;
            this.ListboxRegels.ItemHeight = 16;
            this.ListboxRegels.Location = new System.Drawing.Point(53, 20);
            this.ListboxRegels.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ListboxRegels.Name = "ListboxRegels";
            this.ListboxRegels.ScrollAlwaysVisible = true;
            this.ListboxRegels.Size = new System.Drawing.Size(212, 164);
            this.ListboxRegels.TabIndex = 1;
            // 
            // Lbx_beschrijving
            // 
            this.Lbx_beschrijving.FormattingEnabled = true;
            this.Lbx_beschrijving.ItemHeight = 16;
            this.Lbx_beschrijving.Location = new System.Drawing.Point(273, 20);
            this.Lbx_beschrijving.Margin = new System.Windows.Forms.Padding(4);
            this.Lbx_beschrijving.Name = "Lbx_beschrijving";
            this.Lbx_beschrijving.ScrollAlwaysVisible = true;
            this.Lbx_beschrijving.Size = new System.Drawing.Size(212, 164);
            this.Lbx_beschrijving.TabIndex = 2;
            // 
            // Regels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Lbx_beschrijving);
            this.Controls.Add(this.ListboxRegels);
            this.Controls.Add(this.BtnTerug);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Regels";
            this.Size = new System.Drawing.Size(499, 250);
            this.Load += new System.EventHandler(this.Regels_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnTerug;
        private System.Windows.Forms.ListBox ListboxRegels;
        private System.Windows.Forms.ListBox Lbx_beschrijving;
    }
}
