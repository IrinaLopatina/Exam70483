using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam70483_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await DoTimeConsumingTaskAsync();
        }

        private Task DoTimeConsumingTaskAsync()
        {
            Task task = Task.Run(() =>
            {
                using (var htmlReader = new HTML_Reader())
                {

                    var html = htmlReader.GetHtml();
                    //label1.Text = textBox1.Text;//html;
                    //label1.Text = html.Substring(0, 20);
                    textBox2.Text = html;//.Substring(0, 200);
                }
            });

            return task;
        }
    }
}
