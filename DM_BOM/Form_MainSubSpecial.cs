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
        SqlDataAdapter adapter;
        DataTable table;
        SqlCommand cmd;
        public Form_MainSubSpecial()
        {
            InitializeComponent();
        }
        public void Load_data()
        {
            connect = new SqlConnection();
            connect.ConnectionString = constring;
            connect.Open();
            adapter = new SqlDataAdapter("Select * from Main_Sub", connect);
            table = new DataTable();
            adapter.Fill(table);
            dtgv_Mainsubspecial.DataSource = table;
        }
        private void Form_MainSubSpecial_Load(object sender, EventArgs e)
        {
            Load_data();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form_AddMainSub frm_addmain = new Form_AddMainSub(this);
            frm_addmain.Show();
        }

        private void dtgv_Mainsubspecial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dtgv_Mainsubspecial.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            txtPartlistName.Text = dtgv_Mainsubspecial.Rows[e.RowIndex].Cells["PartNoBom"].Value.ToString();
            txtSubbom.Text = dtgv_Mainsubspecial.Rows[e.RowIndex].Cells["SubBom"].Value.ToString();
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            connect = new SqlConnection();
            connect.ConnectionString = constring;
            connect.Open();
            cmd = new SqlCommand("delete Main_Sub where Id='"+txtId.Text+"'", connect);
            cmd.ExecuteNonQuery();            
            MessageBox.Show("Record Deleted Successfully!");
            adapter = new SqlDataAdapter("Select * from Main_Sub", connect);
            table = new DataTable();
            adapter.Fill(table);
            dtgv_Mainsubspecial.DataSource = table;
            connect.Close();
            Clear();
        }
        public void Clear()
        {
            txtId.Text = "";
            txtPartlistName.Text = "";
            txtSubbom.Text = "";
        }
        public void Search()
        {
            connect = new SqlConnection();
            connect.ConnectionString = constring;
            connect.Open();
            //cmd = new SqlCommand("select * from Main_Sub where CONCAT(Id,PartNoBom,SubBom) like'%" + txtSearch.Text + "%'", connect);
            cmd = new SqlCommand("select * from Main_Sub where PartNoBom like'%" + txtSearch.Text + "%' or SubBom like '%" + txtSearch.Text + "%'", connect);
            adapter = new SqlDataAdapter(cmd);
            table = new DataTable();
            adapter.Fill(table);
            dtgv_Mainsubspecial.DataSource = table;
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
    }

}
