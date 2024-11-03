using MissingParameterIdentifier.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MissingParameterIdentifier.Data;
using System.Xml;
using System.Windows.Forms;

namespace MissingParameterIdentifier
{
    class Program 
    {
        //static string xmlFullPath = String.Empty;
        //static string CsvFullPath = String.Empty;
        //[STAThread]
        //static void Main(string[] args)
        //{
        //    if (args.Length == 0)
        //    {
        //        //Console.WriteLine("Enter the full File name of the xml");
        //        //xmlFullPath = Console.ReadLine();
        //        string CompletePath = Console.ReadLine();
        //        var xmlCsvName = CompletePath.Split(',', ' ');

        //        if (xmlCsvName[0].Equals("MissingParameterIdentifier.exe"))
        //        {
        //            //MissingParameters main = new MissingParameters();
        //            //main.initiate();
        //        }

        //        List<string> fileToUpload = new List<string>();
        //        fileToUpload.Add(xmlCsvName[1]);
        //        XmlUtility xmlUtility = new XmlUtility();
        //        var xmlResult = xmlUtility.Xml(fileToUpload);

        //        //Console.WriteLine("Enter the full File name of the CSV");
        //        //CsvFullPath = Console.ReadLine();
        //        List<string> FileToUpload = new List<string>();
        //        for (int i = 2; i < xmlCsvName.Count(); i++)
        //            FileToUpload.Add(xmlCsvName[i]);

        //        CsvUtility csvUtility = new CsvUtility();
        //        var CSVResult = csvUtility.GetOverallCsvParameter(FileToUpload);
        //        Dictionary<string, string> finalParamMissing = new Dictionary<string, string>();
        //        foreach (var item in CSVResult)
        //        {
        //            if (xmlResult.Contains(item.Key))
        //                continue;
        //            else
        //                finalParamMissing.Add(item.Key, item.Value);
        //        }


        //        Generate_CSV_Utility.GenerateCSV(finalParamMissing);


        //        Console.ReadKey();
        //        //MissingParameters main = new MissingParameters();
        //        //main.initiate();
        //    }

        //public void initiate()
        //{

        //}
        //Application.EnableVisualStyles();
        //Application.SetCompatibleTextRenderingDefault(false);
        //Application.Run(new Missing_Parameter_Identifier());
        //}

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Missing_Parameter_Identifier());
        }
    }
}

