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
        SqlCommand cmd_his;
        Form_MainSubSpecial frm_mainsub;
        SqlDataAdapter adapter_user;
        DataTable table_user;
        private string staffcode;
        private int id_user;
        public Form_AddMainSub()
        {
            InitializeComponent();
           
        }
        public Form_AddMainSub(string staff_code, int iduser,Form_MainSubSpecial frm_mainsub)
        {
            this.staffcode = staff_code;
            this.id_user = iduser;
            this.frm_mainsub = frm_mainsub;
            InitializeComponent();

        }
        public void Clear()
        {
            txtPartlistName.Text = "";
            txtSubbom.Text = "";
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                connect = new SqlConnection();
                connect.ConnectionString = constring;
                cmd = new SqlCommand("insert into Main_Sub(PartNoBom,SubBom,Id_user) values(@partnobom,@subbom,@id_user)", connect);
                connect.Open();
                cmd.Parameters.AddWithValue("@partnobom", txtPartlistName.Text);
                cmd.Parameters.AddWithValue("@subbom", txtSubbom.Text);
                cmd.Parameters.AddWithValue("@id_user", id_user);
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
                        if (txtPartlistName.Text != "" && txtSubbom.Text == "")
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
                            cmd_his.Parameters.AddWithValue("@note", "Add data with Part on bom customer to '" + txtPartlistName.Text + "' and Sub special to '" + txtSubbom.Text + "' in Main sub special");
                            cmd_his.ExecuteNonQuery();
                            cmd.ExecuteNonQuery();
                            adapter = new SqlDataAdapter("Select * from Main_Sub", connect);
                            table = new DataTable();
                            adapter.Fill(table);
                            frm_mainsub.dtgv_Mainsubspecial.DataSource = table;
                            table_user = new DataTable();
                            adapter_user = new SqlDataAdapter("select * from Users", connect);
                            adapter_user.Fill(table_user);
                            for (int i = 0; i < frm_mainsub.dtgv_Mainsubspecial.Rows.Count; i++)
                            {
                                string x = frm_mainsub.dtgv_Mainsubspecial.Rows[i].Cells["Iduser"].Value.ToString();
                                foreach (DataRow dr in table_user.Rows)
                                {
                                    string name = dr["Id_user"].ToString();
                                    if (name == x)
                                    {
                                        frm_mainsub.dtgv_Mainsubspecial.Rows[i].Cells["Name_user"].Value = dr["Name"].ToString();

                                    }
                                }
                                frm_mainsub.dtgv_Mainsubspecial.Rows[i].Cells["No"].Value = i + 1;
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

    }
}
