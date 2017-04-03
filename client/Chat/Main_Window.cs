using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Collections;
using Microsoft.Win32;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Xml;
using System.Security;


namespace Chat
{
    public partial class Main_Window : Form, IEncryption, IDecryption
    {
        Param parameters = new Param();

        public void WriteXML()
        {
            parameters.name_user = txtName.Text;
            parameters.ip_server = txtIP.Text;
            System.Xml.Serialization.XmlSerializer writer =
                new System.Xml.Serialization.XmlSerializer(typeof(Param));
            var path = "parameters1.xml";
            System.IO.FileStream file1 = System.IO.File.Create(path);
            writer.Serialize(file1, parameters);
            file1.Close();
        }

        public void ReadXML()
        {
                System.Xml.Serialization.XmlSerializer reader1 =
                new System.Xml.Serialization.XmlSerializer(typeof(Param));
                System.IO.StreamReader file1 = new System.IO.StreamReader(
                    "parameters1.xml");
                parameters = (Param)reader1.Deserialize(file1);
                if (parameters.save_user == true) { txtName.Text = parameters.name_user; } else { txtName.Text = ""; }
                if (parameters.save_ip == true) { txtIP.Text = parameters.ip_server; } else { Get_IP(); }

                file1.Close();

            System.Xml.Serialization.XmlSerializer reader =
    new System.Xml.Serialization.XmlSerializer(typeof(Param));
            System.IO.StreamReader file = new System.IO.StreamReader(
                "parameters.xml");
            parameters = (Param)reader.Deserialize(file);
            file.Close();
        }
        public Main_Window()
        {
            InitializeComponent();
            this.KeyPreview = true;
            try
            {
                ReadXML();
            }
            catch
            {
            }
        }
   
        ArrayList AllClients;
        TcpClient newClient;
        NetworkStream newStream;
        BinaryReader r2;
        BinaryWriter w2;
        Thread newThread;
        //==========Values==================
        string temp, temp1, temp2;
        string name;
        bool sActive = false;
        bool cActive = false;
        bool show = false;
        //===================================
        public string s1="", s2="", s3="",s4="",s5="";

        private void StartClient()
        {
            new Settings().Visible = false;
                cmdConnect.Enabled = true;
                name = txtName.Text;
                txtName.Enabled = false;
                Main_Window.ActiveForm.Text = "Chat [Client]";
                AllClients = new ArrayList();    
            try
            {
                newClient = new TcpClient(txtIP.Text, 7777);
                cActive = true;
                newStream = newClient.GetStream();
                r2 = new BinaryReader(newStream);
                w2 = new BinaryWriter(newStream);
                if (sActive == true)
                {
                    txtChat.Text = txtChat.Text + "[Server is ready]\r\n";
                    txtMessage.Enabled = true;
                }
                else
                {
                    txtChat.Text = txtChat.Text + "[Вы успешно подключены к серверу]\r\n";
                    Clientlist.Text = name;
                    cmdConnect.Text = "Disconnect";
                    lblStatus.BackColor = Color.Lime;
                    txtIP.BackColor = Color.WhiteSmoke;
                    txtMessage.Enabled = true;
                }
                w2.Write(name);
                if (sActive == false)
                {
                    w2.Write("[I am online]");
                }

                if (newClient.Connected)
                    cActive = true;

                while (cActive == true)
                {
                    temp = r2.ReadString(); 
                    show = true;
                    temp1 = temp;
                    if (show == true)
                 //вывод в чат
                   s3 = temp.Substring(20);
                    LoadKeys();
                    temp2 = temp.Substring(0,10);
                   s1 = txtChat.Text;
                    s5 = txtChat.Text + temp + "\r\n";
                    try
                    {
                        Decrypt();
                    }
                    catch
                    { 
                    }
                }
            }
            catch
            {
                cmdConnect.Text = "Try again";
                Clientlist.Text = "";
                try
                {
                    w2.Close();
                    r2.Close();
                    newStream.Close();
                    newClient.Close();
                }
                catch
                {
                }
            }
        }

        private void Offline()
        {
            if (sActive == true)
            {
                lblStatus.BackColor = Color.Red;
                txtMessage.Enabled = false;
                Clientlist.Text = "";
                try
                {
                    newThread.Abort();
                }
                catch
                {
                }
                try
                {
                    w2.Close();
                    r2.Close();
                    newStream.Close();
                    newClient.Close();
                }
                catch
                {
                }
                sActive = false;
                cActive = false;
                show = false;
            }
            else
            {
                lblStatus.BackColor = Color.Red;
                txtMessage.Enabled = false;
                txtIP.ReadOnly = false;
                txtIP.BackColor = Color.White;
                try
                {
                    w2.Write("[Оффлайн]");
                    newThread.Abort();
                }
                catch
                {
                }
                try
                {
                    w2.Close();
                    r2.Close();
                    newStream.Close();
                    newClient.Close();
                }
                catch
                {
                }
                cActive = false;
                show = false;
            }
        }

        private void Get_IP()
        {
            // получение локального ip-адреса
            string host = Dns.GetHostName();
            IPHostEntry ipE = Dns.GetHostEntry(host);
            IPAddress[] IpA = ipE.AddressList;
            for (int i = 0; i < IpA.Length; i++)
            {
                txtIP.Text = IpA[i].ToString();
            }
        }
  
        private void cmdConnect_Click(object sender, EventArgs e)
        {
            if (sActive == true)
            {
                Main_Window.ActiveForm.Text = "Chat";
                Offline();
                txtChat.Text = "";
                txtIP.ReadOnly = false;
            }
            else
            {
                if (cActive == true)
                {
                    Main_Window.ActiveForm.Text = "Chat";
                    Offline();
                    txtChat.Text = "";
                    txtIP.ReadOnly = false;
                }
                else
                {
                    newThread = new Thread(new ThreadStart(StartClient));
                    newThread.Start();
                    txtChat.Text = txtChat.Text + "[Подключение . . . ]\r\n";
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {   
            if (cActive == true || sActive == true)
            {
                Offline();
            }
            WriteXML();
        }

        public void CreateKeys()
        {
            try
            {
                RSACryptoServiceProvider RsaKey = new RSACryptoServiceProvider();
                string publickey = RsaKey.ToXmlString(false);
                string privatekey = RsaKey.ToXmlString(true);
                File.WriteAllText("private.xml", privatekey, Encoding.UTF8);
                File.WriteAllText("public.xml", publickey, Encoding.UTF8);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        public void Encrypt()
        {
            byte[] data = new byte[1024];
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            try
            {
                if (publicxml.Length == 0)
                {
                    _ispub_xml = false;
                    MessageBox.Show("Файл с открытым ключем пуст...");
                    return;
                }
                else
                {
                    rsa.FromXmlString(publicxml);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проблема с RSA... \n" + ex.Message.ToString());
            }
            try
            {
                data = Encoding.UTF8.GetBytes(txtMessage.Text);
            }
            catch (Exception ss)
            {
                MessageBox.Show(ss.ToString());
                return;
            }
            try
            {
                EncryptedData = rsa.Encrypt(data, false);
            }
            catch (CryptographicException ex)
            {
                MessageBox.Show("Ошибка расшифровки... \n" + ex.Message.ToString());
            }
            s2 = Encoding.UTF8.GetString(EncryptedData);
            s4 = Convert.ToBase64String(EncryptedData);
            for (int i = 0; i < data.Length - 1; i++)
            {
                data.SetValue((byte)0, i);
            }
            for (int i = 0; i < EncryptedData.Length - 1; i++)
            {
                EncryptedData.SetValue((byte)0, i);
            }
        }
        public void LoadKeys()
        {
            try
            {
                privatexml = File.ReadAllText("private.xml", Encoding.UTF8);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проблема с приватным ключем... \n" + ex.Message.ToString());
                return;
            }
            try
            {
                publicxml = File.ReadAllText("public.xml", Encoding.UTF8);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проблема с публичным ключем... \n" + ex.Message.ToString());
                return;
            }

        }


        public string text = "";
        public void Decrypt()
        {
            byte[] data = new byte[1024];
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            try
            {
                if (privatexml.Length == 0)
                {
                    _ispriv_xml = false;
                    MessageBox.Show("Файл с закрытым ключем пуст...");
                    return;
                }
                else
                {
                    rsa.FromXmlString(privatexml);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проблема с RSA... \n" + ex.Message.ToString());
            }
            try
            {
                data = Convert.FromBase64String(s3);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Data file does not exist...");
                return;
            }
            try
            {
                DecryptedData = rsa.Decrypt(data, false);
            }
            catch (CryptographicException ex)
            {
                MessageBox.Show("Ошибка расшифровки... \n" + ex.Message.ToString());
                return;
            }
            text = Encoding.UTF8.GetString(DecryptedData);
            s1.Substring(0, 18);
            txtChat.Text = s1 + temp2+text + "\r\n";
            for (int i = 0; i < data.Length - 1; i++)
            {
                data.SetValue((byte)0, i);
            }
            for (int i = 0; i < DecryptedData.Length - 1; i++)
            {
                DecryptedData.SetValue((byte)0, i);
            }
        }

        private void txtMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (parameters.keys == true) { LoadKeys(); } else { CreateKeys(); LoadKeys(); }
                
                Encrypt();
                w2.Write(s4);
                    txtMessage.Clear();
                txtChat.Focus();
            }
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            txtName.Text = "";
        }


        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            { cmdConnect.Enabled = true; }
            else { cmdConnect.Enabled = false; }
            
        }

        //=================================
        bool _isupdate = true;
        bool _isdata = true;
        bool _ispriv_xml = true;
        bool _ispub_xml = true;
        byte[] EncryptedData;
        byte[] DecryptedData;
        string publicxml = "";
        string privatexml = "";
        //==================================

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Settings().ShowDialog();
        }

        private void вызватьСправкуF1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help help_prog = new Help();
            help_prog.Visible = true;    
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyCode == Keys.F1)
            {
                Help help_prog = new Help();
            }
        }

        public object sender { get; set; }

        public EventArgs e { get; set; }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Info inf_prog = new Info();
            inf_prog.Visible = true;   
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtChat.Text = "";
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cActive == true || sActive == true)
            {
                Offline();
            }
            WriteXML();
            Close();
        }

        private void Main_Window_Load(object sender, EventArgs e)
        {
            if (parameters.autoconnect == true)
            {
                try
                {
                    cmdConnect_Click(sender, e);
                }
                catch
                {
                }
            }
        }
    }
}