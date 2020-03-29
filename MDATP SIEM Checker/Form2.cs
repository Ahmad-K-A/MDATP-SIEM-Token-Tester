using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDATP_SIEM_Checker
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string redirectURL { get; set; }
        public string Code { get; set; }
        public Form2(string url, string redirect)
        {
            InitializeComponent();
            redirectURL = redirect;
            webBrowser1.Navigate(url);
            
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

            string authcodeurl = e.Url.AbsoluteUri;

            if (authcodeurl.StartsWith(redirectURL))
            {
                var values = authcodeurl.Split('?', '&');
                foreach (var value in values)
                {
                    var parts = value.Split('=');
                    if (parts[0] == "code")
                    {
                        Code = parts[1];
                        Logger.WriteLog(Code);
                        break;
                    }
                    
                }
                this.Close();
            }

        }
    }
}
