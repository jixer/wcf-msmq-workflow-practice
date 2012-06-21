using System.Windows.Forms;
using Chris.Blog.MsmqWorkflow.Test.MsmqService;

namespace Chris.Blog.MsmqWorkflow.Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            var svcClient = new ChrisBlogMsmqWorkflowContractIMsmqServiceClient();
            var req = new StartProcessRequest() {MessageText = textBox1.Text};
            svcClient.StartProcess(req);
        }
    }
}
