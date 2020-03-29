using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Identity.Client;

namespace MDATP_SIEM_Checker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        IConfidentialClientApplication app = null;
        string[] scopes = new string[] {"https://graph.windows.net/user.read", "offline_access" };
        string url = null;
        IAccount accnt = null;
        string AuthorizationCodeform = null;
        int tcount = 1;


        public void button1_Click(object sender, EventArgs e)
        {
            string authurl = null;
           

            try
            {
                //Getting Authorization URL
                //Instantiating and adding properties to Confidential Client
                url = String.Format("https://login.microsoftonline.com/{0}/oauth2/v2.0/token", Domain.Text);
                app = ConfidentialClientApplicationBuilder.Create(ClientID.Text).WithClientSecret(Secret.Text).WithRedirectUri(redirectURI.Text).Build();
                 var GeneratedURL = app.GetAuthorizationRequestUrl(scopes).WithAuthority(url, true).ExecuteAsync();
                GeneratedURL.Wait();
                authurl = GeneratedURL.Result.AbsoluteUri;
                Logger.WriteLog("Generated Authorization URL successfully: " + authurl);
            }
            catch (Microsoft.Identity.Client.MsalClientException eexc)
            {
                
                Logger.WriteLog("Issue encountered while generating Authorization URL: " + eexc);
                throw;
            }
            catch (System.AggregateException eexc)
            {
                Logger.WriteLog("Issue encountered while generating Authorization URL. Please check that your domain is entered correctly: " + eexc);
                throw;
            }

                //Navigating to Authorization URL
                Form2 popup = new Form2(authurl, redirectURI.Text);
                popup.ShowDialog(this);
                AuthorizationCodeform = popup.Code;
            Logger.WriteLog("Authorization Code obtained succesfully: " + AuthorizationCodeform);



            try
            {
                //Generating Access token
                url = String.Format("https://login.microsoftonline.com/{0}/oauth2/v2.0/token", Domain.Text);

                var getToken = app.AcquireTokenByAuthorizationCode(scopes, AuthorizationCodeform).WithAuthority(url, true).ExecuteAsync();
                getToken.Wait();
                accnt = getToken.Result.Account;
                string at = getToken.Result.AccessToken;
                accessToken.Text = at;
                Logger.WriteLog("Access Token obtained succesfully: " + at );
            }
            catch //Catch is generic due to possible network issues
            {
                Logger.WriteLog("Issue encountered while obtaining Authrization Code. Please check the AAD Log-in prompt error for more details. This log was generated due to empty Authorization Code");

                throw;
            }


        }

        public void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //Refreshing token
                url = String.Format("https://login.microsoftonline.com/{0}/oauth2/v2.0/token", Domain.Text);

                var refreshT = app.AcquireTokenSilent(scopes, accnt).WithAuthority(url, true).ExecuteAsync();
                refreshT.Wait();
                string atr = refreshT.Result.AccessToken;
                refreshedToken.Text = atr;

                Logger.WriteLog("Access Token refreshed succesfully: " + "[" + tcount.ToString() + "] " + atr);
                tcount++;
            }
            catch 
            {
                Logger.WriteLog("Issue with refreshing access token. Please try obtaining an access token again and then try refreshing." );
                throw;
            }

           

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }



        private void button6_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(accessToken.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(refreshedToken.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                //Obtain token using client credentials.
                string[] scopescc = new string[] { "https://graph.windows.net/.default" };
                url = String.Format("https://login.microsoftonline.com/{0}/oauth2/v2.0/token", Domain.Text);

                IConfidentialClientApplication appcc = ConfidentialClientApplicationBuilder.Create(ClientID.Text).WithClientSecret(Secret.Text).WithRedirectUri(redirectURI.Text).Build();

                Task<Microsoft.Identity.Client.AuthenticationResult> ccToken = appcc.AcquireTokenForClient(scopescc).WithAuthority(url, true).ExecuteAsync();
                ccToken.Wait();

                ccAccessToken.Text = ccToken.Result.AccessToken;
            }
            catch (Microsoft.Identity.Client.MsalClientException eexc)
            {

                Logger.WriteLog("Issue encountered while generating access token using client credentials: " + eexc);
                throw;
            }
            catch (System.AggregateException eexc)
            {
                Logger.WriteLog("Issue encountered while generating access token using client credentials. Please make sure that you have input the correct data: " + eexc);
                throw;
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ccAccessToken.Text);
        }

        private void fetchAlertsdel_Click(object sender, EventArgs e)
        {


            string apiurltext = apiurl.Text;
            string tokenval = null; 
            if (refreshedToken.Text != "" )
            {
                tokenval = refreshedToken.Text; 

            }
            else if (accessToken.Text != "")
            {
                tokenval = accessToken.Text;
            }



            if (tokenval != null && !(string.IsNullOrWhiteSpace(apiurltext)))
            {
                HttpClient httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", tokenval);
                HttpResponseMessage response = httpClient.GetAsync(apiurltext).GetAwaiter().GetResult();
                string detectionsJson = response.Content.ReadAsStringAsync().Result;

                if (response.IsSuccessStatusCode)
                {
                    delAlertsResult.BackColor = Color.Green;
                    delAlertsResult.Text = response.StatusCode.ToString();
                }
                else
                {

                    delAlertsResult.BackColor = Color.Red;
                    delAlertsResult.Text = response.StatusCode.ToString();
                }

                Logger.WriteLog("API response message: (Authorization Code) " + response.StatusCode.ToString());
                Logger.WriteLog("API response data: (Authorization Code) " + detectionsJson);
            }
            else
            {
                MessageBox.Show("Error: Please make sure that both an Access Token and an API URL are defined.", "Error");

            }

        }

        private void fetchAlertscc_Click(object sender, EventArgs e)
        {

            string apiurltext = apiurlcc.Text;
            string tokenval = null;
            if (ccAccessToken.Text != "")
            {
                tokenval = ccAccessToken.Text;

            }




            if (tokenval != null && !(string.IsNullOrWhiteSpace(apiurltext)))
            {
                HttpClient httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", tokenval);
                HttpResponseMessage response = httpClient.GetAsync(apiurltext).GetAwaiter().GetResult();
                string detectionsJson = response.Content.ReadAsStringAsync().Result;

                if (response.IsSuccessStatusCode)
                {
                    responsecc.BackColor = Color.Green;
                    responsecc.Text = response.StatusCode.ToString();
                }
                else
                {

                    responsecc.BackColor = Color.Red;
                    responsecc.Text = response.StatusCode.ToString();
                }

                Logger.WriteLog("API response message: (Client Credentials) " + response.StatusCode.ToString());
                Logger.WriteLog("API response data: (Client Credentials) " + detectionsJson);
            }
            else
            {
                MessageBox.Show("Error: Please make sure that both an Access Token and an API URL are defined.", "Error");

            }
        }

        private void logopn_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists("SIEMlog.txt"))
            {
                System.Diagnostics.Process.Start("SIEMlog.txt");

            }
            else
            {
                MessageBox.Show("Error: Please make sure that the log file is in the same directory as the .exe", "Error");

            }

        }
    }
}
