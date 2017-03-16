namespace WindowsFormsApplication6
{
    partial class MailClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailClient));
            this.btnsend = new System.Windows.Forms.Button();
            this.TxtFrom = new System.Windows.Forms.TextBox();
            this.TxtTo = new System.Windows.Forms.TextBox();
            this.TxtSub = new System.Windows.Forms.TextBox();
            this.TxtBdy = new System.Windows.Forms.TextBox();
            this.lblfrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.lblmsg = new System.Windows.Forms.Label();
            this.lblatch = new System.Windows.Forms.Label();
            this.FileUpload = new System.Windows.Forms.TextBox();
            this.btnBr = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblCc = new System.Windows.Forms.Label();
            this.TxtCc = new System.Windows.Forms.TextBox();
            this.lblBcc = new System.Windows.Forms.Label();
            this.TxtBcc = new System.Windows.Forms.TextBox();
            this.MailServer = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SlctMailSrvr = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnsend
            // 
            this.btnsend.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsend.ForeColor = System.Drawing.Color.Black;
            this.btnsend.Image = ((System.Drawing.Image)(resources.GetObject("btnsend.Image")));
            this.btnsend.Location = new System.Drawing.Point(486, 662);
            this.btnsend.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(118, 43);
            this.btnsend.TabIndex = 0;
            this.btnsend.Text = "Send";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Visible = false;
            this.btnsend.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtFrom
            // 
            this.TxtFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtFrom.Enabled = false;
            this.TxtFrom.Location = new System.Drawing.Point(153, 200);
            this.TxtFrom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtFrom.Name = "TxtFrom";
            this.TxtFrom.Size = new System.Drawing.Size(808, 21);
            this.TxtFrom.TabIndex = 1;
            this.TxtFrom.Visible = false;
            // 
            // TxtTo
            // 
            this.TxtTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTo.Location = new System.Drawing.Point(153, 233);
            this.TxtTo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtTo.Name = "TxtTo";
            this.TxtTo.Size = new System.Drawing.Size(808, 21);
            this.TxtTo.TabIndex = 2;
            this.TxtTo.Visible = false;
            // 
            // TxtSub
            // 
            this.TxtSub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSub.Location = new System.Drawing.Point(153, 339);
            this.TxtSub.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtSub.Name = "TxtSub";
            this.TxtSub.Size = new System.Drawing.Size(808, 21);
            this.TxtSub.TabIndex = 3;
            this.TxtSub.Visible = false;
            // 
            // TxtBdy
            // 
            this.TxtBdy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBdy.Location = new System.Drawing.Point(153, 377);
            this.TxtBdy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtBdy.Multiline = true;
            this.TxtBdy.Name = "TxtBdy";
            this.TxtBdy.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtBdy.Size = new System.Drawing.Size(808, 161);
            this.TxtBdy.TabIndex = 4;
            this.TxtBdy.Visible = false;
            // 
            // lblfrom
            // 
            this.lblfrom.AutoSize = true;
            this.lblfrom.BackColor = System.Drawing.Color.Transparent;
            this.lblfrom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfrom.ForeColor = System.Drawing.Color.Black;
            this.lblfrom.Location = new System.Drawing.Point(86, 200);
            this.lblfrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfrom.Name = "lblfrom";
            this.lblfrom.Size = new System.Drawing.Size(48, 21);
            this.lblfrom.TabIndex = 5;
            this.lblfrom.Text = "From";
            this.lblfrom.Visible = false;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.BackColor = System.Drawing.Color.Transparent;
            this.lblTo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.ForeColor = System.Drawing.Color.Black;
            this.lblTo.Location = new System.Drawing.Point(95, 233);
            this.lblTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(28, 21);
            this.lblTo.TabIndex = 6;
            this.lblTo.Text = "To";
            this.lblTo.Visible = false;
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.BackColor = System.Drawing.Color.Transparent;
            this.lblSub.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSub.ForeColor = System.Drawing.Color.Black;
            this.lblSub.Location = new System.Drawing.Point(65, 339);
            this.lblSub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(69, 21);
            this.lblSub.TabIndex = 7;
            this.lblSub.Text = "Subject";
            this.lblSub.Visible = false;
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.BackColor = System.Drawing.Color.Transparent;
            this.lblmsg.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmsg.ForeColor = System.Drawing.Color.Black;
            this.lblmsg.Location = new System.Drawing.Point(13, 377);
            this.lblmsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(121, 21);
            this.lblmsg.TabIndex = 8;
            this.lblmsg.Text = "Message Body";
            this.lblmsg.Visible = false;
            // 
            // lblatch
            // 
            this.lblatch.AutoSize = true;
            this.lblatch.BackColor = System.Drawing.Color.Transparent;
            this.lblatch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblatch.ForeColor = System.Drawing.Color.Black;
            this.lblatch.Location = new System.Drawing.Point(18, 608);
            this.lblatch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblatch.Name = "lblatch";
            this.lblatch.Size = new System.Drawing.Size(116, 21);
            this.lblatch.TabIndex = 9;
            this.lblatch.Text = "Attachments";
            this.lblatch.Visible = false;
            // 
            // FileUpload
            // 
            this.FileUpload.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FileUpload.Location = new System.Drawing.Point(153, 606);
            this.FileUpload.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FileUpload.Name = "FileUpload";
            this.FileUpload.ShortcutsEnabled = false;
            this.FileUpload.Size = new System.Drawing.Size(685, 21);
            this.FileUpload.TabIndex = 10;
            this.FileUpload.Visible = false;
            // 
            // btnBr
            // 
            this.btnBr.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBr.ForeColor = System.Drawing.Color.Black;
            this.btnBr.Image = ((System.Drawing.Image)(resources.GetObject("btnBr.Image")));
            this.btnBr.Location = new System.Drawing.Point(857, 601);
            this.btnBr.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBr.Name = "btnBr";
            this.btnBr.Size = new System.Drawing.Size(104, 35);
            this.btnBr.TabIndex = 11;
            this.btnBr.Text = "Browse";
            this.btnBr.UseVisualStyleBackColor = true;
            this.btnBr.Visible = false;
            this.btnBr.Click += new System.EventHandler(this.Browse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "File Dialog";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.SupportMultiDottedExtensions = true;
            // 
            // lblCc
            // 
            this.lblCc.AutoSize = true;
            this.lblCc.BackColor = System.Drawing.Color.Transparent;
            this.lblCc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCc.ForeColor = System.Drawing.Color.Black;
            this.lblCc.Location = new System.Drawing.Point(95, 270);
            this.lblCc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCc.Name = "lblCc";
            this.lblCc.Size = new System.Drawing.Size(33, 21);
            this.lblCc.TabIndex = 12;
            this.lblCc.Text = "Cc";
            this.lblCc.Visible = false;
            // 
            // TxtCc
            // 
            this.TxtCc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCc.Location = new System.Drawing.Point(153, 270);
            this.TxtCc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtCc.Name = "TxtCc";
            this.TxtCc.Size = new System.Drawing.Size(808, 21);
            this.TxtCc.TabIndex = 13;
            this.TxtCc.Visible = false;
            // 
            // lblBcc
            // 
            this.lblBcc.AutoSize = true;
            this.lblBcc.BackColor = System.Drawing.Color.Transparent;
            this.lblBcc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBcc.ForeColor = System.Drawing.Color.Black;
            this.lblBcc.Location = new System.Drawing.Point(95, 304);
            this.lblBcc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBcc.Name = "lblBcc";
            this.lblBcc.Size = new System.Drawing.Size(39, 21);
            this.lblBcc.TabIndex = 14;
            this.lblBcc.Text = "Bcc";
            this.lblBcc.Visible = false;
            // 
            // TxtBcc
            // 
            this.TxtBcc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBcc.Location = new System.Drawing.Point(153, 304);
            this.TxtBcc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtBcc.Name = "TxtBcc";
            this.TxtBcc.Size = new System.Drawing.Size(808, 21);
            this.TxtBcc.TabIndex = 15;
            this.TxtBcc.Visible = false;
            // 
            // MailServer
            // 
            this.MailServer.AutoSize = true;
            this.MailServer.Location = new System.Drawing.Point(29, 22);
            this.MailServer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MailServer.Name = "MailServer";
            this.MailServer.Size = new System.Drawing.Size(0, 13);
            this.MailServer.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(306, 17);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "MailServer";
            // 
            // SlctMailSrvr
            // 
            this.SlctMailSrvr.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SlctMailSrvr.FormattingEnabled = true;
            this.SlctMailSrvr.Items.AddRange(new object[] {
            "Gmail",
            "Yahoo",
            "Live"});
            this.SlctMailSrvr.Location = new System.Drawing.Point(431, 14);
            this.SlctMailSrvr.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SlctMailSrvr.Name = "SlctMailSrvr";
            this.SlctMailSrvr.Size = new System.Drawing.Size(343, 27);
            this.SlctMailSrvr.TabIndex = 17;
            this.SlctMailSrvr.Text = "Select Mail Server";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(306, 58);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 21);
            this.label9.TabIndex = 18;
            this.label9.Text = "Username";
            // 
            // TxtUserName
            // 
            this.TxtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtUserName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUserName.Location = new System.Drawing.Point(431, 58);
            this.TxtUserName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.ShortcutsEnabled = false;
            this.TxtUserName.Size = new System.Drawing.Size(343, 27);
            this.TxtUserName.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(306, 104);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 21);
            this.label10.TabIndex = 20;
            this.label10.Text = "Password";
            // 
            // TxtPassword
            // 
            this.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.Location = new System.Drawing.Point(431, 96);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '@';
            this.TxtPassword.ShortcutsEnabled = false;
            this.TxtPassword.Size = new System.Drawing.Size(343, 27);
            this.TxtPassword.TabIndex = 21;
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.Color.Black;
            this.Login.Image = ((System.Drawing.Image)(resources.GetObject("Login.Image")));
            this.Login.Location = new System.Drawing.Point(521, 129);
            this.Login.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(127, 37);
            this.Login.TabIndex = 22;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1144, 750);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtUserName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SlctMailSrvr);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MailServer);
            this.Controls.Add(this.TxtBcc);
            this.Controls.Add(this.lblBcc);
            this.Controls.Add(this.TxtCc);
            this.Controls.Add(this.lblCc);
            this.Controls.Add(this.btnBr);
            this.Controls.Add(this.FileUpload);
            this.Controls.Add(this.lblatch);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.lblSub);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblfrom);
            this.Controls.Add(this.TxtBdy);
            this.Controls.Add(this.TxtSub);
            this.Controls.Add(this.TxtTo);
            this.Controls.Add(this.TxtFrom);
            this.Controls.Add(this.btnsend);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Mconnect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.TextBox TxtFrom;
        private System.Windows.Forms.TextBox TxtTo;
        private System.Windows.Forms.TextBox TxtSub;
        private System.Windows.Forms.TextBox TxtBdy;
        
        private System.Windows.Forms.Label lblfrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.Label lblatch;
        private System.Windows.Forms.TextBox FileUpload;
        private System.Windows.Forms.Button btnBr;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblCc;
        private System.Windows.Forms.TextBox TxtCc;
        private System.Windows.Forms.Label lblBcc;
        private System.Windows.Forms.TextBox TxtBcc;
        private System.Windows.Forms.Label MailServer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox SlctMailSrvr;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Button Login;
    }
}

