namespace Chat
{
    partial class Settings
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
            this.chkRun = new System.Windows.Forms.CheckBox();
            this.chkIp = new System.Windows.Forms.CheckBox();
            this.chkName = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_autoconnect = new System.Windows.Forms.CheckBox();
            this.rbNewKeys = new System.Windows.Forms.RadioButton();
            this.rbKeys = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkRun
            // 
            this.chkRun.AutoSize = true;
            this.chkRun.Location = new System.Drawing.Point(16, 19);
            this.chkRun.Name = "chkRun";
            this.chkRun.Size = new System.Drawing.Size(161, 17);
            this.chkRun.TabIndex = 6;
            this.chkRun.Text = "Автозагрузка приложения";
            this.chkRun.UseVisualStyleBackColor = true;
            // 
            // chkIp
            // 
            this.chkIp.AutoSize = true;
            this.chkIp.Location = new System.Drawing.Point(16, 90);
            this.chkIp.Name = "chkIp";
            this.chkIp.Size = new System.Drawing.Size(157, 17);
            this.chkIp.TabIndex = 7;
            this.chkIp.Text = "Сохранять адрес сервера";
            this.chkIp.UseVisualStyleBackColor = true;
            this.chkIp.CheckedChanged += new System.EventHandler(this.chkIp_CheckedChanged);
            // 
            // chkName
            // 
            this.chkName.AutoSize = true;
            this.chkName.Checked = true;
            this.chkName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkName.Location = new System.Drawing.Point(16, 53);
            this.chkName.Name = "chkName";
            this.chkName.Size = new System.Drawing.Size(176, 17);
            this.chkName.TabIndex = 8;
            this.chkName.Text = "Сохранять имя пользователя";
            this.chkName.UseVisualStyleBackColor = true;
            this.chkName.CheckedChanged += new System.EventHandler(this.chkName_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_autoconnect);
            this.groupBox1.Controls.Add(this.chkRun);
            this.groupBox1.Controls.Add(this.chkName);
            this.groupBox1.Controls.Add(this.chkIp);
            this.groupBox1.Location = new System.Drawing.Point(29, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 150);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Стартовые настройки";
            // 
            // chk_autoconnect
            // 
            this.chk_autoconnect.AutoSize = true;
            this.chk_autoconnect.Enabled = false;
            this.chk_autoconnect.Location = new System.Drawing.Point(16, 127);
            this.chk_autoconnect.Name = "chk_autoconnect";
            this.chk_autoconnect.Size = new System.Drawing.Size(233, 17);
            this.chk_autoconnect.TabIndex = 9;
            this.chk_autoconnect.Text = "Автоматическое подключение к серверу";
            this.chk_autoconnect.UseVisualStyleBackColor = true;
            // 
            // rbNewKeys
            // 
            this.rbNewKeys.AutoSize = true;
            this.rbNewKeys.Location = new System.Drawing.Point(18, 19);
            this.rbNewKeys.Name = "rbNewKeys";
            this.rbNewKeys.Size = new System.Drawing.Size(136, 17);
            this.rbNewKeys.TabIndex = 10;
            this.rbNewKeys.Text = "Создать новые ключи";
            this.rbNewKeys.UseVisualStyleBackColor = true;
            // 
            // rbKeys
            // 
            this.rbKeys.AutoSize = true;
            this.rbKeys.Checked = true;
            this.rbKeys.Location = new System.Drawing.Point(18, 42);
            this.rbKeys.Name = "rbKeys";
            this.rbKeys.Size = new System.Drawing.Size(178, 17);
            this.rbKeys.TabIndex = 11;
            this.rbKeys.TabStop = true;
            this.rbKeys.Text = "Использовать текущие ключи";
            this.rbKeys.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbNewKeys);
            this.groupBox2.Controls.Add(this.rbKeys);
            this.groupBox2.Location = new System.Drawing.Point(29, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 83);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Работа с ключами";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 20);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(242, 17);
            this.checkBox2.TabIndex = 14;
            this.checkBox2.Text = "Выводить сообщения о успешной подписи";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox3);
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Location = new System.Drawing.Point(390, 210);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(249, 100);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Цифровая подпись";
            this.groupBox3.Visible = false;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 37);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(251, 17);
            this.checkBox3.TabIndex = 15;
            this.checkBox3.Text = "Выводить сообщения о успешной проверке ";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 33);
            this.button1.TabIndex = 16;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(174, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 33);
            this.button2.TabIndex = 17;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 302);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Settings";
            this.Text = "Настройки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.EnabledChanged += new System.EventHandler(this.Settings_EnabledChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.CheckBox chkRun;
        public System.Windows.Forms.CheckBox chkIp;
        public System.Windows.Forms.CheckBox chkName;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.RadioButton rbNewKeys;
        public System.Windows.Forms.RadioButton rbKeys;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.CheckBox chk_autoconnect;
    }
}