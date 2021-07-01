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
    public partial class Form_ICManager : Form
    {
        string constring = @"Data Source=172.28.10.17;Initial Catalog=BOM_DM;Persist Security Info=True;User ID=sa;PASSWORD=umc@2019";
        SqlConnection connect;
        SqlDataAdapter adapter;
        DataTable table;
        SqlCommand cmd;
        SqlCommand cmd_his;
        SqlDataAdapter adapter_role;
        DataTable table_role;
        SqlDataAdapter adapter_user;
        DataTable table_user;
        int ?_id;
        private string staffcode;
        private int id_role;
        private int id_user;

        public Form_ICManager()
        {
            InitializeComponent();
        }
        public Form_ICManager(string staff_code, int idrole,int iduser)
        {
            this.staffcode = staff_code;
            this.id_role = idrole;
            this.id_user = iduser;
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
                        dtgv_Flashmemory.Columns["Name_user"].Visible = false;
                        dtgv_Flashmemory.Columns["Partonbomcustomer"].Width = 212;
                        dtgv_Flashmemory.Columns["Partonbomsap"].Width = 212;
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
            table = new DataTable();
            table_role = new DataTable();
            table_user = new DataTable();
        }

        public void Load_data()
        {
            Connect();
            adapter = new SqlDataAdapter("Select * from Flash_memory",connect);
            dtgv_Flashmemory.Columns["Id"].Visible = false;
            dtgv_Flashmemory.Columns["Id_users"].Visible = false;
            adapter.Fill(table);
            dtgv_Flashmemory.DataSource = table;
            adapter_user = new SqlDataAdapter("select * from Users", connect);
            adapter_user.Fill(table_user);
            for (int i = 0; i < dtgv_Flashmemory.Rows.Count; i++)
            {
                string x = dtgv_Flashmemory.Rows[i].Cells["Id_users"].Value.ToString();
                foreach (DataRow dr in table_user.Rows)
                {
                    string name = dr["Id_user"].ToString();
                    if (name == x)
                    {
                        dtgv_Flashmemory.Rows[i].Cells["Name_user"].Value = dr["Name"].ToString();

                    }
                }
                dtgv_Flashmemory.Rows[i].Cells["No"].Value = i + 1;
            }
        }

        void Clear()
        {
            txtbomsap.Text = "";
            txtbomcustomer.Text = "";
           _id = null;
        }

        private void Form_ICManager_Load(object sender, EventArgs e)
        {
            Load_data();
            Check_role();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form_Add_ICManager frm_icmanager = new Form_Add_ICManager(staffcode, id_user, this);
            frm_icmanager.ShowDialog();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (_id != null)
                {
                    Connect();
                    cmd = new SqlCommand("delete Flash_memory where Id='" + _id + "'", connect);
                    cmd.ExecuteNonQuery();
                    cmd_his = new SqlCommand("insert into History(Datetime,Id_user,Status,Note) values(@datetime,@id_user,@status,@note)", connect);
                    cmd_his.Parameters.AddWithValue("@datetime", DateTime.Now);
                    cmd_his.Parameters.AddWithValue("@id_user", id_user);
                    cmd_his.Parameters.AddWithValue("@status", Task.Delete_data.ToString());
                    cmd_his.Parameters.AddWithValue("@note", "Delete data with Part on bom customer to '" + txtbomcustomer.Text + "' and Part on bom sap to '" + txtbomsap.Text + "' in IC Manager");
                    cmd_his.ExecuteNonQuery();
                    MessageBox.Show("Record Deleted Successfully!");
                    Load_data();
                    connect.Close();
                    Clear();
                }
                else
                {
                    MessageBox.Show("Don't have choose value to delete!","Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }   
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtgv_Flashmemory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _id = int.Parse(dtgv_Flashmemory.Rows[e.RowIndex].Cells["Id"].Value.ToString());
            txtbomsap.Text = dtgv_Flashmemory.Rows[e.RowIndex].Cells["Partonbomsap"].Value.ToString();
            txtbomcustomer.Text = dtgv_Flashmemory.Rows[e.RowIndex].Cells["Partonbomcustomer"].Value.ToString();
            txtbomcustomer.Visible = true;
            txtbomsap.Visible = true;
        }

         void Search()
        {
            Connect();
            cmd = new SqlCommand("select * from Flash_memory where PartNoBOM like'%" + txtSearch.Text + "%' or PartNoCUS like '%" + txtSearch.Text + "%'", connect);
            adapter = new SqlDataAdapter(cmd);
            table = new DataTable();
            adapter.Fill(table);
            dtgv_Flashmemory.DataSource = table;
            for (int i = 0; i < dtgv_Flashmemory.Rows.Count - 1; i++)
            {
                dtgv_Flashmemory.Rows[i].Cells["No"].Value = i + 1;
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
                if (_id!= null)
                {
                    Connect();
                    cmd = new SqlCommand("update Flash_memory set PartNoCUS='" + txtbomcustomer.Text + "', PartNoBOM='" + txtbomsap.Text + "',Id_user='" + id_user + "' where Id='" + _id + "'", connect);
                    cmd_his = new SqlCommand("insert into History(Datetime,Id_user,Status,Note) values(@datetime,@id_user,@status,@note)", connect);
                    cmd_his.Parameters.AddWithValue("@datetime", DateTime.Now);
                    cmd_his.Parameters.AddWithValue("@id_user", id_user);
                    cmd_his.Parameters.AddWithValue("@status", Task.Edit_data.ToString());
                    cmd_his.Parameters.AddWithValue("@note", "Edit data with Part on bom customer to '" + txtbomcustomer.Text + "' and Part on bom sap to '" + txtbomsap.Text + "' in IC Manager");
                    cmd_his.ExecuteNonQuery();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Updated Successfully!");
                    Load_data();
                    connect.Close();
                    Clear();
                }
                else
                {
                    MessageBox.Show("Don't have value to edit!", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
