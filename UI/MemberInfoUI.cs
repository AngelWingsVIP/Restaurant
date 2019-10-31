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
    public partial class MemberInfoUI : Form
    {
        List<TextBox> tb = new List<TextBox>();
        public MemberInfoUI()
        {

            InitializeComponent();

            tb.Add(tb_level);
            tb.Add(tb_name);
            tb.Add(tb_phone);
            tb.Add(tb_money);
            tb.Add(tb_mid);

        }

        MemberInfoBLL mib = new MemberInfoBLL();

       
        
        private void GetDatalist()
        {
            gv_1.AutoGenerateColumns = false;

            gv_1.DataSource = mib.GetMemberInfoList(Convert.ToInt32(this.Tag));

            gv_1.ClearSelection();

        }
        private void MemberInfoUI_Load(object sender, EventArgs e)
        {

            this.GetDatalist();

        }

        private void gv_1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex!=-1)
            {
                var row = gv_1.Rows;

                tb_level.Text = row[e.RowIndex].Cells[0].Value.ToString();
                tb_name.Text = row[e.RowIndex].Cells[1].Value.ToString();
                tb_phone.Text = row[e.RowIndex].Cells[2].Value.ToString();
                tb_money.Text = row[e.RowIndex].Cells[3].Value.ToString();
                tb_mid.Text= row[e.RowIndex].Cells[4].Value.ToString();
            }

        }

       
        private void bt_add_Click(object sender, EventArgs e)
        {
            MemberInfo mi = new MemberInfo();

            mi.MName = tb_name.Text;

            mi.MTypeid = Convert.ToInt32(tb_level.Text);

            mi.MMoney = Convert.ToDecimal(tb_money.Text);

            mi.Mphone = tb_phone.Text;

            if (mib.Add(mi))
            {
                this.GetDatalist();
            }

        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            foreach (var item in tb)
            {
                item.Clear();
            }
        }

        private void bt_alter_Click(object sender, EventArgs e)
        {
            MemberInfo mi = new MemberInfo();

            mi.MTypeid = Convert.ToInt32(tb[0].Text);
            mi.MName = tb[1].Text;
            mi.Mphone = tb[2].Text;
            mi.MMoney = Convert.ToDecimal(tb[3].Text);
            mi.Mid  = Convert.ToInt32(tb[4].Text);

            if (mib.Alert(mi))
            {
                this.GetDatalist();
            }
        }

        private void bt_Remove_Click(object sender, EventArgs e)
        {
            if (mib.Remov(Convert.ToInt32(tb[4].Text)))
            {
                this.GetDatalist();
            }
        }
    }
}
