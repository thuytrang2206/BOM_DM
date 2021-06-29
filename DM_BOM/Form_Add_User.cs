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
        SqlDataAdapter adapter;
        DataTable table;
        SqlCommand cmd;
        private string staffcode;
        private int id_user;
        Frm_Users frmuser;
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
                cmd = new SqlCommand("insert into Users(Staff_code,Name,Password,Id_role) values (@staffcode,@name,@password,@id_role) ", connect);
                connect.Open();
                cmd.Parameters.AddWithValue("@staffcode", txtstaff.Text);
                cmd.Parameters.AddWithValue("@name", txtname.Text);
                cmd.Parameters.AddWithValue("@password", txtpass);
                cmd.Parameters.AddWithValue("@id_role", cmbrole.Text);
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
                //            cmd.ExecuteNonQuery();
                //            adapter = new SqlDataAdapter("Select * from Flash_memory", connect);
                //            table = new DataTable();
                //            adapter.Fill(table);
                //            frm_icmanager.dtgv_Flashmemory.DataSource = table;
                //            frm_icmanager.dtgv_Flashmemory.DataSource = table;
                //            for (int i = 0; i < frm_icmanager.dtgv_Flashmemory.Rows.Count - 1; i++)
                //            {
                //                frm_icmanager.dtgv_Flashmemory.Rows[i].Cells["No"].Value = i + 1;
                //            }
                //            connect.Close();
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

        private void Form_Add_User_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bOM_DMDataSet.Role_user' table. You can move, or remove it, as needed.
            this.role_userTableAdapter.Fill(this.bOM_DMDataSet.Role_user);

        }
    }
}
