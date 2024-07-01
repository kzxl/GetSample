using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Client_
{
    public partial class frmClientFirstSetup : Form
    {
        public frmClientFirstSetup()
        {
            InitializeComponent();
        }
        void createXMLSettings(string LINE, string IPServer,string Folder)
        {
            try
            {
                if (!File.Exists("Settings.xml"))
                {
                    XmlWriterSettings settings = new XmlWriterSettings();
                    settings.Indent = true;
                    XmlWriter writer = XmlWriter.Create("Settings.xml", settings);
                    writer.WriteStartDocument();
                    writer.WriteStartElement("GeneralInfo");
                    writer.WriteElementString("LINE", LINE);
                    writer.WriteElementString("IPServer", IPServer);
                    writer.WriteElementString("Folder", Folder);
                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                    writer.Flush();
                    writer.Close();
                }
                else
                {
                    string xmlFile = Application.StartupPath + @"\Settings.xml";
                    XmlDocument xml = new XmlDocument();
                    xml.Load(xmlFile);
                    XmlNodeList nodes = xml.SelectNodes(@"/GeneralInfo");
                    foreach (XmlElement element in nodes)
                    {
                        element.SelectSingleNode("LINE").InnerText = LINE;
                        element.SelectSingleNode("IPServer").InnerText = IPServer;
                        element.SelectSingleNode("Folder").InnerText = Folder;
                        xml.Save(xmlFile);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void frmClientFirstSetup_Load(object sender, EventArgs e)
        {
            if (File.Exists("Settings.xml"))
            {
                frmClient frm = new frmClient();
                this.Hide();
                frm.Closed += (s, args) => this.Close();
                //frmClientDetail.Show();
                frm.ShowDialog();
            }

        }

        private void btSave_Click(object sender, EventArgs e)
        {
            bool bSave = true;
            if (txtLine.Text == "")
            {
                dxError.SetError(txtLine, "Not Empty");
                bSave = false;
            }
            if (txtip.Text == "")
            {
                dxError.SetError(txtip, "Not Empty");
                bSave = false;
            }
            if (txtFolder.Text == "")
            {
                dxError.SetError(txtFolder, "Not Empty");
                bSave = false;
            }
            if (bSave)
            {
                createXMLSettings(txtLine.Text, txtip.Text,txtFolder.Text);
                frmClient frm = new frmClient();
                frm.ShowDialog();
                this.Close();
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if(fbdFolder.ShowDialog() == DialogResult.OK)
            {
                txtFolder.Text = fbdFolder.SelectedPath;
            }
        }
    }
}
