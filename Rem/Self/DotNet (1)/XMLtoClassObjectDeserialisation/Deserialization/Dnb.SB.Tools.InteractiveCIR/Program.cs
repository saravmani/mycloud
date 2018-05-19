using Dnb.SB.Web.BC.CIRDashBoard.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Dnb.SB.Tools.InteractiveCIR
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var FilePath = Console.ReadLine();
                string attributeXml = string.Empty;

                if (File.Exists(FilePath))
                {
                    XmlDocument xmlDocument = new XmlDocument();
                    xmlDocument.Load(FilePath);
                    string xmlString = xmlDocument.OuterXml;
                    xmlString = xmlString.Replace("&", "&amp;");

                    using (StringReader read = new StringReader(xmlString))
                    {
                        Type outType = typeof(WidgetCollection);

                        XmlSerializer serializer = new XmlSerializer(outType);

                        using (XmlReader reader = new XmlTextReader(read))
                        {
                            var objectOut = (WidgetCollection)serializer.Deserialize(reader);
                            reader.Close();
                        }

                        read.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                //Log exception here
            }
        }
    }
}
