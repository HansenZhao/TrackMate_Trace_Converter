using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;

namespace XML2CSV
{
    public partial class XML2CSV : Form
    {
        private List<string> m_fileName;

        public XML2CSV()
        {
            InitializeComponent();
        }

        private void XML2CSV_Load(object sender, EventArgs e)
        {
            this.m_fileName = new List<string>();
            this.BTN_Convert.Enabled = false;
        }

        private void BTN_Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "xml file(*.xml)|*.xml";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.m_fileName.Add(openFileDialog.FileName);
                MessageBox.Show("已选择文件： " + this.m_fileName[0], "XML2CSCV", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.BTN_Convert.Enabled = true;
            }
        }

        private void BTN_Convert_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.Description = "选择保存文件的文件夹";
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                this.BTN_Load.Enabled = false;
                this.BTN_LoadFiles.Enabled = false;
                this.BTN_Convert.Enabled = false;
                foreach (string xmlFilePath in this.m_fileName)
                {
                    string saveName = getFileNameFromPath(xmlFilePath);
                    XmlConverter converter = new XmlConverter(xmlFilePath, folderDialog.SelectedPath + "\\" + saveName + ".csv");
                    if (!converter.convert())
                    {
                        MessageBox.Show("转换失败：" + xmlFilePath);
                        this.BTN_Load.Enabled = true;
                        this.BTN_LoadFiles.Enabled = true;
                    }
                    converter.release();
                }

                DialogResult res =
                    MessageBox.Show("转换完成！是否继续转换其他文件", "XML2CSV", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res == DialogResult.Yes)
                {
                    this.BTN_Load.Enabled = true;
                    this.BTN_LoadFiles.Enabled = true;
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void BTN_Info_Click(object sender,EventArgs e)
        {
            MessageBox.Show("Hansen Zhao: zhaohs12@163.com", "XML2CSV", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BTN_LoadFiles_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.Description = "选择包含xml文件的文件夹";
            if(folderDialog.ShowDialog() == DialogResult.OK)
            {
                this.m_fileName = findTargetFile(folderDialog.SelectedPath, "*.xml");
                MessageBox.Show("Find " + m_fileName.Count + " XML Files");
                this.BTN_Convert.Enabled = true;
            }
        }

        private List<string> findTargetFile(string path,string specific)
        {
            List<string> targetList = new List<string>();
            DirectoryInfo Dir = new DirectoryInfo(path);
            try
            {
                foreach(DirectoryInfo d in Dir.GetDirectories())
                {
                    List<string> tmp = findTargetFile(d.FullName, specific);
                    if(tmp.Count > 0)
                    {
                        foreach(string filePath in tmp)
                        {
                            targetList.Add(filePath);
                        }
                    }
                }

                foreach(FileInfo f in Dir.GetFiles(specific))
                {
                    targetList.Add(f.FullName);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return targetList;
        }

        private string getFileNameFromPath(string path)
        {
            int b = path.LastIndexOf("\\");
            string tmp = path.Substring(b+1);
            //string name = 
            //string tmp = path.Substring(0, b);
            //int a = path.Substring(0, b).LastIndexOf("\\");
            //a += 1;
            return tmp.Replace(".xml", string.Empty);
        }      
    }
}
