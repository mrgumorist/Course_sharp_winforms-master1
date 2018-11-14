using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_sharp_winforms
{
    public partial class WebInfo : Form
    {
        public WebInfo()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void WebInfo_Load(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri((Application.StartupPath + "\\Help.html"));
        }

        private void WebInfo_KeyDown(object sender, KeyEventArgs e)
        {
           
        }
    }
}
