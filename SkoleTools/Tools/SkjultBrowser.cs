using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkoleTools.Tools
{
    public partial class SkjultBrowser : Form
    {
        public SkjultBrowser()
        {
            InitializeComponent();
        }

        private void txtURL_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                WebBrowser.Navigate(txtURL.Text, false);
        }
    }
}
