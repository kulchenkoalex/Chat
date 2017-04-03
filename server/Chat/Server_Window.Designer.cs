namespace Chat
{
    partial class Server_Window
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
            this.components = new System.ComponentModel.Container();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmdConnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtChat = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtClients = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Hint = new System.Windows.Forms.ToolTip(this.components);
            this.gb2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb2
            // 
            this.gb2.Controls.Add(this.lblStatus);
            this.gb2.Controls.Add(this.cmdConnect);
            this.gb2.Controls.Add(this.label2);
            this.gb2.Controls.Add(this.txtIP);
            this.gb2.Controls.Add(this.txtChat);
            this.gb2.Location = new System.Drawing.Point(12, 40);
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
            this.cmdConnect.Text = "Start";
            this.cmdConnect.UseVisualStyleBackColor = true;
            this.cmdConnect.Click += new System.EventHandler(this.cmdConnect_Click_1);
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
            this.txtIP.Enabled = false;
            this.txtIP.Location = new System.Drawing.Point(174, 22);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(90, 20);
            this.txtIP.TabIndex = 4;
            this.txtIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtChat
            // 
            this.txtChat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtChat.Location = new System.Drawing.Point(6, 48);
            this.txtChat.Multiline = true;
            this.txtChat.Name = "txtChat";
            this.txtChat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtChat.Size = new System.Drawing.Size(258, 186);
            this.txtChat.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(18, 13);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(82, 20);
            this.txtName.TabIndex = 2;
            this.txtName.Text = "***SERVER***";
            // 
            // txtClients
            // 
            this.txtClients.Enabled = false;
            this.txtClients.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtClients.Location = new System.Drawing.Point(288, 88);
            this.txtClients.Multiline = true;
            this.txtClients.Name = "txtClients";
            this.txtClients.Size = new System.Drawing.Size(121, 186);
            this.txtClients.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(297, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Пользователи:";
            // 
            // Server_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 307);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClients);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.gb2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Server_Window";
            this.Text = "Chat [Server]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb2.ResumeLayout(false);
            this.gb2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.TextBox txtChat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button cmdConnect;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.TextBox txtClients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip Hint;
    }
}

