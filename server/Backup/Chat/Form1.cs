using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Collections;

namespace Chat
{
    public partial class Form1 : Form
    {
        public Form1()
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
        //==================================================

        //==========Client==================================
        TcpClient newClient;
        NetworkStream newStream;
        BinaryReader r2;
        BinaryWriter w2;
        Thread newThread;
        //==================================================

        //==========Values==================================
        string temp;
        string name;
        bool sActive = false;
        bool cActive = false;
        bool show = false;
        //==================================================

        private void StartServer()
        {
            myListener = new TcpListener(IPAddress.Parse(txtIP.Text), 7777);
            myListener.Start();
            sActive = true;

            while (sActive == true)
            {
                mySocket = myListener.AcceptSocket();
                //   \/ \/ \/
                cmdConnect.Text = "Stop";
                cmdConnect.Enabled = true;
                lblStatus.BackColor = Color.Lime;
                txtIP.ReadOnly = true;
                txtIP.BackColor = Color.WhiteSmoke;
                //   /\ /\ /\
                myStream = new NetworkStream(mySocket);
                r = new BinaryReader(myStream);
                w = new BinaryWriter(myStream);
                name = r.ReadString();
                Thread.Sleep(350);
                new Chatline(ref AllClients, ref mySocket, name);
            }
        }

        private void StartClient()
        {
            try
            {
                newClient = new TcpClient(txtIP.Text, 7777);
                cActive = true;
                newStream = newClient.GetStream();
                r2 = new BinaryReader(newStream);
                w2 = new BinaryWriter(newStream);
                //   \/ \/ \/
                if (sActive == true)
                {
                    txtChat.Text = txtChat.Text + "[Server is ready]\r\n";
                    txtMessage.Enabled = true;
                }
                else
                {
                    txtChat.Text = txtChat.Text + "[You have been connected]\r\n";
                    cmdConnect.Text = "Disconnect";
                    lblStatus.BackColor = Color.Lime;
                    txtIP.ReadOnly = true;
                    txtIP.BackColor = Color.WhiteSmoke;
                    txtMessage.Enabled = true;
                }
                //   /\ /\ /\
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

                    if (show == true)
                        txtChat.Text = txtChat.Text + temp + "\r\n";
                }
            }
            catch
            {
                //   \/ \/ \/
                txtChat.Text = txtChat.Text + "[No connection]\r\n";
                cmdConnect.Text = "Try again";
                //   /\ /\ /\
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
                //   \/ \/ \/
                gb1.Visible = true;
                gb2.Visible = false;
                lblStatus.BackColor = Color.Red;
                txtMessage.Enabled = false;
                //   /\ /\ /\
                try
                {
                    myThread.Abort();
                    newThread.Abort();
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
                //   \/ \/ \/
                gb1.Visible = true;
                gb2.Visible = false;
                lblStatus.BackColor = Color.Red;
                txtMessage.Enabled = false;
                txtIP.ReadOnly = false;
                txtIP.BackColor = Color.White;
                //   /\ /\ /\
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
            gb1.Visible = true;
            gb2.Visible = false;
            gb1.Select();

            // getting local ip
            string host = Dns.GetHostName();
            IPHostEntry ipE = Dns.GetHostEntry(host);
            IPAddress[] IpA = ipE.AddressList;
            for (int i = 0; i < IpA.Length; i++)
            {
                txtIP.Text = IpA[i].ToString();
            }

        }

        private void cmdClient_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "Your nickname here" || txtName.Text == "")
            {
                MessageBox.Show("Plese enter your nickname");
            }
            else
            {
                name = txtName.Text;
                //   \/ \/ \/
                gb1.Visible = false;
                gb2.Visible = true;
                Form1.ActiveForm.Text = "Chat [Client]";
                //   /\ /\ /\
                AllClients = new ArrayList();     /*txtMessage_KeyDown.....
                                                   * ...
                                                   * if (AllClients.Count == 1)
                                                   * ...
                                                   */
            }
        }

        private void cmdServer_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "Your nickname here" || txtName.Text == "")
            {
                MessageBox.Show("Plese enter your nickname");
            }
            else
            {
                name = txtName.Text;
                //   \/ \/ \/
                gb1.Visible = false;
                gb2.Visible = true;
                cmdConnect.Text = "";
                cmdConnect.Enabled = false;
                txtChat.Text = txtChat.Text + "[Server launching . . . ]\r\n";
                Form1.ActiveForm.Text = "Chat [Server]";
                //   /\ /\ /\
                myThread = new Thread(new ThreadStart(StartServer));
                myThread.Start();
                newThread = new Thread(new ThreadStart(StartClient));
                newThread.Start();
                AllClients = new ArrayList();
            }
        }

        private void cmdConnect_Click(object sender, EventArgs e)
        {
            if (sActive == true)
            {
                //   \/ \/ \/
                Form1.ActiveForm.Text = "Chat";
                //   /\ /\ /\
                Offline();
                txtChat.Text = "";
                txtIP.ReadOnly = false;
            }
            else
            {
                if (cActive == true)
                {
                    //   \/ \/ \/
                    Form1.ActiveForm.Text = "Chat";
                    //   /\ /\ /\
                    Offline();
                    txtChat.Text = "";
                    txtIP.ReadOnly = false;
                }
                else
                {
                    newThread = new Thread(new ThreadStart(StartClient));
                    newThread.Start();
                    //   \/ \/ \/
                    txtChat.Text = txtChat.Text + "[Connecting . . . ]\r\n";
                    //   /\ /\ /\
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cActive == true || sActive == true)
            {
                Offline();
            }
        }

        private void txtMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (AllClients.Count == 1)
                {
                    txtChat.Text = txtChat.Text + "[Nobody can hear you]\r\n";
                }
                else
                {
                    w2.Write(txtMessage.Text);
                    txtMessage.Clear();
                }
                txtChat.Focus();
            }
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            txtName.Text = "";
        }
    }

    class Chatline
    {

        //==================================================
        Socket newSocket;
        NetworkStream newStream;
        BinaryReader r;
        BinaryWriter w;
        Thread newThread;
        string name;
        string temp;
        ArrayList AllClientsStream;
        //==================================================



        public Chatline(ref ArrayList oldAllClients, ref Socket oldSocket, string oldName)
        {
            this.newSocket = oldSocket;
            newStream = new NetworkStream(newSocket);
            r = new BinaryReader(newStream);
            w = new BinaryWriter(newStream);
            this.name = oldName;
            this.AllClientsStream = oldAllClients;

            AllClientsStream.Add(w);
            newThread = new Thread(new ThreadStart(SendToAll));
            newThread.Start();
        }

        public void SendToAll()
        {
            try
            {
                do
                {
                    temp = name + ">>> " + r.ReadString();

                    for (int i = 0; i < AllClientsStream.Count; i++)
                    {
                        try
                        {
                            ((BinaryWriter)AllClientsStream[i]).Write(temp);
                        }
                        catch
                        {
                        }
                    }
                } while (newSocket.Connected);
            }

            catch
            {
            }

            finally
            {
                try
                {
                    AllClientsStream.Remove(w);
                }
                catch
                {
                }
                try
                {
                    AllClientsStream.Sort();
                }
                catch
                {
                }
                try
                {
                    w.Close();
                }
                catch
                {
                }
                try
                {
                    r.Close();
                }
                catch
                {
                }
                try
                {
                    newStream.Close();
                }
                catch
                {
                }
                try
                {
                    newSocket.Close();
                }
                catch
                {
                }
            }
        }
    }
}