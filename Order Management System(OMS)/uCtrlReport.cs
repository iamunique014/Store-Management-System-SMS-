using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Order_Management_System_OMS_
{
    public partial class uCtrlReport : UserControl
    {
        public uCtrlReport()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        DataAccessOrder order = new DataAccessOrder();
        private void uCtrlReport_Load(object sender, EventArgs e)
        {
            FillComboBox();
           
        }
        private void FillComboBox()
        {
            cmbCustomer.Items.Clear();
            cmbCustomer.DataSource = bll.GetClients();
            cmbCustomer.DisplayMember = "Name";
            cmbCustomer.ValueMember = "CustomerID";

        }

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCustomerName.Text = cmbCustomer.Text;
            int customerID; 
            Int32.TryParse(cmbCustomer.SelectedValue.ToString(), out customerID);

            Order order = new Order(customerID, DateTime.Now);
            dgvOrder.DataSource = bll.GetCustomerOrders(order);
        }

        private void dgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int orderID = 0;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvOrder.Rows[e.RowIndex];
                orderID = int.Parse(row.Cells[0].Value.ToString());
                lblOrderDate.Text = row.Cells[2].Value.ToString();
            }
            Order order = new Order(orderID);
            dgvOrderItem.DataSource = bll.GetOrderItem(order);

        }
    }
}
