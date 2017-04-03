using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Collections;

namespace Chat
{
     class Chatline
        {
            Socket newSocket;
            NetworkStream newStream;
            BinaryReader r;
            BinaryWriter w;
            Thread newThread;
            string name;
            string temp, temp1, users;
            ArrayList AllClientsStream;

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

         //отправка сообщения всем пользователям
            public void SendToAll()
            {
                try
                {
                    do
                    {
                        temp = name + ">>>" + "                               " + r.ReadString();
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

