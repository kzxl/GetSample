using EasyFunctions;

namespace Client_
{
    public partial class frmClient : Form
    {
        public frmClient()
        {
            InitializeComponent();
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            clsFunctions.SentMess("aaaaa", "192.168.15.115", 5000);
        }
    }
}
    
