using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MissingParameterIdentifier.Data
{
    internal class CsvUtility : Missing_Parameter_Identifier
    {
        public List<string> fileToUploads1 = new List<string>();
        public Dictionary<string, string> GetOverallCsvParameter(List<string> fileToUploads)
        {
            Dictionary<string, string> dtListContains = new Dictionary<string, string>();
            string dup = " ";
            for (int j = 0; j < fileToUploads.Count; j++)
            {
                string[] temp = File.ReadAllLines(fileToUploads[j]);
                try
                {
                    for (int i = 0; i < temp.Length; i++)
                    {
                        //string[] values = temp[i].Split(',');
                        string[] values = Regex.Split(temp[i], ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");
                       
                        if (values.Contains("Number"))
                        {
                            for (int k = i; k < temp.Length-1; k++)
                            {
                                values = Regex.Split(temp[k], ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");
                                //values = temp[k].Split(',');
                                string value = values[i == 0 ? 1 : 0];
                                value = value.Replace("\"", string.Empty);


                                if (!value.Contains(dup) && value.Contains("["))
                                {
                                    dup = value.Substring(0, value.IndexOf("["));


                                    if (!dtListContains.Keys.Contains(dup))
                                    {
                                        dtListContains.Add(dup, values[i == 0 ? 2 : 1]);
                                    }
                                    //continue;
                                }
                                else if (!value.Contains(dup) && value.Contains("."))
                                {
                                    dup = value.Substring(0, value.IndexOf('.'));

                                    if (!dtListContains.Keys.Contains(dup))
                                    {
                                        dtListContains.Add(dup, values[i == 0 ? 2 : 1]);
                                    }
                                    //continue;
                                }
                                else if (value.Contains(dup))
                                {
                                    continue;
                                }
                                else if (!value.Contains(dup))
                                {

                                    //if (!dtListContains.Keys.Contains(value))
                                    //{
                                    //    dtListContains.Add(value, values[i == 0 ? 2 : 1]);
                                    //}
                                    //else
                                    //{
                                    //    //System.Console.WriteLine("Dupicate");
                                    //    System.IO.File.AppendAllText("C:\\temp\\Duplicate.txt", value + " " + values[i == 0 ? 2 : 1] + Environment.NewLine);
                                    //}
                                    dtListContains.Add(value, values[i == 0 ? 2 : 1]);
                                }
                            }
                            break;
                        }   
                       
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }    
            }
            return dtListContains;
        }
        public List<string> CsvFile()
        {
            var o = new OpenFileDialog();
            o.Filter = "Select Valid Document(*.xlsx;*.xls;*.csv)|*.xlsx;*.xls;*.csv;";
            o.Multiselect = true;
            if (o.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                o.FileNames.ToList().ForEach(file =>
                {
                    var upload = System.IO.Path.GetFileName(opennessExcelfile.FileName);
                    //if (upload == null)
                    //{
                    //    uploads.Add(file);
                    //}
                    //else
                    //{
                    fileToUploads1.Add(file);
                    //checkedListBox2.Items.Add(Path.GetFullPath(file));
                    //toolStripStatusLabel1.Text = "CSV file is uploaded";
                    //}
                });

            }
            return fileToUploads1;
        }
    }
}
