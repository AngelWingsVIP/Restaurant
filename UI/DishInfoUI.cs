using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using BLL;
using Common;
namespace UI
{
    public partial class DishInfoUI : Form
    {
        public DishInfoUI()
        {
            InitializeComponent();
        }
        DishInfoBLL dibll = new DishInfoBLL();
        private void   GetDataList()
        {
            gv_1.AutoGenerateColumns = false;

            gv_1.DataSource=dibll.GetDataList();

            gv_1.ClearSelection();

        }
        private void loadtypelist()
        {
            var list = dibll.GetDataList();

            list.Insert(0, new DishInfo()
            {
                Did=0,
                DTitle="全部"
            });

            cb_box1.DisplayMember = "DTitle";
            cb_box1.ValueMember = "Did";
            cb_box1.DataSource = list;

            list= dibll.GetDataList();

            cb_box2.DisplayMember = "DTypeId";
            cb_box2.ValueMember = "Did";
            cb_box2.DataSource = list;

        }
        private void DishInfoUI_Load(object sender, EventArgs e)
        {
            this.GetDataList();
            loadtypelist();
        }
    }
}
