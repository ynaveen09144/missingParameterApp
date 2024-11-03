using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MissingParameterIdentifier.Data
{
    //class Generate_CSV_Utility
    //{
    //    public static void GenerateCSV(Dictionary<string, string> data)
    //    {
    //        string csv = string.Join(Environment.NewLine, data.Select(d => $"{d.Key},{d.Value};"));
    //        System.IO.File.WriteAllText(@"C:\missingParameter\missingparameters.csv", csv);

    //    }
    //}

    class Generate_CSV_Utility
    {
        public static void GenerateCSV(Dictionary<string, string> data)
        {
            string csv = string.Join(Environment.NewLine, data.Select(d => $"{d.Key},{d.Value}"));

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    System.IO.File.WriteAllText(filePath, csv);
                }
            }
        }
    }

}
