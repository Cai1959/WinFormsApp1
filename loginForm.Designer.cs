namespace WinFormsApp1
{
    partial class loginForm
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
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            radioButtonuser = new RadioButton();
            radioButtonadmin = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(105, 62);
            label1.Name = "label1";
            label1.Size = new Size(440, 46);
            label1.TabIndex = 0;
            label1.Text = "欢迎登陆产品信息管理系统";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("微软雅黑", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(165, 177);
            label2.Name = "label2";
            label2.Size = new Size(50, 25);
            label2.TabIndex = 1;
            label2.Text = "账户";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("微软雅黑", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(165, 213);
            label3.Name = "label3";
            label3.Size = new Size(50, 25);
            label3.TabIndex = 2;
            label3.Text = "密码";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("微软雅黑", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(221, 179);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(244, 33);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("微软雅黑", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(221, 215);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(244, 33);
            textBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("微软雅黑", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(137, 318);
            button1.Name = "button1";
            button1.Size = new Size(126, 59);
            button1.TabIndex = 5;
            button1.Text = "登录";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("微软雅黑", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(353, 318);
            button2.Name = "button2";
            button2.Size = new Size(134, 59);
            button2.TabIndex = 6;
            button2.Text = "退出";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // radioButtonuser
            // 
            radioButtonuser.AutoSize = true;
            radioButtonuser.Checked = true;
            radioButtonuser.Font = new Font("微软雅黑", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonuser.Location = new Point(165, 271);
            radioButtonuser.Name = "radioButtonuser";
            radioButtonuser.Size = new Size(68, 29);
            radioButtonuser.TabIndex = 7;
            radioButtonuser.TabStop = true;
            radioButtonuser.Text = "用户";
            radioButtonuser.UseVisualStyleBackColor = true;
            // 
            // radioButtonadmin
            // 
            radioButtonadmin.AutoSize = true;
            radioButtonadmin.Font = new Font("微软雅黑", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonadmin.Location = new Point(373, 271);
            radioButtonadmin.Name = "radioButtonadmin";
            radioButtonadmin.Size = new Size(87, 29);
            radioButtonadmin.TabIndex = 8;
            radioButtonadmin.Text = "管理员";
            radioButtonadmin.UseVisualStyleBackColor = true;
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 462);
            Controls.Add(radioButtonadmin);
            Controls.Add(radioButtonuser);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "loginForm";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private RadioButton radioButtonuser;
        private RadioButton radioButtonadmin;
    }
}