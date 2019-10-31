using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UI
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            if (this.Tag.ToString()=="0")
            {
                ms_Manager.Visible = false;

            }
        }

        private void ms_Manager_Click(object sender, EventArgs e)
        {
            ManagerInfoList mi_from = new ManagerInfoList();

            mi_from.ShowDialog();

        }

        private void ms_Member_Click(object sender, EventArgs e)
        {
            MemberTypeList mtl = new MemberTypeList();

            mtl.ShowDialog();

        }

        private void ms_Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ms_Menu_Click(object sender, EventArgs e)
        {
            DishTypeInfoUI dti = new DishTypeInfoUI();

            dti.ShowDialog();
        }
    }
}
