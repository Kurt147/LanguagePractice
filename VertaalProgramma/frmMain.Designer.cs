namespace VertaalProgramma
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.getWordListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questioningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multipleChoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtList = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.deleteWordListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.fileToolStripMenuItem,
            this.questioningToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(537, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getWordListToolStripMenuItem,
            this.deleteWordListToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // getWordListToolStripMenuItem
            // 
            this.getWordListToolStripMenuItem.Name = "getWordListToolStripMenuItem";
            this.getWordListToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.getWordListToolStripMenuItem.Text = "Get word list";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addListToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.fileToolStripMenuItem.Text = "Add words";
            // 
            // addListToolStripMenuItem
            // 
            this.addListToolStripMenuItem.Name = "addListToolStripMenuItem";
            this.addListToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.addListToolStripMenuItem.Text = "Add list";
            this.addListToolStripMenuItem.Click += new System.EventHandler(this.addListToolStripMenuItem_Click);
            // 
            // questioningToolStripMenuItem
            // 
            this.questioningToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qAToolStripMenuItem,
            this.multipleChoiceToolStripMenuItem});
            this.questioningToolStripMenuItem.Name = "questioningToolStripMenuItem";
            this.questioningToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.questioningToolStripMenuItem.Text = "Questioning";
            // 
            // qAToolStripMenuItem
            // 
            this.qAToolStripMenuItem.Name = "qAToolStripMenuItem";
            this.qAToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.qAToolStripMenuItem.Text = "Q and A";
            // 
            // multipleChoiceToolStripMenuItem
            // 
            this.multipleChoiceToolStripMenuItem.Name = "multipleChoiceToolStripMenuItem";
            this.multipleChoiceToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.multipleChoiceToolStripMenuItem.Text = "Multiple choice";
            // 
            // txtList
            // 
            this.txtList.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtList.Location = new System.Drawing.Point(12, 27);
            this.txtList.Multiline = true;
            this.txtList.Name = "txtList";
            this.txtList.ReadOnly = true;
            this.txtList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtList.Size = new System.Drawing.Size(412, 413);
            this.txtList.TabIndex = 1;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(430, 117);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // deleteWordListToolStripMenuItem
            // 
            this.deleteWordListToolStripMenuItem.Name = "deleteWordListToolStripMenuItem";
            this.deleteWordListToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.deleteWordListToolStripMenuItem.Text = "Delete word list";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 452);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtList);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Translate";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem getWordListToolStripMenuItem;
        private System.Windows.Forms.TextBox txtList;
        private System.Windows.Forms.ToolStripMenuItem questioningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multipleChoiceToolStripMenuItem;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteWordListToolStripMenuItem;
    }
}

