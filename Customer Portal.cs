using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudCenter
{
    public partial class CustomerPortal : Form
    {

        

        public CustomerPortal()
        {
            InitializeComponent();
        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void CustomerPortal_Load(object sender, EventArgs e)
        {

            ShowCustomer();

        }

        private void ShowCustomer()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["SqlConnectionString"].ConnectionString;

            try
            {
                //sql connection object
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    //define the SqlCommand object
                    using (SqlCommand command = new SqlCommand("spGetAllCustomerInformation", conn))
                    //using (SqlCommand command = new SqlCommand("SELECT * FROM [CUSTOMER]", conn))

                    {

                        //Set the SqlDataAdapter object
                        SqlDataAdapter dAdapter = new SqlDataAdapter(command);


                        //define dataset
                        //DataSet ds = new DataSet();

                        DataTable dt = new DataTable();

                        //fill dataset with query results
                        //dAdapter.Fill(ds);

                        dAdapter.Fill(dt);

                        //set DataGridView control to read-only
                        //dataGridView1.ReadOnly = true;

                        //allCustomerInformationDataGrid.AutoResizeColumns();
                        //allCustomerInformationDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                        allCustomerInformationDataGrid.AutoGenerateColumns = false;

                        allCustomerInformationDataGrid.AutoResizeColumns();
                        allCustomerInformationDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                        allCustomerInformationDataGrid.RowsDefaultCellStyle.BackColor = Color.White;
                        allCustomerInformationDataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.Aquamarine;

                        allCustomerInformationDataGrid.ColumnCount = 3;

                        allCustomerInformationDataGrid.Columns[0].Visible = false;

                        allCustomerInformationDataGrid.Columns[1].HeaderText = "First Name";
                        allCustomerInformationDataGrid.Columns[1].DataPropertyName = "First Name";

                        allCustomerInformationDataGrid.Columns[2].HeaderText = "Last Name";
                        allCustomerInformationDataGrid.Columns[2].DataPropertyName = "Last Name";

                        allCustomerInformationDataGrid.DataSource = dt;

                    };

                    //close connection
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                //display error message
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void AddNewCustomerBtn_Click(object sender, EventArgs e)
        {

            var connectionString = ConfigurationManager.ConnectionStrings["SqlConnectionString"].ConnectionString;

            try
            {
                //sql connection object
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    //define the SqlCommand object
                    using (SqlCommand command = new SqlCommand("spGetAllCustomerInformation", conn))
                    {

                        //Set the SqlDataAdapter object
                        SqlDataAdapter dAdapter = new SqlDataAdapter(command);


                        //define dataset
                        DataSet ds = new DataSet();

                        //fill dataset with query results
                        dAdapter.Fill(ds);

                        //set DataGridView control to read-only
                        //dataGridView1.ReadOnly = true;

                        allCustomerInformationDataGrid.AutoResizeColumns();
                        allCustomerInformationDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                        allCustomerInformationDataGrid.AutoGenerateColumns = false;

                        allCustomerInformationDataGrid.RowsDefaultCellStyle.BackColor = Color.White;
                        allCustomerInformationDataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.Aquamarine;

                        //set the DataGridView control's data source/data table
                        allCustomerInformationDataGrid.DataSource = ds.Tables[0];

                    };

                    //close connection
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                //display error message
                MessageBox.Show("Exception: " + ex.Message);
            }









        }
    }
}
