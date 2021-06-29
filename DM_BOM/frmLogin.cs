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

namespace DM_BOM
{
    public partial class frmLogin : Form
    {
        SqlCommand cmd;
        SqlConnection connect;
        string constring = @"Data Source=172.28.10.17;Initial Catalog=BOM_DM;Persist Security Info=True;User ID=sa;PASSWORD=umc@2019";
        
        void Connect()
        {
            try
            {
                if (!NetworkConnection.PingNetwork("172.28.10.17"))
                {
                    MessageBox.Show("Kiểm tra lại mạng kết nối!", "INTERNET WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                else
                {
                    connect = new SqlConnection();
                    connect.ConnectionString = constring;
                    connect.Open();
                   
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try {
                Connect();
                cmd = new SqlCommand("select * from Users where Staff_code= @username and Password= @password",connect);
                cmd.Parameters.AddWithValue("@username", txtstaffcode.Text);
                cmd.Parameters.AddWithValue("@password", txtpassword.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable ds = new DataTable();
                adapter.Fill(ds);
                connect.Close();
                int count = ds.Rows.Count;
                if (count ==1)
                {
                    int id_user = int.Parse(ds.Rows[0]["Id_user"].ToString());
                    string name = ds.Rows[0]["Name"].ToString();
                    int id_role =int.Parse( ds.Rows[0]["Id_role"].ToString());
                    frmMain frm_main = new frmMain(name,id_role,id_user);
                    this.Hide();
                    frm_main.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Login is not correct!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
