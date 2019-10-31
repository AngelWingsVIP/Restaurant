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
    public partial class MemberTypeList : Form
    {
        public MemberTypeList()
        {
            InitializeComponent();
        }

        MemberTypeBLL mbtbll = new MemberTypeBLL();

        private void GetDataList()          
        {
            gv_1.AutoGenerateColumns = false;

            gv_1.DataSource = mbtbll.GetMemberTypeInfo();

            gv_1.ClearSelection();

        }
        private void MemberTypeList_Load(object sender, EventArgs e)
        {

            this.GetDataList();


        }

        private void gv_1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex!=-1)
            {
              tb_level.Text = gv_1.Rows[e.RowIndex].Cells[0].Value.ToString(); 
                
                tb_type.Text = gv_1.Rows[e.RowIndex].Cells[1].Value.ToString();

                tb_discount.Text = gv_1.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
         
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            tb_level.Clear();

            tb_type.Clear();

            tb_discount.Clear();

        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            MemberTypeInfo mti = new MemberTypeInfo();

            if (tb_level.Text!="")
            {
                if (tb_type.Text!="")
                {
                    if (tb_discount.Text!="")
                    {
                        mti.Mid = Convert.ToInt32(tb_level.Text);

                        mti.Mtitle = tb_type.Text;

                        mti.Mdiscount = Convert.ToDecimal(tb_discount.Text);

                        if (mbtbll.Add(mti))
                        {
                            this.GetDataList();
                        }
                        else
                        {
                            MessageBox.Show("添加错误,级别已存在不能重复");
                        }
                    }
                    else
                    {
                        MessageBox.Show("折扣不能为空且不能是文字");
                    }
                }
                else
                {
                    MessageBox.Show("类型不能为空");
                }
            }
            else
            {
                MessageBox.Show("级别不能为空");
            }

           


        }

        private void bt_alter_Click(object sender, EventArgs e)
        {
            MemberTypeInfo mbi = new MemberTypeInfo();

            mbi.Mid = Convert.ToInt32(tb_level.Text);

            mbi.Mtitle = tb_type.Text;

            mbi.Mdiscount = Convert.ToDecimal(tb_discount.Text);


            if (mbtbll.Alert(mbi))
            {
                this.GetDataList();

                MessageBox.Show("修改成功");
                
            }

        }

        private void gv_1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex!=-1)
            {
                MemberInfoUI miui = new MemberInfoUI();

                miui.Tag = gv_1.Rows[e.RowIndex].Cells[0].Value;

                miui.ShowDialog();

            }
        }

        private void bt_Remove_Click(object sender, EventArgs e)
        {
          
            int index = Convert.ToInt32(gv_1.SelectedRows[0].Cells[0].Value);

            if (mbtbll.Remove(index))
            {
                this.GetDataList();
            }
        }
    }
}
