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

namespace Chat
{
    public partial class Server_Window : Form
    {
        public Server_Window()
        {
            InitializeComponent();
        }

        //==========Server==================================
        TcpListener myListener;
        Socket mySocket;
        NetworkStream myStream;
        BinaryReader r;
        BinaryWriter w;
        Thread myThread;
        ArrayList AllClients;

        ////==========Client==================================
        TcpClient newClient;
        NetworkStream newStream;
        BinaryReader r2;
        BinaryWriter w2;
        Thread newThread;

        //==========Values==================================
        string temp, users;
        string name;
        bool sActive = false;
        bool cActive = false;
        bool show = false;

        //старт сервера
        private void StartServer()
        {
                myListener = new TcpListener(IPAddress.Parse(txtIP.Text), 7777);
                myListener.Start();
                sActive = true;
                lblStatus.BackColor = Color.Lime;
                while (sActive == true)
                {
                    mySocket = myListener.AcceptSocket();
                    cmdConnect.Text = "Stop";
                    cmdConnect.Enabled = true;
                    lblStatus.BackColor = Color.Lime;
                    txtIP.ReadOnly = true;
                    txtIP.BackColor = Color.WhiteSmoke;
                    myStream = new NetworkStream(mySocket);
                    r = new BinaryReader(myStream);
                    w = new BinaryWriter(myStream);
                    name = r.ReadString();
                    Thread.Sleep(350);
                    new Chatline(ref AllClients, ref mySocket, name);
                    //добавление клиентов
                    txtClients.Text = txtClients.Text + name + "\r\n";
                    users = txtClients.Text;
                    txtChat.Text += "\"" +name+ "\""+"- присоединилс€"+" "+"[" + DateTime.Now.ToLongTimeString() + "]" + "\r\n";
                }                         
        }

        //отключение
        private void Offline()
        {
            if (sActive == true)
            {
                lblStatus.BackColor = Color.Red;
                try
                {
                    myThread.Abort();
                    myListener.Stop();
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
                    w.Close();
                    r.Close();
                    myStream.Close();
                    mySocket.Close();
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
                txtIP.ReadOnly = false;
                txtIP.BackColor = Color.White;
                try
                {
                    w2.Write("[I am offline]");
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

        
        
        private void Form1_Load(object sender, EventArgs e)
        {
            //получение локального ip-адреса
            string host = Dns.GetHostName();
            IPHostEntry ipE = Dns.GetHostEntry(host);
            IPAddress[] IpA = ipE.AddressList;
            for (int i = 0; i < IpA.Length; i++)
            {
                txtIP.Text = IpA[i].ToString();
            }
        }

        //закрытие приложени€ 
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cActive == true || sActive == true)
            {
                Offline();
            }
        }

        //включение и отключение сервера
        private void cmdConnect_Click_1(object sender, EventArgs e)
        {
                if (cActive == true || sActive == true)
                {
                    try
                    {
                        Offline();
                        txtClients.Text = "";
                        cmdConnect.Text = "Start";
                        txtChat.Text = txtChat.Text + "—ервер остановлен . . . " + "[" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString() + "]" + "\r\n";
                        newThread.Start();
                    }
                    catch
                    {
                    }
                }
            else
            {
                    name = txtName.Text;
                    cmdConnect.Text = "Stop";
                    cmdConnect.Enabled = true;
                    Server_Window.ActiveForm.Text = "Chat [Server]";
                    myThread = new Thread(new ThreadStart(StartServer));
                    myThread.Start();
                    AllClients = new ArrayList();
                    txtChat.Text = txtChat.Text + "—ервер запущен . . . " + "[" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString() + "]" + "\r\n"; 
                }
        }
    }
}