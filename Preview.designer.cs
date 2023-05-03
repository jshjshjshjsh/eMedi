using System.Windows.Forms;

namespace WinFormsApp1
{
    partial class Preview
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.이전페이지ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.다음페이지ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.페이지설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.여백조ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.비율조정ToolStripMenuItem = new System.Windows.Forms.ToolStripComboBox();
            this.나가ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Location = new System.Drawing.Point(0, 61);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1181, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.이전페이지ToolStripMenuItem,
            this.다음페이지ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.hgToolStripMenuItem,
            this.페이지설정ToolStripMenuItem,
            this.여백조ToolStripMenuItem,
            this.비율조정ToolStripMenuItem,
            this.나가ToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 24);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(1181, 37);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // 이전페이지ToolStripMenuItem
            // 
            this.이전페이지ToolStripMenuItem.Name = "이전페이지ToolStripMenuItem";
            this.이전페이지ToolStripMenuItem.Size = new System.Drawing.Size(143, 33);
            this.이전페이지ToolStripMenuItem.Text = "이전 페이지 <";
            // 
            // 다음페이지ToolStripMenuItem
            // 
            this.다음페이지ToolStripMenuItem.Name = "다음페이지ToolStripMenuItem";
            this.다음페이지ToolStripMenuItem.Size = new System.Drawing.Size(143, 33);
            this.다음페이지ToolStripMenuItem.Text = "> 다음 페이지";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::reporting_tool.Properties.Resources.free_icon_font_print_3917119;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(40, 33);
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // hgToolStripMenuItem
            // 
            this.hgToolStripMenuItem.Image = global::reporting_tool.Properties.Resources.free_icon_font_settings_3917035;
            this.hgToolStripMenuItem.Name = "hgToolStripMenuItem";
            this.hgToolStripMenuItem.Size = new System.Drawing.Size(40, 33);
            this.hgToolStripMenuItem.Click += new System.EventHandler(this.hgToolStripMenuItem_Click);
            // 
            // 페이지설정ToolStripMenuItem
            // 
            this.페이지설정ToolStripMenuItem.Image = global::reporting_tool.Properties.Resources.free_icon_font_document_3914193;
            this.페이지설정ToolStripMenuItem.Name = "페이지설정ToolStripMenuItem";
            this.페이지설정ToolStripMenuItem.Size = new System.Drawing.Size(148, 33);
            this.페이지설정ToolStripMenuItem.Text = "페이지 설정";
            // 
            // 여백조ToolStripMenuItem
            // 
            this.여백조ToolStripMenuItem.Name = "여백조ToolStripMenuItem";
            this.여백조ToolStripMenuItem.Size = new System.Drawing.Size(16, 33);
            this.여백조ToolStripMenuItem.Click += new System.EventHandler(this.여백조ToolStripMenuItem_Click);
            // 
            // 비율조정ToolStripMenuItem
            // 
            this.비율조정ToolStripMenuItem.Items.AddRange(new object[] {
            "100%",
            "90%",
            "80%",
            "70%",
            "60%",
            "50%",
            "40%",
            "30%",
            "20%",
            "10%"});
            this.비율조정ToolStripMenuItem.Name = "비율조정ToolStripMenuItem";
            this.비율조정ToolStripMenuItem.Size = new System.Drawing.Size(105, 33);
            this.비율조정ToolStripMenuItem.Click += new System.EventHandler(this.비율조정ToolStripMenuItem_Click);
            // 
            // 나가ToolStripMenuItem
            // 
            this.나가ToolStripMenuItem.Image = global::reporting_tool.Properties.Resources.free_icon_font_arrow_right_3916846;
            this.나가ToolStripMenuItem.Name = "나가ToolStripMenuItem";
            this.나가ToolStripMenuItem.Size = new System.Drawing.Size(106, 33);
            this.나가ToolStripMenuItem.Text = "나가기";
            this.나가ToolStripMenuItem.Click += new System.EventHandler(this.나가ToolStripMenuItem_Click_1);
            // 
            // menuStrip3
            // 
            this.menuStrip3.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip3.Size = new System.Drawing.Size(1181, 24);
            this.menuStrip3.TabIndex = 5;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(90, 90);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Multiline = false;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(998, 900);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1099, 938);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(13, 28);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Preview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 980);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip3);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Preview";
            this.Text = "미리보기";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private MenuStrip menuStrip3;
        private RichTextBox richTextBox1;
        private ToolStripMenuItem 이전페이지ToolStripMenuItem;
        private ToolStripMenuItem 다음페이지ToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem hgToolStripMenuItem;
        private ToolStripMenuItem 페이지설정ToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox textBox1;
        private ToolStripMenuItem 나가ToolStripMenuItem;
        private ToolStripMenuItem 여백조ToolStripMenuItem;
        private ToolStripComboBox 비율조정ToolStripMenuItem;
    }
}