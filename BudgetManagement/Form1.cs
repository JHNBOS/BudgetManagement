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

            //ComboBox handler
            chartComboBox.SelectedIndexChanged += ChartComboBox_SelectedIndexChanged;

            //ComboBox items
            chartComboBox.Items.Add("");
            chartComboBox.Items.Add("Column");
            chartComboBox.Items.Add("Pie");

            //Chart hide in begin
            chart3.Hide();

            //Methods to run

        }


        //Chart Settings
        private void ChartSettings()
        {
            //Legends settings
            chart3.Legends["Legend1"].Docking = Docking.Right;
            chart3.Legends["Legend1"].Alignment = StringAlignment.Near;
            chart3.Legends["Legend1"].Name = "Legend1";
            chart3.Legends["Legend1"].IsTextAutoFit = true;

           
            if (chart == "Column")
            {
                //Chart column settings
                chart3.Series["Income"]["PointWidth"] = "0.6";
                chart3.Series["Costs"]["PointWidth"] = "0.6";

                chart3.Series["Income"].Color = Color.DodgerBlue;
                chart3.Series["Costs"].Color = Color.Orange;

                chart3.Series["Income"].LabelBackColor = Color.White;
                chart3.Series["Income"].LabelBorderColor = Color.Gray;
                chart3.Series["Costs"].LabelBackColor = Color.White;
                chart3.Series["Costs"].LabelBorderColor = Color.Gray;

                chart3.Series["Income"].Label = "#VAL{C2}";
                chart3.Series["Costs"].Label = "#VAL{C2}";

                chart3.Series["Income"].IsVisibleInLegend = true;
                chart3.Series["Costs"].IsVisibleInLegend = true;

                chart3.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
            }
            else
            {
                //Chart pie settings
                chart3.Series["Pie"].IsValueShownAsLabel = true;

                chart3.Series["Pie"].Points[0].Color = Color.DodgerBlue;
                chart3.Series["Pie"].Points[1].Color = Color.Orange;

                chart3.Series["Pie"].Points[0].Name = "Income";
                chart3.Series["Pie"].Points[1].Name = "Costs";

                chart3.Series["Pie"].Points[0].Label = "#PERCENT";
                chart3.Series["Pie"].Points[1].Label = "#PERCENT";

                chart3.Series["Pie"].Points[0].LabelForeColor = Color.White;
                chart3.Series["Pie"].Points[1].LabelForeColor = Color.White;

                chart3.Series["Pie"].Points[0].LegendText = "Income";
                chart3.Series["Pie"].Points[1].LegendText = "Costs";

                chart3.Series["Pie"].Points[0].IsVisibleInLegend = true;
                chart3.Series["Pie"].Points[1].IsVisibleInLegend = true;
            }

            //Overall chart settings
            chart3.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.Black;
            chart3.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.Black;
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

            ChartSettings();

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

            ChartSettings();

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
                chart3.Show();
                ResetChart3();
                Chart3Column();
            }
            else if(chart == "Pie")
            {
                chart3.Show();
                ResetChart3();
                Chart3Pie();
            }
            else
            {
                MessageBox.Show("Please select a type of chart to display!");
            }

            incomeLabel.Text = "€" + Income.GetTotal();
            costLabel.Text = "€" + Cost.GetTotal();

            decimal remain = Income.GetTotal() - Cost.GetTotal();
            remainLabel.Text = "€" + remain;
        }

        //Begin of Button handlers  
        private void exportButton_Click(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("ddMMyyyyhhmmss");
            string path = "C:\\charts\\chart_" + date + ".png";

            chart3.SaveImage(path, ChartImageFormat.Png);

            MessageBox.Show("Chart succesfully exported!");
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            file file = new file();

            try
            {
                file.Import(dataGridView1, "income");
                file.Import(dataGridView2, "costs");

                MessageBox.Show("Files succesfully imported!");

               
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
                MessageBox.Show("Files could not be imported!");
            }

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            file file = new file();

            try
            {
                file.Export(dataGridView1, "income");
                file.Export(dataGridView2, "costs");

                MessageBox.Show("Files succesfully saved!");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
                MessageBox.Show("Files could not be saves!");
                throw;
            }
            
            incomeLabel.Text = "€" + Income.GetTotal();
            costLabel.Text = "€" + Cost.GetTotal();

            decimal remain = Income.GetTotal() - Cost.GetTotal();
            remainLabel.Text = "€" + remain;

        }
        //End of Button handlers



        //Begin of Event handlers
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
        //End of Event handlers


    }
}
