using DM_BOM.MyClass;
using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DM_BOM
{
    public partial class frmMain : Form
    {
        int currentColor = 0;
        int a = 0;
        bool ON = false;
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        List<Color> colors = new List<Color>();
        List<Data_BOM> list_bom = new List<Data_BOM>();
        List<Data_BOM> list_bom_null = new List<Data_BOM>();
        List<Data_ECS> list_ecs = new List<Data_ECS>();
        List<Data_ECS> list_ecs_null = new List<Data_ECS>();
        List<Result> list_result = new List<Result>();
        List<Result> list_result_null = new List<Result>();
        List<Result_Location> list_rl = new List<Result_Location>();
        List<Result_Location_bomSap> list_location_bomsap_null = new List<Result_Location_bomSap>();
        List<Result_Location_bomSap> list_location_bomsap = new List<Result_Location_bomSap>();
        List<List_flash_memory> list_flash_memory = new List<List_flash_memory>();
        DataTableCollection tableCollcetion;
        DataTable dttable;
        DataTable dttable_flash_memory;
        SqlDataAdapter adapter_mainsub;
        SqlDataAdapter adapter_flashmemory;
        SqlConnection connect;
        string constring = @"Data Source=172.28.10.17;Initial Catalog=BOM_DM;Persist Security Info=True;User ID=sa;PASSWORD=umc@2019";
        void Connect()
        {
            try {
                if (!NetworkConnection.PingNetwork("172.28.10.17"))
                {
                    MessageBox.Show("Kiểm tra lại mạng kết nối!", "INTERNET WARNING!",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btn_BOM.Visible = false;
                    btn_ECS.Visible = false;
                    btnStart.Visible = false;
                    btn_MainSubSpecial.Visible = false;
                    label6.Enabled = false;
                    bunifuCircleProgressbar2.Enabled = false;
                }
                else
                {
                    connect = new SqlConnection();
                    connect.ConnectionString = constring;
                    connect.Open();
                    adapter_mainsub = new SqlDataAdapter("Select * from Main_Sub", connect);
                    adapter_flashmemory = new SqlDataAdapter("Select * from Flash_memory", connect);
                    dttable = new DataTable();
                    dttable_flash_memory = new DataTable();
                    adapter_mainsub.Fill(dttable);
                    adapter_flashmemory.Fill(dttable_flash_memory);
                    adapter_flashmemory.Dispose();
                    adapter_mainsub.Dispose();
                    connect.Close();
                }
                
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
        }
        
        public frmMain()
        {

            colors.Add(Color.FromArgb(0, 158, 71));
            colors.Add(Color.FromArgb(112, 191, 83));
            colors.Add(Color.FromArgb(216, 155, 40));
            colors.Add(Color.FromArgb(217, 102, 41));
            colors.Add(Color.FromArgb(217, 102, 41));
            colors.Add(Color.FromArgb(235, 83, 104));
            colors.Add(Color.FromArgb(223, 128, 255));
            colors.Add(Color.FromArgb(112, 48, 160));
            colors.Add(Color.FromArgb(107, 122, 187));
            colors.Add(Color.FromArgb(95, 136, 176));
            colors.Add(Color.FromArgb(70, 175, 227));
            colors.Add(Color.FromArgb(0, 158, 71));
            InitializeComponent();
            Connect();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }
        //private const int cGript = 16;
        //private const int cCaption = 32;
        //protected override void WndProc(ref Message m)
        //{
        //    if (m.Msg == 0x84)
        //    {
        //        Point pos = new Point(m.LParam.ToInt32());
        //        pos = this.PointToClient(pos);
        //        if (pos.Y < cCaption)
        //        {
        //            m.Result = (IntPtr)2;
        //            return;
        //        }
        //        if (pos.X >= this.ClientSize.Width - cGript && pos.Y >= this.ClientSize.Height - cGript)
        //        {
        //            m.Result = (IntPtr)17;
        //            return;
        //        }
        //    }
        //    base.WndProc(ref m);
        //}
        public static string GetRunningVersion()
        {
            try
            {
                return ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();
            }
            catch
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }
        private void btn_BOM_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openfiledialog = new OpenFileDialog() { Filter = "Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx" })/*All files (*.*)|*.**/
                {
                    if (openfiledialog.ShowDialog() == DialogResult.OK)
                    {
                        using (var stream = File.Open(openfiledialog.FileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                        {
                            Properties.Settings.Default.PathfileA = openfiledialog.FileName;
                            Properties.Settings.Default.Save();
                            timer1.Enabled = true;
                            ON = true;
                            label3.Text = openfiledialog.FileName.Split('\\').LastOrDefault();
                            label3.ForeColor = Color.Red;
                            using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                            {
                                DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                                {
                                    ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                                });
                                tableCollcetion = result.Tables;
                                CboSheet.Items.Clear();
                                foreach (DataTable table in tableCollcetion)
                                {
                                    CboSheet.Items.Add(table.TableName);
                                    CboSheet.SelectedIndex = 0;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_ECS_Click(object sender, EventArgs e)
        {
            try {
                using (OpenFileDialog openfiledialog = new OpenFileDialog() { Filter = "Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx" })
                {
                    if (openfiledialog.ShowDialog() == DialogResult.OK)
                    {
                        timer1.Enabled = true;
                        ON = true;
                        using (var stream = File.Open(openfiledialog.FileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                        {
                            Properties.Settings.Default.PathfileB = openfiledialog.FileName;
                            Properties.Settings.Default.Save();
                            label4.Text = openfiledialog.FileName.Split('\\').LastOrDefault();
                            label4.ForeColor = Color.Red;
                            using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                            {
                                DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                                {
                                    ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                                });
                                tableCollcetion = result.Tables;
                                cbosheettwo.Items.Clear();
                                foreach (DataTable table in tableCollcetion)
                                {
                                    cbosheettwo.Items.Add(table.TableName);
                                    if (cbosheettwo.Items.Count > 4)
                                    {
                                        cbosheettwo.SelectedIndex = 4;
                                    }
                                    else
                                    {
                                        cbosheettwo.SelectedIndex = 0;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CboSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollcetion[CboSheet.SelectedItem.ToString()];
            datagridview_BOM.DataSource = dt;
        }

        private void cbosheettwo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollcetion[cbosheettwo.SelectedItem.ToString()];
            datagridview_ECS.DataSource = dt;
        }

        private void lblConfigs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel2_Click(object sender, EventArgs e)
        {
            if (WindowState.ToString() =="Narmal")
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
 
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToString("dd/MM/yyy hh:mm:ss");
            if (ON == true)
            {
                lbltime.ForeColor = Color.White;
                if (currentColor < colors.Count - 1)
                {

                    panel1.BackColor = Bunifu.Framework.UI.BunifuColorTransition.getColorScale(a, colors[currentColor], colors[currentColor + 1]);
                    if (a < 100)
                    {
                        a++;
                    }
                    else
                    {
                        a = 0;
                        currentColor++;
                    }
                }
            }
            else
            {
                timer1.Enabled = false;
                panel1.BackColor = Color.White;
                lbltime.ForeColor = Color.DimGray;
            }
        }
        public void Load_datatable_list_flash_memory()
        {
            list_flash_memory = (from DataRow row in dttable_flash_memory.Rows
                                 select new List_flash_memory()
                                 {
                                     PartNoCUS = row["PartNoCUS"].ToString().Replace("\r\n", ""),
                                     PartNoBOM = row["PartNoBOM"].ToString().Replace("\r\n", "")
                                 }).ToList();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            { 
                if (CboSheet.Items.Count == 0 || cbosheettwo.Items.Count == 0)
                {
                    MessageBox.Show("Please select file before pressing start", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DataTable dt = new DataTable();
                datagridview_Result.DataSource = dt;
                dt.Columns.Add("BOM NAME");
                dt.Columns.Add("LOCATION");
                list_bom.Clear();
                list_ecs.Clear();
                Load_datatable_list_flash_memory();     
                var result_bom = datagridview_BOM.Rows.OfType<DataGridViewRow>().Select(r => r.Cells.OfType<DataGridViewCell>().Select(c => c.Value).ToArray()).ToList();
                foreach (var item in result_bom)
                {
                    var data_bom = new Data_BOM() { BOM_Component = item[6].ToString(), Location = item[40].ToString().TrimEnd(' ') + item[41].ToString().TrimEnd(' ') + item[42].ToString().TrimEnd(' ') };
                    list_bom.Add(data_bom);
                }
                var result_ecs = datagridview_ECS.Rows.OfType<DataGridViewRow>().Select(r => r.Cells.OfType<DataGridViewCell>().Select(c => c.Value).ToArray()).ToList();
                foreach (var item_ecs in result_ecs)
                {        
                    
                    var data_ecs = new Data_ECS() { PartNo = item_ecs[0].ToString(), Location = item_ecs[3].ToString().Replace("\n", "") };
                    list_ecs.Add(data_ecs);
                }
                list_ecs.RemoveRange(0, 2);
                if (bunifuSwitch1.Value == true)
                {
                    label5.Text = "MÃ BOM KHÁCH HÀNG KHÔNG CÓ TRONG DANH SÁCH BOM SAP";
                    label5.ForeColor = Color.Green;
                    label5.Location = new Point(100, 5);
                    foreach (var items in list_ecs)
                    {
                        var check_result = list_bom.Where(x => x.BOM_Component.Substring(0, 9) == items.PartNo).FirstOrDefault();
                        if (check_result == null)
                        {
                            var addlist = new Result() { BOM = items.PartNo, Incomplete = items.Location };
                            list_result.Add(addlist);
                           // dt.Rows.Add(addlist.BOM.ToString(), addlist.Incomplete.ToString());
                        }
                    }
                    foreach ( var item_flash in list_result)
                    { 
                        var result_list_cus = list_flash_memory.Where(x => x.PartNoCUS == item_flash.BOM).FirstOrDefault();
                      
                        if (result_list_cus == null)
                        {                                
                                var addlistd = new Result_Location() { BOM = item_flash.BOM, Location= item_flash.Incomplete };
                                list_rl.Add(addlistd);
                        }
                        else
                        {
                            string name_bom = result_list_cus.PartNoBOM.ToString();
                            var result_list_bom = list_bom.Where(x => x.BOM_Component.Substring(0,9) == name_bom).FirstOrDefault();
                            if (result_list_bom == null)
                            {
                                var addlistd = new Result_Location() { BOM = item_flash.BOM, Location = item_flash.Incomplete };
                                list_rl.Add(addlistd);
                            }
                        }
                    }
                    foreach( var item_list_rl in list_rl)
                    {
                        dt.Rows.Add(item_list_rl.BOM.ToString(), item_list_rl.Location.ToString());
                    }
                    if (list_rl.Count() != 0)
                    {
                        label10.Text = "NG - HAI FILE BOM SAP VÀ BOM CUSTOMER KHÔNG TRÙNG NHAU!";
                        label10.ForeColor = Color.Red;
                        label10.Size = new Size(120,14) ;
                    }
                    else
                    {
                        label10.Text = "OK - HAI FILE BOM SAP VÀ BOM CUSTOMER TRÙNG NHAU!";
                        label10.ForeColor = Color.Green;
                        label10.Size = new Size(120, 14);
                    }
                }
                else
                {
                    foreach (var items in list_bom)
                    {
                        string value_name_bom = items.BOM_Component.ToString().Substring(0, 9);
                        var check_result = list_ecs.Where(x => x.PartNo == value_name_bom).FirstOrDefault();
                        if (check_result != null)
                        {
                            string[] arrList_locationbom = (items.Location).Split(',');
                            string[] arrList_locationecs = check_result.Location.Split(',');
                            string[] result_dist = arrList_locationbom.Except(arrList_locationecs).ToArray();
                            string result = string.Join(",", result_dist);
                            //var result = arrList_locationbom.Distinct().ToArray();
                            if (result != "")
                            {
                                var addlist = new Result() { BOM = items.BOM_Component, Incomplete = result };
                                list_result.Add(addlist);
                            }
                        }
                        else
                        {
                            var addlist = new Result_Location() { BOM = items.BOM_Component, Location = items.Location };
                            list_rl.Add(addlist);
                            var check_bom_in_listflash = list_flash_memory.Where(x => x.PartNoBOM == value_name_bom).FirstOrDefault();
                            if (check_bom_in_listflash != null)
                            {
                                string name_part_list = check_bom_in_listflash.PartNoCUS.ToString();
                                var check_bom_in_partlist = list_ecs.Where(x => x.PartNo == name_part_list).FirstOrDefault();
                                if (check_bom_in_partlist != null)
                                {
                                    string[] arrList_locationbom = (items.Location).Split(',');
                                    string[] arrList_locationecs = check_bom_in_partlist.Location.Split(',');
                                    string[] result_dist = arrList_locationbom.Except(arrList_locationecs).ToArray();
                                    string result = string.Join(",", result_dist);
                                    //var result = arrList_locationbom.Distinct().ToArray();
                                    if (result != "")
                                    {
                                        var addlist1 = new Result() { BOM = items.BOM_Component, Incomplete = result };
                                        list_result.Add(addlist1);
                                    }
                                }
                            }
                        }
                    }
                    label5.Text = "VỊ TRÍ MÃ BOM SAP KHÔNG CÓ TRONG DANH SÁCH BOM CUSTOMER";
                    label5.ForeColor = Color.Green;
                    label5.Location = new Point(100, 5);
                    foreach (var item in list_result)
                    {
                        dt.Rows.Add(item.BOM.ToString(), item.Incomplete.ToString());
                    }
                    if (list_result.Count() != 0)
                    {
                        label10.Text = "NG - TÌM RA VỊ TRÍ CỦA BOM SAP KHÔNG CÓ TRONG BOM CUSTOMER!";
                        label10.ForeColor = Color.Red;
                        label10.Size = new Size(120, 14);
                    }
                    else
                    {
                        label10.Text = "OK - KHÔNG TÌM RA VỊ TRÍ CỦA BOM SAP THIẾU TRONG BOM CUSTOMER!";
                        label10.ForeColor = Color.Green;
                        label10.Size = new Size(120, 14);
                    }
                }

                bunifuCircleProgressbar2.Visible = true;
                label6.Visible = true;
                Properties.Settings.Default.Bom = CboSheet.Text;
                Properties.Settings.Default.ECS = cbosheettwo.Text;
                Properties.Settings.Default.Save();
                btnStart.Visible = false;
                btn_MainSubSpecial.Visible = false;
                datagridview_Result.AutoResizeColumns();
                datagridview_Result.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                ON = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }     
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //reload();
            CboSheet.Text = Properties.Settings.Default.Bom;
            cbosheettwo.Text = Properties.Settings.Default.ECS;
            lblVersion.Text = GetRunningVersion();
        }

        private void bunifuSwitch1_Click(object sender, EventArgs e)
        {
            if (bunifuSwitch1.Value == true)
            {
                label5.Text = "Tìm kiếm mã bom thiếu trong Bom so với Tài liệu";
            }
            else
            {
                label5.Text = "Tìm kiếm mã bom thiếu trong Tài liệu so với BOM";
            }
        }

        public void Restart()
        {
            CboSheet.Items.Clear();
            cbosheettwo.Items.Clear();
            datagridview_BOM.DataSource = list_bom_null;
            datagridview_ECS.DataSource = list_ecs_null;
            datagridview_Result.DataSource = list_location_bomsap_null;
            bunifuCircleProgressbar2.Visible = false;
            label6.Visible = false;
            btnStart.Visible = true;
            list_result = new List<Result>();
            list_rl= new List<Result_Location>();
            list_location_bomsap = new List<Result_Location_bomSap>();
            btn_MainSubSpecial.Visible = true;
            groupBox1.Visible = true;
          //  datagridview_Result.Size = new Size(400, 100);
            CboSheet.Text = Properties.Settings.Default.Bom;
            cbosheettwo.Text = Properties.Settings.Default.ECS;
            dtgv_bomcus.DataSource = list_result_null;
            dtgv_bomcus.Visible = false;
            panel3.Visible = false;
            label10.Text = "";
        }

        private void bunifuCircleProgressbar2_Click(object sender, EventArgs e)
        {
            Restart();
            reload();
            if (bunifuSwitch1.Value == true)
            {
                label5.Text = "Tìm kiếm vị trí thiếu trong Bom so với Tài liệu";
            }
            else
            {
                label5.Text = "Tìm kiếm vị trí thiếu trong Tài liệu so với BOM";
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Restart();
            reload();
            if (bunifuSwitch1.Value == true)
            {
                label5.Text = "Tìm kiếm vị trí thiếu trong Bom so với Tài liệu";
            }
            else
            {
                label5.Text = "Tìm kiếm vị trí thiếu trong Tài liệu so với BOM";
            }
        }

        public void reload()
        {
            try
            {
                if (Properties.Settings.Default.PathfileA != "" && Properties.Settings.Default.PathfileB != "")
                {
                    if (!Directory.Exists(Properties.Settings.Default.PathfileA))
                    {
                        using (var stream = File.Open(Properties.Settings.Default.PathfileA, FileMode.Open, FileAccess.Read,FileShare.ReadWrite))
                        {
                            timer1.Enabled = true;
                            ON = true;
                            label3.Text = Properties.Settings.Default.PathfileA.Split('\\').LastOrDefault();
                            label3.ForeColor = Color.Red;
                            using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                            {
                                DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                                {
                                    ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                                });
                                tableCollcetion = result.Tables;
                                CboSheet.Items.Clear();
                                foreach (DataTable table in tableCollcetion)
                                {
                                    CboSheet.Items.Add(table.TableName);
                                    CboSheet.SelectedIndex = 0;
                                }
                            }
                        }
                    }
                    //
                    if (!Directory.Exists(Properties.Settings.Default.PathfileB))
                    {
                        using (var stream = File.Open(Properties.Settings.Default.PathfileB, FileMode.Open, FileAccess.Read,FileShare.ReadWrite))
                        {
                            Properties.Settings.Default.PathfileB = Properties.Settings.Default.PathfileB;
                            Properties.Settings.Default.Save();
                            label4.Text = Properties.Settings.Default.PathfileB.Split('\\').LastOrDefault();
                            label4.ForeColor = Color.Red;
                            using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                            {
                                DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                                {
                                    ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                                });
                                tableCollcetion = result.Tables;
                                cbosheettwo.Items.Clear();
                                foreach (DataTable table in tableCollcetion)
                                {
                                    cbosheettwo.Items.Add(table.TableName);
                                    if (cbosheettwo.Items.Count > 4)
                                    {
                                        cbosheettwo.SelectedIndex = 4;
                                    }
                                    else
                                    {
                                        cbosheettwo.SelectedIndex = 0;
                                    }
                                }
                            }
                        }
                    }
                }
                CboSheet.Text = Properties.Settings.Default.Bom;
                cbosheettwo.Text = Properties.Settings.Default.ECS;               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_MainSubSpecial_Click(object sender, EventArgs e)
        {
            try {

                if (CboSheet.Items.Count == 0 || cbosheettwo.Items.Count == 0)
                {
                    MessageBox.Show("Please select file before pressing start", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DataTable dt_bomsap = new DataTable();
                datagridview_Result.DataSource = dt_bomsap;
                dt_bomsap.Columns.Add("PartNoBOM");
                dt_bomsap.Columns.Add("Location");
                DataTable dt_bomcus = new DataTable();
                dtgv_bomcus.DataSource = dt_bomcus;
                dt_bomcus.Columns.Add("PartNoBOM");
                dt_bomcus.Columns.Add("Location");
                list_bom.Clear();
                list_ecs.Clear();
                Load_datatable_list_flash_memory();
                var result_bom = datagridview_BOM.Rows.OfType<DataGridViewRow>().Select(r => r.Cells.OfType<DataGridViewCell>().Select(c => c.Value).ToArray()).ToList();
                foreach (var item in result_bom)
                {
                    var data_bom = new Data_BOM() { BOM_Component = item[6].ToString(), Location = item[40].ToString().TrimEnd(' ') + item[41].ToString().TrimEnd(' ') + item[42].ToString().TrimEnd(' ') };
                    list_bom.Add(data_bom);
                }
                var result_ecs = datagridview_ECS.Rows.OfType<DataGridViewRow>().Select(r => r.Cells.OfType<DataGridViewCell>().Select(c => c.Value).ToArray()).ToList();
                foreach (var item_ecs in result_ecs)
                {
                    var data_ecs = new Data_ECS() { PartNo = item_ecs[0].ToString(), Location = item_ecs[3].ToString().Replace("\n", "") };
                    list_ecs.Add(data_ecs);
                }
                list_ecs.RemoveRange(0, 2);
                foreach (var items in list_ecs)
                {
                    for (int i = 0; i < dttable.Rows.Count; i++)
                    {
                        string name_part_bom = dttable.Rows[i]["PartNoBom"].ToString().Replace("\r\n", "");
                        string name_sub_bom = dttable.Rows[i]["SubBom"].ToString().Replace("\r\n", "");
                        if (name_part_bom == items.PartNo)
                        {
                            var addlist = new Result() { BOM = items.PartNo, Incomplete = items.Location };
                            list_result.Add(addlist);
                            label9.Text = "MÃ BOM CUSTOMER CÓ MAIN_SUB ĐẶC BIỆT! ";
                            label9.ForeColor = Color.Green;
                            dtgv_bomcus.Visible = true;
                            dt_bomcus.Rows.Add(addlist.BOM, addlist.Incomplete);
                            foreach (var item_listbom in list_bom)
                            {
                                if(item_listbom.BOM_Component.Substring(0,9)== items.PartNo)
                                {
                                    string[] arrList_location_listbom = (item_listbom.Location).Split(',');
                                    string[] arrList_location_listresult = items.Location.Split(',');
                                    string[] result_dist = arrList_location_listresult.Intersect(arrList_location_listbom).ToArray();
                                    string result = string.Join(",", result_dist);
                                    //var result = arrList_locationbom.Distinct().ToArray();
                                    if (result != "")
                                    {
                                       
                                        var addlist_bom = new Result_Location() { BOM = item_listbom.BOM_Component, Location = item_listbom.Location };
                                        list_rl.Add(addlist_bom);
                                    }
                                }
                                if (item_listbom.BOM_Component.Substring(0, 9) == name_sub_bom)
                                {
                                    string[] arrList_location_listbom = (item_listbom.Location).Split(',');
                                    string[] arrList_location_listresult = items.Location.Split(',');
                                    string[] result_dist = arrList_location_listresult.Intersect(arrList_location_listbom).ToArray();
                                    string result = string.Join(",", result_dist);
                                    //var result = arrList_locationbom.Distinct().ToArray();
                                    if (result != "")
                                    {
                                        var addlist_bom = new Result_Location() { BOM = item_listbom.BOM_Component, Location = item_listbom.Location };
                                        list_rl.Add(addlist_bom);
                                    }
                                }
                            }
                            foreach(var item in list_rl)
                            {
                                label5.Text = "MÃ BOM SAP CÓ TRONG MAIN_SUB ĐẶC BIỆT! ";
                                label5.ForeColor = Color.Green;
                                label5.Location = new Point(100, 5);
                                dt_bomsap.Rows.Add(item.BOM.ToString(), item.Location.ToString());
                            }
                        }
                    }
                }
               
                bunifuCircleProgressbar2.Visible = true;
                label6.Visible = true;
                Properties.Settings.Default.Bom = CboSheet.Text;
                Properties.Settings.Default.ECS = cbosheettwo.Text;
                Properties.Settings.Default.Save();
                datagridview_Result.AutoResizeColumns();
                datagridview_Result.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                //datagridview_Result_main.AutoResizeColumns();
                //datagridview_Result_main.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                ON = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel2_Click_1(object sender, EventArgs e)
        {
            if (WindowState.ToString() == "Normal")
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void lblexport_Click(object sender, EventArgs e)
        {
            //if (datagridview_Result.Rows.Count > 0)
            //{
            //    SaveFileDialog save_csv = new SaveFileDialog();
            //    save_csv.Filter = "CSV (*.csv)|*.csv";
            //    save_csv.FileName = "CSV.csv";
            //    bool FileError = false;
            //    if (save_csv.ShowDialog() == DialogResult.OK)
            //    {
            //        if (File.Exists(save_csv.FileName))
            //        {
            //            try
            //            {
            //                File.Delete(save_csv.FileName);
            //            }
            //            catch (IOException ex)
            //            {
            //                FileError = true;
            //                MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
            //            }
            //        }
            //        if (!FileError)
            //        {
            //            try
            //            {
            //                int columnCount = datagridview_Result.Columns.Count;
            //                string columnNames = "";
            //                string[] outputCsv = new string[datagridview_Result.Rows.Count + 1];
            //                for (int i = 0; i < columnCount; i++)
            //                {
            //                    columnNames += datagridview_Result.Columns[i].HeaderText.ToString() + ",";
            //                }
            //                outputCsv[0] += columnNames;

            //                for (int i = 1; (i - 1) < datagridview_Result.Rows.Count; i++)
            //                {
            //                    for (int j = 0; j < columnCount; j++)
            //                    {
            //                        outputCsv[i] += datagridview_Result.Rows[i - 1].Cells[j].Value.ToString() + ",";
            //                    }
            //                }

            //                File.WriteAllLines(save_csv.FileName, outputCsv, Encoding.UTF8);
            //                MessageBox.Show("Data Exported Successfully !!!", "Info");
            //            }
            //            catch (Exception ex)
            //            {
            //                MessageBox.Show("Error :" + ex.Message);
            //            }
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("No Record To Export !!!", "Info");
            //    }

            //}
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            app.Application.Workbooks.Add(Type.Missing);
            for (int i = 1; i < datagridview_Result.Columns.Count + 1; i++)
            {
                app.Cells[1, 1] = label5.Text;
                app.Cells[2, i] = datagridview_Result.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < datagridview_Result.Rows.Count; i++)
            {
                for (int j = 0; j < datagridview_Result.Columns.Count; j++)
                {
                    app.Cells[i + 3, j + 1] = datagridview_Result.Rows[i].Cells[j].Value.ToString();
                }
            }
            if (dtgv_bomcus.Rows.Count > 0)
            {
                for (int i = 1; i < dtgv_bomcus.Columns.Count + 1; i++)
                {
                    app.Cells[1, 5] = label9.Text;
                    app.Cells[2, i + 4] = dtgv_bomcus.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dtgv_bomcus.Rows.Count; i++)
                {
                    for (int j = 0; j < dtgv_bomcus.Columns.Count; j++)
                    {
                        app.Cells[i + 3, j + 5] = dtgv_bomcus.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            
            app.Columns.AutoFit();
            app.Visible = true;
        }

        private void mainSubSpecialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form_MainSubSpecial().ShowDialog();
        }

        private void managerICToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form_ICManager().ShowDialog();
        }
    }
}
