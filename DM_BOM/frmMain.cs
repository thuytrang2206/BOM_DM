﻿using DM_BOM.MyClass;
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
        List<Result_Location> list_rl = new List<Result_Location>();
        List<Class1> _class = new List<Class1>();
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
                    var check_result = list_bom.Where(x => x.BOM_Component.Substring(0, 9) == items.PartNo/* && (x.Location.Replace(",","")).Contains(items.Location.Replace(",",""))==true*/).FirstOrDefault();
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
            else
            {
                foreach (var items in list_bom)
                {
                    label5.Text = "VỊ TRÍ CỦA BOM_SAP KHÔNG CÓ TRONG BOM_CUSTOMER";
                    label5.ForeColor = Color.Red;
                    label5.Location = new Point(100, 5);
                    string value1 = items.BOM_Component.ToString();
                    string tmp = value1.Substring(0, 9);
                    var check_result = list_ecs.Where(x => x.PartNo == tmp).FirstOrDefault();
                    if (check_result != null)
                    {
                        string[] arrList1 = (items.Location +"," + check_result.Location).Split(',');
                       // string[] arrList2 = check_result.Location.Split(',');
                        var result = arrList1.Distinct().ToArray();
                        if (result.Count() != 0)
                        {
                            var addlist = new Result() { BOM= items.BOM_Component, Incomplete = items.Location.ToString() };
                            list_result.Add(addlist);
                            dt.Rows.Add(addlist.BOM.ToString(), addlist.Incomplete.ToString());
                        }
        
                    }
                }
                //var disdistinctItems = list_result.GroupBy(c => c.BOM.Substring(0, 9)).Select(x => x.First()).ToList();
                //foreach (var items in disdistinctItems)
                //{
                //    list_result.Count();
                //    for (int i = 0; i < list_result.Count(); i++)
                //    {
                //        if (list_result[i].BOM.ToString().Substring(0, 9) == items.BOM)
                //        {
                //            string s = list_result[i].Incomplete.ToString() + "," + items.Incomplete;
                //            string[] ss = s.Split(',');
                //            string[] dist = ss.Distinct().ToArray();
                //            string result_dist = string.Join(",", dist);
                //            items.Incomplete = result_dist;
                //        }
                //    }
                //    // dt.Rows.Add(items.BOM, items.Incomplete);

                //    list_rl.Add(new Result_Location() { BOM = items.BOM, Location = items.Incomplete });

                //}
                //foreach (var item_result in list_rl)
                //{
                //    for (int i = 0; i < list_ecs.Count(); i++)
                //    {
                //        if (item_result.BOM == list_ecs[i].PartNo)
                //        {
                //            string[] d1 = (list_ecs[i].Location.ToString()).Split(',');
                //            string[] d2 = item_result.Location.Split(',');
                //            //string[] dist2 = dd.Distinct().ToArray();
                //            //string result_dist2 = string.Join(",", dist2);
                //            string[] result_dist2 = d1.Except(d2).ToArray();

                //            string dist2 = string.Join(",", result_dist2);
                //            if(dist2 != "")
                //            {

                //                item_result.Location = dist2;
                //               var add= new Class1 { BOM = item_result.BOM, Location = dist2 };
                //                _class.Add(add);
                //                dt.Rows.Add(add.BOM.ToString(), add.Location.ToString());
                //            }

                //        }
                //    }

                //}

                //094000720
            }
            ON = false;
        }
        public class ItemEqualityComparer<T> : IEqualityComparer<T> where T : class
        {
            private readonly PropertyInfo _propertyInfo;

            public ItemEqualityComparer(string keyItem)
            {
                _propertyInfo = typeof(T).GetProperty(keyItem, BindingFlags.GetProperty | BindingFlags.Instance | BindingFlags.Public);
            }

            public bool Equals(T x, T y)
            {
                var xValue = _propertyInfo?.GetValue(x, null);
                var yValue = _propertyInfo?.GetValue(y, null);
                return xValue != null && yValue != null && xValue.Equals(yValue);
            }

            public int GetHashCode(T obj)
            {
                var propertyValue = _propertyInfo.GetValue(obj, null);
                return propertyValue == null ? 0 : propertyValue.GetHashCode();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //  reload();
           
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

       
    }
}
