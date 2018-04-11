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
            this.Lb_Naamregel = new System.Windows.Forms.ListBox();
            this.Btn_Terug = new System.Windows.Forms.Button();
            this.Rtb_Regel_Uitleg = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Lb_Naamregel
            // 
            this.Lb_Naamregel.FormattingEnabled = true;
            this.Lb_Naamregel.ItemHeight = 16;
            this.Lb_Naamregel.Location = new System.Drawing.Point(50, 27);
            this.Lb_Naamregel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Lb_Naamregel.Name = "Lb_Naamregel";
            this.Lb_Naamregel.Size = new System.Drawing.Size(200, 212);
            this.Lb_Naamregel.TabIndex = 0;
            this.Lb_Naamregel.SelectedIndexChanged += new System.EventHandler(this.Lb_naamregel_SelectedIndexChanged);
            // 
            // Btn_Terug
            // 
            this.Btn_Terug.BackColor = System.Drawing.Color.Navy;
            this.Btn_Terug.ForeColor = System.Drawing.Color.White;
            this.Btn_Terug.Location = new System.Drawing.Point(415, 262);
            this.Btn_Terug.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Terug.Name = "Btn_Terug";
            this.Btn_Terug.Size = new System.Drawing.Size(87, 48);
            this.Btn_Terug.TabIndex = 2;
            this.Btn_Terug.Text = "Terug";
            this.Btn_Terug.UseVisualStyleBackColor = false;
            this.Btn_Terug.Click += new System.EventHandler(this.Btn_Terug_Click);
            // 
            // Rtb_Regel_Uitleg
            // 
            this.Rtb_Regel_Uitleg.Location = new System.Drawing.Point(302, 27);
            this.Rtb_Regel_Uitleg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Rtb_Regel_Uitleg.Name = "Rtb_Regel_Uitleg";
            this.Rtb_Regel_Uitleg.ReadOnly = true;
            this.Rtb_Regel_Uitleg.Size = new System.Drawing.Size(200, 212);
            this.Rtb_Regel_Uitleg.TabIndex = 3;
            this.Rtb_Regel_Uitleg.Text = "";
            // 
            // Regels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.Controls.Add(this.Rtb_Regel_Uitleg);
            this.Controls.Add(this.Btn_Terug);
            this.Controls.Add(this.Lb_Naamregel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Regels";
            this.Size = new System.Drawing.Size(552, 321);
            this.Load += new System.EventHandler(this.Regels_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Lb_Naamregel;
        private System.Windows.Forms.Button Btn_Terug;
        private System.Windows.Forms.RichTextBox Rtb_Regel_Uitleg;
    }
}
