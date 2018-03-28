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
            this.GrboxSpelers = new System.Windows.Forms.GroupBox();
            this.RadiobtnAchtspelers = new System.Windows.Forms.RadioButton();
            this.RadiobtnTienspelers = new System.Windows.Forms.RadioButton();
            this.RadiobtnZesspelers = new System.Windows.Forms.RadioButton();
            this.RadiobtnVierspelers = new System.Windows.Forms.RadioButton();
            this.BtnTerug = new System.Windows.Forms.Button();
            this.BtnVerder = new System.Windows.Forms.Button();
            this.GrboxSpelers.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrboxSpelers
            // 
            this.GrboxSpelers.Controls.Add(this.RadiobtnAchtspelers);
            this.GrboxSpelers.Controls.Add(this.RadiobtnTienspelers);
            this.GrboxSpelers.Controls.Add(this.RadiobtnZesspelers);
            this.GrboxSpelers.Controls.Add(this.RadiobtnVierspelers);
            this.GrboxSpelers.Location = new System.Drawing.Point(32, 20);
            this.GrboxSpelers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GrboxSpelers.Name = "GrboxSpelers";
            this.GrboxSpelers.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GrboxSpelers.Size = new System.Drawing.Size(267, 123);
            this.GrboxSpelers.TabIndex = 0;
            this.GrboxSpelers.TabStop = false;
            this.GrboxSpelers.Text = "Aantal spelers";
            // 
            // RadiobtnAchtspelers
            // 
            this.RadiobtnAchtspelers.AutoSize = true;
            this.RadiobtnAchtspelers.Location = new System.Drawing.Point(11, 79);
            this.RadiobtnAchtspelers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RadiobtnAchtspelers.Name = "RadiobtnAchtspelers";
            this.RadiobtnAchtspelers.Size = new System.Drawing.Size(87, 21);
            this.RadiobtnAchtspelers.TabIndex = 3;
            this.RadiobtnAchtspelers.Text = "8 spelers";
            this.RadiobtnAchtspelers.UseVisualStyleBackColor = true;
            this.RadiobtnAchtspelers.CheckedChanged += new System.EventHandler(this.RadiobtnAchtspelers_CheckedChanged);
            // 
            // RadiobtnTienspelers
            // 
            this.RadiobtnTienspelers.AutoSize = true;
            this.RadiobtnTienspelers.Location = new System.Drawing.Point(139, 79);
            this.RadiobtnTienspelers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RadiobtnTienspelers.Name = "RadiobtnTienspelers";
            this.RadiobtnTienspelers.Size = new System.Drawing.Size(95, 21);
            this.RadiobtnTienspelers.TabIndex = 2;
            this.RadiobtnTienspelers.Text = "10 spelers";
            this.RadiobtnTienspelers.UseVisualStyleBackColor = true;
            this.RadiobtnTienspelers.CheckedChanged += new System.EventHandler(this.RadiobtnTienspelers_CheckedChanged);
            // 
            // RadiobtnZesspelers
            // 
            this.RadiobtnZesspelers.AutoSize = true;
            this.RadiobtnZesspelers.Location = new System.Drawing.Point(139, 30);
            this.RadiobtnZesspelers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RadiobtnZesspelers.Name = "RadiobtnZesspelers";
            this.RadiobtnZesspelers.Size = new System.Drawing.Size(87, 21);
            this.RadiobtnZesspelers.TabIndex = 1;
            this.RadiobtnZesspelers.Text = "6 spelers";
            this.RadiobtnZesspelers.UseVisualStyleBackColor = true;
            this.RadiobtnZesspelers.CheckedChanged += new System.EventHandler(this.RadiobtnZesspelers_CheckedChanged);
            // 
            // RadiobtnVierspelers
            // 
            this.RadiobtnVierspelers.AutoSize = true;
            this.RadiobtnVierspelers.Checked = true;
            this.RadiobtnVierspelers.Location = new System.Drawing.Point(11, 30);
            this.RadiobtnVierspelers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RadiobtnVierspelers.Name = "RadiobtnVierspelers";
            this.RadiobtnVierspelers.Size = new System.Drawing.Size(87, 21);
            this.RadiobtnVierspelers.TabIndex = 0;
            this.RadiobtnVierspelers.TabStop = true;
            this.RadiobtnVierspelers.Text = "4 spelers";
            this.RadiobtnVierspelers.UseVisualStyleBackColor = true;
            this.RadiobtnVierspelers.CheckedChanged += new System.EventHandler(this.RadiobtnVierspelers_CheckedChanged);
            // 
            // BtnTerug
            // 
            this.BtnTerug.Location = new System.Drawing.Point(13, 167);
            this.BtnTerug.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnTerug.Name = "BtnTerug";
            this.BtnTerug.Size = new System.Drawing.Size(87, 48);
            this.BtnTerug.TabIndex = 1;
            this.BtnTerug.Text = "Terug";
            this.BtnTerug.UseVisualStyleBackColor = true;
            this.BtnTerug.Click += new System.EventHandler(this.BtnTerug_Click);
            // 
            // BtnVerder
            // 
            this.BtnVerder.Location = new System.Drawing.Point(240, 167);
            this.BtnVerder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnVerder.Name = "BtnVerder";
            this.BtnVerder.Size = new System.Drawing.Size(87, 48);
            this.BtnVerder.TabIndex = 2;
            this.BtnVerder.Text = "Verder";
            this.BtnVerder.UseVisualStyleBackColor = true;
            this.BtnVerder.Click += new System.EventHandler(this.BtnVerder_Click);
            // 
            // Toernooi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnVerder);
            this.Controls.Add(this.BtnTerug);
            this.Controls.Add(this.GrboxSpelers);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Toernooi";
            this.Size = new System.Drawing.Size(348, 250);
            this.GrboxSpelers.ResumeLayout(false);
            this.GrboxSpelers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrboxSpelers;
        private System.Windows.Forms.RadioButton RadiobtnAchtspelers;
        private System.Windows.Forms.RadioButton RadiobtnTienspelers;
        private System.Windows.Forms.RadioButton RadiobtnZesspelers;
        private System.Windows.Forms.RadioButton RadiobtnVierspelers;
        private System.Windows.Forms.Button BtnTerug;
        private System.Windows.Forms.Button BtnVerder;
    }
}
