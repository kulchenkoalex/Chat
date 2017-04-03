using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Chat
{
    class Signature
    { 
        byte[] HashValue = { 59, 4, 248, 102, 77, 97, 142, 201, 210, 12, 224, 93, 25, 41, 100, 197, 213, 134, 130, 135 };
        byte[] SignedHashValue;
        public void Create()
        {
            //Generate a public/private key pair.
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            RSAPKCS1SignatureFormatter RSAFormatter = new RSAPKCS1SignatureFormatter(RSA);
            RSAFormatter.SetHashAlgorithm("SHA1");
            SignedHashValue = RSAFormatter.CreateSignature(HashValue);
        }
        RSAParameters RSAKeyInfo;
        public void Check()
        {
            try
            {
                byte[] ModulusData = { };
                byte[] ExponentData = { };
                RSAKeyInfo.Modulus = ModulusData;
                RSAKeyInfo.Exponent = ExponentData;
                RSACryptoServiceProvider RSA1 = new RSACryptoServiceProvider();
                RSA1.ImportParameters(RSAKeyInfo);
                RSAPKCS1SignatureDeformatter RSADeformatter = new RSAPKCS1SignatureDeformatter(RSA1);
                RSADeformatter.SetHashAlgorithm("SHA1");
                if (RSADeformatter.VerifySignature(HashValue, SignedHashValue))
                {
                    MessageBox.Show("Цифровая подпись действительна.");
                }
                else
                {
                    MessageBox.Show("цифровая подпись не действительна!");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }
    }
}
