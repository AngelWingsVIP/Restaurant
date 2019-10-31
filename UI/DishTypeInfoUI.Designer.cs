namespace UI
{
    partial class DishTypeInfoUI
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
            this.bt_alter = new System.Windows.Forms.Button();
            this.bt_Remove = new System.Windows.Forms.Button();
            this.lb_tip2 = new System.Windows.Forms.Label();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_menu = new System.Windows.Forms.TextBox();
            this.lb_type = new System.Windows.Forms.Label();
            this.lb_level = new System.Windows.Forms.Label();
            this.rb_1 = new System.Windows.Forms.GroupBox();
            this.gv_1 = new System.Windows.Forms.DataGridView();
            this.level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rb_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_alter
            // 
            this.bt_alter.Location = new System.Drawing.Point(452, 146);
            this.bt_alter.Name = "bt_alter";
            this.bt_alter.Size = new System.Drawing.Size(75, 23);
            this.bt_alter.TabIndex = 33;
            this.bt_alter.Text = "修改";
            this.bt_alter.UseVisualStyleBackColor = true;
            this.bt_alter.Click += new System.EventHandler(this.bt_alter_Click);
            // 
            // bt_Remove
            // 
            this.bt_Remove.Location = new System.Drawing.Point(386, 235);
            this.bt_Remove.Name = "bt_Remove";
            this.bt_Remove.Size = new System.Drawing.Size(198, 33);
            this.bt_Remove.TabIndex = 31;
            this.bt_Remove.Text = "删除选中菜型及菜谱";
            this.bt_Remove.UseVisualStyleBackColor = true;
            this.bt_Remove.Click += new System.EventHandler(this.bt_Remove_Click);
            // 
            // lb_tip2
            // 
            this.lb_tip2.AutoSize = true;
            this.lb_tip2.ForeColor = System.Drawing.Color.Red;
            this.lb_tip2.Location = new System.Drawing.Point(371, 201);
            this.lb_tip2.Name = "lb_tip2";
            this.lb_tip2.Size = new System.Drawing.Size(221, 12);
            this.lb_tip2.TabIndex = 32;
            this.lb_tip2.Text = "提示：双击表格项可以查看菜单信息列表";
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(529, 146);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_cancel.TabIndex = 30;
            this.bt_cancel.Text = "重置";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(373, 146);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(75, 23);
            this.bt_add.TabIndex = 29;
            this.bt_add.Text = "添加";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(436, 101);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(155, 21);
            this.tb_name.TabIndex = 27;
            // 
            // tb_menu
            // 
            this.tb_menu.ForeColor = System.Drawing.Color.Red;
            this.tb_menu.Location = new System.Drawing.Point(436, 59);
            this.tb_menu.Name = "tb_menu";
            this.tb_menu.Size = new System.Drawing.Size(155, 21);
            this.tb_menu.TabIndex = 26;
            // 
            // lb_type
            // 
            this.lb_type.AutoSize = true;
            this.lb_type.Location = new System.Drawing.Point(384, 104);
            this.lb_type.Name = "lb_type";
            this.lb_type.Size = new System.Drawing.Size(41, 12);
            this.lb_type.TabIndex = 24;
            this.lb_type.Text = "菜名：";
            // 
            // lb_level
            // 
            this.lb_level.AutoSize = true;
            this.lb_level.Location = new System.Drawing.Point(384, 64);
            this.lb_level.Name = "lb_level";
            this.lb_level.Size = new System.Drawing.Size(41, 12);
            this.lb_level.TabIndex = 23;
            this.lb_level.Text = "菜型：";
            // 
            // rb_1
            // 
            this.rb_1.Controls.Add(this.gv_1);
            this.rb_1.Location = new System.Drawing.Point(9, 7);
            this.rb_1.Name = "rb_1";
            this.rb_1.Size = new System.Drawing.Size(356, 283);
            this.rb_1.TabIndex = 34;
            this.rb_1.TabStop = false;
            this.rb_1.Text = "菜单列表";
            // 
            // gv_1
            // 
            this.gv_1.AllowUserToAddRows = false;
            this.gv_1.AllowUserToDeleteRows = false;
            this.gv_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.level,
            this.type});
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
            this.level.DataPropertyName = "Did";
            this.level.HeaderText = "菜型";
            this.level.Name = "level";
            this.level.ReadOnly = true;
            // 
            // type
            // 
            this.type.DataPropertyName = "DTitle";
            this.type.HeaderText = "菜名";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // DishTypeInfoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 301);
            this.Controls.Add(this.rb_1);
            this.Controls.Add(this.bt_alter);
            this.Controls.Add(this.bt_Remove);
            this.Controls.Add(this.lb_tip2);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_menu);
            this.Controls.Add(this.lb_type);
            this.Controls.Add(this.lb_level);
            this.Name = "DishTypeInfoUI";
            this.Text = "DishTypeInfoUI";
            this.Load += new System.EventHandler(this.DishTypeInfoUI_Load);
            this.rb_1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_alter;
        private System.Windows.Forms.Button bt_Remove;
        private System.Windows.Forms.Label lb_tip2;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_menu;
        private System.Windows.Forms.Label lb_type;
        private System.Windows.Forms.Label lb_level;
        private System.Windows.Forms.GroupBox rb_1;
        private System.Windows.Forms.DataGridView gv_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn level;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
    }
}