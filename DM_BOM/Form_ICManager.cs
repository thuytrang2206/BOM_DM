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
        int ?_id;
        public Form_ICManager()
        {
            InitializeComponent();
        }

        public void Connect()
        {
            connect = new SqlConnection();
            connect.ConnectionString = constring;
            connect.Open();
            table = new DataTable();
        }

        public void Load_data()
        {
            Connect();
            adapter = new SqlDataAdapter("Select * from Flash_memory",connect);
            dtgv_Flashmemory.Columns["Id"].Visible = false;
            adapter.Fill(table);
            dtgv_Flashmemory.DataSource = table;
            for (int i = 0; i < dtgv_Flashmemory.Rows.Count-1; i++)
            {
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
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form_Add_ICManager frm_icmanager = new Form_Add_ICManager(this);
            frm_icmanager.Show();
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
                    MessageBox.Show("Record Deleted Successfully!");
                    Load_data();
                    connect.Close();
                    Clear();
                }
                else
                {
                    MessageBox.Show("Don't have choose value to delete!");
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
                Connect();
                cmd = new SqlCommand("update Flash_memory set PartNoCUS='" + txtbomcustomer.Text + "', PartNoBOM='" +txtbomsap.Text + "' where Id='" + _id + "'", connect);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully!");
                Load_data();
                connect.Close();
                Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
