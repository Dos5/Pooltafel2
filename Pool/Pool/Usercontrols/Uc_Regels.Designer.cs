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
            this.Lbx_NaamRegels = new System.Windows.Forms.ListBox();
            this.Lbx_UitlegRegels = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Btn_Terug
            // 
            this.Btn_Terug.BackColor = System.Drawing.Color.Navy;
            this.Btn_Terug.ForeColor = System.Drawing.Color.White;
            this.Btn_Terug.Location = new System.Drawing.Point(4, 299);
            this.Btn_Terug.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Terug.Name = "Btn_Terug";
            this.Btn_Terug.Size = new System.Drawing.Size(110, 47);
            this.Btn_Terug.TabIndex = 0;
            this.Btn_Terug.Text = "Terug";
            this.Btn_Terug.UseVisualStyleBackColor = false;
            this.Btn_Terug.Click += new System.EventHandler(this.Btn_Terug_Click);
            // 
            // Lbx_NaamRegels
            // 
            this.Lbx_NaamRegels.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Lbx_NaamRegels.FormattingEnabled = true;
            this.Lbx_NaamRegels.ItemHeight = 16;
            this.Lbx_NaamRegels.Location = new System.Drawing.Point(4, 19);
            this.Lbx_NaamRegels.Margin = new System.Windows.Forms.Padding(4);
            this.Lbx_NaamRegels.Name = "Lbx_NaamRegels";
            this.Lbx_NaamRegels.ScrollAlwaysVisible = true;
            this.Lbx_NaamRegels.Size = new System.Drawing.Size(277, 272);
            this.Lbx_NaamRegels.TabIndex = 1;
            this.Lbx_NaamRegels.SelectedIndexChanged += new System.EventHandler(this.Lbx_Regels_SelectedIndexChanged);
            // 
            // Lbx_UitlegRegels
            // 
            this.Lbx_UitlegRegels.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Lbx_UitlegRegels.FormattingEnabled = true;
            this.Lbx_UitlegRegels.ItemHeight = 16;
            this.Lbx_UitlegRegels.Location = new System.Drawing.Point(289, 19);
            this.Lbx_UitlegRegels.Margin = new System.Windows.Forms.Padding(4);
            this.Lbx_UitlegRegels.Name = "Lbx_UitlegRegels";
            this.Lbx_UitlegRegels.ScrollAlwaysVisible = true;
            this.Lbx_UitlegRegels.Size = new System.Drawing.Size(277, 272);
            this.Lbx_UitlegRegels.TabIndex = 2;
            // 
            // Regels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.Controls.Add(this.Lbx_UitlegRegels);
            this.Controls.Add(this.Lbx_NaamRegels);
            this.Controls.Add(this.Btn_Terug);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Regels";
            this.Size = new System.Drawing.Size(570, 350);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Terug;
        private System.Windows.Forms.ListBox Lbx_NaamRegels;
        private System.Windows.Forms.ListBox Lbx_UitlegRegels;
    }
}
