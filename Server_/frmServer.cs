

using EasyFunctions;
using System.Net.NetworkInformation;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using System.Data;
using ClosedXML.Excel;

namespace Server_
{
    public partial class frmServer : Form
    {
        private TcpListener tcpListener;
        private int appStatus;
        private TcpClient client;
        private List<TcpClient> clientList = new List<TcpClient>();
        private Thread th_StartListen;
        private Thread th_handleClient;
        SqliteConnection sqlite_conn;
        DataTable dt;
        int idLine;
        public static XLWorkbook workbook, workbookLogs;
        string CFPath, LogPath, Location1, Location2;
        System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"notification.wav");

        public frmServer()
        {
            InitializeComponent();
        }
        private void frmServer_Load(object sender, EventArgs e)
        {
            if (File.Exists("SSettings.xml"))
            {

                string xmlFile = "SSettings.xml";
                DataSet dsXML = new DataSet();
                dsXML.ReadXml(xmlFile, XmlReadMode.InferSchema);
                CFPath = dsXML.Tables["GeneralInfo"].Rows[0]["CFPath"].ToString();

                workbook = new XLWorkbook(CFPath);

                LogPath = dsXML.Tables["GeneralInfo"].Rows[0]["LogPath"].ToString();
            }
            if (File.Exists("mydb.db"))
                sqlite_conn = clsFunctions.CreateConnection();
            else
            {
                sqlite_conn = clsFunctions.CreateConnection();
                clsFunctions.CreateTable(sqlite_conn);
            }

            refreshData();
            Clear();
            if (!File.Exists("SSettings.xml"))
                lbLocation.Text = "Chưa chọn file chứa CF, vui lòng chọn ở Setting";
            else
                lbLocation.Text = "";
            btChecked.Enabled = false;

            if (clsFunctions.GetIPv4() != null)
            {
                foreach (string temp in clsFunctions.GetIPv4())
                {
                    lbIP.Text += " " + temp + " ";
                }
            }
            else { lbIP.Text += ""; }

            lbComputerName.Text += " " + clsFunctions.GetComputerName();


            th_StartListen = new Thread(new ThreadStart(StartListen));
            th_StartListen.Start();


        }
        private void StartListen()
        {
            //Creating a TCP Connection and listening to the port
            tcpListener = new TcpListener(System.Net.IPAddress.Any, 6666);
            tcpListener.Start();
            lbStatus.Text = "Listening on port 6666 ...";
            int counter = 0;
            appStatus = 0;

            while (appStatus != 2)
            {
                try
                {
                    client = tcpListener.AcceptTcpClient();
                    counter++;
                    clientList.Add(client);
                    IPEndPoint ipend = (IPEndPoint)client.Client.RemoteEndPoint;
                    //Updating status of connection
                    lbStatus.Text = "Connected from " + IPAddress.Parse(ipend.Address.ToString());

                    //lstUser.Items.Add(ipend.Address.ToString() + " " + counter);

                    appStatus = 1;
                    th_handleClient = new Thread(delegate () { handleClient(client, counter); });
                    th_handleClient.Start();

                }
                catch (Exception err)
                {

                }
            }
        }

        private void handleClient(object client, int i)
        {
            try
            {
                TcpClient streamData = (TcpClient)client;
                byte[] data = new byte[4096];
                byte[] sendData = new byte[4096];
                int byteRead;
                string strdata;
                ASCIIEncoding encode = new ASCIIEncoding();
                Thread.Sleep(1000);
                NetworkStream networkstream = streamData.GetStream();

                StreamWriter writer = new StreamWriter(networkstream);
                StreamReader reader = new StreamReader(networkstream);
                //Send Command 1
                sendData = encode.GetBytes("1");
                //networkstream.Write(sendData, 0, sendData.Length);
                writer.WriteLine(sendData);
                //networkstream.Flush();
                //Listen...
                while (true)
                {

                    //byteRead = 8;
                    //byteRead = networkstream.Read(data, 0, 4096);

                    if (networkstream.DataAvailable == true)
                    {


                        //MessageBox.Show(byteRead.ToString());
                        //strdata = Encoding.ASCII.GetString(data, 0, byteRead);
                        strdata = reader.ReadLine();
                        //Get user info
                        if (strdata.StartsWith("MESS"))
                        {

                            lbLine.Text = strdata.Split('/')[1];
                            lbCF.Text = strdata.Split('/')[2];
                            lbCode.Text = strdata.Split('/')[3];
                            lbQuantity.Text = strdata.Split('/')[4];
                            clsFunctions.InsertData(sqlite_conn, strdata.Split('/')[1], strdata.Split('/')[2], strdata.Split('/')[3], strdata.Split('/')[4]);
                            player.Play();
                            //refreshData();
                            // break;
                            timer1.Enabled = true;
                            Thread.Sleep(2000);
                            timer1.Enabled = false;
                        }
                        if (strdata.StartsWith("END"))
                        {

                        }
                    }
                }

            }
            catch (Exception)
            {

            }

        }
        void refreshData()
        {
            dt = clsFunctions.ExecuteReadQuery("Select * from LineInfo order by DATE DESC", sqlite_conn);
            dgv.AutoGenerateColumns = false;
            dgv.DataSource = dt;
        }
        void getDataByID(int id)
        {
            try
            {

            }
            catch { }
        }
        private void frmServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            refreshData();


        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ckLocation1.Text = "Không tìm thấy vị trí";
                ckLocation1.Enabled = false;
                ckLocation2.Text = "Không tìm thấy vị trí";
                ckLocation2.Enabled = false;
                btChecked.Enabled = true;
                Clear();
                idLine = dgv.Rows[e.RowIndex].Cells["Id"].Value._Int();
                lbLine.Text = dgv.Rows[e.RowIndex].Cells["LINE"].Value.ToString();
                lbCF.Text = dgv.Rows[e.RowIndex].Cells["CF"].Value.ToString();
                lbCode.Text = dgv.Rows[e.RowIndex].Cells["CODE"].Value.ToString();
                lbQuantity.Text = dgv.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();
                //
                if (CheckCFLocation(lbCode.Text.Trim()).Split('/')[0] == "")
                {
                    Location2 = ckLocation2.Text = "Vị trí mới: " + CheckCFLocation(lbCode.Text.Trim())[1];
                    ckLocation2.Checked = true;
                    ckLocation2.Enabled = true;

                    ckLocation1.Text = "Không tìm thấy vị trí cũ";
                    ckLocation1.Enabled = false;
                }
                else

                    if (CheckCFLocation(lbCode.Text.Trim()).Split('/')[1] == "")
                {
                    Location1 = ckLocation1.Text = "Vị trí cũ: " + CheckCFLocation(lbCode.Text.Trim())[0];
                    ckLocation1.Checked = true;
                    ckLocation1.Enabled = true;

                    ckLocation2.Enabled = false;
                    ckLocation2.Text = "Không tìm thấy vị trí mới";
                }
                else
                {
                    Location1 = CheckCFLocation(lbCode.Text.Trim()).Split('/')[0];
                    ckLocation1.Text = "Vị trí cũ: " + CheckCFLocation(lbCode.Text.Trim()).Split('/')[0];
                    ckLocation1.Enabled = true;

                    Location2 = CheckCFLocation(lbCode.Text.Trim()).Split('/')[1];
                    ckLocation2.Text = "Vị trí mới: " + CheckCFLocation(lbCode.Text.Trim()).Split('/')[1];
                    ckLocation2.Enabled = true;
                }


            }
            catch { }
        }
        string CheckCFLocation(string CODE)
        {
            try
            {
                string _location = "";
                if (!string.IsNullOrEmpty(CFPath))
                {
                    int row = 9;

                    var ws = workbook.Worksheet(1);
                    int lastRow = ws.LastRowUsed().RowNumber();
                    while (row < lastRow + 1)
                    {
                        if (CODE.Equals(ws.Cell("B" + row).Value.ToString().Trim()))
                        {
                            _location = ws.Cell("E" + row).Value.ToString() + "/" + ws.Cell("G" + row).Value.ToString();
                        }
                        row++;
                    }


                    return _location;

                }
                else
                {
                    return _location;
                }
            }
            catch { return ""; }
        }
        void Clear()
        {
            ckLocation1.Text = "Không tìm thấy vị trí";
            ckLocation1.Enabled = false;
            ckLocation2.Text = "Không tìm thấy vị trí";
            ckLocation2.Enabled = false;
            btChecked.Enabled = true;

            lbLine.Text = "";
            lbCF.Text = "";
            lbCode.Text = "";
            lbQuantity.Text = "";
            lbLocation.Text = "";
        }
        private void btChecked_Click(object sender, EventArgs e)
        {
            try
            {
                if (ckLocation1.CheckState != CheckState.Checked && ckLocation2.CheckState != CheckState.Checked)
                {
                    MessageBox.Show("Cần chọn vị trí để lưu");
                    return;
                }
                if (ckLocation1.Checked == true && ckLocation2.Checked==false)
                    Location2 = "";
                else
                if (ckLocation2.Checked == true&& ckLocation1.Checked==false)
                    Location1 = "";
                else
                { }    
                SaveLogs(lbLine.Text, lbCF.Text, lbCode.Text, lbQuantity.Text, Location1, Location2, DateTime.Now);
                clsFunctions.DeleteData(sqlite_conn, idLine);
                refreshData();
                Clear();
            }
            catch { }
        }
        void SaveLogs(string Line, string CF, string Code, string Quantity, string Location1, string Location2, DateTime Confirm)
        {
            try
            {
                if (File.Exists(LogPath + @"\SLogs.xlsx"))
                {
                    workbookLogs = new XLWorkbook(LogPath + @"\SLogs.xlsx");
                    var ws = workbookLogs.Worksheet(1);
                    int lastRow = ws.LastRowUsed().RowNumber();
                    ws.Cell("A" + (lastRow + 1)).Value = Line;
                    ws.Cell("B" + (lastRow + 1)).Value = CF;
                    ws.Cell("C" + (lastRow + 1)).Value = Code;
                    ws.Cell("D" + (lastRow + 1)).Value = Quantity;
                    ws.Cell("E" + (lastRow + 1)).Value = Location1;
                    ws.Cell("F" + (lastRow + 1)).Value = Location2;
                    ws.Cell("G" + (lastRow + 1)).Value = Confirm;
                    //
                    workbookLogs.Save();
                }
                else
                {
                    workbookLogs = new XLWorkbook();
                    var ws = workbookLogs.AddWorksheet("Logs");
                    //Header
                    ws.Cell("A1").Value = "LINE";
                    ws.Cell("B1").Value = "CF";
                    ws.Cell("C1").Value = "CODE";
                    ws.Cell("D1").Value = "Quantity";
                    ws.Cell("E1").Value = "Location 1";
                    ws.Cell("F1").Value = "Location 2";
                    ws.Cell("G1").Value = "Confirm";
                    //Data
                    ws.Cell("A2").Value = Line;
                    ws.Cell("B2").Value = CF;
                    ws.Cell("C2").Value = Code;
                    ws.Cell("D2").Value = Quantity;
                    ws.Cell("E2").Value = Location1;
                    ws.Cell("F2").Value = Location2;
                    ws.Cell("G2").Value = Confirm.ToString("dd/MM/yyyy hh:mm:ss tt");
                    workbookLogs.SaveAs(LogPath + @"\SLogs.xlsx");
                }
            }
            catch { }

        }
        private void btSetup_Click(object sender, EventArgs e)
        {
            frmServer_Setting f = new frmServer_Setting();
            if (f.ShowDialog() == DialogResult.OK)
                Clear();
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            refreshData();
        }
    }
    public class LineInfo
    {
        public string Line { get; set; }
        public string CF { get; set; }
        public string Code { get; set; }
        public string Quantity { get; set; }

    }
}
