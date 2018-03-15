namespace Pool
{
    partial class Toernooi
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
            this.GbxSpelers = new System.Windows.Forms.GroupBox();
            this.RbtnAchtspelers = new System.Windows.Forms.RadioButton();
            this.RbtnTienspelers = new System.Windows.Forms.RadioButton();
            this.RbtnZesspelers = new System.Windows.Forms.RadioButton();
            this.RbtnVierspelers = new System.Windows.Forms.RadioButton();
            this.BtnTerug = new System.Windows.Forms.Button();
            this.BtnVerder = new System.Windows.Forms.Button();
            this.GbxSpelers.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbxSpelers
            // 
            this.GbxSpelers.Controls.Add(this.RbtnAchtspelers);
            this.GbxSpelers.Controls.Add(this.RbtnTienspelers);
            this.GbxSpelers.Controls.Add(this.RbtnZesspelers);
            this.GbxSpelers.Controls.Add(this.RbtnVierspelers);
            this.GbxSpelers.Location = new System.Drawing.Point(24, 16);
            this.GbxSpelers.Name = "GbxSpelers";
            this.GbxSpelers.Size = new System.Drawing.Size(200, 100);
            this.GbxSpelers.TabIndex = 0;
            this.GbxSpelers.TabStop = false;
            this.GbxSpelers.Text = "Aantal spelers";
            // 
            // RbtnAchtspelers
            // 
            this.RbtnAchtspelers.AutoSize = true;
            this.RbtnAchtspelers.Location = new System.Drawing.Point(8, 64);
            this.RbtnAchtspelers.Name = "RbtnAchtspelers";
            this.RbtnAchtspelers.Size = new System.Drawing.Size(67, 17);
            this.RbtnAchtspelers.TabIndex = 3;
            this.RbtnAchtspelers.TabStop = true;
            this.RbtnAchtspelers.Text = "8 spelers";
            this.RbtnAchtspelers.UseVisualStyleBackColor = true;
            // 
            // RbtnTienspelers
            // 
            this.RbtnTienspelers.AutoSize = true;
            this.RbtnTienspelers.Location = new System.Drawing.Point(104, 64);
            this.RbtnTienspelers.Name = "RbtnTienspelers";
            this.RbtnTienspelers.Size = new System.Drawing.Size(73, 17);
            this.RbtnTienspelers.TabIndex = 2;
            this.RbtnTienspelers.TabStop = true;
            this.RbtnTienspelers.Text = "10 spelers";
            this.RbtnTienspelers.UseVisualStyleBackColor = true;
            // 
            // RbtnZesspelers
            // 
            this.RbtnZesspelers.AutoSize = true;
            this.RbtnZesspelers.Location = new System.Drawing.Point(104, 24);
            this.RbtnZesspelers.Name = "RbtnZesspelers";
            this.RbtnZesspelers.Size = new System.Drawing.Size(67, 17);
            this.RbtnZesspelers.TabIndex = 1;
            this.RbtnZesspelers.TabStop = true;
            this.RbtnZesspelers.Text = "6 spelers";
            this.RbtnZesspelers.UseVisualStyleBackColor = true;
            // 
            // RbtnVierspelers
            // 
            this.RbtnVierspelers.AutoSize = true;
            this.RbtnVierspelers.Location = new System.Drawing.Point(8, 24);
            this.RbtnVierspelers.Name = "RbtnVierspelers";
            this.RbtnVierspelers.Size = new System.Drawing.Size(67, 17);
            this.RbtnVierspelers.TabIndex = 0;
            this.RbtnVierspelers.TabStop = true;
            this.RbtnVierspelers.Text = "4 spelers";
            this.RbtnVierspelers.UseVisualStyleBackColor = true;
            // 
            // BtnTerug
            // 
            this.BtnTerug.Location = new System.Drawing.Point(2, 136);
            this.BtnTerug.Name = "BtnTerug";
            this.BtnTerug.Size = new System.Drawing.Size(65, 39);
            this.BtnTerug.TabIndex = 1;
            this.BtnTerug.Text = "Terug";
            this.BtnTerug.UseVisualStyleBackColor = true;
            this.BtnTerug.Click += new System.EventHandler(this.BtnTerug_Click);
            // 
            // BtnVerder
            // 
            this.BtnVerder.Location = new System.Drawing.Point(180, 136);
            this.BtnVerder.Name = "BtnVerder";
            this.BtnVerder.Size = new System.Drawing.Size(65, 39);
            this.BtnVerder.TabIndex = 2;
            this.BtnVerder.Text = "Verder";
            this.BtnVerder.UseVisualStyleBackColor = true;
            this.BtnVerder.Click += new System.EventHandler(this.BtnVerder_Click);
            // 
            // Toernooi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnVerder);
            this.Controls.Add(this.BtnTerug);
            this.Controls.Add(this.GbxSpelers);
            this.Name = "Toernooi";
            this.Size = new System.Drawing.Size(261, 203);
            this.GbxSpelers.ResumeLayout(false);
            this.GbxSpelers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbxSpelers;
        private System.Windows.Forms.RadioButton RbtnAchtspelers;
        private System.Windows.Forms.RadioButton RbtnTienspelers;
        private System.Windows.Forms.RadioButton RbtnZesspelers;
        private System.Windows.Forms.RadioButton RbtnVierspelers;
        private System.Windows.Forms.Button BtnTerug;
        private System.Windows.Forms.Button BtnVerder;
    }
}
