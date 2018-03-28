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
            this.Btn_Terug = new System.Windows.Forms.Button();
            this.Lbx_Regels = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Btn_Terug
            // 
            this.Btn_Terug.Location = new System.Drawing.Point(0, 187);
            this.Btn_Terug.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Terug.Name = "Btn_Terug";
            this.Btn_Terug.Size = new System.Drawing.Size(100, 39);
            this.Btn_Terug.TabIndex = 0;
            this.Btn_Terug.Text = "Terug";
            this.Btn_Terug.UseVisualStyleBackColor = true;
            this.Btn_Terug.Click += new System.EventHandler(this.Btn_Terug_Click);
            // 
            // Lbx_Regels
            // 
            this.Lbx_Regels.FormattingEnabled = true;
            this.Lbx_Regels.ItemHeight = 16;
            this.Lbx_Regels.Location = new System.Drawing.Point(53, 20);
            this.Lbx_Regels.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Lbx_Regels.Name = "Lbx_Regels";
            this.Lbx_Regels.ScrollAlwaysVisible = true;
            this.Lbx_Regels.Size = new System.Drawing.Size(212, 164);
            this.Lbx_Regels.TabIndex = 1;
            this.Lbx_Regels.SelectedIndexChanged += new System.EventHandler(this.Lbx_Regels_SelectedIndexChanged);
            // 
            // Regels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Lbx_Regels);
            this.Controls.Add(this.Btn_Terug);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Regels";
            this.Size = new System.Drawing.Size(331, 250);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Terug;
        private System.Windows.Forms.ListBox Lbx_Regels;
    }
}
