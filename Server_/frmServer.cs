

using EasyFunctions;
using System.Net.NetworkInformation;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using System.Data;

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
        public frmServer()
        {
            InitializeComponent();
        }
        private void frmServer_Load(object sender, EventArgs e)
        {
            sqlite_conn = clsFunctions.CreateConnection();
            refreshData();
            Clear();
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
                            timer1.Enabled = true;
                            Thread.Sleep(1000);
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
                idLine = dgv.Rows[e.RowIndex].Cells["Id"].Value._Int();
                lbLine.Text = dgv.Rows[e.RowIndex].Cells["LINE"].Value.ToString();
                lbCF.Text = dgv.Rows[e.RowIndex].Cells["CF"].Value.ToString();
                lbCode.Text = dgv.Rows[e.RowIndex].Cells["CODE"].Value.ToString();
                lbQuantity.Text = dgv.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();
            }
            catch { }
        }
        void Clear()
        {
            lbLine.Text = "";
            lbCF.Text = "";
            lbCode.Text = "";
            lbQuantity.Text = "";
        }
        private void btChecked_Click(object sender, EventArgs e)
        {
            try
            {
                clsFunctions.DeleteData(sqlite_conn, idLine);
                refreshData();
                Clear();
            }
            catch { }
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
