namespace Order_Management_System_OMS_
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sidebar = new System.Windows.Forms.Panel();
            this.btnIfo = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnItem = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pbAdmin = new System.Windows.Forms.PictureBox();
            this.navbar = new System.Windows.Forms.Panel();
            this.lblHeading = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uCtrlReport1 = new Order_Management_System_OMS_.uCtrlReport();
            this.uCtrlOrder1 = new Order_Management_System_OMS_.uCtrlOrder();
            this.uCtrlItem1 = new Order_Management_System_OMS_.uCtrlItem();
            this.uCtrlCategory1 = new Order_Management_System_OMS_.uCtrlCategory();
            this.uCtrlCustomer1 = new Order_Management_System_OMS_.uCtrlCustomer();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdmin)).BeginInit();
            this.navbar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.sidebar.Controls.Add(this.btnIfo);
            this.sidebar.Controls.Add(this.btnReports);
            this.sidebar.Controls.Add(this.btnOrders);
            this.sidebar.Controls.Add(this.btnItem);
            this.sidebar.Controls.Add(this.btnCategory);
            this.sidebar.Controls.Add(this.btnCustomer);
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(200, 616);
            this.sidebar.TabIndex = 0;
            // 
            // btnIfo
            // 
            this.btnIfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIfo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnIfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIfo.Location = new System.Drawing.Point(0, 426);
            this.btnIfo.Name = "btnIfo";
            this.btnIfo.Size = new System.Drawing.Size(200, 48);
            this.btnIfo.TabIndex = 6;
            this.btnIfo.Text = "Info";
            this.btnIfo.UseVisualStyleBackColor = false;
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReports.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.Location = new System.Drawing.Point(0, 381);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(200, 48);
            this.btnReports.TabIndex = 5;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrders.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrders.Location = new System.Drawing.Point(0, 333);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(200, 48);
            this.btnOrders.TabIndex = 4;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = false;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnItem
            // 
            this.btnItem.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItem.Location = new System.Drawing.Point(0, 285);
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new System.Drawing.Size(200, 48);
            this.btnItem.TabIndex = 3;
            this.btnItem.Text = "Item";
            this.btnItem.UseVisualStyleBackColor = false;
            this.btnItem.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCategory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.Location = new System.Drawing.Point(0, 237);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(200, 48);
            this.btnCategory.TabIndex = 2;
            this.btnCategory.Text = "Category";
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCustomer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.Location = new System.Drawing.Point(0, 189);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(200, 48);
            this.btnCustomer.TabIndex = 0;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pbAdmin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 189);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Admin";
            // 
            // pbAdmin
            // 
            this.pbAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbAdmin.Image = ((System.Drawing.Image)(resources.GetObject("pbAdmin.Image")));
            this.pbAdmin.Location = new System.Drawing.Point(0, 0);
            this.pbAdmin.Name = "pbAdmin";
            this.pbAdmin.Size = new System.Drawing.Size(200, 189);
            this.pbAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAdmin.TabIndex = 0;
            this.pbAdmin.TabStop = false;
            // 
            // navbar
            // 
            this.navbar.Controls.Add(this.lblHeading);
            this.navbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.navbar.Location = new System.Drawing.Point(200, 0);
            this.navbar.Name = "navbar";
            this.navbar.Size = new System.Drawing.Size(835, 50);
            this.navbar.TabIndex = 1;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(242, 18);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(243, 23);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Manage Store Infomation";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.uCtrlReport1);
            this.groupBox1.Controls.Add(this.uCtrlOrder1);
            this.groupBox1.Controls.Add(this.uCtrlItem1);
            this.groupBox1.Controls.Add(this.uCtrlCategory1);
            this.groupBox1.Controls.Add(this.uCtrlCustomer1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(200, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(829, 560);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // uCtrlReport1
            // 
            this.uCtrlReport1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.uCtrlReport1.Location = new System.Drawing.Point(6, 15);
            this.uCtrlReport1.Name = "uCtrlReport1";
            this.uCtrlReport1.Size = new System.Drawing.Size(806, 545);
            this.uCtrlReport1.TabIndex = 4;
            // 
            // uCtrlOrder1
            // 
            this.uCtrlOrder1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.uCtrlOrder1.Location = new System.Drawing.Point(6, 15);
            this.uCtrlOrder1.Name = "uCtrlOrder1";
            this.uCtrlOrder1.Size = new System.Drawing.Size(806, 545);
            this.uCtrlOrder1.TabIndex = 3;
            // 
            // uCtrlItem1
            // 
            this.uCtrlItem1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.uCtrlItem1.Location = new System.Drawing.Point(6, 19);
            this.uCtrlItem1.Name = "uCtrlItem1";
            this.uCtrlItem1.Size = new System.Drawing.Size(702, 529);
            this.uCtrlItem1.TabIndex = 2;
            // 
            // uCtrlCategory1
            // 
            this.uCtrlCategory1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.uCtrlCategory1.Location = new System.Drawing.Point(6, 19);
            this.uCtrlCategory1.Name = "uCtrlCategory1";
            this.uCtrlCategory1.Size = new System.Drawing.Size(781, 529);
            this.uCtrlCategory1.TabIndex = 1;
            // 
            // uCtrlCustomer1
            // 
            this.uCtrlCustomer1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.uCtrlCustomer1.Location = new System.Drawing.Point(6, 19);
            this.uCtrlCustomer1.Name = "uCtrlCustomer1";
            this.uCtrlCustomer1.Size = new System.Drawing.Size(709, 529);
            this.uCtrlCustomer1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1035, 616);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.navbar);
            this.Controls.Add(this.sidebar);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximumSize = new System.Drawing.Size(1051, 665);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdmin)).EndInit();
            this.navbar.ResumeLayout(false);
            this.navbar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Panel navbar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbAdmin;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnItem;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnIfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private uCtrlOrder uCtrlOrder1;
        private uCtrlItem uCtrlItem1;
        private uCtrlCategory uCtrlCategory1;
        private uCtrlCustomer uCtrlCustomer1;
        private uCtrlReport uCtrlReport1;
    }
}

