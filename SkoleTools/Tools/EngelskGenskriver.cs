using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkoleTools.Tools
{
    public partial class EngelskGenskriver : Form
    {
        public EngelskGenskriver()
        {
            InitializeComponent();
        }

        private void btnRewrite_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;






            string textToSpin = "Enter a article, need to spin......";
            string api_key = "Your-API-KEY";
            string serviceUri = "http://paraphrasingtool.pro/api.php";
            string lang = "en";

            string post_data = "api_key=" + api_key + "&article=" + textToSpin + "&lang=" + lang;

            // create a request
            HttpWebRequest request = (HttpWebRequest)
            WebRequest.Create(serviceUri);
            request.Method = "POST";

            // turn our request string into a byte stream
            byte[] postBytes = System.Text.Encoding.ASCII.GetBytes(post_data);

            // this is important - make sure you specify type this way
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = postBytes.Length;
            Stream requestStream = request.GetRequestStream();

            // now send it
            requestStream.Write(postBytes, 0, postBytes.Length);
            requestStream.Close();

            // grab te response and print it out to the console
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Console.WriteLine(new StreamReader(response.GetResponseStream()).ReadToEnd());
            Console.ReadLine();

            /*
            using (WebClient wc = new WebClient())
            {
                string response2 = wc.DownloadString($"https://paraphrasingtool.pro/php/verify.php");
                string response = wc.DownloadString($"https://paraphrasingtool.pro/php/process.php?data={input}&lang=en");
                txtOutput.Text = response;
            }
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://paraphrasingtool.pro/php/process.php");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "{\"data\":\"" + input + "\"," +
                              "\"lang\":\"en\"}";

                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                txtOutput.Text = streamReader.ReadToEnd();
            }
            */
        }
    }
}