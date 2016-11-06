using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BudgetManagement
{
    public partial class Form1 : Form
    {
        private income Income;
        private cost Cost;
        private string chart;

        public Form1()
        {
            InitializeComponent();

            //Datagridview handlers and setting valuetypes of columns
            dataGridView2.CellEndEdit += DataGridView2_CellEndEdit;
            dataGridView1.CellEndEdit += DataGridView1_CellEndEdit;

            dataGridView1.Columns[0].ValueType = typeof(string);
            dataGridView1.Columns[1].ValueType = typeof(decimal);

            dataGridView2.Columns[0].ValueType = typeof(string);
            dataGridView2.Columns[1].ValueType = typeof(decimal);

            //Chart settings
            chart3.Series["Income"]["PointWidth"] = "0.75";
            chart3.Series["Costs"]["PointWidth"] = "0.75";

            chart3.Enabled = false;
            chart3.Legends["Legend1"].Enabled = false;

            //ComboBox items
            chartComboBox.Items.Add("");
            chartComboBox.Items.Add("Column");
            chartComboBox.Items.Add("Pie");

            chartComboBox.SelectedIndexChanged += ChartComboBox_SelectedIndexChanged;
        }

        //Create Costs instance
        private void CreateCosts()
        {
            int rows = dataGridView2.Rows.Count;

            Cost = new cost();
            List<string> desc = new List<string>();
            List<decimal> amount = new List<decimal>();


            for (int i = 0; i < rows; i++)
            {
                desc.Add(Convert.ToString(dataGridView2.Rows[i].Cells["descriptionColumn2"].Value));
                amount.Add(Convert.ToDecimal(dataGridView2.Rows[i].Cells["amountColumn2"].Value));
            }

            Cost.Amount = amount;
            Cost.Description = desc;
        }

        //Create Income instance
        private void CreateIncome()
        {
            int rows = dataGridView1.Rows.Count;

            Income = new income();
            List<string> desc = new List<string>();
            List<decimal> amount = new List<decimal>();

            for (int i = 0; i < rows; i++)
            {
                desc.Add(Convert.ToString(dataGridView1.Rows[i].Cells["descriptionColumn"].Value));
                amount.Add(Convert.ToDecimal(dataGridView1.Rows[i].Cells["amountColumn"].Value));
            }

            Income.Amount = amount;
            Income.Description = desc;
        }

        //Create Column Chart
        private void Chart3Column()
        {
            CreateIncome();
            CreateCosts();

            decimal income = Income.GetTotal();
            decimal costs = Cost.GetTotal();

            chart3.ChartAreas.Add("ChartArea1");
            chart3.Series.Add("Income");
            chart3.Series.Add("Costs");

            chart3.Series["Income"].ChartType = SeriesChartType.Column;
            chart3.Series["Costs"].ChartType = SeriesChartType.Column;

            chart3.Enabled = true;
            chart3.Legends["Legend1"].Enabled = true;

            chart3.Series["Income"].Points.Add(Convert.ToDouble(income));
            chart3.Series["Costs"].Points.Add(Convert.ToDouble(costs));
        }

        //Create Pie Chart
        private void Chart3Pie()
        {
            CreateIncome();
            CreateCosts();

            decimal income = Income.GetTotal();
            decimal costs = Cost.GetTotal();

            chart3.ChartAreas.Add("ChartArea1");
            chart3.Series.Add("Pie");

            chart3.Series["Pie"].ChartType = SeriesChartType.Pie;

            chart3.Enabled = true;
            chart3.Legends["Legend1"].Enabled = true;

            chart3.Series["Pie"].Points.Add(Convert.ToDouble(income));
            chart3.Series["Pie"].Points.Add(Convert.ToDouble(costs));
        }

        //Reset chart
        private void ResetChart3()
        {
            chart3.ChartAreas.Clear();
            chart3.Series.Clear();
        }

        //Load Chart
        private void loadButton_Click(object sender, EventArgs e)
        {
            if (chart == "Column")
            {
                ResetChart3();
                Chart3Column();
            }
            else
            {
                ResetChart3();
                Chart3Pie();
            }

        }

        ////    Begin of Button handlers     ////
        private void exportButton_Click(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("ddMMyyyyhhmmss");
            string path = "C:\\charts\\chart_" + date + ".png";

            chart3.SaveImage(path, ChartImageFormat.Png);
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            file file = new file();

            file.Import(dataGridView1, "income");
            file.Import(dataGridView2, "costs");

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            file file = new file();

            file.Export(dataGridView1, "income");
            file.Export(dataGridView2, "costs");
        }
        ////    End of Button handlers     ////



        ////    Begin of Event handlers     ////
        private void ChartComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart = chartComboBox.SelectedItem.ToString();
        }

        private void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            CreateIncome();
        }

        private void DataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            CreateCosts();
        }
        ////    End of Event handlers     ////


    }
}
