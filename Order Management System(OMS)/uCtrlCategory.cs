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

namespace Order_Management_System_OMS_
{
    public partial class uCtrlCategory : UserControl
    {
        public uCtrlCategory()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        string errorMessage;
        bool empty = false;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //void method that helps make sure no empty string is sent to the database 
            HandleEmptyString(errorMessage, empty);
            
        }
        public void HandleEmptyString(string errorMessage, bool empty)
        {
            //check for empty text Boxes then create errorMessage
            if (txtCategory.Text == "")
            {
                errorMessage = "CATEGORY NAME IS REQUIRED";
                empty = true;
            }

            //check if there was any empty text if not then send Data to Database else Display Error Message
            if (empty == false)
            {
                Category category = new Category(txtCategory.Text);
                int x = bll.InsertDescription(category);
                dgvCategory.DataSource = bll.GetDescription();
            }
            else
            {
                MessageBox.Show(errorMessage, "PLEASE ENTER REQUIRED DATA");
            }

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
