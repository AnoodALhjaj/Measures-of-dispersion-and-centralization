using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Diagnostics;
using Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace DataMining_
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        List<double> numbers = new List<double>();
        double[] terms;

        int Repeated = 1;
        int itemrep = 1;
        double[] Mo;
        String num;
        public RadForm1()
        {
            InitializeComponent();
        }

        //المنوال
        public List<double> mostFrequent(double[] arr)
        {
            Repeated = 1;
            itemrep = 1;
            List<double> mode = new List<double>();
            List<double> res = new List<double>();
            // Sort the array 
            Array.Sort(arr);


            //compare
            for (int i = 0; i < arr.Length - 1; i++)
            {
                double a = arr[i];
                double b = arr[i + 1];

                if (a == b)
                {
                    itemrep++;
                    if (mode.Contains(a))
                    {
                       

                        if (itemrep > Repeated)
                        {
                            Repeated = itemrep;
                        }

                    }
                    else
                    {
                        if (itemrep > Repeated)
                        {
                            Repeated = itemrep;
                        }
                        itemrep = 1;
                        mode.Add(a);
                       
                    }

                }
            }

            int count = 1;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    count++;
                    if (count == Repeated)
                    {

                        res.Add(arr[i]);
                    }
                }
                else { count = 1; }



            }

            
            return res;

        }


        //الانحراف المعياري

        String Standard_deviation(double[] terms, double Mean)
        {
            string num = "";
            double Sum = 0;
            for (int i = 0; i < terms.Length; i++)
            {
                Sum = Sum + (terms[i] * terms[i]);
            }
            double divide = Math.Round((double)(Sum) / terms.Length, 2);
            double div2 = Math.Round((Mean * Mean), 2);
            num = (Math.Round(Math.Sqrt(divide - div2), 2)).ToString();


            return num;
        }
        //المركز
        String MidRange(double[] terms)
        {
            String num = "";
            num = (Math.Round((((double)terms.Max() + terms.Min()) / 2), 2)).ToString();
            return num;
        }
        //التباين

        String variance(double[] terms, double Mean)
        {


            string num = "";
            double Sum = 0;
            for (int i = 0; i < terms.Length; i++)
            {
                Sum = Sum + Math.Pow((terms[i] - Mean), 2);
            }
            double divide = Math.Round((double)(Sum) / terms.Length, 4);
            num = (divide).ToString();


            return num;


        }
        void prepare()
        {
            terms = numbers.ToArray();
            radTextBox1.Text = "";
            for (int run = 0; run < terms.Length; run++)
            {
                if (run == 0)
                {
                    radTextBox1.Text = radTextBox1.Text + terms[run].ToString();

                }
                else
                {
                    radTextBox1.Text = radTextBox1.Text + "," + terms[run].ToString();
                }
            }

            radTextBox2.Text = "";
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            if (radTextBox2.Text != "")
            {
                numbers.Add(double.Parse(radTextBox2.Text));
                prepare();
            }
        }

        //الوسط
        double Mean(double[] terms)
        {
            
            if (terms.Length % 2 == 0)
            {
                double men = Math.Round((double)(terms[(terms.Length / 2) - 1] + terms[(terms.Length / 2)]) / 2, 2);


                return  men;
            }
            else
            {
               return terms[((terms.Length - 1) / 2)];
            }
        }

        private void radTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {
                if (!radTextBox2.AcceptsReturn && radTextBox2.Text.Length > 0)
                {
                    radButton1.PerformClick();
                }
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            String deviation = "";
            double mean;
            //الوسيط الحسابي
            double avarge = Math.Round((double)(terms.Sum()) / terms.Length, 2);
            //الانحراف المعياري

            deviation = Standard_deviation(terms, avarge);
            //المركز
            mean = Mean(terms);
            //التباين
            string va = variance(terms, avarge);


            //المنوال

            Mo = mostFrequent(terms).ToArray();
            
            num = "";
            
                for (int run = 0; run < Mo.Length; run++)
                {
                    if (run == 0)
                    {
                        num = num + Mo[run].ToString();

                    }
                    else
                    {
                        num = num + "," + Mo[run].ToString();
                    }
                }

             if(num==""){
                for (int run = 0; run < terms.Length; run++)
                {
                    if (run == 0)
                    {
                        num = num + terms[run].ToString();

                    }
                    else
                    {
                        num = num + "," + terms[run].ToString();
                    }
                }
            }


             radLabel1.Text = "(الوسط الحسابي) Avrage =" + "  " + avarge.ToString() + "\n" + "(الوسيط) Median =     " + mean.ToString() + "\n" + "(المنوال)  Mode=  [" + num + "]" + "\n" + " (الأنحراف المعياري) Standard deviation =  [" + deviation + "]" + "\n" + "(التباين) variance =  [" + va + "]" + "\n" + "(المركز) MidRange =  [" + MidRange(terms) + "]" + "\n" + "(المدى) Range =  [" + (terms.Max() - terms.Min()) + "]" + "\n" + "(معامل التشتت) CV =  [" + Math.Round(( (double.Parse(deviation)/avarge) *100),2) + "]";
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            if (terms != null)
            {
                numbers.Clear();
                Array.Clear(terms, 0, terms.Length);
                if (Mo != null)
                {
                    Array.Clear(Mo, 0, Mo.Length);
                }
                num = "";
                radLabel1.Text = "هنا سيتم عرض النتائج";
                radTextBox1.Text = "";
                label4.Text = "Xslx.أسم الملف";
            }
        }
    
        void CovertCv(String fn)
        {
            // Get the Excel application object.
            var excel_app = new Microsoft.Office.Interop.Excel.Application();
          

            // Make Excel visible (optional).
            excel_app.Visible = false;

            // Open the workbook read-only.
            Excel.Workbook workbook = excel_app.Workbooks.Open(
                fn,
                Type.Missing, true, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing);

            // Get the first worksheet.
            Excel.Worksheet sheet = (Excel.Worksheet)workbook.Sheets[1];

            // Get the values only.
            SetTitleAndListValues(sheet, 1, 1);
            

            // Close the workbook without saving changes.
            workbook.Close(false, Type.Missing, Type.Missing);

            // Close the Excel server.
            excel_app.Quit();
        }
        private void SetTitleAndListValues(Excel.Worksheet sheet,
    int row, int col)
        {
            Excel.Range range;

            // Set the title.
            range = (Excel.Range)sheet.Cells[row, col];
          

            // Get the values.
            // Find the last cell in the column.
            range = (Excel.Range)sheet.Columns[col, Type.Missing];
            Excel.Range last_cell =range.get_End(Excel.XlDirection.xlDown);

            // Get a Range holding the values.
            Excel.Range first_cell =
                (Excel.Range)sheet.Cells[row , col];
            Excel.Range value_range =
                (Excel.Range)sheet.get_Range(first_cell, last_cell);

            // Get the values.
            object[,] range_values = (object[,])value_range.Value2;

            // Convert this into a 1-dimensional array.
            // Note that the Range's array has lower bounds 1.
            int num_items = range_values.GetUpperBound(0);
            double[] values1 = new double[num_items];
            for (int i = 0; i < num_items; i++)
            {
                values1[i] = (double)range_values[i + 1, 1];
               numbers.Add(values1[i]);
            }
            prepare();
            // Display the values in the ListBox.
            
        }
        
        

        private void radButton4_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"E:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "xlsx",
                Filter = "xlsx files (*.xlsx)|*.xlsx",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                label4.Text = openFileDialog1.FileName;
                CovertCv(openFileDialog1.FileName);
            }  
        }

        
    }



    

}
