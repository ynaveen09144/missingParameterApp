using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using MissingParameterIdentifier;



namespace MissingParameterIdentifier.Data
{
    internal class XmlUtility : Missing_Parameter_Identifier
    {
        public string[] Xml(List<string> fileToUploadsxml)
        {
            string[] xml_Text = null;
            for (int i = 0; i < fileToUploadsxml.Count; i++)
            {
                xml_Text = XDocument.Load(@fileToUploadsxml[i]).Descendants("ParamName").Select(element => element.Value).ToArray();
            }
            return xml_Text;
        }
        public List<string> XmlFile()
        {
            var x = new OpenFileDialog();
            x.Filter = "Select Valid Document(*.xml;)|*.xml;";
            x.Multiselect = false;
            if (x.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                x.FileNames.ToList().ForEach(file =>
                {
                    var upload = System.IO.Path.GetFileName(XmlTextFile.FileName);
                    if (upload == null)
                    {
                        uploadsxml.Add(file);
                    }
                    else
                    {
                        fileToUploadsxml.Add(file);
                        listBox1.Items.Add(Path.GetFullPath(file));
                        toolStripStatusLabel1.Text = "Xml file is uploaded";
                    }
                });
            }
            return fileToUploadsxml;
        }
    } 
}

