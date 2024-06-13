using System.Management;

namespace GetSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String a = Environment.ProcessId + " " +
            Environment.MachineName + " " +
            Environment.UserName + " ";
                MessageBox.Show(a);
            
        }
    }
}
