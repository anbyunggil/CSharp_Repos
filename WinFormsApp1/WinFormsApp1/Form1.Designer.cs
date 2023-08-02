using System.Diagnostics;

namespace WinFormsApp1
{
    partial class Form1
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
            btn_bigbutton = new Button();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // btn_bigbutton
            // 
            btn_bigbutton.Location = new Point(12, 12);
            btn_bigbutton.Name = "btn_bigbutton";
            btn_bigbutton.Size = new Size(266, 93);
            btn_bigbutton.TabIndex = 0;
            btn_bigbutton.Text = "왕버튼";
            btn_bigbutton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(284, 9);
            button1.Name = "button1";
            button1.Size = new Size(315, 98);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(12, 124);
            button2.Name = "button2";
            button2.Size = new Size(145, 167);
            button2.TabIndex = 2;
            button2.Text = "절대 누르지 마세요.";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(178, 124);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btn_bigbutton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Button btn_bigbutton;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private EventHandler textBox1_TextChanged;
    }
}