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
using System.Xml.Linq;
using System.Diagnostics;

namespace Order_Management_System_OMS_
{
    public partial class uCtrlOrder : UserControl
    {
        public uCtrlOrder()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        DataTable dtCart = new DataTable();
        public double orderTotal = 0, itemTotal = 0;
        public int itemID = 0, quantity = 0, customerID;
        public string name, price;
        int numOfRows = 0;
        private void uCtrlOrder_Load(object sender, EventArgs e)
        {
            FillComboBox();
            dgvItem.DataSource = bll.GetProductForOder();
            lblOrderDate.Text = DateTime.Now.ToString();
        }
        private void FillComboBox()
        {
            cmbCustomer.Items.Clear();
            cmbCustomer.DataSource = bll.GetClients();
            cmbCustomer.DisplayMember = "Name";
            cmbCustomer.ValueMember = "CustomerID";
            
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            customerID = int.Parse(cmbCustomer.SelectedValue.ToString());
       
            Order order = new Order(customerID, DateTime.Now);
            int x = bll.InsertOrder(order);

            DataTable dt = new DataTable();
            dt.Columns.Add("orderID", typeof(int));
            dt = bll.GetOrderID(); 
            int orderID = int.Parse(dt.Rows[0]["OrderID"].ToString());
            dt.Rows.Add(orderID);
            int i = 0;

            while (i < dgvOrderItem.RowCount -1)
            {
                int itemID = int.Parse(dtCart.Rows[i]["ItemID"].ToString());
                int quantity = int.Parse(dtCart.Rows[i]["Quantity"].ToString());

                order = new Order(orderID, quantity, itemID);
                x = bll.InsertOrderItem(order);
                i++;
            }

            dtCart.Rows.Clear();
            dgvOrderItem.DataSource = dtCart;
            dgvOrderItem.Refresh();
        }
       
        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCustomerName.Text = cmbCustomer.Text;
            
        }

        private void dgvItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvItem.Rows[e.RowIndex];

                itemID = int.Parse(row.Cells[0].Value.ToString());
                name = row.Cells[1].Value.ToString();
                price= row.Cells[4].Value.ToString();
            }
        }
        
        private void btnAddItem_Click(object sender, EventArgs e)
        {
           quantity = (int)nQuantity.Value;
            string message = "Name: " + name + "\n" + "Quantity: " + quantity + "\n" + "Price: " + price;
            MessageBox.Show("You are about to Add " +"\n\n" + message + " to your Cart");
            if( dgvOrderItem.DataSource == null)
            {
                dtCart.Columns.AddRange(new DataColumn[4] { new DataColumn("ItemID"), new DataColumn("ItemName"), new DataColumn("Price"), new DataColumn("Quantity") });
                dtCart.Rows.Add(itemID, name, price, quantity);
            }
            else if( dgvOrderItem.DataSource != null)
            {
                dtCart.Rows.Add(itemID, name, price, quantity);
            }

            dgvOrderItem.DataSource = dtCart;

            while (numOfRows < dtCart.Rows.Count)
            {
                orderTotal += int.Parse(dtCart.Rows[numOfRows]["Price"].ToString()) * int.Parse(dtCart.Rows[numOfRows]["Quantity"].ToString());
                numOfRows++;
            }
            lblTotalPrice.Text = orderTotal.ToString("C");
        }
    }
}
