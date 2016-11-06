using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetManagement
{
    public class file
    {
        public void Export(DataGridView dataGridView1, string Filename)
        {
            //Filepath
            string filepath = @"C:/charts/" + Filename + ".txt";

            try
            {
                using (StreamWriter writer = new StreamWriter(filepath))
                {
                    int rowCount = dataGridView1.Rows.Count;

                    for (int i = 0; i < rowCount - 1; i++)
                    {
                        string description = dataGridView1.Rows[i].Cells[0].Value.ToString();
                        string value = dataGridView1.Rows[i].Cells[1].Value.ToString();

                        writer.Write(description);
                        writer.Write("\t");
                        writer.Write(value);
                        writer.Write("\r\n");
                    }
                }

                MessageBox.Show("File succesfully saved!");

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
                MessageBox.Show("Unable to save data!");
            }
            
        }


        public void Import(DataGridView dataGridView1, string Filename)
        {
            //Filepath
            string filepath = @"C:/charts/" + Filename + ".txt";

            //Lists to store descriptions and amounts
            List<string> descriptionList = new List<string>();
            List<decimal> valueList = new List<decimal>();

            try
            {
                using (StreamReader reader = new StreamReader(filepath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] lines = line.Split('\t');

                        descriptionList.Add(lines[0]);
                        valueList.Add(Convert.ToDecimal(lines[1]));
                    }
                }

                //Add items inside Lists into dataGridView
                for (int i = 0; i < descriptionList.Count; i++)
                {
                    dataGridView1.Rows.Add(descriptionList[i], valueList[i]);
                }

                MessageBox.Show("File succesfully imported!");

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
                MessageBox.Show("Unable to save data!");
            }
        }


    }
}
