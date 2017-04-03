using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using System.Data;
using System.Drawing;

namespace Chat
{
    interface IEncryption
    {
        void CreateKeys();
        void LoadKeys();
        void Encrypt();
    }

    interface IDecryption
    {
        void LoadKeys();
        void Decrypt();
    }
    class Encryption
    {
        //bool _isupdate = true;
        //bool _isdata = true;
        //bool _ispriv_xml = true;
        //bool _ispub_xml = true;
        //byte[] EncryptedData;
        //byte[] DecryptedData;
        //string publicxml = "";
        //string privatexml = "";
    }
}
