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

namespace PetShopManagementSystem
{
    public partial class UserModule : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DbConnect db = new DbConnect();
        string title = "Pet Shop Management System";

        public UserModule()
        {
            InitializeComponent();
            cn = new SqlConnection(db.connection());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want register user?", "User registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    cmd = new SqlCommand("INSERT INTO tbUsers (name,address,phone,role,dob,password)VALUES(@name,@address,@phone,@role,@dob,@password)", cn);
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@role", boxRole.Text);
                    cmd.Parameters.AddWithValue("@dob", dateBirth.Value);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("User have been registered!", title);
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {

        }

        private void dateBirth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void boxRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #region Method
        public void Clear()
        {
            txtName.Clear();
            txtAddress.Clear();
            txtPassword.Clear();
            txtPhone.Clear();
            boxRole.SelectedIndex = 0;
            dateBirth.Value = DateTime.Now;
        }
        #endregion Method
    }
}
