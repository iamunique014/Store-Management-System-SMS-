using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;

namespace Order_Management_System_OMS_
{
    public partial class uCtrlCategory : UserControl
    {
        public uCtrlCategory()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Category category = new Category(txtCategory.Text);
            int x = bll.InsertDescription(category);
            dgvCategory.DataSource = bll.GetDescription();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Category category = new Category(txtCategory.Text);
            int x = bll.DeleteDescription(category);
            dgvCategory.DataSource = bll.GetDescription();
        }

        private void uCtrlCategory_Load(object sender, EventArgs e)
        {
            dgvCategory.DataSource = bll.GetDescription();
        }
    }
}
