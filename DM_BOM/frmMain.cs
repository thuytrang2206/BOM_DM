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

namespace DM_BOM
{
    public partial class frmMain : Form
    {
        int currentColor = 0;
        int a = 0;
        bool ON = false;
        List<Color> colors = new List<Color>();
        List<Data_BOM> list_bom = new List<Data_BOM>();
        List<Data_ECS> list_ecs = new List<Data_ECS>();
        List<Result> list_result = new List<Result>();
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
        }
        DataTableCollection tableCollcetion;
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
        public void reload()
        {
            try
            {
                if (Properties.Settings.Default.PathfileA != "" && Properties.Settings.Default.PathfileB != "")
                {
                    if (!Directory.Exists(Properties.Settings.Default.PathfileA))
                    {
                        using (var stream = File.Open(Properties.Settings.Default.PathfileA, FileMode.Open, FileAccess.Read))
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
                        using (var stream = File.Open(Properties.Settings.Default.PathfileB, FileMode.Open, FileAccess.Read))
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
        private void btn_BOM_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openfiledialog = new OpenFileDialog() { Filter = "All files (*.*)|*.*" })
            {
                if (openfiledialog.ShowDialog() == DialogResult.OK)
                {
                    using (var stream = File.Open(openfiledialog.FileName, FileMode.Open, FileAccess.Read))
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

        private void btn_ECS_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openfiledialog = new OpenFileDialog() { Filter = "All files (*.*)|*.*" })
            {
                if (openfiledialog.ShowDialog() == DialogResult.OK)
                {
                    timer1.Enabled = true;
                    ON = true;
                    using (var stream = File.Open(openfiledialog.FileName, FileMode.Open, FileAccess.Read))
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
            if (linkLabel2.BackColor == Color.White)
            {
                linkLabel2.BackColor = Color.DarkGray;
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                linkLabel2.BackColor = Color.White;
                WindowState = FormWindowState.Normal;
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

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(CboSheet.Items.Count==0 || cbosheettwo.Items.Count == 0)
            {
                MessageBox.Show("Please select file before pressing start", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataTable dt = new DataTable();
            datagridview_Result.DataSource = dt;
            dt.Columns.Add("PartNoBOM");
            dt.Columns.Add("Location");
            //for (int i = 0; i < datagridview_BOM.Rows.Count; i++)
            //{
            //    string value1 = datagridview_BOM.Rows[i].Cells[6].Value.ToString();
            //    string result1 = value1.Substring(0, 9);
            //    for (int j = 2; j < datagridview_ECS.Rows.Count - 1; j++)
            //    {
            //        string value2 = datagridview_ECS.Rows[j].Cells[0].Value.ToString();

            //        if (value2.Equals(result1)== true)
            //        {
            //            datagridview_BOM.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
            //            datagridview_ECS.Rows[j].DefaultCellStyle.BackColor = Color.Yellow;
            //            j++;
            //        }
            //        else
            //        {
            //            label5.Text = "Danh sách Part code trong file BOM còn thiếu!";
            //            label5.ForeColor = Color.Red;
            //            string[] row = { datagridview_ECS.Rows[j].Cells[0].Value.ToString() };
            //            dt.Rows.Add(row);

            //        }
            //    }
            //}
            list_bom.Clear();
            list_ecs.Clear();
            var result_bom = datagridview_BOM.Rows.OfType<DataGridViewRow>().Select(
              r => r.Cells.OfType<DataGridViewCell>().Select(c => c.Value).ToArray()).ToList();
            foreach (var item in result_bom)
            {
                    var data_bom = new Data_BOM() { BOM_Component = item[6].ToString(), Location = item[40].ToString() };
                    list_bom.Add(data_bom);
               
            }
            var result_ecs = datagridview_ECS.Rows.OfType<DataGridViewRow>().Select(r => r.Cells.OfType<DataGridViewCell>().Select(c => c.Value).ToArray()).ToList();
            foreach( var item_ecs in result_ecs)
            {
                var data_ecs = new Data_ECS() { PartNo = item_ecs[0].ToString(), Location = item_ecs[3].ToString() };
                list_ecs.Add(data_ecs);
            }
            if(bunifuSwitch1.Value == true)
            {
                foreach (var items in list_ecs)
                {
                    var check_result = list_bom.Where(x => x.BOM_Component.Substring(0, 9) == items.PartNo && (x.Location.Replace(",","")).Contains(items.Location.Replace(",",""))==true).FirstOrDefault();
                    if (check_result == null)
                    {
                        label5.Text = "MÃ BOM_SAP KHÔNG CÓ TRONG DANH SÁCH BOM_CUSTOMER";
                        label5.ForeColor = Color.Red;
                        label5.Location = new Point(100, 5);
                        var addlist = new Result() { BOM = items.PartNo, Incomplete= items.Location };
                        list_result.Add(addlist);
                        dt.Rows.Add(addlist.BOM.ToString(), addlist.Incomplete.ToString());
                    }
                }
            }
            else {
                foreach (var items in list_bom)
                {
                    string value1 = items.BOM_Component.ToString();
                    string tmp = value1.Substring(0, 9);
                    var check_result = list_ecs.Where(x => x.PartNo == tmp).FirstOrDefault();
                    if (check_result == null)
                    {
                        label5.Text = "MÃ BOM_CUSTOMER KHÔNG CÓ TRONG DANH SÁCH BOM_SAP";
                        label5.ForeColor = Color.Red;
                        label5.Location = new Point(100, 5);
                        var addlist = new Result() { BOM = items.BOM_Component };
                        list_result.Add(addlist);
                        dt.Rows.Add(addlist.BOM.ToString());
                    }
                }
            }
            ON = false;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //  reload();
           
        }

        private void bunifuSwitch1_Click(object sender, EventArgs e)
        {
            if (bunifuSwitch1.Value == true)
            {
                label5.Text = "Tìm kiếm vị trí thiếu trong Bom so với Tài liệu";
            }
            else
            {
                label5.Text = "Tìm kiếm vị trí thiếu trong Tài liệu so với BOM";
            }
        }
    }
}
