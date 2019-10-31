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
    public partial class DishTypeInfoUI : Form
    {
        public DishTypeInfoUI()
        {
            InitializeComponent();
        }

        DishTypeInfoBLL dtibll = new DishTypeInfoBLL();

        private void GetDataList()
        {
            gv_1.AutoGenerateColumns = false;

            gv_1.DataSource=dtibll.GetDishTypeList();

            gv_1.ClearSelection();

        }
        private void DishTypeInfoUI_Load(object sender, EventArgs e)
        {
            this.GetDataList();
        }

        private void gv_1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex!=-1)
            {
               var row = gv_1.Rows;

                tb_menu.Text = row[e.RowIndex].Cells[0].Value.ToString();
                tb_name.Text = row[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            DishTypeInfo dti = new DishTypeInfo();

            dti.Did =Convert.ToInt32(tb_menu.Text);

            dti.Dtitle = tb_name.Text;

            if (dtibll.Add(dti))
            {
                this.GetDataList();
            }
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            tb_menu.Clear();
            tb_name.Clear();
        }

        private void bt_alter_Click(object sender, EventArgs e)
        {
            DishTypeInfo dti = new DishTypeInfo();

            dti.Did = Convert.ToInt32(tb_menu.Text); 

            dti.Dtitle = tb_name.Text;

            if (dtibll.Alert(dti, Convert.ToInt32(gv_1.SelectedRows[0].Cells[0].Value)))
            {
                this.GetDataList();
            }
        }

        private void bt_Remove_Click(object sender, EventArgs e)
        {
            if (dtibll.Remove(Convert.ToInt32(tb_menu.Text)))
            {
                this.GetDataList();
            }
        }
    }
}
