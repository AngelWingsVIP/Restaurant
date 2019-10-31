namespace UI
{
    partial class ManagerInfoList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerInfoList));
            this.gv_list = new System.Windows.Forms.DataGridView();
            this.Mid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group_list = new System.Windows.Forms.GroupBox();
            this.group_add_remov = new System.Windows.Forms.GroupBox();
            this.bt_alter = new System.Windows.Forms.Button();
            this.bt_Remove = new System.Windows.Forms.Button();
            this.lb_tip2 = new System.Windows.Forms.Label();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.rb_2 = new System.Windows.Forms.RadioButton();
            this.rb_1 = new System.Windows.Forms.RadioButton();
            this.lb_type = new System.Windows.Forms.Label();
            this.lb_tip = new System.Windows.Forms.Label();
            this.tb_pwd = new System.Windows.Forms.TextBox();
            this.tb_uname = new System.Windows.Forms.TextBox();
            this.tb_mid = new System.Windows.Forms.TextBox();
            this.lb_pwd = new System.Windows.Forms.Label();
            this.lb_uname = new System.Windows.Forms.Label();
            this.lb_mid = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gv_list)).BeginInit();
            this.group_list.SuspendLayout();
            this.group_add_remov.SuspendLayout();
            this.SuspendLayout();
            // 
            // gv_list
            // 
            this.gv_list.AllowUserToAddRows = false;
            this.gv_list.AllowUserToDeleteRows = false;
            this.gv_list.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gv_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mid,
            this.username,
            this.type});
            this.gv_list.Location = new System.Drawing.Point(3, 17);
            this.gv_list.MultiSelect = false;
            this.gv_list.Name = "gv_list";
            this.gv_list.ReadOnly = true;
            this.gv_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_list.Size = new System.Drawing.Size(380, 254);
            this.gv_list.TabIndex = 0;
            this.gv_list.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_list_CellClick);
            this.gv_list.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gv_list_CellFormatting);
            // 
            // Mid
            // 
            this.Mid.DataPropertyName = "Mid";
            this.Mid.HeaderText = "编号";
            this.Mid.Name = "Mid";
            this.Mid.ReadOnly = true;
            // 
            // username
            // 
            this.username.DataPropertyName = "mname";
            this.username.HeaderText = "用户名";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // type
            // 
            this.type.DataPropertyName = "mtype";
            this.type.HeaderText = "类型";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // group_list
            // 
            this.group_list.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.group_list.AutoSize = true;
            this.group_list.Controls.Add(this.gv_list);
            this.group_list.Location = new System.Drawing.Point(12, 12);
            this.group_list.Name = "group_list";
            this.group_list.Size = new System.Drawing.Size(386, 291);
            this.group_list.TabIndex = 1;
            this.group_list.TabStop = false;
            this.group_list.Text = "列表";
            // 
            // group_add_remov
            // 
            this.group_add_remov.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.group_add_remov.Controls.Add(this.button1);
            this.group_add_remov.Controls.Add(this.bt_alter);
            this.group_add_remov.Controls.Add(this.bt_Remove);
            this.group_add_remov.Controls.Add(this.lb_tip2);
            this.group_add_remov.Controls.Add(this.bt_cancel);
            this.group_add_remov.Controls.Add(this.bt_add);
            this.group_add_remov.Controls.Add(this.rb_2);
            this.group_add_remov.Controls.Add(this.rb_1);
            this.group_add_remov.Controls.Add(this.lb_type);
            this.group_add_remov.Controls.Add(this.lb_tip);
            this.group_add_remov.Controls.Add(this.tb_pwd);
            this.group_add_remov.Controls.Add(this.tb_uname);
            this.group_add_remov.Controls.Add(this.tb_mid);
            this.group_add_remov.Controls.Add(this.lb_pwd);
            this.group_add_remov.Controls.Add(this.lb_uname);
            this.group_add_remov.Controls.Add(this.lb_mid);
            this.group_add_remov.Location = new System.Drawing.Point(411, 26);
            this.group_add_remov.Name = "group_add_remov";
            this.group_add_remov.Size = new System.Drawing.Size(243, 256);
            this.group_add_remov.TabIndex = 2;
            this.group_add_remov.TabStop = false;
            this.group_add_remov.Text = "添加V修改";
            // 
            // bt_alter
            // 
            this.bt_alter.Location = new System.Drawing.Point(85, 172);
            this.bt_alter.Name = "bt_alter";
            this.bt_alter.Size = new System.Drawing.Size(75, 23);
            this.bt_alter.TabIndex = 22;
            this.bt_alter.Text = "修改";
            this.bt_alter.UseVisualStyleBackColor = true;
            this.bt_alter.Click += new System.EventHandler(this.bt_alter_Click);
            // 
            // bt_Remove
            // 
            this.bt_Remove.Location = new System.Drawing.Point(6, 229);
            this.bt_Remove.Name = "bt_Remove";
            this.bt_Remove.Size = new System.Drawing.Size(114, 23);
            this.bt_Remove.TabIndex = 20;
            this.bt_Remove.Text = "删除选中的店员";
            this.bt_Remove.UseVisualStyleBackColor = true;
            this.bt_Remove.Click += new System.EventHandler(this.bt_Remove_Click);
            // 
            // lb_tip2
            // 
            this.lb_tip2.AutoSize = true;
            this.lb_tip2.ForeColor = System.Drawing.Color.Red;
            this.lb_tip2.Location = new System.Drawing.Point(6, 205);
            this.lb_tip2.Name = "lb_tip2";
            this.lb_tip2.Size = new System.Drawing.Size(209, 12);
            this.lb_tip2.TabIndex = 21;
            this.lb_tip2.Text = "提示：单击表格项可以在此处进行修改";
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(162, 172);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_cancel.TabIndex = 19;
            this.bt_cancel.Text = "重置";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(6, 172);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(75, 23);
            this.bt_add.TabIndex = 18;
            this.bt_add.Text = "添加";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // rb_2
            // 
            this.rb_2.AutoSize = true;
            this.rb_2.Checked = true;
            this.rb_2.Location = new System.Drawing.Point(130, 147);
            this.rb_2.Name = "rb_2";
            this.rb_2.Size = new System.Drawing.Size(47, 16);
            this.rb_2.TabIndex = 17;
            this.rb_2.TabStop = true;
            this.rb_2.Text = "店员";
            this.rb_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb_2.UseVisualStyleBackColor = true;
            // 
            // rb_1
            // 
            this.rb_1.AutoSize = true;
            this.rb_1.ForeColor = System.Drawing.Color.Red;
            this.rb_1.Location = new System.Drawing.Point(63, 147);
            this.rb_1.Name = "rb_1";
            this.rb_1.Size = new System.Drawing.Size(47, 16);
            this.rb_1.TabIndex = 16;
            this.rb_1.Text = "经理";
            this.rb_1.UseVisualStyleBackColor = true;
            // 
            // lb_type
            // 
            this.lb_type.AutoSize = true;
            this.lb_type.Location = new System.Drawing.Point(11, 149);
            this.lb_type.Name = "lb_type";
            this.lb_type.Size = new System.Drawing.Size(41, 12);
            this.lb_type.TabIndex = 15;
            this.lb_type.Text = "类型：";
            // 
            // lb_tip
            // 
            this.lb_tip.AutoSize = true;
            this.lb_tip.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lb_tip.Location = new System.Drawing.Point(23, 122);
            this.lb_tip.Name = "lb_tip";
            this.lb_tip.Size = new System.Drawing.Size(197, 12);
            this.lb_tip.TabIndex = 14;
            this.lb_tip.Text = "这里只是提示，与实际密码位数无关";
            // 
            // tb_pwd
            // 
            this.tb_pwd.Location = new System.Drawing.Point(64, 92);
            this.tb_pwd.Name = "tb_pwd";
            this.tb_pwd.PasswordChar = '*';
            this.tb_pwd.Size = new System.Drawing.Size(155, 21);
            this.tb_pwd.TabIndex = 5;
            // 
            // tb_uname
            // 
            this.tb_uname.Location = new System.Drawing.Point(64, 63);
            this.tb_uname.Name = "tb_uname";
            this.tb_uname.Size = new System.Drawing.Size(155, 21);
            this.tb_uname.TabIndex = 4;
            // 
            // tb_mid
            // 
            this.tb_mid.Enabled = false;
            this.tb_mid.ForeColor = System.Drawing.Color.Red;
            this.tb_mid.Location = new System.Drawing.Point(64, 28);
            this.tb_mid.Name = "tb_mid";
            this.tb_mid.Size = new System.Drawing.Size(155, 21);
            this.tb_mid.TabIndex = 3;
            this.tb_mid.Text = "编号智能处理";
            // 
            // lb_pwd
            // 
            this.lb_pwd.AutoSize = true;
            this.lb_pwd.Location = new System.Drawing.Point(12, 96);
            this.lb_pwd.Name = "lb_pwd";
            this.lb_pwd.Size = new System.Drawing.Size(41, 12);
            this.lb_pwd.TabIndex = 2;
            this.lb_pwd.Text = "密码：";
            // 
            // lb_uname
            // 
            this.lb_uname.AutoSize = true;
            this.lb_uname.Location = new System.Drawing.Point(12, 66);
            this.lb_uname.Name = "lb_uname";
            this.lb_uname.Size = new System.Drawing.Size(53, 12);
            this.lb_uname.TabIndex = 1;
            this.lb_uname.Text = "用户名：";
            // 
            // lb_mid
            // 
            this.lb_mid.AutoSize = true;
            this.lb_mid.Location = new System.Drawing.Point(17, 33);
            this.lb_mid.Name = "lb_mid";
            this.lb_mid.Size = new System.Drawing.Size(41, 12);
            this.lb_mid.TabIndex = 0;
            this.lb_mid.Text = "编号：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "导出Excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ManagerInfoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 298);
            this.Controls.Add(this.group_add_remov);
            this.Controls.Add(this.group_list);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ManagerInfoList";
            this.Text = "店员管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManergerInfoList_FormClosing);
            this.Load += new System.EventHandler(this.ManergerInfoList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_list)).EndInit();
            this.group_list.ResumeLayout(false);
            this.group_add_remov.ResumeLayout(false);
            this.group_add_remov.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_list;
        private System.Windows.Forms.GroupBox group_list;
        private System.Windows.Forms.GroupBox group_add_remov;
        private System.Windows.Forms.Label lb_pwd;
        private System.Windows.Forms.Label lb_uname;
        private System.Windows.Forms.Label lb_mid;
        private System.Windows.Forms.Button bt_Remove;
        private System.Windows.Forms.Label lb_tip2;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.RadioButton rb_2;
        private System.Windows.Forms.RadioButton rb_1;
        private System.Windows.Forms.Label lb_type;
        private System.Windows.Forms.Label lb_tip;
        private System.Windows.Forms.TextBox tb_pwd;
        private System.Windows.Forms.TextBox tb_uname;
        private System.Windows.Forms.TextBox tb_mid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mid;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.Button bt_alter;
        private System.Windows.Forms.Button button1;
    }
}