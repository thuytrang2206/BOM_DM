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
        SqlDataAdapter adapter_user;
        DataTable table_user;
        DataTable table;
        SqlCommand cmd;
        SqlCommand cmd_his;
        Form_ICManager frm_icmanager;
        Task task;
        private string staffcode;
        private int id_user;

        public Form_Add_ICManager()
        {
            InitializeComponent();
        }
        public Form_Add_ICManager(string staff_code, int iduser, Form_ICManager frm_icmanager)
        {
            this.staffcode = staff_code;
            this.id_user = iduser;
            this.frm_icmanager = frm_icmanager;
            InitializeComponent();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                connect = new SqlConnection();
                connect.ConnectionString = constring;
                cmd = new SqlCommand("insert into Flash_memory(PartNoCUS,PartNoBOM,Id_user) values (@partCUS,@partBOM,@iduser) ", connect);
                connect.Open();
                cmd.Parameters.AddWithValue("@partCUS", txtPartCUS.Text);
                cmd.Parameters.AddWithValue("@partBOM", txtPartBOM.Text);
                cmd.Parameters.AddWithValue("@iduser", id_user);
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
                            cmd_his = new SqlCommand("insert into History(Datetime,Id_user,Status,Note) values(@datetime,@id_user,@status,@note)", connect);
                            cmd_his.Parameters.AddWithValue("@datetime", DateTime.Now);
                            cmd_his.Parameters.AddWithValue("@id_user", id_user);
                            cmd_his.Parameters.AddWithValue("@status", Task.Add_data.ToString());
                            cmd_his.Parameters.AddWithValue("@note", "Add data with Part on bom customer to '" + txtPartCUS.Text + "' and Sub special to '" + txtPartBOM.Text + "' in IC Manager");
                            cmd_his.ExecuteNonQuery();
                            cmd.ExecuteNonQuery();
                            adapter = new SqlDataAdapter("Select * from Flash_memory", connect);
                            table = new DataTable();
                            adapter.Fill(table);
                            frm_icmanager.dtgv_Flashmemory.DataSource = table;
                            adapter_user = new SqlDataAdapter("select * from Users", connect);
                            table_user = new DataTable();
                            adapter_user.Fill(table_user);
                            for (int i = 0; i < frm_icmanager.dtgv_Flashmemory.Rows.Count; i++)
                            {
                                string x = frm_icmanager.dtgv_Flashmemory.Rows[i].Cells["Id_users"].Value.ToString();
                                foreach (DataRow dr in table_user.Rows)
                                {
                                    string name = dr["Id_user"].ToString();
                                    if (name == x)
                                    {
                                        frm_icmanager.dtgv_Flashmemory.Rows[i].Cells["Name_user"].Value = dr["Name"].ToString();

                                    }
                                }
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
