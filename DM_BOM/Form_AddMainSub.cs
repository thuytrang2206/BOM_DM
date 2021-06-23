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
    public partial class Form_AddMainSub : Form
    {
        string constring = @"Data Source=172.28.10.17;Initial Catalog=BOM_DM;Persist Security Info=True;User ID=sa;PASSWORD=umc@2019";
        SqlConnection connect;
        SqlDataAdapter adapter;
        DataTable table;
        SqlCommand cmd;
        private Form_MainSubSpecial frm_mainsub;
        public Form_AddMainSub(Form_MainSubSpecial frm_mainsub)
        {
            InitializeComponent();
            this.frm_mainsub = frm_mainsub;
        }
        public void Clear()
        {
            txtPartlistName.Text = "";
            txtSubbom.Text = "";
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            connect = new SqlConnection();
            connect.ConnectionString = constring;
            cmd = new SqlCommand("insert into Main_Sub(PartNoBom,SubBom) values(@partnobom,@subbom)", connect);
            connect.Open();
            cmd.Parameters.AddWithValue("@partnobom", txtPartlistName.Text);
            cmd.Parameters.AddWithValue("@subbom", txtSubbom.Text);
            if (txtPartlistName.Text == "" && txtSubbom.Text == "")
            {
                lblerrorpartlist.Text = "Data cannot be empty!";
                lblerrormain.Text = "Data cannot be empty!";
            }
            else
            {
                if (txtPartlistName.Text == "" && txtSubbom.Text != "")
                {
                    lblerrorpartlist.Text = "Data cannot be empty!";
                    lblerrormain.Text = "";
                }
                else
                {
                    if(txtPartlistName.Text != "" && txtSubbom.Text == "")
                    {
                        lblerrorpartlist.Text = "";
                        lblerrormain.Text = "Data cannot be empty!";
                    }
                    else
                    {
                        cmd.ExecuteNonQuery();
                        adapter = new SqlDataAdapter("Select * from Main_Sub", connect);
                        table = new DataTable();
                        adapter.Fill(table);
                        frm_mainsub.dtgv_Mainsubspecial.DataSource = table;
                        connect.Close();
                        Clear();
                    }
                }
            }
        }
    }
}
