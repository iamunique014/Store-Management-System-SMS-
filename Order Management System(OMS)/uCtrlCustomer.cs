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
    public partial class uCtrlCustomer : UserControl
    {
        public uCtrlCustomer()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        public string customerID = "1", errorMessage;
        bool empty = false;
        private void uCtrlCustomer_Load(object sender, EventArgs e)
        {
            dgvCustomers.DataSource = bll.GetClients();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //void method that helps make sure no empty string is sent to the database 
            HandleEmptyString(errorMessage, empty);
            
        }
        public void  HandleEmptyString(string errorMessage, bool empty)
        {
            //check for empty text Boxes the create or increment to errorMessage
            if(txtName.Text == "")
            {
                errorMessage = "CUSTOMER NAME IS REQUIRED";
                empty = true;
            }
            if (txtSurname.Text == "")
            {
                errorMessage = errorMessage + "\nCUSTOMER SURNAME IS REQUIRED";
                empty = true;
            }
            if (txtAddress.Text == "")
            {
                errorMessage = errorMessage + "\nCUSTOMER ADDRESS IS REQUIRED";
                empty = true;
            }
            if (txtEmail.Text == "")
            {
                errorMessage = errorMessage + "\nCUSTOMER EMAIL IS REQUIRED";
                empty = true;
            }

            //check if there was any empty text if not then send Data to Database else Display Error Message
            if (empty == false)
            {
                Customer customer = new Customer(int.Parse(customerID), txtName.Text, txtSurname.Text, txtEmail.Text, txtAddress.Text, DateTime.Parse(dtpDate.Text));
                int x = bll.InsertClient(customer);
                dgvCustomers.DataSource = bll.GetClients();
            }
            else
            {
                MessageBox.Show(errorMessage, "PLEASE ENTER REQUIRED DATA");
            }

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer(int.Parse(customerID), txtName.Text, txtSurname.Text, txtEmail.Text, txtAddress.Text, DateTime.Parse(dtpDate.Text));
            int x = bll.UpdateClient(customer);
            dgvCustomers.DataSource = bll.GetClients();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Message to be shown when user wants to delete a record
            string message = "Delete " + txtName.Text + " " + txtSurname.Text + "'S Record";

            //Display the message with the record that the user is about to delete
            if (MessageBox.Show(message, "Delete Record " + customerID, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //Warning the user before deleting records
                if (MessageBox.Show("Deleted Records Cannot be recovered, Prooced","Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Customer customer = new Customer(int.Parse(customerID));
                    int x = bll.DeleteClient(customer);
                    dgvCustomers.DataSource = bll.GetClients();
                }
            }
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvCustomers.DataSource = bll.SearchClient(txtName.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvCustomers.DataSource = bll.GetClients();
        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if(e.RowIndex >= 0) 
            { 
                DataGridViewRow row = this.dgvCustomers.Rows[e.RowIndex];

                customerID = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtSurname.Text = row.Cells[2].Value.ToString();
                txtEmail.Text = row.Cells[3].Value.ToString();
                txtAddress.Text = row.Cells[4].Value.ToString();
            }
        }
    }
}
