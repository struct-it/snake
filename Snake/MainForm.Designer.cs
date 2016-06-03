namespace Snake
{
    partial class MainForm
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
            this.mainFormLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.mainFormMap = new System.Windows.Forms.PictureBox();
            this.mainFormStatusStrip = new System.Windows.Forms.StatusStrip();
            this.mainFormStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainFormLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormMap)).BeginInit();
            this.mainFormStatusStrip.SuspendLayout();
            this.mainFormMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.mainFormLayoutPanel.ColumnCount = 1;
            this.mainFormLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainFormLayoutPanel.Controls.Add(this.mainFormMap, 0, 0);
            this.mainFormLayoutPanel.Location = new System.Drawing.Point(0, 33);
            this.mainFormLayoutPanel.Name = "tableLayoutPanel1";
            this.mainFormLayoutPanel.RowCount = 1;
            this.mainFormLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainFormLayoutPanel.Size = new System.Drawing.Size(607, 512);
            this.mainFormLayoutPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.mainFormMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainFormMap.Location = new System.Drawing.Point(3, 3);
            this.mainFormMap.Name = "pictureBox1";
            this.mainFormMap.Size = new System.Drawing.Size(601, 506);
            this.mainFormMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.mainFormMap.TabIndex = 0;
            this.mainFormMap.TabStop = false;
            this.mainFormMap.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.mainFormMap.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.MainForm_KeyDown);
            // 
            // statusStrip1
            // 
            this.mainFormStatusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mainFormStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainFormStatusLabel});
            this.mainFormStatusStrip.Location = new System.Drawing.Point(0, 548);
            this.mainFormStatusStrip.Name = "statusStrip1";
            this.mainFormStatusStrip.Size = new System.Drawing.Size(607, 22);
            this.mainFormStatusStrip.TabIndex = 1;
            this.mainFormStatusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.mainFormStatusLabel.Name = "toolStripStatusLabel1";
            this.mainFormStatusLabel.Size = new System.Drawing.Size(0, 23);
            // 
            // menuStrip1
            // 
            this.mainFormMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mainFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem});
            this.mainFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainFormMenuStrip.Name = "menuStrip1";
            this.mainFormMenuStrip.Size = new System.Drawing.Size(607, 33);
            this.mainFormMenuStrip.TabIndex = 2;
            this.mainFormMenuStrip.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.gameToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(198, 30);
            this.newToolStripMenuItem.Text = "New Game";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.MainForm_NewGame);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(198, 30);
            this.quitToolStripMenuItem.Text = "Close";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.MainForm_Dispose);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(198, 30);
            this.exitToolStripMenuItem.Text = "Exit Game";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.MainForm_Exit);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 570);
            this.Controls.Add(this.mainFormStatusStrip);
            this.Controls.Add(this.mainFormMenuStrip);
            this.Controls.Add(this.mainFormLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mainFormMenuStrip;
            this.Name = "Form2";
            this.Text = "Snake";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainFormLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainFormMap)).EndInit();
            this.mainFormStatusStrip.ResumeLayout(false);
            this.mainFormStatusStrip.PerformLayout();
            this.mainFormMenuStrip.ResumeLayout(false);
            this.mainFormMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainFormLayoutPanel;
        private System.Windows.Forms.PictureBox mainFormMap;
        private System.Windows.Forms.StatusStrip mainFormStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel mainFormStatusLabel;
        private System.Windows.Forms.MenuStrip mainFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}