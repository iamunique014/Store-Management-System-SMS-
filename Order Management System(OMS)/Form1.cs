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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Form1 size = 1051, 655
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void Form1_Load(object sender, EventArgs e)
        {
            uCtrlCategory1.Hide();
            uCtrlItem1.Hide();
            uCtrlCustomer1.Hide();
            uCtrlOrder1.Hide();
            uCtrlReport1.Hide();
        }
        private void btnCategory_Click(object sender, EventArgs e)
        {
            uCtrlCustomer1.Hide();
            uCtrlItem1.Hide();
            uCtrlOrder1.Hide();
            uCtrlReport1.Hide();
            uCtrlCategory1.Show();
            uCtrlCategory1.BringToFront();
            lblHeading.Text = "Manage Store - Categories";
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            uCtrlCustomer1.Hide();
            uCtrlCategory1.Hide();
            uCtrlOrder1.Hide();
            uCtrlReport1.Hide();
            uCtrlItem1.Show();
            uCtrlItem1.BringToFront();
            lblHeading.Text = "Manage Store - Items";
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            uCtrlItem1.Hide();
            uCtrlCategory1.Hide();
            uCtrlOrder1.Hide();
            uCtrlReport1.Hide();
            uCtrlCustomer1.Show();
            uCtrlCustomer1.BringToFront();
            lblHeading.Text = "Manage Store - Customers";
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            uCtrlItem1.Hide();
            uCtrlCategory1.Hide();
            uCtrlReport1.Hide();
            uCtrlOrder1.Show();
            uCtrlOrder1.BringToFront();
            lblHeading.Text = "Manage Store - Orders";
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            uCtrlCategory1.Hide();
            uCtrlItem1.Hide();
            uCtrlCustomer1.Hide();
            uCtrlOrder1.Hide();
            uCtrlReport1.Show();
            uCtrlReport1.BringToFront();
            lblHeading.Text = "Manage Store - Reports";
        }
    }
}
