namespace Chat
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
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmdServer = new System.Windows.Forms.Button();
            this.cmdClient = new System.Windows.Forms.Button();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmdConnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtChat = new System.Windows.Forms.TextBox();
            this.gb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gb2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.pictureBox1);
            this.gb1.Controls.Add(this.label1);
            this.gb1.Controls.Add(this.txtName);
            this.gb1.Controls.Add(this.cmdServer);
            this.gb1.Controls.Add(this.cmdClient);
            this.gb1.Location = new System.Drawing.Point(12, 6);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(270, 250);
            this.gb1.TabIndex = 0;
            this.gb1.TabStop = false;
            this.gb1.Text = "Start . . .";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Chat.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 78);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hello!\r\nPlease enter your name (nickname)\r\nand press button \"Server\", if you want" +
                "\r\nto create own chat room or press\r\nbutton \"Client\", if you want be\r\nconnect to " +
                "an existing server.";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(60, 154);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(156, 20);
            this.txtName.TabIndex = 2;
            this.txtName.Text = "Your nickname here";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtName.Enter += new System.EventHandler(this.txtName_Enter);
            // 
            // cmdServer
            // 
            this.cmdServer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdServer.Location = new System.Drawing.Point(60, 180);
            this.cmdServer.Name = "cmdServer";
            this.cmdServer.Size = new System.Drawing.Size(75, 23);
            this.cmdServer.TabIndex = 1;
            this.cmdServer.Text = "Server";
            this.cmdServer.UseVisualStyleBackColor = true;
            this.cmdServer.Click += new System.EventHandler(this.cmdServer_Click);
            // 
            // cmdClient
            // 
            this.cmdClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdClient.Location = new System.Drawing.Point(141, 180);
            this.cmdClient.Name = "cmdClient";
            this.cmdClient.Size = new System.Drawing.Size(75, 23);
            this.cmdClient.TabIndex = 0;
            this.cmdClient.Text = "Client";
            this.cmdClient.UseVisualStyleBackColor = true;
            this.cmdClient.Click += new System.EventHandler(this.cmdClient_Click);
            // 
            // gb2
            // 
            this.gb2.Controls.Add(this.lblStatus);
            this.gb2.Controls.Add(this.cmdConnect);
            this.gb2.Controls.Add(this.label2);
            this.gb2.Controls.Add(this.txtIP);
            this.gb2.Controls.Add(this.txtMessage);
            this.gb2.Controls.Add(this.txtChat);
            this.gb2.Location = new System.Drawing.Point(12, 6);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(270, 250);
            this.gb2.TabIndex = 1;
            this.gb2.TabStop = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Red;
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStatus.Location = new System.Drawing.Point(88, 24);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(15, 15);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "  ";
            // 
            // cmdConnect
            // 
            this.cmdConnect.Location = new System.Drawing.Point(6, 19);
            this.cmdConnect.Name = "cmdConnect";
            this.cmdConnect.Size = new System.Drawing.Size(75, 23);
            this.cmdConnect.TabIndex = 6;
            this.cmdConnect.Text = "Connect";
            this.cmdConnect.UseVisualStyleBackColor = true;
            this.cmdConnect.Click += new System.EventHandler(this.cmdConnect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "IP:";
            // 
            // txtIP
            // 
            this.txtIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIP.Location = new System.Drawing.Point(174, 22);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(90, 20);
            this.txtIP.TabIndex = 4;
            this.txtIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMessage
            // 
            this.txtMessage.Enabled = false;
            this.txtMessage.Location = new System.Drawing.Point(6, 224);
            this.txtMessage.MaxLength = 350;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(258, 20);
            this.txtMessage.TabIndex = 3;
            this.txtMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMessage_KeyDown);
            // 
            // txtChat
            // 
            this.txtChat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtChat.Location = new System.Drawing.Point(6, 48);
            this.txtChat.Multiline = true;
            this.txtChat.Name = "txtChat";
            this.txtChat.ReadOnly = true;
            this.txtChat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtChat.Size = new System.Drawing.Size(258, 170);
            this.txtChat.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 268);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.gb2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Chat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gb2.ResumeLayout(false);
            this.gb2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.Button cmdServer;
        private System.Windows.Forms.Button cmdClient;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtChat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button cmdConnect;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

