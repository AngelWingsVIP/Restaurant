namespace UI
{
    partial class ManagerLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerLogin));
            this.lb_zw = new System.Windows.Forms.Label();
            this.lb_user = new System.Windows.Forms.Label();
            this.lb_pwd = new System.Windows.Forms.Label();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.tb_pwd = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_zw
            // 
            this.lb_zw.AutoSize = true;
            this.lb_zw.Font = new System.Drawing.Font("叶根友毛笔行书2.0版", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_zw.ForeColor = System.Drawing.Color.Red;
            this.lb_zw.Location = new System.Drawing.Point(141, 264);
            this.lb_zw.Name = "lb_zw";
            this.lb_zw.Size = new System.Drawing.Size(108, 18);
            this.lb_zw.TabIndex = 0;
            this.lb_zw.Text = "软 件 工 程 师";
            // 
            // lb_user
            // 
            this.lb_user.AutoSize = true;
            this.lb_user.Font = new System.Drawing.Font("叶根友毛笔行书2.0版", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_user.ForeColor = System.Drawing.Color.Red;
            this.lb_user.Location = new System.Drawing.Point(424, 109);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(47, 14);
            this.lb_user.TabIndex = 1;
            this.lb_user.Text = "用户名:";
            // 
            // lb_pwd
            // 
            this.lb_pwd.AutoSize = true;
            this.lb_pwd.Font = new System.Drawing.Font("叶根友毛笔行书2.0版", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_pwd.ForeColor = System.Drawing.Color.Red;
            this.lb_pwd.Location = new System.Drawing.Point(424, 152);
            this.lb_pwd.Name = "lb_pwd";
            this.lb_pwd.Size = new System.Drawing.Size(35, 14);
            this.lb_pwd.TabIndex = 2;
            this.lb_pwd.Text = "密码:";
            // 
            // tb_user
            // 
            this.tb_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_user.Location = new System.Drawing.Point(473, 107);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(133, 21);
            this.tb_user.TabIndex = 3;
            this.tb_user.Text = "123";
            // 
            // tb_pwd
            // 
            this.tb_pwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_pwd.Location = new System.Drawing.Point(473, 146);
            this.tb_pwd.Name = "tb_pwd";
            this.tb_pwd.PasswordChar = '*';
            this.tb_pwd.Size = new System.Drawing.Size(133, 21);
            this.tb_pwd.TabIndex = 4;
            this.tb_pwd.Text = "123";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(349, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 74);
            this.button1.TabIndex = 5;
            this.button1.Text = "登陆";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ManagerLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(659, 388);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_pwd);
            this.Controls.Add(this.tb_user);
            this.Controls.Add(this.lb_pwd);
            this.Controls.Add(this.lb_user);
            this.Controls.Add(this.lb_zw);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ManagerLogin";
            this.Text = "ManagerLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_zw;
        private System.Windows.Forms.Label lb_user;
        private System.Windows.Forms.Label lb_pwd;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.TextBox tb_pwd;
        private System.Windows.Forms.Button button1;
    }
}