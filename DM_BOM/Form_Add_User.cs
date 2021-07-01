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
    public partial class Form_Add_User : Form
    {
        string constring = @"Data Source=172.28.10.17;Initial Catalog=BOM_DM;Persist Security Info=True;User ID=sa;PASSWORD=umc@2019";
        SqlConnection connect;
        SqlDataReader reader;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable table;
        SqlCommand cmd_check;
        SqlCommand cmd_his;
        SqlDataAdapter adapter_role;
        DataTable table_role;
        private string staffcode;
        private int id_user;
        Frm_Users frmuser;
        int i;
        public Form_Add_User()
        {
            InitializeComponent();
        }
        public Form_Add_User(string staff_code, int iduser,  Frm_Users frmuser)
        {
            this.staffcode = staff_code;
            this.id_user = iduser;
            this.frmuser = frmuser;
            InitializeComponent();

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                connect = new SqlConnection();
                connect.ConnectionString = constring;
                cmd_check = new SqlCommand("SELECT * FROM Users WHERE Staff_code = @staff_code ", connect);
                cmd_check.Parameters.AddWithValue("@staff_code", txtstaff.Text);
                SqlDataAdapter adapter_check = new SqlDataAdapter(cmd_check);
                DataTable table_check = new DataTable();
                adapter_check.Fill(table_check);
                if (table_check.Rows.Count > 0)
                {
                    MessageBox.Show("Staff code already exists");
                }
                else
                {
                    if (txtstaff.Text == "")
                    {
                        lblerror1.Text = "Data cannot be empty!";
                    }
                    else if (txtname.Text == "")
                    {
                        lblerror2.Text = "Data cannot be empty!";
                    } else if (txtpass.Text == "" )
                    {
                        lblerror3.Text = "Data cannot be empty!";
                    }else if (cmbrole.SelectedValue.ToString() == "")
                    {
                        lblerror4.Text= "Data cannot be empty!";
                    }
                    else if(txtpass.Text.Length < 5)
                    {
                        lblerror3.Text = "Password must be longer than 5 characters!";
                    }
                    else
                    {
                        cmd = new SqlCommand("insert into Users(Staff_code,Name,Password,Id_role) values (@staffcode,@name,@password,@id_role) ", connect);
                        connect.Open();
                        cmd.Parameters.AddWithValue("@staffcode", txtstaff.Text);
                        cmd.Parameters.AddWithValue("@name", txtname.Text);
                        cmd.Parameters.AddWithValue("@password", txtpass.Text);
                        cmd.Parameters.AddWithValue("@id_role", cmbrole.SelectedValue);
                        cmd.ExecuteNonQuery();
                        adapter = new SqlDataAdapter("Select * from Users", connect);
                        table = new DataTable();
                        adapter.Fill(table);
                        frmuser.dtgv_users.DataSource = table;
                        adapter_role = new SqlDataAdapter("select * from Role_user", connect);
                        table_role = new DataTable(); ;
                        adapter_role.Fill(table_role);                     
                        for (int i = 0; i < frmuser.dtgv_users.Rows.Count ; i++)
                        {
                            string x = frmuser.dtgv_users.Rows[i].Cells["Id_roles"].Value.ToString();
                            foreach (DataRow dr in table_role.Rows)
                            {
                                string name = dr["Id_Role"].ToString();
                                if (name == x)
                                {
                                    frmuser.dtgv_users.Rows[i].Cells["Role_name"].Value = dr["Name"].ToString();

                                }
                            }
                            frmuser.dtgv_users.Rows[i].Cells["No"].Value = i + 1;
                        }
                        cmd_his = new SqlCommand("insert into History(Datetime,Id_user,Status,Note) values(@datetime,@id_user,@status,@note)", connect);
                        cmd_his.Parameters.AddWithValue("@datetime", DateTime.Now);
                        cmd_his.Parameters.AddWithValue("@id_user", id_user);
                        cmd_his.Parameters.AddWithValue("@status", Task.Add_data.ToString());
                        cmd_his.Parameters.AddWithValue("@note", "Add new user '" + txtstaff.Text + "'");
                        cmd_his.ExecuteNonQuery();
                        connect.Close();
                        Clear();
                    }
                   
                }
                
                //if (txtPartCUS.Text == "" && txtPartBOM.Text == "")
                //{
                //    lblerrorpartlist.Text = "Data cannot be empty!";
                //    lblerrormain.Text = "Data cannot be empty!";
                //}
                //else
                //{
                //    if (txtPartCUS.Text == "" && txtPartBOM.Text != "")
                //    {
                //        lblerrorpartlist.Text = "Data cannot be empty!";
                //        lblerrormain.Text = "";
                //    }
                //    else
                //    {
                //        if (txtPartCUS.Text != "" && txtPartBOM.Text == "")
                //        {
                //            lblerrorpartlist.Text = "";
                //            lblerrormain.Text = "Data cannot be empty!";
                //        }
                //        else
                //        {
                //            cmd_his = new SqlCommand("insert into History(Datetime,Id_user,Status,Note) values(@datetime,@id_user,@status,@note)", connect);
                //            cmd_his.Parameters.AddWithValue("@datetime", DateTime.Now);
                //            cmd_his.Parameters.AddWithValue("@id_user", id_user);
                //            cmd_his.Parameters.AddWithValue("@status", Task.Add_data.ToString());
                //            cmd_his.Parameters.AddWithValue("@note", "Add data with Part on bom customer to '" + txtPartCUS.Text + "' and Sub special to '" + txtPartBOM.Text + "' in IC Manager");
                //            cmd_his.ExecuteNonQuery();

                //            Clear();
                //        }
                //    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void Clear()
        {
            txtname.Text = "";
            txtpass.Text = "";
            txtstaff.Text = "";
            this.Close();
        }
        private void Form_Add_User_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bOM_DMDataSet.Role_user' table. You can move, or remove it, as needed.
            this.role_userTableAdapter.Fill(this.bOM_DMDataSet.Role_user);
        }

        private void cmbrole_SelectedIndexChanged(object sender, EventArgs e)
        {
            //connect.Open();
            //cmd = new SqlCommand("Select Role_user.Id_Role from Users inner join Role_user on Users.Id_role = Role_user.Id_Role where (Role_user.Id_Role=N'" + cmbrole.Text + @"')",connect);
            //reader = cmd.ExecuteReader();
            //i = 0;
            //while (!reader.Read())
            //{

            //}
        }
    }
}
