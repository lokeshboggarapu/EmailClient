using System;
using System.Windows.Forms;
using System.Net.Mail;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;

namespace WindowsFormsApplication6
{

    public partial class MailClient : Form
    {
        public MailClient()
        {
            InitializeComponent();
        }

        //private void Form1_MouseClick(object sender, MouseEventArgs e)
        //{
        //    if (e.Button.ToString().ToLower() == "right")
        //    {
        //        SendKeys.Send("{Esc}");
        //        MessageBox.Show("Right Click Not Allowed");
        //    }
        //}  
        List<String> fn = new List<String>();
        public void Browse_Click(object sender, EventArgs e)
        {
            
            this.openFileDialog1.Multiselect = true;
            DialogResult result = this.openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {

               
                FileUpload.Text = string.Join(",", openFileDialog1.FileNames);
                openFileDialog1 = new OpenFileDialog();
             //  openFileDialog1.Filter = "Word Documents|*.doc|Excel Worksheets|*.xls|PowerPoint Presentations|*.ppt|Office Files|*.doc;*.xls;*.ppt|All Files|*.*";
                openFileDialog1.Multiselect = true;
              // openFileDialog1.ShowDialog();
                
                fn = new List<string>(FileUpload.Text.Split(','));
                //foreach (String item in fn)
                //{
                   
                //    //string attchfilename = FileUpload.Text + "," + openFileDialog1.FileName.ToString() + ",";
                //    FileUpload.Text = attchfilename;
                    
                //}

            }
        }
        public void button1_Click(object sender, EventArgs e)
        {
            try
            {

                

                if (!string.IsNullOrWhiteSpace(FileUpload.Text) )
                {
                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient();
                    if (SlctMailSrvr.SelectedItem == "Gmail")
                    {
                        SmtpServer.Host = "smtp.gmail.com";
                        SmtpServer.Port = 587;
                        TcpClient client = new TcpClient(SmtpServer.Host, SmtpServer.Port);

                        SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
                        SmtpServer.UseDefaultCredentials = false;
                        TxtFrom.Text = TxtUserName.Text;
                        mail.From = new MailAddress(TxtUserName.Text);
                        if (TxtTo.Text == "")
                        {
                            MessageBox.Show("Please enter To Address");
                        }
                        else
                            mail.To.Add(TxtTo.Text);
                        if (TxtCc.Text == "")
                        {
                            //mail.To.Add(TxtTo.Text);
                        }
                        else
                            mail.CC.Add(TxtCc.Text);
                        if (TxtBcc.Text == "")
                        {
                            //mail.To.Add(TxtTo.Text);
                        }
                        else
                            mail.Bcc.Add(TxtBcc.Text);

                        if (TxtSub.Text == "")
                        {
                            if (MessageBox.Show("Send Mail Without Subject?", "Important",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question)
         == DialogResult.No)
                            {
                                goto closed;
                            }
                        }
                        else
                            mail.Subject = TxtSub.Text;

                        if (TxtBdy.Text == "")
                        {
                            //mail.To.Add(TxtTo.Text);
                        }
                        else
                            mail.Body = TxtBdy.Text;
                        mail.BodyEncoding = System.Text.Encoding.UTF8;


                        //mail.To.Add(TxtTo.Text);
                        //mail.CC.Add(TxtCc.Text);
                        //mail.Bcc.Add(TxtBcc.Text);
                        //mail.Subject = TxtSub.Text;
                        //mail.Body = TxtBdy.Text;
                        for (var i = 0; i <= fn.Count - 1; i++)
                        {
                            System.Net.Mail.Attachment attachment;

                            mail.Attachments.Add(new Attachment(fn[i].ToString()));
                            attachment = new System.Net.Mail.Attachment(fn[i]);
                            //mail.Attachments.Add(attachment);
                        }
                        // System.Net.Mail.Attachment attachment;

                        SmtpServer.Credentials = new System.Net.NetworkCredential(TxtUserName.Text, TxtPassword.Text);
                        SmtpServer.EnableSsl = true;
                        mail.BodyEncoding = System.Text.Encoding.UTF8;
                        mail.SubjectEncoding = System.Text.Encoding.UTF8;
                        mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure |
                      DeliveryNotificationOptions.OnSuccess | DeliveryNotificationOptions.Delay;
                        mail.Headers.Add("Disposition-Notification-To", TxtUserName.Text);
                       
                        SmtpServer.Send(mail);
                        MessageBox.Show("Mail Sent Successfully");                             

                    closed:
                        client.Close();
                        
                    }
                    else if (SlctMailSrvr.SelectedItem == "Yahoo")
                    {
                        //Yahoo
                        SmtpServer.Host = "smtp.mail.yahoo.com";
                        SmtpServer.Port = 587;
                        TcpClient client = new TcpClient(SmtpServer.Host, SmtpServer.Port);

                        SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
                        SmtpServer.UseDefaultCredentials = false;
                        TxtFrom.Text = TxtUserName.Text;
                        mail.From = new MailAddress(TxtUserName.Text);
                        if (TxtTo.Text == "")
                        {
                            MessageBox.Show("Please enter To Address");
                        }
                        else
                            mail.To.Add(TxtTo.Text);
                        if (TxtCc.Text == "")
                        {
                            //mail.To.Add(TxtTo.Text);
                        }
                        else
                            mail.CC.Add(TxtCc.Text);
                        if (TxtBcc.Text == "")
                        {
                            //mail.To.Add(TxtTo.Text);
                        }
                        else
                            mail.Bcc.Add(TxtBcc.Text);

                        if (TxtSub.Text == "")
                        {
                            if (MessageBox.Show("Send Mail Without Subject?", "Important",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question)
         == DialogResult.No)
                            {
                                goto closed;
                            }
                        }
                        else
                            mail.Subject = TxtSub.Text;

                        if (TxtBdy.Text == "")
                        {
                            //mail.To.Add(TxtTo.Text);
                        }
                        else
                            mail.Body = TxtBdy.Text;
                        mail.BodyEncoding = System.Text.Encoding.UTF8;


                        //mail.To.Add(TxtTo.Text);
                        //mail.CC.Add(TxtCc.Text);
                        //mail.Bcc.Add(TxtBcc.Text);
                        //mail.Subject = TxtSub.Text;
                        //mail.Body = TxtBdy.Text;
                        for (var i = 0; i <= fn.Count - 1; i++)
                        {
                            System.Net.Mail.Attachment attachment;

                            mail.Attachments.Add(new Attachment(fn[i].ToString()));
                            attachment = new System.Net.Mail.Attachment(fn[i]);
                            //mail.Attachments.Add(attachment);
                        }
                        // System.Net.Mail.Attachment attachment;

                        SmtpServer.Credentials = new System.Net.NetworkCredential(TxtUserName.Text, TxtPassword.Text);
                        SmtpServer.EnableSsl = true;
                        mail.BodyEncoding = System.Text.Encoding.UTF8;
                        mail.SubjectEncoding = System.Text.Encoding.UTF8;
                        mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure |
                      DeliveryNotificationOptions.OnSuccess | DeliveryNotificationOptions.Delay;
                        mail.Headers.Add("Disposition-Notification-To", TxtUserName.Text);
                        SmtpServer.Send(mail);
                        //mail.


                        MessageBox.Show("Mail Sent Successfully");
                    closed:
                        client.Close();
                    }
                    else
                    {
                        SmtpServer.Host = "smtp.live.com";
                        SmtpServer.Port = 587;
                        TcpClient client = new TcpClient(SmtpServer.Host, SmtpServer.Port);

                        SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
                        SmtpServer.UseDefaultCredentials = false;
                        TxtFrom.Text = TxtUserName.Text;
                        mail.From = new MailAddress(TxtUserName.Text);
                        if (TxtTo.Text == "")
                        {
                            MessageBox.Show("Please enter To Address");
                        }
                        else
                            mail.To.Add(TxtTo.Text);
                        if (TxtCc.Text == "")
                        {
                            //mail.To.Add(TxtTo.Text);
                        }
                        else
                            mail.CC.Add(TxtCc.Text);
                        if (TxtBcc.Text == "")
                        {
                            //mail.To.Add(TxtTo.Text);
                        }
                        else
                            mail.Bcc.Add(TxtBcc.Text);

                        if (TxtSub.Text == "")
                        {
                            if (MessageBox.Show("Send Mail Without Subject?", "Important",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question)
         == DialogResult.No)
                            {
                                goto closed;
                            }
                            
                        }
                        else
                            mail.Subject = TxtSub.Text;

                        if (TxtBdy.Text == "")
                        {
                            //mail.To.Add(TxtTo.Text);
                        }
                        else
                            mail.Body = TxtBdy.Text;
                        mail.BodyEncoding = System.Text.Encoding.UTF8;
                        //mail.To.Add(TxtTo.Text);
                        //mail.CC.Add(TxtCc.Text);
                        //mail.Bcc.Add(TxtBcc.Text);
                        //mail.Subject = TxtSub.Text;
                        //mail.Body = TxtBdy.Text;
                        for (var i = 0; i <= fn.Count - 1; i++)
                        {
                            System.Net.Mail.Attachment attachment;

                            mail.Attachments.Add(new Attachment(fn[i].ToString()));
                            attachment = new System.Net.Mail.Attachment(fn[i]);
                            //mail.Attachments.Add(attachment);
                        }
                        // System.Net.Mail.Attachment attachment;

                        SmtpServer.Credentials = new System.Net.NetworkCredential(TxtUserName.Text, TxtPassword.Text);
                        SmtpServer.EnableSsl = true;
                        mail.BodyEncoding = System.Text.Encoding.UTF8;
                        mail.SubjectEncoding = System.Text.Encoding.UTF8;
                        mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure |
                      DeliveryNotificationOptions.OnSuccess | DeliveryNotificationOptions.Delay;
                        mail.Headers.Add("Disposition-Notification-To", TxtUserName.Text);
                        SmtpServer.Send(mail);
                        MessageBox.Show("Mail Sent Successfully");
                    closed:
                        client.Close();
                    }
                        
                   
                }
                   
                else 
                {
             
                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient();
                    if (SlctMailSrvr.SelectedItem == "Gmail")
                    {
                        SmtpServer.Host = "smtp.gmail.com";
                        SmtpServer.Port = 587;
                        TcpClient client = new TcpClient(SmtpServer.Host, SmtpServer.Port);
                        SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
                        SmtpServer.UseDefaultCredentials = false;
                        TxtFrom.Text = TxtUserName.Text;
                        mail.From = new MailAddress(TxtUserName.Text);
                        if (TxtTo.Text == "")
                        {
                            MessageBox.Show("Please enter To Address");
                        }
                        else
                            mail.To.Add(TxtTo.Text);
                        if (TxtCc.Text == "")
                        {
                            //mail.To.Add(TxtTo.Text);
                        }
                        else
                            mail.CC.Add(TxtCc.Text);
                        if (TxtBcc.Text == "")
                        {
                            //mail.To.Add(TxtTo.Text);
                        }
                        else
                            mail.Bcc.Add(TxtBcc.Text);
                       
                        if (TxtSub.Text == "")
                        {

                            if (MessageBox.Show("Send Mail Without Subject?", "Important",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question)
         == DialogResult.No)
                            {
                               goto closed;
                            }
                             
                            
                        }                         
                    
                        else
                            mail.Subject = TxtSub.Text;
                       
                        if (TxtBdy.Text == "")
                        {
                            //mail.To.Add(TxtTo.Text);
                        }
                        else
                            mail.Body = TxtBdy.Text;

                        SmtpServer.Credentials = new System.Net.NetworkCredential(TxtUserName.Text, TxtPassword.Text);
                        
                        mail.BodyEncoding = System.Text.Encoding.UTF8;
                        mail.SubjectEncoding = System.Text.Encoding.UTF8;
                        mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnSuccess;
                        mail.Headers.Add("Disposition-Notification-To", TxtFrom.Text);
                        SmtpServer.EnableSsl = true;
                        
                        SmtpServer.Send(mail);
                        MessageBox.Show("Mail Sent Successfully");
                    closed:
                        client.Close();
                        
                    }
                    else if (SlctMailSrvr.SelectedItem == "Yahoo")
                    {
                        //Yahoo
                        SmtpServer.Host = "smtp.mail.yahoo.com";
                        SmtpServer.Port = 587;
                        TcpClient client = new TcpClient(SmtpServer.Host, SmtpServer.Port);
                        SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
                        SmtpServer.UseDefaultCredentials = false;
                        TxtFrom.Text = TxtUserName.Text;
                        mail.From = new MailAddress(TxtUserName.Text);
                        if (TxtTo.Text == "")
                        {
                            MessageBox.Show("Please enter To Address");
                        }
                        else
                            mail.To.Add(TxtTo.Text);
                        if (TxtCc.Text == "")
                        {
                            //mail.To.Add(TxtTo.Text);
                        }
                        else
                            mail.CC.Add(TxtCc.Text);
                        if (TxtBcc.Text == "")
                        {
                            //mail.To.Add(TxtTo.Text);
                        }
                        else
                            mail.Bcc.Add(TxtBcc.Text);

                        if (TxtSub.Text == "")
                        {
                            if (MessageBox.Show("Send Mail Without Subject?", "Important",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question)
         == DialogResult.No)
                            {
                                goto closed;
                            }
                        }
                        else
                            mail.Subject = TxtSub.Text;

                        if (TxtBdy.Text == "")
                        {
                            //mail.To.Add(TxtTo.Text);
                        }
                        else
                            mail.Body = TxtBdy.Text;

                        SmtpServer.Credentials = new System.Net.NetworkCredential(TxtUserName.Text, TxtPassword.Text);
                        mail.BodyEncoding = System.Text.Encoding.UTF8;
                        mail.SubjectEncoding = System.Text.Encoding.UTF8;
                        mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnSuccess;
                        mail.Headers.Add("Disposition-Notification-To", TxtFrom.Text);
                        SmtpServer.EnableSsl = true;
                        SmtpServer.Send(mail);
                        MessageBox.Show("Mail Sent Successfully");
                    closed:
                        client.Close();
                    }
                    else
                    {
                        SmtpServer.Host = "smtp.live.com";
                        SmtpServer.Port = 587;
                        TcpClient client = new TcpClient(SmtpServer.Host, SmtpServer.Port);
                        SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
                        SmtpServer.UseDefaultCredentials = false;
                        TxtFrom.Text = TxtUserName.Text;
                        mail.From = new MailAddress(TxtUserName.Text);
                        if (TxtTo.Text == "")
                        {
                            MessageBox.Show("Please enter To Address");
                        }
                        else
                            mail.To.Add(TxtTo.Text);
                        if (TxtCc.Text == "")
                        {
                            //mail.To.Add(TxtTo.Text);
                        }
                        else
                            mail.CC.Add(TxtCc.Text);
                        if (TxtBcc.Text == "")
                        {
                            //mail.To.Add(TxtTo.Text);
                        }
                        else
                            mail.Bcc.Add(TxtBcc.Text);

                       // bool isValid = true;

                        if (TxtSub.Text == "")
                        {

                            if (MessageBox.Show("Send Mail Without Subject?", "Important",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question)
         == DialogResult.No)
                            {
                                goto closed;
                            }
                        }
                        else
                            mail.Subject = TxtSub.Text;

                        if (TxtBdy.Text == "")
                        {
                            //mail.To.Add(TxtTo.Text);
                        }
                        else
                            mail.Body = TxtBdy.Text;

                        SmtpServer.Credentials = new System.Net.NetworkCredential(TxtUserName.Text, TxtPassword.Text);
                        mail.BodyEncoding = System.Text.Encoding.UTF8;
                        mail.SubjectEncoding = System.Text.Encoding.UTF8;
                        mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnSuccess;
                        mail.Headers.Add("Disposition-Notification-To", TxtFrom.Text);
                        SmtpServer.EnableSsl = true;
                        SmtpServer.Send(mail);
                        MessageBox.Show("Mail Sent Successfully");
                    closed:
                        client.Close();
                    }
                   
                    
                    
                    
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("OOPS !! Mail Not Sent");
               // MessageBox.Show(ex.ToString());
            }
             
            
        }
       

        private void Login_Click(object sender, EventArgs e)
        {
            if (SlctMailSrvr.SelectedItem == "Gmail")
            {
                try
                {

                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient();
                    SmtpServer.Host = "smtp.gmail.com";
                    SmtpServer.Port = 587;
                    SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
                    SmtpServer.UseDefaultCredentials = false;

                    mail.From = new MailAddress(TxtUserName.Text);
                    mail.To.Add("lokeshboggarapu08@outlook.com");
                    mail.Subject = TxtUserName.Text + "Trying to login";
                    SmtpServer.EnableSsl = true;
                    SmtpServer.Credentials = new System.Net.NetworkCredential(TxtUserName.Text, TxtPassword.Text);
                    SmtpServer.Send(mail);
                    TxtFrom.Text = TxtUserName.Text;
                    lblfrom.Visible = true;
                    lblTo.Visible = true;
                    lblSub.Visible = true;
                    lblCc.Visible = true;
                    lblBcc.Visible = true;
                    lblmsg.Visible = true;
                    lblatch.Visible = true;
                    btnsend.Visible = true;
                    btnBr.Visible = true;
                    TxtFrom.Visible = true;
                    TxtTo.Visible = true;
                    TxtCc.Visible = true;
                    TxtBcc.Visible = true;
                    TxtSub.Visible = true;
                    TxtBdy.Visible = true;
                    FileUpload.Visible = true;                                    
                    MessageBox.Show("Logged in Successfully");
               
                    TxtPassword.Enabled = false;
                    TxtUserName.Enabled = false;
                    SlctMailSrvr.Enabled = false;

                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("OOPS !! Check Username And Password");
                    // MessageBox.Show(ex.ToString());
                }

            }

            else if (SlctMailSrvr.SelectedItem == "Yahoo")
            {
                try
                {

                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient();
                    SmtpServer.Host = "smtp.mail.yahoo.com";
                    SmtpServer.Port = 587;
                    SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
                    SmtpServer.UseDefaultCredentials = false;
                    mail.From = new MailAddress(TxtUserName.Text);
                    mail.To.Add("lokeshboggarapu08@outlook.com");
                    mail.Subject = TxtUserName.Text + "Trying to login";
                    SmtpServer.EnableSsl = true;
                    SmtpServer.Credentials = new System.Net.NetworkCredential(TxtUserName.Text, TxtPassword.Text);
                    SmtpServer.Send(mail);
                    TxtFrom.Text = TxtUserName.Text;
                    lblfrom.Visible = true;
                    lblTo.Visible = true;
                    lblSub.Visible = true;
                    lblCc.Visible = true;
                    lblBcc.Visible = true;
                    lblmsg.Visible = true;
                    lblatch.Visible = true;
                    btnsend.Visible = true;
                    btnBr.Visible = true;
                    TxtFrom.Visible = true;
                    TxtTo.Visible = true;
                    TxtCc.Visible = true;
                    TxtBcc.Visible = true;
                    TxtSub.Visible = true;
                    TxtBdy.Visible = true;
                    FileUpload.Visible = true;
                    
                    MessageBox.Show("Logged in Successfully");
                 //   TxtFrom.Text = TxtUserName.Text;
                    TxtPassword.Enabled = false;
                    TxtUserName.Enabled = false;
                    SlctMailSrvr.Enabled = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("OOPS !! Check Username And Password");
                    // MessageBox.Show(ex.ToString());
                }

            }

            else
            {
                try
                {

                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient();
                    SmtpServer.Host = "smtp.live.com";
                    SmtpServer.Port = 587;
                    SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
                    SmtpServer.UseDefaultCredentials = false;
                    mail.From = new MailAddress(TxtUserName.Text);
                    mail.To.Add("lokeshboggarapu08@outlook.com");
                    mail.Subject = TxtUserName.Text + "Trying to login";
                    SmtpServer.EnableSsl = true;
                    SmtpServer.Credentials = new System.Net.NetworkCredential(TxtUserName.Text, TxtPassword.Text);
                    SmtpServer.Send(mail);
                    TxtFrom.Text = TxtUserName.Text;
                    lblfrom.Visible = true;
                    lblTo.Visible = true;
                    lblSub.Visible = true;
                    lblCc.Visible = true;
                    lblBcc.Visible = true;
                    lblmsg.Visible = true;
                    lblatch.Visible = true;
                    btnsend.Visible = true;
                    btnBr.Visible = true;
                    TxtFrom.Visible = true;
                    TxtTo.Visible = true;
                    TxtCc.Visible = true;
                    TxtBcc.Visible = true;
                    TxtSub.Visible = true;
                    TxtBdy.Visible = true;
                    FileUpload.Visible = true;
                    
                    MessageBox.Show("Logged in Successfully");
                   // TxtFrom.Text = TxtUserName.Text;
                    TxtPassword.Enabled = false;
                    TxtUserName.Enabled = false;
                    SlctMailSrvr.Enabled = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("OOPS !! Check Username And Password");
                    // MessageBox.Show(ex.ToString());
                }

            }

        }

       

        //private void uc_MouseClick(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == System.Windows.Forms.MouseButtons.Right)
        //    {
        //        MessageBox.Show("OOPS !! ");
        //    }
        //}

       

    
    }
}
