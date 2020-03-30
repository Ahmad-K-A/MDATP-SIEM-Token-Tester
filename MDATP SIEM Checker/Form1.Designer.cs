namespace MDATP_SIEM_Checker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ClientID = new System.Windows.Forms.TextBox();
            this.Secret = new System.Windows.Forms.TextBox();
            this.Domain = new System.Windows.Forms.TextBox();
            this.redirectURI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.apiurl = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.delAlertsResult = new System.Windows.Forms.RichTextBox();
            this.fetchAlertsdel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.refreshedToken = new System.Windows.Forms.RichTextBox();
            this.accessToken = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.apiurlcc = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.responsecc = new System.Windows.Forms.RichTextBox();
            this.fetchAlertscc = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.ccAccessToken = new System.Windows.Forms.RichTextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.logopn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClientID
            // 
            this.ClientID.Location = new System.Drawing.Point(49, 22);
            this.ClientID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClientID.Name = "ClientID";
            this.ClientID.Size = new System.Drawing.Size(153, 22);
            this.ClientID.TabIndex = 0;
            // 
            // Secret
            // 
            this.Secret.Location = new System.Drawing.Point(224, 22);
            this.Secret.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Secret.Name = "Secret";
            this.Secret.Size = new System.Drawing.Size(153, 22);
            this.Secret.TabIndex = 1;
            // 
            // Domain
            // 
            this.Domain.Location = new System.Drawing.Point(397, 22);
            this.Domain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Domain.Name = "Domain";
            this.Domain.Size = new System.Drawing.Size(153, 22);
            this.Domain.TabIndex = 2;
            // 
            // redirectURI
            // 
            this.redirectURI.Location = new System.Drawing.Point(571, 22);
            this.redirectURI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.redirectURI.Name = "redirectURI";
            this.redirectURI.Size = new System.Drawing.Size(151, 22);
            this.redirectURI.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Client ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Client Secret";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(395, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tenant Domain";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(567, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Redirect URL";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 30);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 41);
            this.button1.TabIndex = 8;
            this.button1.Text = "Log-in + Generate Access Token";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(45, 87);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(696, 539);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.apiurl);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.delAlertsResult);
            this.tabPage1.Controls.Add(this.fetchAlertsdel);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.refreshedToken);
            this.tabPage1.Controls.Add(this.accessToken);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(688, 510);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Authorization Code Flow";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 468);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 17);
            this.label9.TabIndex = 31;
            this.label9.Text = "MDATP API URL";
            // 
            // apiurl
            // 
            this.apiurl.Location = new System.Drawing.Point(9, 433);
            this.apiurl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.apiurl.Name = "apiurl";
            this.apiurl.Size = new System.Drawing.Size(280, 22);
            this.apiurl.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(503, 468);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "Response";
            // 
            // delAlertsResult
            // 
            this.delAlertsResult.Location = new System.Drawing.Point(456, 425);
            this.delAlertsResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delAlertsResult.Name = "delAlertsResult";
            this.delAlertsResult.ReadOnly = true;
            this.delAlertsResult.Size = new System.Drawing.Size(119, 40);
            this.delAlertsResult.TabIndex = 29;
            this.delAlertsResult.Text = "";
            // 
            // fetchAlertsdel
            // 
            this.fetchAlertsdel.Location = new System.Drawing.Point(333, 425);
            this.fetchAlertsdel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fetchAlertsdel.Name = "fetchAlertsdel";
            this.fetchAlertsdel.Size = new System.Drawing.Size(117, 41);
            this.fetchAlertsdel.TabIndex = 28;
            this.fetchAlertsdel.Text = "Fetch Alerts";
            this.fetchAlertsdel.UseVisualStyleBackColor = true;
            this.fetchAlertsdel.Click += new System.EventHandler(this.fetchAlertsdel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Access Token";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(605, 366);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(61, 34);
            this.button7.TabIndex = 26;
            this.button7.Text = "Copy";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(605, 178);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(61, 34);
            this.button6.TabIndex = 25;
            this.button6.Text = "Copy";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // refreshedToken
            // 
            this.refreshedToken.Location = new System.Drawing.Point(5, 263);
            this.refreshedToken.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.refreshedToken.Name = "refreshedToken";
            this.refreshedToken.ReadOnly = true;
            this.refreshedToken.Size = new System.Drawing.Size(668, 96);
            this.refreshedToken.TabIndex = 23;
            this.refreshedToken.Text = "";
            // 
            // accessToken
            // 
            this.accessToken.Location = new System.Drawing.Point(5, 78);
            this.accessToken.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.accessToken.Name = "accessToken";
            this.accessToken.ReadOnly = true;
            this.accessToken.Size = new System.Drawing.Size(665, 96);
            this.accessToken.TabIndex = 22;
            this.accessToken.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Refreshed Access Token";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(5, 217);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(195, 41);
            this.button3.TabIndex = 17;
            this.button3.Text = "Refresh the Access Token";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.apiurlcc);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.responsecc);
            this.tabPage2.Controls.Add(this.fetchAlertscc);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.ccAccessToken);
            this.tabPage2.Controls.Add(this.button8);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(688, 510);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Client Credentials Flow";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 446);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 17);
            this.label10.TabIndex = 36;
            this.label10.Text = "MDATP API URL";
            // 
            // apiurlcc
            // 
            this.apiurlcc.Location = new System.Drawing.Point(9, 411);
            this.apiurlcc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.apiurlcc.Name = "apiurlcc";
            this.apiurlcc.Size = new System.Drawing.Size(280, 22);
            this.apiurlcc.TabIndex = 32;
            this.apiurlcc.Text = "https://graph.microsoft.com/v1.0/users";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(503, 446);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 17);
            this.label11.TabIndex = 35;
            this.label11.Text = "Response";
            // 
            // responsecc
            // 
            this.responsecc.Location = new System.Drawing.Point(456, 402);
            this.responsecc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.responsecc.Name = "responsecc";
            this.responsecc.ReadOnly = true;
            this.responsecc.Size = new System.Drawing.Size(119, 40);
            this.responsecc.TabIndex = 34;
            this.responsecc.Text = "";
            // 
            // fetchAlertscc
            // 
            this.fetchAlertscc.Location = new System.Drawing.Point(333, 402);
            this.fetchAlertscc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fetchAlertscc.Name = "fetchAlertscc";
            this.fetchAlertscc.Size = new System.Drawing.Size(117, 41);
            this.fetchAlertscc.TabIndex = 33;
            this.fetchAlertscc.Text = "Fetch Alerts";
            this.fetchAlertscc.UseVisualStyleBackColor = true;
            this.fetchAlertscc.Click += new System.EventHandler(this.fetchAlertscc_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(611, 295);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(61, 34);
            this.button5.TabIndex = 29;
            this.button5.Text = "Copy";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ccAccessToken
            // 
            this.ccAccessToken.Location = new System.Drawing.Point(8, 89);
            this.ccAccessToken.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ccAccessToken.Name = "ccAccessToken";
            this.ccAccessToken.ReadOnly = true;
            this.ccAccessToken.Size = new System.Drawing.Size(663, 201);
            this.ccAccessToken.TabIndex = 28;
            this.ccAccessToken.Text = "";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(5, 28);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(195, 43);
            this.button8.TabIndex = 27;
            this.button8.Text = "Generate Access Token";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "Access Token";
            // 
            // logopn
            // 
            this.logopn.Location = new System.Drawing.Point(607, 633);
            this.logopn.Margin = new System.Windows.Forms.Padding(4);
            this.logopn.Name = "logopn";
            this.logopn.Size = new System.Drawing.Size(129, 28);
            this.logopn.TabIndex = 18;
            this.logopn.Text = "Open Log File";
            this.logopn.UseVisualStyleBackColor = true;
            this.logopn.Click += new System.EventHandler(this.logopn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 682);
            this.Controls.Add(this.logopn);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.redirectURI);
            this.Controls.Add(this.Domain);
            this.Controls.Add(this.Secret);
            this.Controls.Add(this.ClientID);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "MDATP SIEM Token Flow Checker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ClientID;
        private System.Windows.Forms.TextBox Secret;
        private System.Windows.Forms.TextBox Domain;
        private System.Windows.Forms.TextBox redirectURI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox refreshedToken;
        private System.Windows.Forms.RichTextBox accessToken;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.RichTextBox ccAccessToken;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button fetchAlertsdel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox delAlertsResult;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox apiurl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox apiurlcc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox responsecc;
        private System.Windows.Forms.Button fetchAlertscc;
        private System.Windows.Forms.Button logopn;
    }
}

