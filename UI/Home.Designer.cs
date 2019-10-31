namespace UI
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.menu_strip1 = new System.Windows.Forms.MenuStrip();
            this.ms_Manager = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_Member = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_Table = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_Pay = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_Quit = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_strip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_strip1
            // 
            this.menu_strip1.ImageScalingSize = new System.Drawing.Size(100, 100);
            this.menu_strip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_Manager,
            this.ms_Member,
            this.ms_Menu,
            this.ms_Table,
            this.ms_Pay,
            this.ms_Quit});
            this.menu_strip1.Location = new System.Drawing.Point(0, 0);
            this.menu_strip1.Name = "menu_strip1";
            this.menu_strip1.Size = new System.Drawing.Size(692, 108);
            this.menu_strip1.TabIndex = 0;
            this.menu_strip1.Text = "menuStrip1";
            // 
            // ms_Manager
            // 
            this.ms_Manager.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ms_Manager.Image = ((System.Drawing.Image)(resources.GetObject("ms_Manager.Image")));
            this.ms_Manager.Name = "ms_Manager";
            this.ms_Manager.Size = new System.Drawing.Size(112, 104);
            this.ms_Manager.Text = "Manager";
            this.ms_Manager.Click += new System.EventHandler(this.ms_Manager_Click);
            // 
            // ms_Member
            // 
            this.ms_Member.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ms_Member.Image = ((System.Drawing.Image)(resources.GetObject("ms_Member.Image")));
            this.ms_Member.Name = "ms_Member";
            this.ms_Member.Size = new System.Drawing.Size(112, 104);
            this.ms_Member.Text = "Member";
            this.ms_Member.Click += new System.EventHandler(this.ms_Member_Click);
            // 
            // ms_Menu
            // 
            this.ms_Menu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ms_Menu.Image = ((System.Drawing.Image)(resources.GetObject("ms_Menu.Image")));
            this.ms_Menu.Name = "ms_Menu";
            this.ms_Menu.Size = new System.Drawing.Size(112, 104);
            this.ms_Menu.Text = "Menu";
            this.ms_Menu.Click += new System.EventHandler(this.ms_Menu_Click);
            // 
            // ms_Table
            // 
            this.ms_Table.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ms_Table.Image = ((System.Drawing.Image)(resources.GetObject("ms_Table.Image")));
            this.ms_Table.Name = "ms_Table";
            this.ms_Table.Size = new System.Drawing.Size(112, 104);
            this.ms_Table.Text = "Table";
            // 
            // ms_Pay
            // 
            this.ms_Pay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ms_Pay.Image = ((System.Drawing.Image)(resources.GetObject("ms_Pay.Image")));
            this.ms_Pay.Name = "ms_Pay";
            this.ms_Pay.Size = new System.Drawing.Size(112, 104);
            this.ms_Pay.Text = "Pay";
            // 
            // ms_Quit
            // 
            this.ms_Quit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ms_Quit.Image = ((System.Drawing.Image)(resources.GetObject("ms_Quit.Image")));
            this.ms_Quit.Name = "ms_Quit";
            this.ms_Quit.Size = new System.Drawing.Size(112, 104);
            this.ms_Quit.Text = "Quit";
            this.ms_Quit.Click += new System.EventHandler(this.ms_Quit_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 450);
            this.Controls.Add(this.menu_strip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menu_strip1;
            this.MaximizeBox = false;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menu_strip1.ResumeLayout(false);
            this.menu_strip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu_strip1;
        private System.Windows.Forms.ToolStripMenuItem ms_Manager;
        private System.Windows.Forms.ToolStripMenuItem ms_Member;
        private System.Windows.Forms.ToolStripMenuItem ms_Menu;
        private System.Windows.Forms.ToolStripMenuItem ms_Table;
        private System.Windows.Forms.ToolStripMenuItem ms_Pay;
        private System.Windows.Forms.ToolStripMenuItem ms_Quit;
    }
}