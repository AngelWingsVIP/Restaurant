namespace UI
{
    partial class DishInfoUI
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
            this.group = new System.Windows.Forms.GroupBox();
            this.gv_1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_ShowAll = new System.Windows.Forms.Button();
            this.cb_box1 = new System.Windows.Forms.ComboBox();
            this.tb_name1 = new System.Windows.Forms.TextBox();
            this.lb_type1 = new System.Windows.Forms.Label();
            this.lb_name1 = new System.Windows.Forms.Label();
            this.did = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.py = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_manage = new System.Windows.Forms.Button();
            this.cb_box2 = new System.Windows.Forms.ComboBox();
            this.tb_name2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // group
            // 
            this.group.Controls.Add(this.gv_1);
            this.group.Location = new System.Drawing.Point(8, 8);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(514, 430);
            this.group.TabIndex = 0;
            this.group.TabStop = false;
            this.group.Text = "列表";
            // 
            // gv_1
            // 
            this.gv_1.AllowUserToAddRows = false;
            this.gv_1.AllowUserToDeleteRows = false;
            this.gv_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.did,
            this.name,
            this.type,
            this.money,
            this.py});
            this.gv_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_1.Location = new System.Drawing.Point(3, 17);
            this.gv_1.MultiSelect = false;
            this.gv_1.Name = "gv_1";
            this.gv_1.ReadOnly = true;
            this.gv_1.RowTemplate.Height = 23;
            this.gv_1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_1.Size = new System.Drawing.Size(508, 410);
            this.gv_1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_ShowAll);
            this.groupBox1.Controls.Add(this.cb_box1);
            this.groupBox1.Controls.Add(this.tb_name1);
            this.groupBox1.Controls.Add(this.lb_type1);
            this.groupBox1.Controls.Add(this.lb_name1);
            this.groupBox1.Location = new System.Drawing.Point(530, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 116);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "搜索";
            // 
            // bt_ShowAll
            // 
            this.bt_ShowAll.Location = new System.Drawing.Point(24, 83);
            this.bt_ShowAll.Name = "bt_ShowAll";
            this.bt_ShowAll.Size = new System.Drawing.Size(189, 24);
            this.bt_ShowAll.TabIndex = 4;
            this.bt_ShowAll.Text = "显 示 全 部";
            this.bt_ShowAll.UseVisualStyleBackColor = true;
            // 
            // cb_box1
            // 
            this.cb_box1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_box1.FormattingEnabled = true;
            this.cb_box1.Items.AddRange(new object[] {
            "1"});
            this.cb_box1.Location = new System.Drawing.Point(53, 57);
            this.cb_box1.Name = "cb_box1";
            this.cb_box1.Size = new System.Drawing.Size(160, 20);
            this.cb_box1.TabIndex = 3;
            // 
            // tb_name1
            // 
            this.tb_name1.Location = new System.Drawing.Point(51, 27);
            this.tb_name1.Name = "tb_name1";
            this.tb_name1.Size = new System.Drawing.Size(163, 21);
            this.tb_name1.TabIndex = 2;
            // 
            // lb_type1
            // 
            this.lb_type1.AutoSize = true;
            this.lb_type1.Location = new System.Drawing.Point(8, 61);
            this.lb_type1.Name = "lb_type1";
            this.lb_type1.Size = new System.Drawing.Size(47, 12);
            this.lb_type1.TabIndex = 1;
            this.lb_type1.Text = "分 类：";
            // 
            // lb_name1
            // 
            this.lb_name1.AutoSize = true;
            this.lb_name1.Location = new System.Drawing.Point(8, 30);
            this.lb_name1.Name = "lb_name1";
            this.lb_name1.Size = new System.Drawing.Size(47, 12);
            this.lb_name1.TabIndex = 0;
            this.lb_name1.Text = "名 称：";
            // 
            // did
            // 
            this.did.DataPropertyName = "did";
            this.did.HeaderText = "编号";
            this.did.Name = "did";
            this.did.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "DTitle";
            this.name.HeaderText = "名称";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // type
            // 
            this.type.DataPropertyName = "DTypeId";
            this.type.HeaderText = "分类";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // money
            // 
            this.money.DataPropertyName = "DPrice";
            this.money.HeaderText = "价格";
            this.money.Name = "money";
            this.money.ReadOnly = true;
            // 
            // py
            // 
            this.py.DataPropertyName = "DChar";
            this.py.HeaderText = "拼音";
            this.py.Name = "py";
            this.py.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_id);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.bt_manage);
            this.groupBox2.Controls.Add(this.cb_box2);
            this.groupBox2.Controls.Add(this.tb_name2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(530, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 154);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "添加-修改";
            // 
            // bt_manage
            // 
            this.bt_manage.Location = new System.Drawing.Point(34, 112);
            this.bt_manage.Name = "bt_manage";
            this.bt_manage.Size = new System.Drawing.Size(163, 24);
            this.bt_manage.TabIndex = 4;
            this.bt_manage.Text = "分 类 管 理";
            this.bt_manage.UseVisualStyleBackColor = true;
            // 
            // cb_box2
            // 
            this.cb_box2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_box2.FormattingEnabled = true;
            this.cb_box2.Items.AddRange(new object[] {
            "1"});
            this.cb_box2.Location = new System.Drawing.Point(53, 86);
            this.cb_box2.Name = "cb_box2";
            this.cb_box2.Size = new System.Drawing.Size(160, 20);
            this.cb_box2.TabIndex = 3;
            // 
            // tb_name2
            // 
            this.tb_name2.Location = new System.Drawing.Point(51, 53);
            this.tb_name2.Name = "tb_name2";
            this.tb_name2.Size = new System.Drawing.Size(163, 21);
            this.tb_name2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "分 类：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "名 称：";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(51, 21);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(163, 21);
            this.tb_id.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "编 号：";
            // 
            // DishInfoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.group);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DishInfoUI";
            this.Text = "DishInfoUI";
            this.Load += new System.EventHandler(this.DishInfoUI_Load);
            this.group.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group;
        private System.Windows.Forms.DataGridView gv_1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_ShowAll;
        private System.Windows.Forms.ComboBox cb_box1;
        private System.Windows.Forms.TextBox tb_name1;
        private System.Windows.Forms.Label lb_type1;
        private System.Windows.Forms.Label lb_name1;
        private System.Windows.Forms.DataGridViewTextBoxColumn did;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn money;
        private System.Windows.Forms.DataGridViewTextBoxColumn py;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_manage;
        private System.Windows.Forms.ComboBox cb_box2;
        private System.Windows.Forms.TextBox tb_name2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}