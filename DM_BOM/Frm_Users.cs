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
        SqlCommand cmd;
        SqlCommand cmd_his;
        private string staffcode;
        int? _Id;
        int id_user;
        int id_role;

        public Frm_Users()
        {
            InitializeComponent();
        }
        public Frm_Users(string staff_code,  int role,int user)
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
            
        }
        void LoadData()
        {
            Connect();
            adapter_user = new SqlDataAdapter("select * from Users", connect);
            adapter_user.Fill(table_user);
            adapter_role = new SqlDataAdapter("select * from Role_user", connect);
            adapter_role.Fill(table_role);
            dtgv_users.DataSource = table_user;
            dtgv_users.Columns["Id"].Visible = false;
            dtgv_users.Columns["Password"].Visible = false;
            dtgv_users.Columns["Id_roles"].Visible = false;
            for (int i = 0; i < dtgv_users.Rows.Count; i++)
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
        public void Check_role()
        {
            Connect();
            adapter_role = new SqlDataAdapter("Select * from Role_user", connect);
            adapter_role.Fill(table_role);
            foreach (DataRow row in table_role.Rows)
            {
                int id_role_user = int.Parse(row["Id_role"].ToString());
                string name_role = row["Name"].ToString();
                if (id_role == id_role_user)
                {
                    if (name_role == "user")
                    {
                        btnAdd.Visible = false;
                        btnEdit.Visible = false;
                        btnDel.Visible = false;
                    }
                    else
                    {
                        btnAdd.Visible = true;
                        btnEdit.Visible = true;
                        btnDel.Visible = true;
                    }
                }

            }
        }
        private void Frm_Users_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bOM_DMDataSet1.Role_user' table. You can move, or remove it, as needed.
            this.role_userTableAdapter.Fill(this.bOM_DMDataSet1.Role_user);
            LoadData();
            Check_role();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form_Add_User frm_addmain = new Form_Add_User(staffcode, id_user, this);
            frm_addmain.ShowDialog();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (_Id != null)
                {
                    Connect();
                    cmd = new SqlCommand("delete Users where Id_user='" + _Id + "'", connect);
                    cmd.ExecuteNonQuery();
                    cmd_his = new SqlCommand("insert into History(Datetime,Id_user,Status,Note) values(@datetime,@id_user,@status,@note)", connect);
                    cmd_his.Parameters.AddWithValue("@datetime", DateTime.Now);
                    cmd_his.Parameters.AddWithValue("@id_user", id_user);
                    cmd_his.Parameters.AddWithValue("@status", Task.Delete_data.ToString());
                    cmd_his.Parameters.AddWithValue("@note", "Delete user with staff code= '" + txtstaff.Text + "'");
                    cmd_his.ExecuteNonQuery();
                    MessageBox.Show("Record Deleted Successfully!");
                    LoadData();
                    connect.Close();
                    Clear();
                }
                else
                {
                    MessageBox.Show("Don't have choose value to delete!", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void Clear()
        {
            txtstaff.Text = "";
            txtname.Text = "";
            txtpass.Text = "";
        }
        private void dtgv_users_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _Id = int.Parse(dtgv_users.Rows[e.RowIndex].Cells["id"].Value.ToString());
            txtstaff.Text = dtgv_users.Rows[e.RowIndex].Cells["Staff_code"].Value.ToString();
            txtname.Text = dtgv_users.Rows[e.RowIndex].Cells["_Name"].Value.ToString();
            txtpass.Text = dtgv_users.Rows[e.RowIndex].Cells["Password"].Value.ToString();
            cmbrole.SelectedValue = dtgv_users.Rows[e.RowIndex].Cells["Id_roles"].Value.ToString();
            txtstaff.Visible = true;
            txtname.Visible = true;
        }
        public void Search()
        {
            try
            {
                Connect();
                //cmd = new SqlCommand("select * from Main_Sub where CONCAT(Id,PartNoBom,SubBom) like'%" + txtSearch.Text + "%'", connect);
                cmd = new SqlCommand("select * from Users where Staff_code like'%" + txtSearch.Text + "%' or Name like '%" + txtSearch.Text + "%'", connect);
                adapter_user = new SqlDataAdapter(cmd);
                table_user = new DataTable();
                adapter_user.Fill(table_user);
                dtgv_users.DataSource = table_user;
                adapter_role = new SqlDataAdapter("select * from Role_user", connect);
                adapter_role.Fill(table_role);
                for (int i = 0; i < dtgv_users.Rows.Count; i++)
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_Searchs_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                LoadData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (_Id != null)
                {
                    Connect();
                    cmd = new SqlCommand("update Users set Staff_code='" + txtstaff.Text + "', Name='" + txtname.Text + "',Password='" + txtpass.Text + "',Id_role='" + cmbrole.SelectedValue + "' where Id_user='" + _Id + "'", connect);
                    cmd_his = new SqlCommand("insert into History(Datetime,Id_user,Status,Note) values(@datetime,@id_user,@status,@note)", connect);
                    cmd_his.Parameters.AddWithValue("@datetime", DateTime.Now);
                    cmd_his.Parameters.AddWithValue("@id_user", id_user);
                    cmd_his.Parameters.AddWithValue("@status", Task.Edit_data.ToString());
                    cmd_his.Parameters.AddWithValue("@note", "Edit user with staff_code= '" + txtstaff.Text + "'");
                    cmd_his.ExecuteNonQuery();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Updated Successfully!");
                    LoadData();
                    connect.Close();
                    Clear();
                }
                else
                {
                    MessageBox.Show("Don't have value to edit!", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
