using System.Windows.Forms;

namespace WinFormsApp2
{
    partial class Printing
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
            this.RichTextBox2 = new System.Windows.Forms.RichTextBox();
            this.ComboBox2 = new System.Windows.Forms.ComboBox();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.RichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // RichTextBox2
            // 
            this.RichTextBox2.Location = new System.Drawing.Point(51, 137);
            this.RichTextBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RichTextBox2.Name = "RichTextBox2";
            this.RichTextBox2.Size = new System.Drawing.Size(251, 408);
            this.RichTextBox2.TabIndex = 23;
            this.RichTextBox2.Text = "미리보기";
            // 
            // ComboBox2
            // 
            this.ComboBox2.FormattingEnabled = true;
            this.ComboBox2.Items.AddRange(new object[] {
            "전체 페이지",
            "현재 페이지",
            "페이지 선택"});
            this.ComboBox2.Location = new System.Drawing.Point(367, 288);
            this.ComboBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboBox2.Name = "ComboBox2";
            this.ComboBox2.Size = new System.Drawing.Size(171, 26);
            this.ComboBox2.TabIndex = 39;
            this.ComboBox2.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
            // 
            // ComboBox1
            // 
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Items.AddRange(new object[] {
            "한 면 복사",
            "양 면 복사"});
            this.ComboBox1.Location = new System.Drawing.Point(367, 594);
            this.ComboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(171, 26);
            this.ComboBox1.TabIndex = 38;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.Label7.Location = new System.Drawing.Point(370, 481);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(104, 29);
            this.Label7.TabIndex = 36;
            this.Label7.Text = "용지 크기";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(521, 431);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(94, 18);
            this.Label6.TabIndex = 35;
            this.Label6.Text = "ex) 1, 2, 3";
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(370, 427);
            this.TextBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(141, 28);
            this.TextBox2.TabIndex = 34;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.Label5.Location = new System.Drawing.Point(367, 402);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(174, 29);
            this.Label5.TabIndex = 33;
            this.Label5.Text = "용지당 페이지 수";
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.SystemColors.Control;
            this.Button2.Location = new System.Drawing.Point(681, 660);
            this.Button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(137, 54);
            this.Button2.TabIndex = 32;
            this.Button2.Text = "닫기";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.SystemColors.Control;
            this.Button1.Location = new System.Drawing.Point(681, 44);
            this.Button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(137, 52);
            this.Button1.TabIndex = 31;
            this.Button1.Text = "프린트";
            this.Button1.UseVisualStyleBackColor = false;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(483, 342);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(135, 18);
            this.Label4.TabIndex = 30;
            this.Label4.Text = "ex) 1, 2, 3, 5-9";
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(367, 342);
            this.TextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(105, 28);
            this.TextBox1.TabIndex = 29;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.SystemColors.Control;
            this.Label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label3.Location = new System.Drawing.Point(370, 259);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(141, 32);
            this.Label3.TabIndex = 28;
            this.Label3.Text = "프린트 범위";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.Location = new System.Drawing.Point(367, 565);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(141, 32);
            this.Label2.TabIndex = 27;
            this.Label2.Text = "프린트 방식";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(370, 91);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(141, 32);
            this.Label1.TabIndex = 26;
            this.Label1.Text = "프린터 선택";
            // 
            // RichTextBox1
            // 
            this.RichTextBox1.Location = new System.Drawing.Point(370, 137);
            this.RichTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RichTextBox1.Name = "RichTextBox1";
            this.RichTextBox1.Size = new System.Drawing.Size(378, 93);
            this.RichTextBox1.TabIndex = 25;
            this.RichTextBox1.Text = "";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "A4",
            "A3",
            "B2"});
            this.comboBox3.Location = new System.Drawing.Point(367, 506);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(133, 26);
            this.comboBox3.TabIndex = 40;
            // 
            // Printing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 736);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.ComboBox2);
            this.Controls.Add(this.ComboBox1);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.RichTextBox1);
            this.Controls.Add(this.RichTextBox2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Printing";
            this.Text = "Print";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal RichTextBox RichTextBox2;
        internal ComboBox ComboBox2;
        internal ComboBox ComboBox1;
        internal Label Label7;
        internal Label Label6;
        internal TextBox TextBox2;
        internal Label Label5;
        internal Button Button2;
        internal Button Button1;
        internal Label Label4;
        internal TextBox TextBox1;
        internal Label Label3;
        internal Label Label2;
        internal Label Label1;
        internal RichTextBox RichTextBox1;
        internal ComboBox comboBox3;
    }
}