using MissingParameterIdentifier.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MissingParameterIdentifier
{
    public partial class Missing_Parameter_Identifier : Form
    {
        public List<string> fileToUploadsxml = new List<string>();
        public List<string> uploadsxml = new List<string>();

        public List<string> fileRecievied = new List<string>();
        public List<string> fileToUploads = new List<string>();
      
        public List<string> uploads = new List<string>();


        public Missing_Parameter_Identifier()
        {
            InitializeComponent();  
        }
        private void upload_Xmlfile_Click(object sender, EventArgs e)
        {
            try
            {
                XmlUtility files = new XmlUtility();
                fileToUploadsxml =files.XmlFile();
                listBox1.Items.Add(fileToUploadsxml.FirstOrDefault());
                toolStripStatusLabel1.Text = "Xml file is uploaded";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void openness_Excel_Click(object sender, EventArgs e)
        {
            try
            {
                CsvUtility csv = new CsvUtility();
                fileRecievied = csv.CsvFile();
                foreach(var item in fileRecievied)
                checkedListBox2.Items.Add(item);
                toolStripStatusLabel1.Text = "CSV file is uploaded";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void process_final_Click(object sender, EventArgs e)
        {

            #region declaring variables, list...etc

            string[] xml_Text = null;
            DataTable dtexcel = new DataTable();


            Dictionary<string, string> dtListContains = new Dictionary<string, string>();



            #endregion

            toolStripStatusLabel1.Text = "Upload completed, Process started";

            Cursor.Current = Cursors.WaitCursor; //process starts

            #region Reading XML file

            XmlUtility a = new XmlUtility();
            xml_Text = a.Xml(fileToUploadsxml);



            #endregion

            #region Reading Excels and storing common and Not common parameter to list

            for (int i = 0; i < checkedListBox2.Items.Count; i++)
            {
                if (checkedListBox2.GetItemChecked(i) == true)
                {
                    fileToUploads.Add(checkedListBox2.Items[i].ToString());
                }
            }
            #endregion


            CsvUtility b = new CsvUtility();
            dtListContains = b.GetOverallCsvParameter(fileToUploads);
            Dictionary<string, string> finalParamMissing = new Dictionary<string, string>();
                foreach (var item in dtListContains)
                {
                    if (xml_Text.Contains(item.Key))
                        continue;
                    else
                        finalParamMissing.Add(item.Key, item.Value);
                }
            #region printing on excel
            
            GenerateExcel(finalParamMissing);

            #endregion

            toolStripStatusLabel1.Text = "Process completed";

                Cursor.Current = Cursors.Default; //process ends
        }



        private static List<string> ConvertExcelToDataTable(string filename)
        {
            List<string> listA = new List<string>();
            using (var reader = new StreamReader(filename))
            {
                
                
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    listA.Add(values[1]);
                    listA.Add(values[2]);
                }
            }
            return listA;
            
        }
        public static void GenerateExcel(Dictionary<string,string> data)
        {
            //Generate_CSV_Utility c = new Generate_CSV_Utility();
            Generate_CSV_Utility.GenerateCSV(data);

            ////foreach (var kvp in data)
            //  string csv = string.Join(Environment.NewLine,data.Select(d => $"{d.Key},{d.Value};"));
            ////string header = "Missing Parameters Values, Missing Parameters Names" + Environment.NewLine;
            ////String csv = String.Join(Environment.NewLine, kvp.Key, kvp.Value);
            ////String csv = String.Join(Environment.NewLine, data.Select(d => $"{d.Key}")/*, data.Select(d=>$"{d.Value}")*/);
            //System.IO.File.WriteAllText(@"D:\UI Imported parameter\z\missingparameters.csv",csv);


        }
    }
}


