

using EasyFunctions;

namespace Server_
{
    public partial class frmServer : Form
    {
        public frmServer()
        {
            InitializeComponent();
        }
        private void frmServer_Load(object sender, EventArgs e)
        {
            if (clsFunctions.GetIPv4() != null)
            {
                foreach (string temp in clsFunctions.GetIPv4())
                {
                    lbIP.Text += " "+temp + " ";
                }
            }
            else { lbIP.Text += ""; }

            lbComputerName.Text +=" "+ clsFunctions.GetComputerName();

            clsFunctions.StartServer();
        }
    }
}
