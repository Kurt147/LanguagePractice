namespace VertaalProgramma
{
    partial class AddWords
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblLanguage1 = new System.Windows.Forms.Label();
            this.lblLanguage2 = new System.Windows.Forms.Label();
            this.txtLanguage1 = new System.Windows.Forms.TextBox();
            this.txtLanguage2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(388, 23);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblLanguage1
            // 
            this.lblLanguage1.AutoSize = true;
            this.lblLanguage1.Location = new System.Drawing.Point(12, 9);
            this.lblLanguage1.Name = "lblLanguage1";
            this.lblLanguage1.Size = new System.Drawing.Size(61, 13);
            this.lblLanguage1.TabIndex = 1;
            this.lblLanguage1.Text = "Language1";
            // 
            // lblLanguage2
            // 
            this.lblLanguage2.AutoSize = true;
            this.lblLanguage2.Location = new System.Drawing.Point(197, 9);
            this.lblLanguage2.Name = "lblLanguage2";
            this.lblLanguage2.Size = new System.Drawing.Size(61, 13);
            this.lblLanguage2.TabIndex = 2;
            this.lblLanguage2.Text = "Language2";
            // 
            // txtLanguage1
            // 
            this.txtLanguage1.Location = new System.Drawing.Point(12, 25);
            this.txtLanguage1.Name = "txtLanguage1";
            this.txtLanguage1.Size = new System.Drawing.Size(182, 20);
            this.txtLanguage1.TabIndex = 3;
            // 
            // txtLanguage2
            // 
            this.txtLanguage2.Location = new System.Drawing.Point(200, 25);
            this.txtLanguage2.Name = "txtLanguage2";
            this.txtLanguage2.Size = new System.Drawing.Size(182, 20);
            this.txtLanguage2.TabIndex = 4;
            // 
            // AddWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 67);
            this.Controls.Add(this.txtLanguage2);
            this.Controls.Add(this.txtLanguage1);
            this.Controls.Add(this.lblLanguage2);
            this.Controls.Add(this.lblLanguage1);
            this.Controls.Add(this.btnAdd);
            this.Name = "AddWords";
            this.Text = "Add Words";
            this.Load += new System.EventHandler(this.AddWords_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblLanguage1;
        private System.Windows.Forms.Label lblLanguage2;
        private System.Windows.Forms.TextBox txtLanguage1;
        private System.Windows.Forms.TextBox txtLanguage2;
    }
}