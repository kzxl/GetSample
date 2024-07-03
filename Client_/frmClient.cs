using EasyFunctions;
using System.Data;
using System.IO.Ports;

namespace Client_
{
    public partial class frmClient : Form
    {
        public frmClient()
        {
            InitializeComponent();
        }
        string LINE, IPServer, Folder;
        SerialPort serPort;

        private void btSend_Click(object sender, EventArgs e)
        {
            try
            {
                bool bSend = true;
                if (txtCF.Text == "")
                {
                    bSend = false;
                    dxErr.SetError(txtCF, "Not Empty");
                }
                if (txtCODE.Text == "")
                {
                    bSend = false;
                    dxErr.SetError(txtCODE, "Not Empty");
                }
                if (txtQuatity.Text == "")
                {
                    bSend = false;
                    dxErr.SetError(txtQuatity, "Not Empty");
                }
                if (bSend)
                {
                    //Send to Server
                    clsFunctions.SentMess("MESS/" + lbLINE.Text + "/" + txtCF.Text + "/" + txtCODE.Text + "/" + txtQuatity.Text, IPServer, 6666);
                    //Open frmDetail

                    frmClientDetail frmClientDetail = new frmClientDetail(txtCF.Text, txtCODE.Text, txtQuatity.Text, Folder);
                    this.Hide();
                    frmClientDetail.Closed += (s, args) => this.Close();
                    if (clsFunctions.checkCOMExits("COM7"))
                    {
                        serPort.Close();
                    }
                    //frmClientDetail.Show();
                    frmClientDetail.ShowDialog();

                    if (frmClientDetail.DialogResult == DialogResult.OK)
                    {
                        txtCF.Text = "";
                        txtCODE.Text = "";
                        txtQuatity.Text = "";
                    }
                }
            }catch(Exception ex) { MessageBox.Show(ex.Message); }

        }
        
        private void frmClient_Load(object sender, EventArgs e)
        {
            LoadInfo();
            //Check COM exist
            if (clsFunctions.checkCOMExits("COM7"))
            {
                serPort = new SerialPort("COM7"); // thats the USB port on which the scanner is connected
                serPort.DataReceived += new SerialDataReceivedEventHandler(serial_DataReceived);
                serPort.Open();
            }

        }

        void LoadInfo()
        {
            if (File.Exists("Settings.xml"))
            {
                string xmlFile = "Settings.xml";
                DataSet dsXML = new DataSet();
                dsXML.ReadXml(xmlFile, XmlReadMode.InferSchema);
                LINE = dsXML.Tables["GeneralInfo"].Rows[0]["LINE"].ToString();
                IPServer = dsXML.Tables["GeneralInfo"].Rows[0]["IPServer"].ToString();
                Folder = dsXML.Tables["GeneralInfo"].Rows[0]["Folder"].ToString();

                lbLINE.Text = LINE;

            }
        }

        private void serial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string response = serPort.ReadExisting();

            //do work
            if (response != null)
            {
                txtCF.Text = response.Split(new char[] { '\r', '\n', })[0];
                txtCODE.Text = response.Split(new char[] { '\r', '\n' })[1];

            }
        }
        private void SavetoExcel()
        {

        }
    }
}

