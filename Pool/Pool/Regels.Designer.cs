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
            this.Lb_regel_uitleg = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lb_naamregel
            // 
            this.Lb_naamregel.FormattingEnabled = true;
            this.Lb_naamregel.ItemHeight = 16;
            this.Lb_naamregel.Location = new System.Drawing.Point(17, 53);
            this.Lb_naamregel.Name = "Lb_naamregel";
            this.Lb_naamregel.Size = new System.Drawing.Size(173, 212);
            this.Lb_naamregel.TabIndex = 0;
            this.Lb_naamregel.SelectedIndexChanged += new System.EventHandler(this.Lb_naamregel_SelectedIndexChanged);
            // 
            // Lb_regel_uitleg
            // 
            this.Lb_regel_uitleg.FormattingEnabled = true;
            this.Lb_regel_uitleg.ItemHeight = 16;
            this.Lb_regel_uitleg.Location = new System.Drawing.Point(212, 53);
            this.Lb_regel_uitleg.Name = "Lb_regel_uitleg";
            this.Lb_regel_uitleg.Size = new System.Drawing.Size(173, 212);
            this.Lb_regel_uitleg.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Regels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Lb_regel_uitleg);
            this.Controls.Add(this.Lb_naamregel);
            this.Name = "Regels";
            this.Size = new System.Drawing.Size(403, 341);
            this.Load += new System.EventHandler(this.Regels_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Lb_naamregel;
        private System.Windows.Forms.ListBox Lb_regel_uitleg;
        private System.Windows.Forms.Button button1;
    }
}
