using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetManagement
{
    public partial class Form1 : Form
    {
        private income Income;
        private cost Cost;

        public Form1()
        {
            InitializeComponent();

            dataGridView1.Columns[0].ValueType = typeof(string);
            dataGridView1.Columns[1].ValueType = typeof(decimal);

            dataGridView2.Columns[0].ValueType = typeof(string);
            dataGridView2.Columns[1].ValueType = typeof(decimal);

            chart1.Series["Income"]["PointWidth"] = "1.5";
            chart1.Series["Costs"]["PointWidth"] = "1.5";

            tabControl1.SelectedIndexChanged += TabControl1_SelectedIndexChanged;

        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex == 2)
            {
                Chart1();
            }
        }

        private void saveIncomeButton_Click(object sender, EventArgs e)
        {
            int rows = dataGridView1.Rows.Count;

            Income = new income();
            string[] desc = new string[rows];
            decimal[] amount = new decimal[rows];

            for (int i = 0; i < rows; i++)
            {
                desc[i] = Convert.ToString(dataGridView1.Rows[i].Cells["descriptionColumn"].Value);
                amount[i] = Convert.ToDecimal(dataGridView1.Rows[i].Cells["amountColumn"].Value);
            }

            Income.Amount = amount;
            Income.Description = desc;

            incomeLabel.Text = "€" + Income.GetTotal().ToString();
        }

        private void saveCostButton_Click(object sender, EventArgs e)
        {
            int rows = dataGridView2.Rows.Count;

            Cost = new cost();
            string[] desc = new string[rows];
            decimal[] amount = new decimal[rows];


            for (int i = 0; i < rows; i++)
            {
                desc[i] = Convert.ToString(dataGridView2.Rows[i].Cells["description2Column"].Value);
                amount[i] = Convert.ToDecimal(dataGridView2.Rows[i].Cells["amount2Column"].Value);
            }

            Cost.Amount = amount;
            Cost.Description = desc;

            costLabel.Text = "€" + Cost.GetTotal().ToString();
        }

        private void Chart1()
        {
            decimal income = Income.GetTotal();
            decimal costs = Cost.GetTotal();

            chart1.Series["Income"].Points.AddXY(1d, Convert.ToDouble(income));
            chart1.Series["Costs"].Points.AddXY(2d, Convert.ToDouble(costs));
        }



    }
}
