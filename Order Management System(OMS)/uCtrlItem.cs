using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DAL;
using BLL;
namespace Order_Management_System_OMS_
{
    public partial class uCtrlItem : UserControl
    {
        public uCtrlItem()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        string categoryID = "2";
        string itemID = "1";
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            categoryID = cmbCategory.SelectedValue.ToString();
            Item item = new Item(int.Parse(categoryID), int.Parse(itemID), txtName.Text, txtDesign.Text, txtPrice.Text, DateTime.Parse(dtpItemDate.Text));
            int x = bll.UpdateProduct(item);
            dgvItems.DataSource = bll.GetProduct();
            MessageBox.Show("Item Updated");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Item item = new Item(int.Parse(itemID));
            int x = bll.DeleteProduct(item);
            dgvItems.DataSource= bll.GetProduct();
            MessageBox.Show("Item Deleted!");
        }

        private void uCtrlItem_Load(object sender, EventArgs e)
        {
            FillComboBox();
            dgvItems.DataSource = bll.GetProduct();
        }

        private void FillComboBox()
        {
            cmbCategory.Items.Clear();
            cmbCategory.DataSource = bll.GetDescription();
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryID";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            categoryID = cmbCategory.SelectedValue.ToString();
            Item item = new Item(int.Parse(categoryID), int.Parse(itemID),txtName.Text, txtDesign.Text, txtPrice.Text, DateTime.Parse(dtpItemDate.Text));
            int x = bll.InsertProduct(item);
            dgvItems.DataSource = bll.GetProduct();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        { 
            dgvItems.DataSource = bll.SearchProduct(txtName.Text);
        }

        private void dgvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvItems.Rows[e.RowIndex];

                itemID = row.Cells[0].Value.ToString(); 
                txtName.Text = row.Cells[1].Value.ToString();
                cmbCategory.Text = row.Cells[2].Value.ToString();
                txtDesign.Text = row.Cells[3].Value.ToString();
                txtPrice.Text = row.Cells[4].Value.ToString();
            }
        }
    }
}
