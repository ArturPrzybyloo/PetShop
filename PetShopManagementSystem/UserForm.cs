using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShopManagementSystem
{
    public partial class UserForm : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DbConnect db = new DbConnect();
        SqlDataReader dr;
        string title = "Pet Shop Management System";
        UserModule userModule = new UserModule();
        public UserForm()
        {
            InitializeComponent();
            cn = new SqlConnection(db.connection());
            LoadUser();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            userModule.ShowDialog();
        }

        private void searchUser_TextChanged(object sender, EventArgs e)
        {
            UserModule module = new UserModule();
            module.Show();
        }

        #region Method
        public void LoadUser()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            cmd = new SqlCommand("SELECT * FROM tbUsers WHERE CONCAT(name,address,phone,dob,role) LIKE '%" + searchUser.Text + "%'", cn);
            cn.Open(); 

            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            cn.Close();

        }
        #endregion Method
    }
}
