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
    public partial class Frm_Users : Form
    {
        string constring= @"Data Source=172.28.10.17;Initial Catalog=BOM_DM;Persist Security Info=True;User ID=sa;PASSWORD=umc@2019";
        SqlConnection connect;
        SqlDataAdapter adapter_user;
        SqlDataAdapter adapter_role;
        DataTable table_user;
        DataTable table_role;
        private string staffcode;
        int id_user;
        int id_role;
        public Frm_Users()
        {
            InitializeComponent();
        }
        public Frm_Users(string staff_code, int user, int role)
        {
            this.staffcode = staff_code;
            this.id_user = user;
            this.id_role = role;
            InitializeComponent();
        }
        void Connect()
        {
            connect = new SqlConnection();
            connect.ConnectionString = constring;
            connect.Open();
            table_user = new DataTable();
            table_role = new DataTable();
            adapter_user= new SqlDataAdapter("select * from Users",connect);
            adapter_user.Fill(table_user);
            adapter_role= new SqlDataAdapter("select * from Role_user", connect);
            adapter_role.Fill(table_role);
            dtgv_users.DataSource = table_user;
            dtgv_users.Columns["Id"].Visible = false;
            dtgv_users.Columns["Password"].Visible = false;
            dtgv_users.Columns["Id_roles"].Visible = false;
            for (int i = 0; i < dtgv_users.Rows.Count - 1; i++)
            {
                string x = dtgv_users.Rows[i].Cells["Id_roles"].Value.ToString();
                foreach (DataRow dr in table_role.Rows)
                {
                    string name = dr["Id_Role"].ToString();
                    if (name == x)
                    {
                        dtgv_users.Rows[i].Cells["Role_name"].Value = dr["Name"].ToString();

                    }
                }
                dtgv_users.Rows[i].Cells["No"].Value = i + 1;
            }
            connect.Close();
        }
        private void Frm_Users_Load(object sender, EventArgs e)
        {
            Connect();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form_Add_User frm_addmain = new Form_Add_User(staffcode, id_user, this);
            frm_addmain.ShowDialog();
        }
    }
}
