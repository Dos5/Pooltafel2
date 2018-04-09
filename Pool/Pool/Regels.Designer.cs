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
            this.Lb_naamregel = new System.Windows.Forms.ListBox();
            this.Btn_Terug = new System.Windows.Forms.Button();
            this.Rtb_regel_uitleg = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Lb_naamregel
            // 
            this.Lb_naamregel.FormattingEnabled = true;
            this.Lb_naamregel.Location = new System.Drawing.Point(13, 43);
            this.Lb_naamregel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Lb_naamregel.Name = "Lb_naamregel";
            this.Lb_naamregel.Size = new System.Drawing.Size(131, 173);
            this.Lb_naamregel.TabIndex = 0;
            this.Lb_naamregel.SelectedIndexChanged += new System.EventHandler(this.Lb_naamregel_SelectedIndexChanged);
            // 
            // Btn_Terug
            // 
            this.Btn_Terug.Location = new System.Drawing.Point(16, 232);
            this.Btn_Terug.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Terug.Name = "Btn_Terug";
            this.Btn_Terug.Size = new System.Drawing.Size(56, 24);
            this.Btn_Terug.TabIndex = 2;
            this.Btn_Terug.Text = "Terug";
            this.Btn_Terug.UseVisualStyleBackColor = true;
            this.Btn_Terug.Click += new System.EventHandler(this.Btn_Terug_Click);
            // 
            // Rtb_regel_uitleg
            // 
            this.Rtb_regel_uitleg.Location = new System.Drawing.Point(160, 40);
            this.Rtb_regel_uitleg.Name = "Rtb_regel_uitleg";
            this.Rtb_regel_uitleg.ReadOnly = true;
            this.Rtb_regel_uitleg.Size = new System.Drawing.Size(131, 173);
            this.Rtb_regel_uitleg.TabIndex = 3;
            this.Rtb_regel_uitleg.Text = "";
            // 
            // Regels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Rtb_regel_uitleg);
            this.Controls.Add(this.Btn_Terug);
            this.Controls.Add(this.Lb_naamregel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Regels";
            this.Size = new System.Drawing.Size(302, 277);
            this.Load += new System.EventHandler(this.Regels_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Lb_naamregel;
        private System.Windows.Forms.Button Btn_Terug;
        private System.Windows.Forms.RichTextBox Rtb_regel_uitleg;
    }
}
