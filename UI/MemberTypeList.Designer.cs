namespace UI
{
    partial class MemberTypeList
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
            this.rb_1 = new System.Windows.Forms.GroupBox();
            this.gv_1 = new System.Windows.Forms.DataGridView();
            this.level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group_add_remov = new System.Windows.Forms.GroupBox();
            this.bt_alter = new System.Windows.Forms.Button();
            this.bt_Remove = new System.Windows.Forms.Button();
            this.lb_tip2 = new System.Windows.Forms.Label();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.tb_discount = new System.Windows.Forms.TextBox();
            this.tb_type = new System.Windows.Forms.TextBox();
            this.tb_level = new System.Windows.Forms.TextBox();
            this.lb_discount = new System.Windows.Forms.Label();
            this.lb_type = new System.Windows.Forms.Label();
            this.lb_level = new System.Windows.Forms.Label();
            this.rb_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_1)).BeginInit();
            this.group_add_remov.SuspendLayout();
            this.SuspendLayout();
            // 
            // rb_1
            // 
            this.rb_1.Controls.Add(this.gv_1);
            this.rb_1.Location = new System.Drawing.Point(1, 4);
            this.rb_1.Name = "rb_1";
            this.rb_1.Size = new System.Drawing.Size(356, 283);
            this.rb_1.TabIndex = 0;
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
            this.type,
            this.discount});
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
            this.gv_1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_1_CellDoubleClick);
            // 
            // level
            // 
            this.level.DataPropertyName = "Mid";
            this.level.HeaderText = "级别";
            this.level.Name = "level";
            this.level.ReadOnly = true;
            // 
            // type
            // 
            this.type.DataPropertyName = "MTitle";
            this.type.HeaderText = "类型";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // discount
            // 
            this.discount.DataPropertyName = "Mdiscount";
            this.discount.HeaderText = "折扣";
            this.discount.Name = "discount";
            this.discount.ReadOnly = true;
            // 
            // group_add_remov
            // 
            this.group_add_remov.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.group_add_remov.Controls.Add(this.bt_alter);
            this.group_add_remov.Controls.Add(this.bt_Remove);
            this.group_add_remov.Controls.Add(this.lb_tip2);
            this.group_add_remov.Controls.Add(this.bt_cancel);
            this.group_add_remov.Controls.Add(this.bt_add);
            this.group_add_remov.Controls.Add(this.tb_discount);
            this.group_add_remov.Controls.Add(this.tb_type);
            this.group_add_remov.Controls.Add(this.tb_level);
            this.group_add_remov.Controls.Add(this.lb_discount);
            this.group_add_remov.Controls.Add(this.lb_type);
            this.group_add_remov.Controls.Add(this.lb_level);
            this.group_add_remov.Location = new System.Drawing.Point(360, 23);
            this.group_add_remov.Name = "group_add_remov";
            this.group_add_remov.Size = new System.Drawing.Size(254, 263);
            this.group_add_remov.TabIndex = 3;
            this.group_add_remov.TabStop = false;
            this.group_add_remov.Text = "添加V修改";
            // 
            // bt_alter
            // 
            this.bt_alter.Location = new System.Drawing.Point(85, 138);
            this.bt_alter.Name = "bt_alter";
            this.bt_alter.Size = new System.Drawing.Size(75, 23);
            this.bt_alter.TabIndex = 22;
            this.bt_alter.Text = "修改";
            this.bt_alter.UseVisualStyleBackColor = true;
            this.bt_alter.Click += new System.EventHandler(this.bt_alter_Click);
            // 
            // bt_Remove
            // 
            this.bt_Remove.Location = new System.Drawing.Point(21, 209);
            this.bt_Remove.Name = "bt_Remove";
            this.bt_Remove.Size = new System.Drawing.Size(198, 33);
            this.bt_Remove.TabIndex = 20;
            this.bt_Remove.Text = "删除选中类型及会员信息";
            this.bt_Remove.UseVisualStyleBackColor = true;
            this.bt_Remove.Click += new System.EventHandler(this.bt_Remove_Click);
            // 
            // lb_tip2
            // 
            this.lb_tip2.AutoSize = true;
            this.lb_tip2.ForeColor = System.Drawing.Color.Red;
            this.lb_tip2.Location = new System.Drawing.Point(6, 178);
            this.lb_tip2.Name = "lb_tip2";
            this.lb_tip2.Size = new System.Drawing.Size(221, 12);
            this.lb_tip2.TabIndex = 21;
            this.lb_tip2.Text = "提示：双击表格项可以查看会员信息列表";
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(162, 138);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_cancel.TabIndex = 19;
            this.bt_cancel.Text = "重置";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(6, 138);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(75, 23);
            this.bt_add.TabIndex = 18;
            this.bt_add.Text = "添加";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // tb_discount
            // 
            this.tb_discount.Location = new System.Drawing.Point(64, 92);
            this.tb_discount.Name = "tb_discount";
            this.tb_discount.Size = new System.Drawing.Size(155, 21);
            this.tb_discount.TabIndex = 5;
            // 
            // tb_type
            // 
            this.tb_type.Location = new System.Drawing.Point(64, 63);
            this.tb_type.Name = "tb_type";
            this.tb_type.Size = new System.Drawing.Size(155, 21);
            this.tb_type.TabIndex = 4;
            // 
            // tb_level
            // 
            this.tb_level.ForeColor = System.Drawing.Color.Red;
            this.tb_level.Location = new System.Drawing.Point(64, 28);
            this.tb_level.Name = "tb_level";
            this.tb_level.Size = new System.Drawing.Size(155, 21);
            this.tb_level.TabIndex = 3;
            // 
            // lb_discount
            // 
            this.lb_discount.AutoSize = true;
            this.lb_discount.Location = new System.Drawing.Point(12, 96);
            this.lb_discount.Name = "lb_discount";
            this.lb_discount.Size = new System.Drawing.Size(41, 12);
            this.lb_discount.TabIndex = 2;
            this.lb_discount.Text = "折扣：";
            // 
            // lb_type
            // 
            this.lb_type.AutoSize = true;
            this.lb_type.Location = new System.Drawing.Point(12, 66);
            this.lb_type.Name = "lb_type";
            this.lb_type.Size = new System.Drawing.Size(41, 12);
            this.lb_type.TabIndex = 1;
            this.lb_type.Text = "类型：";
            // 
            // lb_level
            // 
            this.lb_level.AutoSize = true;
            this.lb_level.Location = new System.Drawing.Point(12, 33);
            this.lb_level.Name = "lb_level";
            this.lb_level.Size = new System.Drawing.Size(41, 12);
            this.lb_level.TabIndex = 0;
            this.lb_level.Text = "级别：";
            // 
            // MemberTypeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 291);
            this.Controls.Add(this.group_add_remov);
            this.Controls.Add(this.rb_1);
            this.Name = "MemberTypeList";
            this.Text = "MemberTypeList";
            this.Load += new System.EventHandler(this.MemberTypeList_Load);
            this.rb_1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_1)).EndInit();
            this.group_add_remov.ResumeLayout(false);
            this.group_add_remov.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox rb_1;
        private System.Windows.Forms.DataGridView gv_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn level;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
        private System.Windows.Forms.GroupBox group_add_remov;
        private System.Windows.Forms.Button bt_alter;
        private System.Windows.Forms.Button bt_Remove;
        private System.Windows.Forms.Label lb_tip2;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.TextBox tb_discount;
        private System.Windows.Forms.TextBox tb_type;
        private System.Windows.Forms.TextBox tb_level;
        private System.Windows.Forms.Label lb_discount;
        private System.Windows.Forms.Label lb_type;
        private System.Windows.Forms.Label lb_level;
    }
}