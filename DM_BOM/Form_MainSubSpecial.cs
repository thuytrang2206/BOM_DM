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
    public partial class Form_MainSubSpecial : Form
    {
        string constring = @"Data Source=172.28.10.17;Initial Catalog=BOM_DM;Persist Security Info=True;User ID=sa;PASSWORD=umc@2019";
        SqlConnection connect;
        SqlDataAdapter adapter_mainsub;
        SqlDataAdapter adapter_role;
        SqlDataAdapter adapter_history;
        SqlDataAdapter adapter_user;
        DataTable table_user;
        DataTable table_history;
        DataTable table_mainsub;
        DataTable table_role;
        SqlCommand cmd;
        SqlCommand cmd_his;
        int ? _Id;
        private string staffcode;
        private int id_role,id_user;
        public Form_MainSubSpecial()
        {
            InitializeComponent();
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
                        dtgv_Mainsubspecial.Columns["Name_user"].Visible = false;
                        dtgv_Mainsubspecial.Columns["Partonbomcustomer"].Width = 200;
                        dtgv_Mainsubspecial.Columns["Subspecial"].Width = 200;
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
        public void Connect()
        {
            connect = new SqlConnection();
            connect.ConnectionString = constring;
            connect.Open();
            table_mainsub = new DataTable();
            table_role = new DataTable();
            table_history = new DataTable();
            table_user = new DataTable();
        }

        public void Load_data()
        {
            Connect();
            adapter_mainsub = new SqlDataAdapter("Select * from Main_Sub", connect);
            dtgv_Mainsubspecial.Columns["Id"].Visible = false;
            dtgv_Mainsubspecial.Columns["Iduser"].Visible = false;
            adapter_mainsub.Fill(table_mainsub);
            dtgv_Mainsubspecial.DataSource = table_mainsub;
            adapter_user = new SqlDataAdapter("select * from Users", connect);
            adapter_user.Fill(table_user);
            for (int i = 0; i < dtgv_Mainsubspecial.Rows.Count; i++)
            {
                string x = dtgv_Mainsubspecial.Rows[i].Cells["Iduser"].Value.ToString();
                foreach (DataRow dr in table_user.Rows)
                {
                    string name = dr["Id_user"].ToString();
                    if (name == x)
                    {
                        dtgv_Mainsubspecial.Rows[i].Cells["Name_user"].Value = dr["Name"].ToString();

                    }
                }
                dtgv_Mainsubspecial.Rows[i].Cells["No"].Value = i + 1;
            }
        }
        public Form_MainSubSpecial(string staff_code, int idrole,int iduser)
        {
            this.staffcode = staff_code;
            this.id_role = idrole;
            this.id_user = iduser;
            InitializeComponent();
          
        }
      
        private void Form_MainSubSpecial_Load(object sender, EventArgs e)
        {
            Load_data();
            Check_role();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form_AddMainSub frm_addmain = new Form_AddMainSub(staffcode, id_user,this);
            frm_addmain.ShowDialog();
        }

        private void dtgv_Mainsubspecial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            _Id = int.Parse(dtgv_Mainsubspecial.Rows[e.RowIndex].Cells["Id"].Value.ToString());
            txtpartbomcus.Text = dtgv_Mainsubspecial.Rows[e.RowIndex].Cells["Partonbomcustomer"].Value.ToString();
            txtsubspecial.Text = dtgv_Mainsubspecial.Rows[e.RowIndex].Cells["Subspecial"].Value.ToString();
            txtpartbomcus.Visible = true;
            txtsubspecial.Visible = true;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if(_Id!= null)
                {
                    Connect();
                    cmd = new SqlCommand("delete Main_Sub where Id='" + _Id + "'", connect);
                    cmd.ExecuteNonQuery();
                    Load_data();
                    cmd_his = new SqlCommand("insert into History(Datetime,Id_user,Status,Note) values(@datetime,@id_user,@status,@note)", connect);
                    cmd_his.Parameters.AddWithValue("@datetime", DateTime.Now);
                    cmd_his.Parameters.AddWithValue("@id_user", id_user);
                    cmd_his.Parameters.AddWithValue("@status", Task.Delete_data.ToString());
                    cmd_his.Parameters.AddWithValue("@note", "Delete data with Part on bom customer to '" + txtpartbomcus.Text + "' and Sub special to '" + txtsubspecial.Text + "' in Main sub special");
                    cmd_his.ExecuteNonQuery();
                    MessageBox.Show("Record Deleted Successfully!");
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

        public void Clear()
        {
            lbl_Id.Text = "";
            txtpartbomcus.Text = "";
            txtsubspecial.Text = "";
            _Id = null;
        }

        public void Search()
        {
            try
            {
                Connect();
                //cmd = new SqlCommand("select * from Main_Sub where CONCAT(Id,PartNoBom,SubBom) like'%" + txtSearch.Text + "%'", connect);
                cmd = new SqlCommand("select * from Main_Sub where PartNoBom like'%" + txtSearch.Text + "%' or SubBom like '%" + txtSearch.Text + "%'", connect);
                adapter_mainsub = new SqlDataAdapter(cmd);
                table_mainsub = new DataTable();
                adapter_mainsub.Fill(table_mainsub);
                dtgv_Mainsubspecial.DataSource = table_mainsub;
                adapter_user = new SqlDataAdapter("select * from Users", connect);
                adapter_user.Fill(table_user);
                for (int i = 0; i < dtgv_Mainsubspecial.Rows.Count; i++)
                {
                    string x = dtgv_Mainsubspecial.Rows[i].Cells["Iduser"].Value.ToString();
                    foreach (DataRow dr in table_user.Rows)
                    {
                        string name = dr["Id_user"].ToString();
                        if (name == x)
                        {
                            dtgv_Mainsubspecial.Rows[i].Cells["Name_user"].Value = dr["Name"].ToString();

                        }
                    }
                    dtgv_Mainsubspecial.Rows[i].Cells["No"].Value = i + 1;
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
                Load_data();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if(_Id!= null)
                {
                    Connect();
                    cmd = new SqlCommand("update Main_Sub set PartNoBom='" + txtpartbomcus.Text + "', SubBom='" + txtsubspecial.Text + "',Id_user='" + id_user + "' where Id='" + _Id + "'", connect);
                    cmd_his = new SqlCommand("insert into History(Datetime,Id_user,Status,Note) values(@datetime,@id_user,@status,@note)", connect);
                    cmd_his.Parameters.AddWithValue("@datetime", DateTime.Now);
                    cmd_his.Parameters.AddWithValue("@id_user", id_user);
                    cmd_his.Parameters.AddWithValue("@status", Task.Edit_data.ToString());
                    cmd_his.Parameters.AddWithValue("@note","Edit data with Part on bom customer to '" + txtpartbomcus.Text +"' and Sub special to '" + txtsubspecial.Text + "' in Main sub special");
                    cmd_his.ExecuteNonQuery();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Updated Successfully!");
                    Load_data();
                    connect.Close();
                    Clear();
                }
                else
                {
                    MessageBox.Show("Don't have value to edit!","Warning!!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }
    }

}
