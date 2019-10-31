using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Model;

namespace UI
{
    public partial class ManagerLogin : Form
    {
        public ManagerLogin()
        {
            InitializeComponent();
        }

        ManagerInfoBLL mbll = new ManagerInfoBLL();
        private void button1_Click(object sender, EventArgs e)
        {
            ManagerInfo mi = new ManagerInfo {

                Mname = tb_user.Text,
                Mpwd    =   tb_pwd.Text
            };

            if (mbll.Login(mi))  //登录账号
            {
                Home mian = new Home();
                mian.Tag = mi.Mtype;
                mian.Show();
                this.Visible = false;

            }
            else
            {
                
                MessageBox.Show("账户或密码错误");
            }
            
        }
    }
}
