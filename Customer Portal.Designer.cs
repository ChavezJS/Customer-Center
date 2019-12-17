namespace CrudCenter
{
    partial class CustomerPortal
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
            this.MainTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.customerBillingInformationControl1 = new CrudCenter.UserControls.CustomerBillingInformationControl();
            this.allCustomerInformationDataGrid = new System.Windows.Forms.DataGridView();
            this.servicesRequestedControl1 = new CrudCenter.UserControls.ServicesRequestedControl();
            this.customerServiceAddressControl1 = new CrudCenter.UserControls.CustomerServiceAddressControl();
            this.addNewCustomerBtn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.FertCustomerTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.FertSearchGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MainTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allCustomerInformationDataGrid)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.FertCustomerTableLayout.SuspendLayout();
            this.FertSearchGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTabs
            // 
            this.MainTabs.Controls.Add(this.tabPage1);
            this.MainTabs.Controls.Add(this.tabPage2);
            this.MainTabs.Controls.Add(this.tabPage3);
            this.MainTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabs.Location = new System.Drawing.Point(0, 0);
            this.MainTabs.Name = "MainTabs";
            this.MainTabs.SelectedIndex = 0;
            this.MainTabs.Size = new System.Drawing.Size(1904, 1041);
            this.MainTabs.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1896, 1015);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add New Customer";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.83992F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.16008F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 425F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 923F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel1.Controls.Add(this.customerBillingInformationControl1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.allCustomerInformationDataGrid, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.servicesRequestedControl1, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.customerServiceAddressControl1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.addNewCustomerBtn, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.668605F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.3314F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 488F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1890, 1009);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // customerBillingInformationControl1
            // 
            this.customerBillingInformationControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerBillingInformationControl1.Location = new System.Drawing.Point(79, 26);
            this.customerBillingInformationControl1.Name = "customerBillingInformationControl1";
            this.customerBillingInformationControl1.Size = new System.Drawing.Size(371, 385);
            this.customerBillingInformationControl1.TabIndex = 0;
            // 
            // allCustomerInformationDataGrid
            // 
            this.allCustomerInformationDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.allCustomerInformationDataGrid, 3);
            this.allCustomerInformationDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allCustomerInformationDataGrid.Location = new System.Drawing.Point(79, 523);
            this.allCustomerInformationDataGrid.Name = "allCustomerInformationDataGrid";
            this.allCustomerInformationDataGrid.Size = new System.Drawing.Size(1719, 483);
            this.allCustomerInformationDataGrid.TabIndex = 4;
            this.allCustomerInformationDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2_CellContentClick);
            // 
            // servicesRequestedControl1
            // 
            this.servicesRequestedControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.servicesRequestedControl1.Location = new System.Drawing.Point(881, 26);
            this.servicesRequestedControl1.Name = "servicesRequestedControl1";
            this.servicesRequestedControl1.Size = new System.Drawing.Size(917, 385);
            this.servicesRequestedControl1.TabIndex = 2;
            // 
            // customerServiceAddressControl1
            // 
            this.customerServiceAddressControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerServiceAddressControl1.Location = new System.Drawing.Point(456, 26);
            this.customerServiceAddressControl1.Name = "customerServiceAddressControl1";
            this.customerServiceAddressControl1.Size = new System.Drawing.Size(419, 385);
            this.customerServiceAddressControl1.TabIndex = 1;
            // 
            // addNewCustomerBtn
            // 
            this.addNewCustomerBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addNewCustomerBtn.Location = new System.Drawing.Point(177, 442);
            this.addNewCustomerBtn.Name = "addNewCustomerBtn";
            this.addNewCustomerBtn.Size = new System.Drawing.Size(175, 50);
            this.addNewCustomerBtn.TabIndex = 5;
            this.addNewCustomerBtn.Text = "Add New Customer";
            this.addNewCustomerBtn.UseVisualStyleBackColor = true;
            this.addNewCustomerBtn.Click += new System.EventHandler(this.AddNewCustomerBtn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1896, 1015);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "New Service Location";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.FertCustomerTableLayout);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1896, 1015);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Fertilization Customers";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // FertCustomerTableLayout
            // 
            this.FertCustomerTableLayout.ColumnCount = 3;
            this.FertCustomerTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.15686F));
            this.FertCustomerTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.84314F));
            this.FertCustomerTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.FertCustomerTableLayout.Controls.Add(this.FertSearchGroupBox, 0, 0);
            this.FertCustomerTableLayout.Controls.Add(this.dataGridView1, 0, 1);
            this.FertCustomerTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FertCustomerTableLayout.Location = new System.Drawing.Point(0, 0);
            this.FertCustomerTableLayout.Name = "FertCustomerTableLayout";
            this.FertCustomerTableLayout.RowCount = 2;
            this.FertCustomerTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.24335F));
            this.FertCustomerTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.75665F));
            this.FertCustomerTableLayout.Size = new System.Drawing.Size(1896, 1015);
            this.FertCustomerTableLayout.TabIndex = 0;
            // 
            // FertSearchGroupBox
            // 
            this.FertCustomerTableLayout.SetColumnSpan(this.FertSearchGroupBox, 3);
            this.FertSearchGroupBox.Controls.Add(this.tableLayoutPanel2);
            this.FertSearchGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FertSearchGroupBox.Location = new System.Drawing.Point(3, 3);
            this.FertSearchGroupBox.Name = "FertSearchGroupBox";
            this.FertSearchGroupBox.Size = new System.Drawing.Size(1890, 290);
            this.FertSearchGroupBox.TabIndex = 0;
            this.FertSearchGroupBox.TabStop = false;
            this.FertSearchGroupBox.Text = "Customer Search";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.0367F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.9633F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 603F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 419F));
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1884, 271);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FertCustomerTableLayout.SetColumnSpan(this.dataGridView1, 3);
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 299);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1890, 713);
            this.dataGridView1.TabIndex = 1;
            // 
            // CustomerPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.MainTabs);
            this.Name = "CustomerPortal";
            this.Text = "Customer Portal";
            this.Load += new System.EventHandler(this.CustomerPortal_Load);
            this.MainTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.allCustomerInformationDataGrid)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.FertCustomerTableLayout.ResumeLayout(false);
            this.FertSearchGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel FertCustomerTableLayout;
        private System.Windows.Forms.GroupBox FertSearchGroupBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private UserControls.CustomerBillingInformationControl customerBillingInformationControl1;
        private System.Windows.Forms.DataGridView allCustomerInformationDataGrid;
        private UserControls.ServicesRequestedControl servicesRequestedControl1;
        private UserControls.CustomerServiceAddressControl customerServiceAddressControl1;
        private System.Windows.Forms.Button addNewCustomerBtn;
    }
}

