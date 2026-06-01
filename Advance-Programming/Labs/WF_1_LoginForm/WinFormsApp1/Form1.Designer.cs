namespace WF_1_LoginForm
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
            label1 = new Label();
            label2 = new Label();
            tb_1 = new TextBox();
            label3 = new Label();
            tb_2 = new TextBox();
            btn_1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label4 = new Label();
            tb_3 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(241, 45);
            label1.Name = "label1";
            label1.Size = new Size(184, 25);
            label1.TabIndex = 0;
            label1.Text = "Student Login System";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(161, 122);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 1;
            label2.Text = "Enter Name";
            label2.Click += label2_Click;
            // 
            // tb_1
            // 
            tb_1.Location = new Point(317, 122);
            tb_1.Name = "tb_1";
            tb_1.Size = new Size(150, 31);
            tb_1.TabIndex = 2;
            tb_1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(161, 185);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 3;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // tb_2
            // 
            tb_2.Location = new Point(317, 179);
            tb_2.Name = "tb_2";
            tb_2.PasswordChar = '*';
            tb_2.Size = new Size(150, 31);
            tb_2.TabIndex = 4;
            // 
            // btn_1
            // 
            btn_1.Location = new Point(153, 308);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(112, 34);
            btn_1.TabIndex = 5;
            btn_1.Text = "Login";
            btn_1.UseVisualStyleBackColor = true;
            btn_1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(304, 308);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 6;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(466, 308);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 7;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(161, 243);
            label4.Name = "label4";
            label4.Size = new Size(85, 25);
            label4.TabIndex = 8;
            label4.Text = "Semester";
            label4.Click += label4_Click;
            // 
            // tb_3
            // 
            tb_3.Location = new Point(317, 243);
            tb_3.Name = "tb_3";
            tb_3.ReadOnly = true;
            tb_3.Size = new Size(150, 31);
            tb_3.TabIndex = 9;
            tb_3.TextChanged += tb_3_TextChanged_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tb_3);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btn_1);
            Controls.Add(tb_2);
            Controls.Add(label3);
            Controls.Add(tb_1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tb_1;
        private Label label3;
        private TextBox tb_2;
        private Button btn_1;
        private Button button2;
        private Button button3;
        private Label label4;
        private TextBox tb_3;
    }
}
