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
    public partial class employees : Form
    {
        public employees()
        {
            InitializeComponent();
        }

        private void DashboardForm_Click(object sender, EventArgs e)
        {
            dashboard dashboardForm = new dashboard();
            dashboardForm.Show();
            this.Hide();
        }

        private void dateofbirth_txt_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;port=3306;database=employeedb;uid=root;password=;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                //insert ng bago na employee sa database
                MySqlCommand command = new MySqlCommand("INSERT INTO employees (name, address, department, phone, edu, dateofbirth, gender) VALUES (@name, @address, @department, @phone, @edu, @dateofbirth, @gender)", connection);
                command.Parameters.AddWithValue("@name", nameTextBox.Text);
                command.Parameters.AddWithValue("@address", addressTextBox.Text);
                command.Parameters.AddWithValue("@department", departmentTextBox.Text);
                command.Parameters.AddWithValue("@phone", phoneTextBox.Text);
                command.Parameters.AddWithValue("@edu", eduTextBox.Text);
                command.Parameters.AddWithValue("@dateofbirth", dateOfBirthPicker.Value);
                command.Parameters.AddWithValue("@gender", genderComboBox.Text);
                command.ExecuteNonQuery();

                // kukunin nya tas updated employee sa database
                command = new MySqlCommand("SELECT * FROM employees", connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Ba-Bind nya ung updated data sa DataGridView control
                dataGridView1.DataSource = dataTable;
                //clear lahat ng textbox
                nameTextBox.Clear();
                addressTextBox.Clear();
                departmentTextBox.Clear();
                phoneTextBox.Clear();
                eduTextBox.Clear();
                genderComboBox.Clear();

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


        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            //kukunin nya ung index ng row sa selected cell
            int rowIndex = e.RowIndex;

            
            // kukunin nya ung value sa cell sa first na column na sa selected row
            int selectedEmployeeId = int.Parse(dataGridView1.Rows[rowIndex].Cells[0].Value.ToString());

            
            //connection ulit sa database
            string connectionString = "server=localhost;port=3306;database=employeedb;uid=root;password=;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                
                // select nya ung employees id nya sa database
                MySqlCommand command = new MySqlCommand("SELECT * FROM employees WHERE id=@id", connection);
                command.Parameters.AddWithValue("@id", selectedEmployeeId);
                MySqlDataReader reader = command.ExecuteReader();

                
                //pag clinick ung employee ma lalagyan ung mga textbox ng information ng employees
                if (reader.Read())
                {
                    nameTextBox.Text = reader["name"].ToString();
                    addressTextBox.Text = reader["address"].ToString();
                    departmentTextBox.Text = reader["department"].ToString();
                    phoneTextBox.Text = reader["phone"].ToString();
                    eduTextBox.Text = reader["edu"].ToString();
                    dateOfBirthPicker.Value = DateTime.Parse(reader["dateofbirth"].ToString());
                    genderComboBox.Text = reader["gender"].ToString();
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

        private void employees_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;port=3306;database=employeedb;uid=root;password=;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                // kukunin nya tas updated employee sa database
                MySqlCommand command = new MySqlCommand("SELECT * FROM employees", connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Ba-Bind nya ung updated data sa DataGridView control
                dataGridView1.DataSource = dataTable;
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

        private void delete_btn_Click(object sender, EventArgs e)
        {
            
            //kukunin ung na click na employee id sa DataGridView
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an employee to delete");
                return;
            }

            int selectedEmployeeId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);

           //connection sa database
            string connectionString = "server=localhost;port=3306;database=employeedb;uid=root;password=;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                // delete ung employee sa database using ung id nila
                MySqlCommand command = new MySqlCommand("DELETE FROM employees WHERE id=@id", connection);
                command.Parameters.AddWithValue("@id", selectedEmployeeId);
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    //show nya to pag na successfully na nadelete ung employee
                    MessageBox.Show("Employee deleted successfully");

           
                    // remove nya pag na select ung row sa DataGridView
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);

                    
                    // function call refresh nya ung DataGridView
                    RefreshDataGridView();
                }
                else
                {
                    
                    MessageBox.Show("Employee not found");
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }


        private void RefreshDataGridView()
        {
            // clear nya ung DataGridView
            dataGridView1.Rows.Clear();
           

            // connection sa database
            string connectionString = "server=localhost;port=3306;database=employeedb;uid=root;password=;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                // select all nya ung employees sa database
                MySqlCommand command = new MySqlCommand("SELECT * FROM employees", connection);
                MySqlDataReader reader = command.ExecuteReader();

                // add nya each employee sa DataGridView
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader["id"], reader["name"], reader["address"], reader["department"], reader["phone"], reader["edu"], reader["dateofbirth"], reader["gender"]);
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

        private void update_btn_Click(object sender, EventArgs e)
        {
            
            // check pag ung row ay na select sa DataGridView
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an employee to update");
                return;
            }

            
            //kukunin ung na select na employee id sa DataGridView
            int selectedEmployeeId = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

            //connection sa database
            string connectionString = "server=localhost;port=3306;database=employeedb;uid=root;password=;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                // update ung information ng employee sa database
                MySqlCommand command = new MySqlCommand("UPDATE employees SET name=@name, address=@address, department=@department, phone=@phone, edu=@edu, dateofbirth=@dateofbirth, gender=@gender WHERE id=@id", connection);
                command.Parameters.AddWithValue("@name", nameTextBox.Text);
                command.Parameters.AddWithValue("@address", addressTextBox.Text);
                command.Parameters.AddWithValue("@department", departmentTextBox.Text);
                command.Parameters.AddWithValue("@phone", phoneTextBox.Text);
                command.Parameters.AddWithValue("@edu", eduTextBox.Text);
                command.Parameters.AddWithValue("@dateofbirth", dateOfBirthPicker.Value);
                command.Parameters.AddWithValue("@gender", genderComboBox.ToString());
                command.Parameters.AddWithValue("@id", selectedEmployeeId);
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    // pag nag successfull
                    MessageBox.Show("Employee updated successfully");

                    // clear ung mga textbox
                    nameTextBox.Clear();
                    addressTextBox.Clear();
                    departmentTextBox.Clear();
                    phoneTextBox.Clear();
                    eduTextBox.Clear();
                    genderComboBox.Clear();

                    
                    // function call i refresh ung DataGridView
                    RefreshDataGridView();
                }
                else
                {
                    
                    MessageBox.Show("Employee not found");
                }
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
