using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Employee_management_system
{
    public partial class dashboard : Form
    {
      
        public dashboard()
        {
            InitializeComponent();
            
        }

        private void dashboard_txt_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            //connection  sa db
            string connectionString = "server=localhost;port=3306;database=employeedb;uid=root;password=;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                //count nya ung lahat ng employee
                MySqlCommand command = new MySqlCommand("SELECT COUNT(*) FROM employees", connection);

                int totalCount = Convert.ToInt32(command.ExecuteScalar());
                //dito nya display as a string
                employeeCountLabel.Text = totalCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
             try
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand("SELECT COUNT(*) FROM employees", connection);

                int totalCount = Convert.ToInt32(command.ExecuteScalar());

                employeeCountLabel.Text = totalCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            employees EmployeesForm = new employees();
            EmployeesForm.Show();
            this.Hide();
        }

        private void employeeCountLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
