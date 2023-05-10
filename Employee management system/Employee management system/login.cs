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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void signin_btn_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;port=3306;database=employeedb;uid=root;password=;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand("SELECT * FROM admin WHERE username=@username AND password=@password", connection);
                command.Parameters.AddWithValue("@username", username.Text);
                command.Parameters.AddWithValue("@password", password.Text);

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // login successful
                    dashboard dashboardForm = new dashboard();
                    dashboardForm.Show();
                    this.Hide();
                }
                else
                {
                    // login failed
                    MessageBox.Show("Invalid username or password");
                }

                reader.Close();
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



    }
}
