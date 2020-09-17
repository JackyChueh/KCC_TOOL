using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using KCC_TOOL.Model;
using System.Net.Mail;

namespace KCC_TOOL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region 電子郵件
            txtMAIL_SERVER.Text = ConfigurationManager.AppSettings["MAIL_SERVER"];
            txtMAIL_PORT.Text = ConfigurationManager.AppSettings["MAIL_PORT"];
            txtMAIL_ACCOUNT.Text = ConfigurationManager.AppSettings["MAIL_ACCOUNT"];
            txtMAIL_PASSWORD.Text = ConfigurationManager.AppSettings["MAIL_PASSWORD"];

            txtMAIL_FROM.Text = ConfigurationManager.AppSettings["MAIL_FROM"];
            txtMAIL_TO.Text = ConfigurationManager.AppSettings["MAIL_TO"];

            txtMAIL_SUBJECT.Text = "測試標題" + DateTime.Now.ToString();
            txtMAIL_BODY.Text = "<h1>測試內文</h1>";

            txtMAIL_IsBodyHtml.Text = ConfigurationManager.AppSettings["MAIL_IsBodyHtml"];
            txtMAIL_EnableSsl.Text = ConfigurationManager.AppSettings["MAIL_EnableSsl"];
            txtMAIL_UseDefaultCredentials.Text = ConfigurationManager.AppSettings["MAIL_UseDefaultCredentials"];
            #endregion
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            try
            {
                MailAddress from = new MailAddress(txtMAIL_FROM.Text);
                MailAddress to = new MailAddress(txtMAIL_TO.Text);
                string subject = txtMAIL_SUBJECT.Text;
                string body = txtMAIL_BODY.Text;

                string server = txtMAIL_SERVER.Text;
                int port = int.Parse(txtMAIL_PORT.Text);
                string account = txtMAIL_ACCOUNT.Text;
                string password = txtMAIL_PASSWORD.Text;

                bool isBodyHtml = bool.Parse(txtMAIL_IsBodyHtml.Text);
                bool enableSsl = bool.Parse(txtMAIL_EnableSsl.Text);
                bool useDefaultCredentials = bool.Parse(txtMAIL_UseDefaultCredentials.Text);
                SendMessage.Email(from, to, subject, body, server, port, account, password, isBodyHtml, enableSsl, useDefaultCredentials);
            }
            catch (Exception ex)
            {
                string exString = ex.ToString();
                Log.Write(exString);
                txtOUTPUT.AppendText(exString);
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

