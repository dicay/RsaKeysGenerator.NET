/*
 *This project for RSA keys generator, XML,PEM,DER format using for .NET, JAVA
 * Created by: xonv,2016-01-24
 * In PEM Format, I reference at stackoverflow: http://stackoverflow.com/questions/23734792/c-sharp-export-private-public-rsa-key-from-rsacryptoserviceprovider-to-pem-strin 
 * Hope this help for looking key generator between .NET and Java when using RSA Algorithm 
 * Contact me at: http://blog.dicay.net/ or 
 */
using System;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using RsaGenerateKey.NET.Common;

namespace RsaGenerateKey.NET
{
    /// <summary>
    /// RSA Keys Generator
    /// </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int keySize = Convert.ToInt32(txtKeySize.Text);
            string savePath = txtSavePath.Text.Trim();
            RSACryptoServiceProvider rsa=new RSACryptoServiceProvider(keySize);
            if (chkXmlFormat.Checked)
            {
                string xmlPrivKey = "privateKey.xml";
                string xmlPubKey = "publicKey.xml";
                Save(Path.Combine(savePath,xmlPrivKey ),XmlFormatter.ExportPrivateKey(rsa));
                Save(Path.Combine(savePath, xmlPubKey), XmlFormatter.ExportPublicKey(rsa));
            }
            if (chkPemFormat.Checked)
            {
                string pemPrivKey = "privateKey.pem";
                string pemPubKey = "publicKey.pem";
                Save(Path.Combine(savePath, pemPrivKey), PemFormatter.ExportPrivateKey(rsa));
                Save(Path.Combine(savePath, pemPubKey), PemFormatter.ExportPublicKey(rsa));
            }
            if (chkDerFormat.Checked)
            {
                string derPrivKey = "privateKey.der";
                string derPubKey = "publicKey.der";
                SaveBinary(Path.Combine(savePath, derPrivKey), DerFormatter.ExportPrivateKey(rsa));
                SaveBinary(Path.Combine(savePath, derPubKey), DerFormatter.ExportPublicKey(rsa));
            }
            MessageBox.Show("Key Generated");
        }
        public void Save(string fileName, string content)
        {
            StreamWriter sw = new StreamWriter(fileName, false);
            sw.Write(content);
            sw.Close();
        }

        public void SaveBinary(string fileName, byte[] content)
        {
            FileInfo f = new FileInfo(fileName);
            BinaryWriter bw = new BinaryWriter(f.OpenWrite());
            bw.Write(content);
            bw.Flush();
            bw.Close();
        }
    }
}
