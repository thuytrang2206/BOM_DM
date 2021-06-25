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
    public partial class Form_Add_ICManager : Form
    {
        string constring = @"Data Source=172.28.10.17;Initial Catalog=BOM_DM;Persist Security Info=True;User ID=sa;PASSWORD=umc@2019";
        SqlConnection connect;
        SqlDataAdapter adapter;
        DataTable table;
        SqlCommand cmd;
        private Form_ICManager frm_icmanager;
        
        public Form_Add_ICManager(Form_ICManager frm_icmanager)
        {
            InitializeComponent();
            this.frm_icmanager = frm_icmanager;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                connect = new SqlConnection();
                connect.ConnectionString = constring;
                cmd = new SqlCommand("insert into Flash_memory(PartNoCUS,PartNoBOM) values (@partCUS,@partBOM) ", connect);
                connect.Open();
                cmd.Parameters.AddWithValue("@partCUS", txtPartCUS.Text);
                cmd.Parameters.AddWithValue("@partBOM", txtPartBOM.Text);
                if (txtPartCUS.Text == "" && txtPartBOM.Text == "")
                {
                    lblerrorpartlist.Text = "Data cannot be empty!";
                    lblerrormain.Text = "Data cannot be empty!";
                }
                else
                {
                    if (txtPartCUS.Text == "" && txtPartBOM.Text != "")
                    {
                        lblerrorpartlist.Text = "Data cannot be empty!";
                        lblerrormain.Text = "";
                    }
                    else
                    {
                        if (txtPartCUS.Text != "" && txtPartBOM.Text == "")
                        {
                            lblerrorpartlist.Text = "";
                            lblerrormain.Text = "Data cannot be empty!";
                        }
                        else
                        {
                            cmd.ExecuteNonQuery();
                            adapter = new SqlDataAdapter("Select * from Flash_memory", connect);
                            table = new DataTable();
                            adapter.Fill(table);
                            frm_icmanager.dtgv_Flashmemory.DataSource = table;
                            frm_icmanager.dtgv_Flashmemory.DataSource = table;
                            for (int i = 0; i < frm_icmanager.dtgv_Flashmemory.Rows.Count - 1; i++)
                            {
                                frm_icmanager.dtgv_Flashmemory.Rows[i].Cells["No"].Value = i + 1;
                            }
                            connect.Close();
                            Clear();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Clear()
        {
            txtPartCUS.Text = "";
            txtPartBOM.Text = "";
            this.Close();
        }
    }
}
