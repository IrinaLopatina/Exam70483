using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

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
            string html = await GetHTML(uriTxtb.Text);
            htmlLbl.Text = html;
        }

    
        /// <summary>
        /// Asyncronously gets the html from url
        /// </summary>
        /// <param name="url">url whose html needs to be extracted</param>
        /// <returns>returns html code of url</returns>
        private async Task<string> GetHTML(string url = "https://www.google.com")
        {
            string htmlcode;
            using (WebClient client = new WebClient())
            {
                htmlcode = await client.DownloadStringTaskAsync(url);
            }
            return htmlcode;
        }
    }
}
