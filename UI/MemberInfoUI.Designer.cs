namespace UI
{
    partial class MemberInfoUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberInfoUI));
            this.rb_1 = new System.Windows.Forms.GroupBox();
            this.gv_1 = new System.Windows.Forms.DataGridView();
            this.level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group_add_remov = new System.Windows.Forms.GroupBox();
            this.tb_money = new System.Windows.Forms.TextBox();
            this.lb_money = new System.Windows.Forms.Label();
            this.bt_alter = new System.Windows.Forms.Button();
            this.bt_Remove = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_level = new System.Windows.Forms.TextBox();
            this.lb_phone = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_level = new System.Windows.Forms.Label();
            this.tb_mid = new System.Windows.Forms.TextBox();
            this.rb_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_1)).BeginInit();
            this.group_add_remov.SuspendLayout();
            this.SuspendLayout();
            // 
            // rb_1
            // 
            this.rb_1.Controls.Add(this.gv_1);
            this.rb_1.Location = new System.Drawing.Point(6, 6);
            this.rb_1.Name = "rb_1";
            this.rb_1.Size = new System.Drawing.Size(356, 283);
            this.rb_1.TabIndex = 1;
            this.rb_1.TabStop = false;
            this.rb_1.Text = "会员列表";
            // 
            // gv_1
            // 
            this.gv_1.AllowUserToAddRows = false;
            this.gv_1.AllowUserToDeleteRows = false;
            this.gv_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.level,
            this.name,
            this.phone,
            this.money,
            this.mid});
            this.gv_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_1.Location = new System.Drawing.Point(3, 17);
            this.gv_1.MultiSelect = false;
            this.gv_1.Name = "gv_1";
            this.gv_1.ReadOnly = true;
            this.gv_1.RowTemplate.Height = 23;
            this.gv_1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_1.Size = new System.Drawing.Size(350, 263);
            this.gv_1.TabIndex = 0;
            this.gv_1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_1_CellClick);
            // 
            // level
            // 
            this.level.DataPropertyName = "MTypeId";
            this.level.HeaderText = "级别";
            this.level.Name = "level";
            this.level.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "MName";
            this.name.HeaderText = "姓名";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "MPhone";
            this.phone.HeaderText = "手机号";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // money
            // 
            this.money.DataPropertyName = "MMoney";
            this.money.HeaderText = "余额";
            this.money.Name = "money";
            this.money.ReadOnly = true;
            // 
            // mid
            // 
            this.mid.DataPropertyName = "mid";
            this.mid.HeaderText = "索引";
            this.mid.Name = "mid";
            this.mid.ReadOnly = true;
            this.mid.Visible = false;
            // 
            // group_add_remov
            // 
            this.group_add_remov.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.group_add_remov.Controls.Add(this.tb_money);
            this.group_add_remov.Controls.Add(this.lb_money);
            this.group_add_remov.Controls.Add(this.bt_alter);
            this.group_add_remov.Controls.Add(this.bt_Remove);
            this.group_add_remov.Controls.Add(this.bt_cancel);
            this.group_add_remov.Controls.Add(this.bt_add);
            this.group_add_remov.Controls.Add(this.tb_phone);
            this.group_add_remov.Controls.Add(this.tb_name);
            this.group_add_remov.Controls.Add(this.tb_level);
            this.group_add_remov.Controls.Add(this.lb_phone);
            this.group_add_remov.Controls.Add(this.lb_name);
            this.group_add_remov.Controls.Add(this.lb_level);
            this.group_add_remov.Location = new System.Drawing.Point(368, 23);
            this.group_add_remov.Name = "group_add_remov";
            this.group_add_remov.Size = new System.Drawing.Size(248, 263);
            this.group_add_remov.TabIndex = 4;
            this.group_add_remov.TabStop = false;
            this.group_add_remov.Text = "添加V修改";
            // 
            // tb_money
            // 
            this.tb_money.Location = new System.Drawing.Point(64, 114);
            this.tb_money.Name = "tb_money";
            this.tb_money.Size = new System.Drawing.Size(155, 21);
            this.tb_money.TabIndex = 24;
            // 
            // lb_money
            // 
            this.lb_money.AutoSize = true;
            this.lb_money.Location = new System.Drawing.Point(12, 118);
            this.lb_money.Name = "lb_money";
            this.lb_money.Size = new System.Drawing.Size(41, 12);
            this.lb_money.TabIndex = 23;
            this.lb_money.Text = "余额：";
            // 
            // bt_alter
            // 
            this.bt_alter.Location = new System.Drawing.Point(88, 147);
            this.bt_alter.Name = "bt_alter";
            this.bt_alter.Size = new System.Drawing.Size(75, 23);
            this.bt_alter.TabIndex = 22;
            this.bt_alter.Text = "修改";
            this.bt_alter.UseVisualStyleBackColor = true;
            this.bt_alter.Click += new System.EventHandler(this.bt_alter_Click);
            // 
            // bt_Remove
            // 
            this.bt_Remove.Location = new System.Drawing.Point(21, 215);
            this.bt_Remove.Name = "bt_Remove";
            this.bt_Remove.Size = new System.Drawing.Size(198, 26);
            this.bt_Remove.TabIndex = 20;
            this.bt_Remove.Text = "删除选中会员";
            this.bt_Remove.UseVisualStyleBackColor = true;
            this.bt_Remove.Click += new System.EventHandler(this.bt_Remove_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(144, 176);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_cancel.TabIndex = 19;
            this.bt_cancel.Text = "重置";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(30, 176);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(75, 23);
            this.bt_add.TabIndex = 18;
            this.bt_add.Text = "添加";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // tb_phone
            // 
            this.tb_phone.Location = new System.Drawing.Point(64, 86);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(155, 21);
            this.tb_phone.TabIndex = 5;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(64, 56);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(155, 21);
            this.tb_name.TabIndex = 4;
            // 
            // tb_level
            // 
            this.tb_level.ForeColor = System.Drawing.Color.Red;
            this.tb_level.Location = new System.Drawing.Point(64, 26);
            this.tb_level.Name = "tb_level";
            this.tb_level.Size = new System.Drawing.Size(155, 21);
            this.tb_level.TabIndex = 3;
            // 
            // lb_phone
            // 
            this.lb_phone.AutoSize = true;
            this.lb_phone.Location = new System.Drawing.Point(12, 90);
            this.lb_phone.Name = "lb_phone";
            this.lb_phone.Size = new System.Drawing.Size(41, 12);
            this.lb_phone.TabIndex = 2;
            this.lb_phone.Text = "号码：";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(12, 59);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(41, 12);
            this.lb_name.TabIndex = 1;
            this.lb_name.Text = "姓名：";
            // 
            // lb_level
            // 
            this.lb_level.AutoSize = true;
            this.lb_level.Location = new System.Drawing.Point(12, 31);
            this.lb_level.Name = "lb_level";
            this.lb_level.Size = new System.Drawing.Size(41, 12);
            this.lb_level.TabIndex = 0;
            this.lb_level.Text = "级别：";
            // 
            // tb_mid
            // 
            this.tb_mid.Enabled = false;
            this.tb_mid.Location = new System.Drawing.Point(432, 6);
            this.tb_mid.Name = "tb_mid";
            this.tb_mid.Size = new System.Drawing.Size(155, 21);
            this.tb_mid.TabIndex = 25;
            this.tb_mid.Visible = false;
            // 
            // MemberInfoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 292);
            this.Controls.Add(this.tb_mid);
            this.Controls.Add(this.group_add_remov);
            this.Controls.Add(this.rb_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MemberInfoUI";
            this.Text = "MemberInfoUI";
            this.Load += new System.EventHandler(this.MemberInfoUI_Load);
            this.rb_1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_1)).EndInit();
            this.group_add_remov.ResumeLayout(false);
            this.group_add_remov.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox rb_1;
        private System.Windows.Forms.DataGridView gv_1;
        private System.Windows.Forms.GroupBox group_add_remov;
        private System.Windows.Forms.Button bt_alter;
        private System.Windows.Forms.Button bt_Remove;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_level;
        private System.Windows.Forms.Label lb_phone;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_level;
        private System.Windows.Forms.TextBox tb_money;
        private System.Windows.Forms.Label lb_money;
        private System.Windows.Forms.DataGridViewTextBoxColumn level;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn money;
        private System.Windows.Forms.DataGridViewTextBoxColumn mid;
        private System.Windows.Forms.TextBox tb_mid;
    }
}