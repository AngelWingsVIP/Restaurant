using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Configuration;
using Model;
using BLL;
using Common;
namespace UI
{
    public partial class ManagerInfoList : Form
    {
        public ManagerInfoList()
        {
            InitializeComponent();
        }

     

        ManagerInfoBLL mbll = new ManagerInfoBLL();
        private void ManergerInfoList_Load(object sender, EventArgs e)
        {
            //1.创建连接
            //2.打开连接
            //3.执行SQL语句
            //4.获取结果
            //5.使用结果


            //取消自动生成列

            gv_list.AutoGenerateColumns = false;

            this.load_list();



        }

        private void load_list()
        {
            //绑定数据

            gv_list.DataSource = mbll.GetManagerInfoList();

            //清空默认选项
            gv_list.ClearSelection();
        }

        private void gv_list_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex==2)
            {
                switch (e.Value)
                {
                    case 0:
                        e.Value = "店员";
                        break;
                    case 1:
                        e.Value = "经理";
                        break;
                    default:
                        break;
                }
            }
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            ManagerInfo mi = new ManagerInfo() {

                Mname = tb_uname.Text,
                Mpwd = MD5Helper.Md5_Encrypt(tb_pwd.Text),
                Mtype = rb_1.Checked ? 1 : 0
            };

            if (mbll.Add(mi))
            {
                MessageBox.Show("succse", "tip");
                this.load_list();

            }
            else
            {
                MessageBox.Show("error", "tip");
            }


        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            tb_mid.Clear();
            tb_uname.Clear();
            tb_pwd.Clear();
            rb_2.Checked = true;

        }

        private void bt_Remove_Click(object sender, EventArgs e)
        {
            var rows    =   gv_list.SelectedRows;
            if (rows.Count>0)
            {
               DialogResult result = MessageBox.Show("确定删除吗？", "tip", MessageBoxButtons.OKCancel);

                if (result==DialogResult.OK)
                {
                    int id = Convert.ToInt32(rows[0].Cells[0].Value);

                    if (mbll.Remove(id)!=0)
                    {
                        this.load_list();

                    }
                }

            }
            else
            {
                MessageBox.Show("SB？你选了吗？");
            }
        }

        private void gv_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex!=-1)
            {
                var row = gv_list.Rows[e.RowIndex];

                tb_mid.Text = row.Cells[0].Value.ToString();

                tb_uname.Text = row.Cells[1].Value.ToString();

                

                if (row.Cells[2].Value.ToString() == "1")
                {
                    rb_1.Checked = true;
                }
                else
                {
                    rb_2.Checked = true;
                }
            }
            
            
        }

        private void bt_alter_Click(object sender, EventArgs e)
        {
            ManagerInfo mi = new ManagerInfo()
            {
                Mid = Convert.ToInt32(tb_mid.Text),
                Mname = tb_uname.Text,
                Mpwd = MD5Helper.Md5_Encrypt(tb_pwd.Text),
                Mtype  = rb_2.Checked ? 0 : 1
            };

            if (mbll.alter(mi)!=0)
            {
                this.load_list();
            }
        }

        private void ManergerInfoList_FormClosing(object sender, FormClosingEventArgs e)
        {
           

        }

        private string Event_save()
        {
            OpenFileDialog openfile = new OpenFileDialog();
            //初始显示文件目录
            //openfile.InitialDirectory = @"";
            openfile.Title = "请选择要导入的文件";
            //过滤文件类型
            openfile.Filter = "Excel|*.xls|可执行文件|*.exe|STOCK|STOCK.txt|所有文件类型|*.*";
            if (DialogResult.OK == openfile.ShowDialog())
            {
                //将选择的文件的全路径赋值给文本框
                //MessageBox.Show(openfile.FileName.ToString());
                return openfile.FileName;
            }
            else
            {
                return null;
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ExcelHelper.CreateWork();

            //ExcelHelper.CreateSheet("fuck");

            //List<string>str = new List<string>{ };

            //List<string> str2 = new List<string> { };

            //List<ManagerInfo> mi = mbll.GetManagerInfoList();

            //str2.Add("mid"); str2.Add("user"); str2.Add("passwrod"); str2.Add("type");


            //for (int i = 0; i < mi.Count; i++)
            //{
            //    str.Add(mi[i].Mid.ToString());
            //    str.Add(mi[i].Mname.ToString());
            //    str.Add(mi[i].Mpwd.ToString());
            //    str.Add(mi[i].Mtype.ToString());
            //}

            //ExcelHelper.CreateRow_Cell(str.Count()/4,str2.Count(),1);

            //ExcelHelper.SetCellHead(str2.ToArray());

            //ExcelHelper.Full(str.ToArray());

            //ExcelHelper.Save(@"E:\4.三层综合项目-餐桌管理 厅包管理 Excel操作\视频\1111.xls");

            //ExcelHelper.GetFilename += Event_save;

            //Dictionary<int, string[]> data =  ExcelHelper.ImportExcell();

            //List<ManagerInfo> list = new List<ManagerInfo>();

            //for (int i = 0; i < data.Keys.Count(); i++)
            //{
               
            //    for (int j = 0; j < 1; j++)
            //    {
            //        list.Add(new ManagerInfo()
            //        {
            //            Mid = Convert.ToInt32(data.ElementAt(i).Value[0]),
            //            Mname = data.ElementAt(i).Value[1],
            //            Mpwd = data.ElementAt(i).Value[2],
            //            Mtype = Convert.ToInt32(data.ElementAt(i).Value[3])

            //        });

            //    }
            //}
            //gv_list.DataSource = list;



        }
    }
}
