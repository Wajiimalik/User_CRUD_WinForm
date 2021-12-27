using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace User_CRUD_WinForm
{
    public partial class form_User_CRUD : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=db_USER_CRUD;Integrated Security=true;");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        int ID = 0;

        public form_User_CRUD()
        {
            InitializeComponent();
            DisplayData();
        }

        //Display Data in DataGridView  
        private void DisplayData()
        {
            conn.Open();
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter("SELECT * FROM tb_USER", conn);
            adapter.Fill(dt);
            dgv_users_list.DataSource = dt;
            conn.Close();
        }

        // Insert Button Click Event
        private void btn_insert_Click(object sender, EventArgs e)
        {
            if (tb_name.Text != "" && num_age.Text != "" && tb_city.Text != "")
            {
                cmd = new SqlCommand("INSERT INTO tb_USER(u_name, age, city) values(@name, @age, @city)", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@name", tb_name.Text);
                cmd.Parameters.AddWithValue("@age", num_age.Text);
                cmd.Parameters.AddWithValue("@city", tb_city.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Record Inserted Successfully");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please fill all Details!");
            }
        }

        //Clear Data  
        private void ClearData()
        {
            tb_name.Text = "";
            num_age.Text = "0";
            tb_city.Text = "";
            ID = 0;
        }

        //DataGridView RowHeaderMouseClick Event  
        private void dgv_users_list_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dgv_users_list.Rows[e.RowIndex].Cells[0].Value.ToString());
            tb_name.Text = dgv_users_list.Rows[e.RowIndex].Cells[1].Value.ToString();
            num_age.Text = dgv_users_list.Rows[e.RowIndex].Cells[2].Value.ToString();
            tb_city.Text = dgv_users_list.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (tb_name.Text != "" && num_age.Text != "" && tb_city.Text != "")
            {
                cmd = new SqlCommand("UPDATE tb_USER SET u_name=@name,age=@age, city=@city WHERE user_id=@id", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@name", tb_name.Text);
                cmd.Parameters.AddWithValue("@age", num_age.Text);
                cmd.Parameters.AddWithValue("@city", tb_city.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                conn.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    cmd = new SqlCommand("DELETE FROM tb_USER where user_id=@id", conn);
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Record Deleted Successfully!");
                    DisplayData();
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Operation Cancelled!");
                }
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }
    }
}
