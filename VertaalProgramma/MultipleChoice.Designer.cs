namespace VertaalProgramma
{
    partial class MultipleChoice
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEnglish = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb1 = new System.Windows.Forms.RadioButton();
            this.rdb2 = new System.Windows.Forms.RadioButton();
            this.rdb3 = new System.Windows.Forms.RadioButton();
            this.btnSkip = new System.Windows.Forms.Button();
            this.btnScore = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEnglish
            // 
            this.lblEnglish.AutoSize = true;
            this.lblEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnglish.Location = new System.Drawing.Point(13, 9);
            this.lblEnglish.Name = "lblEnglish";
            this.lblEnglish.Size = new System.Drawing.Size(0, 25);
            this.lblEnglish.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb3);
            this.groupBox1.Controls.Add(this.rdb2);
            this.groupBox1.Controls.Add(this.rdb1);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 98);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // rdb1
            // 
            this.rdb1.AutoSize = true;
            this.rdb1.Location = new System.Drawing.Point(6, 19);
            this.rdb1.Name = "rdb1";
            this.rdb1.Size = new System.Drawing.Size(85, 17);
            this.rdb1.TabIndex = 0;
            this.rdb1.TabStop = true;
            this.rdb1.Text = "radioButton1";
            this.rdb1.UseVisualStyleBackColor = true;
            // 
            // rdb2
            // 
            this.rdb2.AutoSize = true;
            this.rdb2.Location = new System.Drawing.Point(6, 42);
            this.rdb2.Name = "rdb2";
            this.rdb2.Size = new System.Drawing.Size(85, 17);
            this.rdb2.TabIndex = 1;
            this.rdb2.TabStop = true;
            this.rdb2.Text = "radioButton2";
            this.rdb2.UseVisualStyleBackColor = true;
            // 
            // rdb3
            // 
            this.rdb3.AutoSize = true;
            this.rdb3.Location = new System.Drawing.Point(6, 65);
            this.rdb3.Name = "rdb3";
            this.rdb3.Size = new System.Drawing.Size(85, 17);
            this.rdb3.TabIndex = 2;
            this.rdb3.TabStop = true;
            this.rdb3.Text = "radioButton3";
            this.rdb3.UseVisualStyleBackColor = true;
            // 
            // btnSkip
            // 
            this.btnSkip.Location = new System.Drawing.Point(324, 38);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(75, 23);
            this.btnSkip.TabIndex = 2;
            this.btnSkip.Text = "skip";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // btnScore
            // 
            this.btnScore.Location = new System.Drawing.Point(324, 116);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(75, 23);
            this.btnScore.TabIndex = 8;
            this.btnScore.Text = "Score";
            this.btnScore.UseVisualStyleBackColor = true;
            this.btnScore.Click += new System.EventHandler(this.btnScore_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(324, 78);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 7;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // MultipleChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 150);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblEnglish);
            this.Name = "MultipleChoice";
            this.Text = "MultipleChoice";
            this.Load += new System.EventHandler(this.MultipleChoice_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnglish;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb3;
        private System.Windows.Forms.RadioButton rdb2;
        private System.Windows.Forms.RadioButton rdb1;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Button btnScore;
        private System.Windows.Forms.Button btnCheck;
    }
}