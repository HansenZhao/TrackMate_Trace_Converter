using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.IO;

namespace XML2CSV
{
    class XmlConverter
    {
        private XmlDocument xmlDoc;
        private FileStream fileStream;
        private StreamWriter writer;
        private static string pattern = @"^\D+(?<frame>\d+)\D+(?<x>\d+.\d+)\D+(?<y>\d+.\d+)\D+(?<z>\d+.\d+)\D+$";
        private static string replace = "${frame},${x},${y},${z}\n";
        private Regex regex;

        public XmlConverter(string filePath,string savePath)
        {
            this.xmlDoc = new XmlDocument();
            xmlDoc.Load(filePath);
            FileInfo fileInfo = new FileInfo(savePath);
            if (!fileInfo.Directory.Exists)
            {
                fileInfo.Create();
            }
            this.fileStream = new FileStream(savePath, FileMode.Create, FileAccess.Write);
            this.writer = new StreamWriter(this.fileStream, Encoding.Default);
            this.regex = new Regex(XmlConverter.pattern);
        }

        public bool convert()
        {
            writeTitle();
            XmlElement root = this.xmlDoc.DocumentElement;
            XmlNodeList nodes = root.SelectNodes("particle");
            XmlNodeList tmpList = null;
            for(int i = 0; i < nodes.Count; i++)
            {
                tmpList = nodes.Item(i).SelectNodes("detection");
                writeParticle(tmpList, i);
            }
            tmpList = null;
            this.writer.Close();
            this.fileStream.Close();       
            return true;
        }

        public void release()
        {
            this.fileStream.Dispose();
            this.xmlDoc = null;
        }

        private void writeTitle()
        {
            this.writer.Write("ParticleID,frame,X,Y,Z\n");
        }
        private bool writeParticle(XmlNodeList list,int id)
        {
            for(int i = 0; i < list.Count; i++)
            {
                writer.Write(xmlText2csvText(list.Item(i).OuterXml, id));
            }
            return true;
        }

        private string xmlText2csvText(string xmlText,int id)
        {
            Match m = this.regex.Match(xmlText);
            if (m.Success)
            {
                string tmp = regex.Replace(xmlText, XmlConverter.replace);
                return id + "," + tmp;
            }
            return null;
        }
    }
}
