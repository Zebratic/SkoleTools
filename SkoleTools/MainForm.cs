using SkoleTools.Libs;
using SkoleTools.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkoleTools
{
    public partial class MainForm : Form
    {
        public static int hotkeyid = 0;
        public MainForm()
        {
            InitializeComponent();
            HotKeyManager.HotKeyPressed += HotKeyManager_HotKeyPressed;
            hotkeyid = HotKeyManager.RegisterHotKey(Keys.Home, KeyModifiers.None);
        }
        
        private void HotKeyManager_HotKeyPressed(object sender, HotKeyEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate { this.Visible = !this.Visible; if (this.Visible) this.Focus(); });
        }

        public Dictionary<string, Form> Tools = new Dictionary<string, Form>();

        private void MainForm_Load(object sender, EventArgs e)
        {
            Tools.Add("Information", new Information());
            Tools.Add("Opgaver.com Bypass", new OpgaverDotComBypass());
            Tools.Add("Skjult Browser", new SkjultBrowser());
            //Tools.Add("Genskriv tekst (Engelsk)", new EngelskGenskriver());
            //Tools.Add("Matematik Udregner", new MatematikUdregner());
            //Tools.Add("Genskriv tekst (Dansk)");
            //Tools.Add("Plagiat Tjek");

            foreach (string name in Tools.Keys)
                cbTools.Items.Add(name);

            foreach (Form form in Tools.Values)
            {
                if (form != null)
                {
                    form.TopLevel = false;
                    form.FormBorderStyle = FormBorderStyle.None;
                    form.Dock = DockStyle.Fill;
                    form.Visible = false;
                    gbTool.Controls.Add(form);
                }
            }

            cbTools.SelectedIndex = 0;
        }

        private void cbTools_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Form oldform in Tools.Values)
                if (oldform != null)
                    oldform.Visible = false;
            try
            {
                string toolname = Tools.Keys.ElementAt(cbTools.SelectedIndex);
                gbTool.Text = toolname;

                Form form = Tools.Values.ElementAt(cbTools.SelectedIndex);
                this.Size = new Size(form.Size.Width + 46, form.Size.Height + 109);
                form.Visible = true;
                form.BringToFront();
            }
            catch { }
        }
    }
}