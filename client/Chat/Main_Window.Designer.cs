namespace Chat
{
    partial class Main_Window
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
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmdConnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtChat = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.÷àòToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.î÷èñòèòüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.âûõîäToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.íàñòğîéêèToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ñïğàâêàToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.âûçâàòüÑïğàâêóF1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.îÏğîãğàììåToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Clientlist = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gb2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb2
            // 
            this.gb2.Controls.Add(this.lblStatus);
            this.gb2.Controls.Add(this.cmdConnect);
            this.gb2.Controls.Add(this.label2);
            this.gb2.Controls.Add(this.txtIP);
            this.gb2.Controls.Add(this.txtMessage);
            this.gb2.Controls.Add(this.txtChat);
            this.gb2.Location = new System.Drawing.Point(158, 53);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(285, 277);
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
            this.cmdConnect.Enabled = false;
            this.cmdConnect.Location = new System.Drawing.Point(6, 0);
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
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(258, 47);
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
            // txtName
            // 
            this.txtName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtName.Location = new System.Drawing.Point(208, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 20);
            this.txtName.TabIndex = 2;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.Enter += new System.EventHandler(this.txtName_Enter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.÷àòToolStripMenuItem,
            this.íàñòğîéêèToolStripMenuItem,
            this.ñïğàâêàToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(457, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "×àò";
            // 
            // ÷àòToolStripMenuItem
            // 
            this.÷àòToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.î÷èñòèòüToolStripMenuItem,
            this.âûõîäToolStripMenuItem});
            this.÷àòToolStripMenuItem.Name = "÷àòToolStripMenuItem";
            this.÷àòToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.÷àòToolStripMenuItem.Text = "×àò";
            // 
            // î÷èñòèòüToolStripMenuItem
            // 
            this.î÷èñòèòüToolStripMenuItem.Name = "î÷èñòèòüToolStripMenuItem";
            this.î÷èñòèòüToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.î÷èñòèòüToolStripMenuItem.Text = "Î÷èñòèòü";
            this.î÷èñòèòüToolStripMenuItem.Click += new System.EventHandler(this.î÷èñòèòüToolStripMenuItem_Click);
            // 
            // âûõîäToolStripMenuItem
            // 
            this.âûõîäToolStripMenuItem.Name = "âûõîäToolStripMenuItem";
            this.âûõîäToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.âûõîäToolStripMenuItem.Text = "Âûõîä";
            this.âûõîäToolStripMenuItem.Click += new System.EventHandler(this.âûõîäToolStripMenuItem_Click);
            // 
            // íàñòğîéêèToolStripMenuItem
            // 
            this.íàñòğîéêèToolStripMenuItem.Name = "íàñòğîéêèToolStripMenuItem";
            this.íàñòğîéêèToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.íàñòğîéêèToolStripMenuItem.Text = "Íàñòğîéêè";
            this.íàñòğîéêèToolStripMenuItem.Click += new System.EventHandler(this.íàñòğîéêèToolStripMenuItem_Click);
            // 
            // ñïğàâêàToolStripMenuItem
            // 
            this.ñïğàâêàToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.âûçâàòüÑïğàâêóF1ToolStripMenuItem,
            this.îÏğîãğàììåToolStripMenuItem});
            this.ñïğàâêàToolStripMenuItem.Name = "ñïğàâêàToolStripMenuItem";
            this.ñïğàâêàToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.ñïğàâêàToolStripMenuItem.Text = "Ñïğàâêà";
            // 
            // âûçâàòüÑïğàâêóF1ToolStripMenuItem
            // 
            this.âûçâàòüÑïğàâêóF1ToolStripMenuItem.Name = "âûçâàòüÑïğàâêóF1ToolStripMenuItem";
            this.âûçâàòüÑïğàâêóF1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.âûçâàòüÑïğàâêóF1ToolStripMenuItem.Text = "Âûçâàòü ñïğàâêó F1";
            this.âûçâàòüÑïğàâêóF1ToolStripMenuItem.Click += new System.EventHandler(this.âûçâàòüÑïğàâêóF1ToolStripMenuItem_Click);
            // 
            // îÏğîãğàììåToolStripMenuItem
            // 
            this.îÏğîãğàììåToolStripMenuItem.Name = "îÏğîãğàììåToolStripMenuItem";
            this.îÏğîãğàììåToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.îÏğîãğàììåToolStripMenuItem.Text = "Î ïğîãğàììå";
            this.îÏğîãğàììåToolStripMenuItem.Click += new System.EventHandler(this.îÏğîãğàììåToolStripMenuItem_Click);
            // 
            // Clientlist
            // 
            this.Clientlist.Location = new System.Drawing.Point(32, 67);
            this.Clientlist.Multiline = true;
            this.Clientlist.Name = "Clientlist";
            this.Clientlist.Size = new System.Drawing.Size(120, 203);
            this.Clientlist.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Èìÿ:";
            // 
            // Main_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 341);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Clientlist);
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main_Window";
            this.Text = "Chat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Main_Window_Load);
            this.gb2.ResumeLayout(false);
            this.gb2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtChat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button cmdConnect;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ÷àòToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem íàñòğîéêèToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ñïğàâêàToolStripMenuItem;
        private System.Windows.Forms.TextBox Clientlist;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem âûçâàòüÑïğàâêóF1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem îÏğîãğàììåToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem î÷èñòèòüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem âûõîäToolStripMenuItem;
    }
}

