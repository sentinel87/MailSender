using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Configuration;

namespace MailSender
{
    public partial class MainForm : Form
    {
        Configuration configuration;
        StorageHelper storage;
        MailCommunication communication;

        public MainForm()
        {
            InitializeComponent();
            loadConfigData();
            communication = new MailCommunication(configuration);
            storage = new StorageHelper();
        }

        private void loadConfigData()
        {
            configuration = new Configuration();
            configuration.Hostmail = ConfigurationManager.AppSettings["Hostmail"];
            configuration.Password = ConfigurationManager.AppSettings["Password"];
            configuration.Smtp = ConfigurationManager.AppSettings["Smtp"];
            configuration.Username = ConfigurationManager.AppSettings["Username"];
            configuration.Port = Int32.Parse(ConfigurationManager.AppSettings["Port"]);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            MailMessageBuilder messageBuilder = new MailMessageBuilder();
            if(storage.GetFileList().Count>0 && !String.IsNullOrEmpty(tbCC.Text))
            {
                messageBuilder.IsBodyHtml(false)
                .From(configuration.Hostmail, configuration.Username)
                .Subject(tbHeadline.Text)
                .SendTo(tbTo.Text)
                .AddCC(tbCC.Text)
                .AddAttachments(storage.GetFilePaths())
                .Body(rtbMailBody.Text);
            }
            else if(storage.GetFileList().Count > 0)
            {
                messageBuilder.IsBodyHtml(false)
                .From(configuration.Hostmail, configuration.Username)
                .Subject(tbHeadline.Text)
                .SendTo(tbTo.Text)
                .AddAttachments(storage.GetFilePaths())
                .Body(rtbMailBody.Text);
            }
            else if(!String.IsNullOrEmpty(tbCC.Text))
            {
                messageBuilder.IsBodyHtml(false)
                .From(configuration.Hostmail, configuration.Username)
                .Subject(tbHeadline.Text)
                .SendTo(tbTo.Text)
                .AddCC(tbCC.Text)
                .Body(rtbMailBody.Text);
            }
            else
            {
                messageBuilder.IsBodyHtml(false)
                .From(configuration.Hostmail, configuration.Username)
                .Subject(tbHeadline.Text)
                .SendTo(tbTo.Text)
                .Body(rtbMailBody.Text);
            }

            string result = communication.SendMail(messageBuilder);
            if (result == "OK")
                MessageBox.Show("Message was sent!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show($"Message was not sent!\n{result}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAddAtt_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if(openFileDialog.ShowDialog()==DialogResult.OK)
                {
                    foreach (string file in openFileDialog.FileNames)
                        storage.AddToFileList(file);

                    refreshListView();
                }
            }
        }

        private void refreshListView()
        {
            lvAttachments.Items.Clear();
            foreach (string name in storage.GetFileList())
                lvAttachments.Items.Add(name);
        }

        private void btnRemoveAtt_Click(object sender, EventArgs e)
        {
            if(lvAttachments.SelectedItems.Count>0)
            {
                foreach(ListViewItem item in lvAttachments.SelectedItems)
                {
                    storage.RemoveFromFileList(item.Text);
                }
                refreshListView();
            }
        }
    }
}
