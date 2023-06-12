namespace Login_Lab3
{
    partial class Form1
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
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.User_name = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên Đăng Nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật Khẩu";
            // 
            // User_name
            // 
            this.User_name.AccessibleDescription = "";
            this.User_name.Location = new System.Drawing.Point(311, 169);
            this.User_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.User_name.Name = "User_name";
            this.User_name.Size = new System.Drawing.Size(285, 22);
            this.User_name.TabIndex = 4;
            this.User_name.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // pass
            // 
            this.pass.AccessibleDescription = "";
            this.pass.Location = new System.Drawing.Point(311, 225);
            this.pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(285, 22);
            this.pass.TabIndex = 5;
            this.pass.UseSystemPasswordChar = true;
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(271, 283);
            this.login_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(138, 43);
            this.login_button.TabIndex = 6;
            this.login_button.Text = "Đăng Nhập";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exit_button.Location = new System.Drawing.Point(477, 283);
            this.exit_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(136, 43);
            this.exit_button.TabIndex = 7;
            this.exit_button.Text = "Thoát";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 500);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.User_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Đăng nhập tài khoản";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox User_name;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button exit_button;
    }

}