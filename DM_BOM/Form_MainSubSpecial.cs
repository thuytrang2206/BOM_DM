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
        int ? _Id;
        public Form_MainSubSpecial()
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
            adapter = new SqlDataAdapter("Select * from Main_Sub", connect);
            dtgv_Mainsubspecial.Columns["Id"].Visible = false;
            adapter.Fill(table);
            dtgv_Mainsubspecial.DataSource = table;
            for (int i = 0; i < dtgv_Mainsubspecial.Rows.Count - 1; i++)
            {
                dtgv_Mainsubspecial.Rows[i].Cells["No"].Value = i + 1;
            }
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
           
            _Id = int.Parse(dtgv_Mainsubspecial.Rows[e.RowIndex].Cells["Id"].Value.ToString());
            txtpartbomcus.Text = dtgv_Mainsubspecial.Rows[e.RowIndex].Cells["Partonbomcustomer"].Value.ToString();
            txtsubspecial.Text = dtgv_Mainsubspecial.Rows[e.RowIndex].Cells["Subspecial"].Value.ToString();
            txtpartbomcus.Visible = true;
            txtpartbomcus.Visible = true;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if(_Id!= null)
                {
                    Connect();
                    cmd = new SqlCommand("delete Main_Sub where Id='" + lbl_Id.Text + "'", connect);
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
                adapter = new SqlDataAdapter(cmd);
                table = new DataTable();
                adapter.Fill(table);
                dtgv_Mainsubspecial.DataSource = table;
                for (int i = 0; i < dtgv_Mainsubspecial.Rows.Count - 1; i++)
                {
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
                Connect();
                cmd = new SqlCommand("update Main_Sub set PartNoBom='" + txtpartbomcus.Text + "', SubBom='" + txtsubspecial.Text + "' where Id='" + _Id + "'", connect);
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
