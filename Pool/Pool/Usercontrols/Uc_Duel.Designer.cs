namespace Pool.Usercontrols
{
    partial class Uc_Duel
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
            this.Tb_SpelerInput = new System.Windows.Forms.TextBox();
            this.Lb_SpelerLinks = new System.Windows.Forms.Label();
            this.Lb_SpelerRechts = new System.Windows.Forms.Label();
            this.Lb_Vs = new System.Windows.Forms.Label();
            this.Btn_SpelerToevoegen = new System.Windows.Forms.Button();
            this.Btn_Terug = new System.Windows.Forms.Button();
            this.Btn_Verder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tb_SpelerInput
            // 
            this.Tb_SpelerInput.Location = new System.Drawing.Point(16, 32);
            this.Tb_SpelerInput.Name = "Tb_SpelerInput";
            this.Tb_SpelerInput.Size = new System.Drawing.Size(100, 20);
            this.Tb_SpelerInput.TabIndex = 0;
            // 
            // Lb_SpelerLinks
            // 
            this.Lb_SpelerLinks.AutoSize = true;
            this.Lb_SpelerLinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.Lb_SpelerLinks.Location = new System.Drawing.Point(216, 40);
            this.Lb_SpelerLinks.Name = "Lb_SpelerLinks";
            this.Lb_SpelerLinks.Size = new System.Drawing.Size(55, 16);
            this.Lb_SpelerLinks.TabIndex = 1;
            this.Lb_SpelerLinks.Text = "Speler1";
            // 
            // Lb_SpelerRechts
            // 
            this.Lb_SpelerRechts.AutoSize = true;
            this.Lb_SpelerRechts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.Lb_SpelerRechts.Location = new System.Drawing.Point(336, 40);
            this.Lb_SpelerRechts.Name = "Lb_SpelerRechts";
            this.Lb_SpelerRechts.Size = new System.Drawing.Size(55, 16);
            this.Lb_SpelerRechts.TabIndex = 2;
            this.Lb_SpelerRechts.Text = "Speler2";
            // 
            // Lb_Vs
            // 
            this.Lb_Vs.AutoSize = true;
            this.Lb_Vs.Location = new System.Drawing.Point(296, 40);
            this.Lb_Vs.Name = "Lb_Vs";
            this.Lb_Vs.Size = new System.Drawing.Size(19, 13);
            this.Lb_Vs.TabIndex = 3;
            this.Lb_Vs.Text = "Vs";
            // 
            // Btn_SpelerToevoegen
            // 
            this.Btn_SpelerToevoegen.BackColor = System.Drawing.Color.Navy;
            this.Btn_SpelerToevoegen.ForeColor = System.Drawing.Color.White;
            this.Btn_SpelerToevoegen.Location = new System.Drawing.Point(128, 24);
            this.Btn_SpelerToevoegen.Name = "Btn_SpelerToevoegen";
            this.Btn_SpelerToevoegen.Size = new System.Drawing.Size(65, 39);
            this.Btn_SpelerToevoegen.TabIndex = 4;
            this.Btn_SpelerToevoegen.Text = "Voeg toe";
            this.Btn_SpelerToevoegen.UseVisualStyleBackColor = false;
            this.Btn_SpelerToevoegen.Click += new System.EventHandler(this.Btn_SpelerToevoegen_Click);
            // 
            // Btn_Terug
            // 
            this.Btn_Terug.BackColor = System.Drawing.Color.Navy;
            this.Btn_Terug.ForeColor = System.Drawing.Color.White;
            this.Btn_Terug.Location = new System.Drawing.Point(16, 72);
            this.Btn_Terug.Name = "Btn_Terug";
            this.Btn_Terug.Size = new System.Drawing.Size(65, 39);
            this.Btn_Terug.TabIndex = 5;
            this.Btn_Terug.Text = "Terug";
            this.Btn_Terug.UseVisualStyleBackColor = false;
            this.Btn_Terug.Click += new System.EventHandler(this.Btn_Terug_Click);
            // 
            // Btn_Verder
            // 
            this.Btn_Verder.BackColor = System.Drawing.Color.Navy;
            this.Btn_Verder.ForeColor = System.Drawing.Color.White;
            this.Btn_Verder.Location = new System.Drawing.Point(320, 72);
            this.Btn_Verder.Name = "Btn_Verder";
            this.Btn_Verder.Size = new System.Drawing.Size(65, 39);
            this.Btn_Verder.TabIndex = 6;
            this.Btn_Verder.Text = "Verder";
            this.Btn_Verder.UseVisualStyleBackColor = false;
            this.Btn_Verder.Click += new System.EventHandler(this.Btn_Verder_Click);
            // 
            // Uc_Duel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.Controls.Add(this.Btn_Verder);
            this.Controls.Add(this.Btn_Terug);
            this.Controls.Add(this.Btn_SpelerToevoegen);
            this.Controls.Add(this.Lb_Vs);
            this.Controls.Add(this.Lb_SpelerRechts);
            this.Controls.Add(this.Lb_SpelerLinks);
            this.Controls.Add(this.Tb_SpelerInput);
            this.Name = "Uc_Duel";
            this.Size = new System.Drawing.Size(414, 261);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tb_SpelerInput;
        private System.Windows.Forms.Label Lb_SpelerLinks;
        private System.Windows.Forms.Label Lb_SpelerRechts;
        private System.Windows.Forms.Label Lb_Vs;
        private System.Windows.Forms.Button Btn_SpelerToevoegen;
        private System.Windows.Forms.Button Btn_Terug;
        private System.Windows.Forms.Button Btn_Verder;
    }
}
