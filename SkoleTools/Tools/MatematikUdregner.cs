using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkoleTools.Tools
{
    public partial class MatematikUdregner : Form
    {
        public MatematikUdregner()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string input = txtEquation.Text;
            
            using (WebClient wc = new WebClient())
            {
                string response = wc.DownloadString($"https://www.cymath.com/answer?q={input}");
                Console.WriteLine(response);
            }
            /*
            webResult.Navigated += (sender, e) =>
            {
                ((WebBrowser)sender).Document.GetElementById("Text").InnerHtml = "Bye";
            };
            */
            //webResult.Navigate($"https://www.cymath.com/answer?q={input}");
           
        }
    }
}