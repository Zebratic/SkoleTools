using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SkoleTools.Libs;

namespace SkoleTools.Tools
{
    public partial class OpgaverDotComBypass : Form
    {
        public List<Image> pages = new List<Image>();
        public int CurrentImageIndex = 0;
        public int ID = 0;
        public OpgaverDotComBypass()
        {
            InitializeComponent();
        }

        private void btnDownloadOpgave_Click(object sender, EventArgs e)
        {
            string url = txtURL.Text;
            if (!url.Contains("http"))
                MessageBox.Show("Husk at copy paste hele linket til opgaven ind i feltet øverst!");
            else
            {
                pages = new List<Image>();
                CurrentImageIndex = 0;
                ID = Convert.ToInt32(url.Split('=')[1]);
                picPages.Image = null;
                txtOpgaven.Text = "Downloader...\nVent venligst...";
                lblOpgaveInfo.Text = $"Titel:\n\n\n" +
                                     $"Bruger:\n\n\n" +
                                     $"Fag:\n\n\n" +
                                     $"Uploadet:\n\n\n" +
                                     $"Klassetrin:\n\n\n" +
                                     $"Antal sider:\n\n\n" +
                                     $"Downloadet:\n\n\n" +
                                     $"Rating:\n";


                if (cbHTTPMethod.Checked)
                {
                    using (WebClient wc = new WebClient())
                    {
                        try
                        {
                            wc.Headers.Add("user-agent", "Mozilla/5.0 (iPad; CPU OS 6_0 like Mac OS X) AppleWebKit/536.26 (KHTML, like Gecko) Version/6.0 Mobile/10A5355d Safari/8536.25");
                            wc.Headers.Add("Referer", "https://www.google.com/");
                            string response = wc.DownloadString(url);
                            string titel = "";
                            string fag = "";
                            string uploadet = "";
                            string klassetrin = "";
                            string sidetal = "";
                            string downloaded = "";
                            string filinfo = "";
                            string bruger = "";
                            string brugersrating = "";



                            try { titel = response.Split(new string[] { "<span class=\"fn\">" }, StringSplitOptions.None)[1].Split('<')[0].FixEncoding(); } catch { }
                            try { bruger = response.Split(new string[] { "<span class=\"reviewer\">" }, StringSplitOptions.None)[1].Split('<')[0].FixEncoding(); } catch { }
                            try { fag = response.Split(new string[] { "<td width=\"300px\">" }, StringSplitOptions.None)[1].Split('<')[0].Replace("\n", "").Replace(" ", "").FixEncoding(); } catch { }
                            try { uploadet = response.Split(new string[] { "<span id=\"date\">" }, StringSplitOptions.None)[1].Split('<')[0].FixEncoding(); } catch { }
                            try { klassetrin = response.Split(new string[] { "Klassetrin:</b></td><td>" }, StringSplitOptions.None)[1].Split('<')[0].FixEncoding(); } catch { }
                            try { sidetal = response.Split(new string[] { "Antal sider:</b></td><td>" }, StringSplitOptions.None)[1].Split('<')[0].FixEncoding(); } catch { }
                            try { downloaded = response.Split(new string[] { "Downloadet:</b>\n         </td>\n         <td>" }, StringSplitOptions.None)[1].Split('<')[0].Replace("\n", "").Replace(" ", "").FixEncoding(); } catch { }
                            try { filinfo = response.Split(new string[] { "alt=\"pdf-format\">" }, StringSplitOptions.None)[1].Split('<')[0].FixEncoding(); } catch { }
                            try { brugersrating = response.Split(new string[] { "<span class=\"rating\">" }, StringSplitOptions.None)[1].Split('<')[0].FixEncoding(); } catch { }
                            
         
                            lblOpgaveInfo.Text = $"Titel:\n  {titel}\n\n" +
                                                 $"Bruger:\n  {bruger}\n\n" +
                                                 $"Fag:\n  {fag}\n\n" +
                                                 $"Uploadet:\n  {uploadet}\n\n" +
                                                 $"Klassetrin:\n  {klassetrin}\n\n" +
                                                 $"Antal sider:\n  {sidetal}\n\n" +
                                                 $"Downloadet:\n  {downloaded.Split('g')[0]} gange\n\n" +
                                                 $"Rating:\n  {brugersrating}/5";



                            string opgaven = response.Split(new string[] { "class=\"tastyled\">" }, StringSplitOptions.None)[1].Split(new string[] { "</textarea>" }, StringSplitOptions.None)[0].FixEncoding();
                            txtOpgaven.Text = opgaven;

                            try
                            {
                                int MaxNR = Convert.ToInt32(sidetal);
                                for (int i = 1; i <= MaxNR; i++)
                                {
                                    byte[] imageData = wc.DownloadData($"https://opgaver.com/site/previews/medium/{ID}-{i}.png");
                                    using (var ms = new MemoryStream(imageData))
                                        pages.Add(Image.FromStream(ms));
                                }
                                picPages.Image = pages.First();
                            }
                            catch { }
                        }
                        catch
                        {
                            txtOpgaven.Text = "Der skete en fejl, kunne desværre ikke downloade opgaven.\nprøv igen med senere eller med VPN til!";
                        }
                    }
                }
                else
                {
                    ChromeOptions cho = new ChromeOptions();
                    cho.AddArgument("--user-agent=Mozilla/5.0 (iPad; CPU OS 6_0 like Mac OS X) AppleWebKit/536.26 (KHTML, like Gecko) Version/6.0 Mobile/10A5355d Safari/8536.25");
                    cho.AddArgument("--incognito");
                    cho.AddArgument("--headless");

                    ChromeDriverService service = ChromeDriverService.CreateDefaultService();
                    service.HideCommandPromptWindow = true;

                    IWebDriver driver = new ChromeDriver(service, cho);
                    int attempts = 0;
                    bool success = false;
                    while (!success && attempts < 5)
                    {
                        try
                        {
                            driver.Navigate().GoToUrl("https://www.google.com/url?q=" + url);

                            driver.FindElement(By.LinkText(url)).Click();
                            txtOpgaven.Text = driver.FindElement(By.ClassName("tastyled")).Text;
                            success = true;
                        }
                        catch { attempts++; }
                    }

                    if (!success)
                        txtOpgaven.Text = "Der skete en fejl, kunne desværre ikke downloade opgaven.\nprøv igen med senere eller med VPN til!";

                    driver.Quit();
                }
            }
        }

        private void btnPictureBack_Click(object sender, EventArgs e)
        {
            if (pages.Count != 0)
            {
                CurrentImageIndex--;
                if (CurrentImageIndex < 0)
                    CurrentImageIndex = pages.Count - 1;

                picPages.Image = pages[CurrentImageIndex];
            }
        }

        private void btnPictureForward_Click(object sender, EventArgs e)
        {
            if (pages.Count != 0)
            {
                CurrentImageIndex++;
                if (CurrentImageIndex >= pages.Count)
                    CurrentImageIndex = 0;

                picPages.Image = pages[CurrentImageIndex];
            }
        }

        private void picPages_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                Menu.Show(Cursor.Position);
        }

        private void downloadBilledeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = $"{ID}_{(CurrentImageIndex + 1)}.png";
            savefile.Filter = "Image files (*.png)|*.png|All files (*.*)|*.*";

            if (savefile.ShowDialog() == DialogResult.OK)
                pages[CurrentImageIndex].Save(savefile.FileName);
        }

        private void btnFixFormat_Click(object sender, EventArgs e)
        {
            picPages.Image = ImageEnhancer.AdjustContrast(new Bitmap(picPages.Image), -10.0f);



            btnDownloadDocx.Enabled = true; // if success
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            float contrast = 0.04f * trackBar2.Value;
            Bitmap bm = new Bitmap(pages[CurrentImageIndex].Width, pages[CurrentImageIndex].Height);
            
            Graphics g = Graphics.FromImage(bm);
            ImageAttributes ia = new ImageAttributes();

            ColorMatrix cm = new ColorMatrix(new float[][]
            {
                new float[] { contrast, 0f, 0f, 0f, 0f},
                new float[] { 0f, contrast, 0f, 0f, 0f},
                new float[] { 0f, 0f, contrast, 0f, 0f},
                new float[] { 0f, 0f, 0f, 1f, 0f},

                new float[] { 0.001f, 0.001f, 0.001f, 0f, 1f }
            });

            ia.SetColorMatrix(cm);

            g.DrawImage(pages[CurrentImageIndex], new Rectangle(0, 0, picPages.Image.Width, picPages.Image.Height), 0, 0, picPages.Image.Width, picPages.Image.Height, GraphicsUnit.Pixel, ia);
            g.Dispose();
            ia.Dispose();
            picPages.Image = bm;
        }
    }
}