/*
 *This project for RSA keys generator, XML,PEM,DER format using for .NET, JAVA
 * Created by: xonv,2016-01-24
 * In PEM Format, I reference at stackoverflow: http://stackoverflow.com/questions/23734792/c-sharp-export-private-public-rsa-key-from-rsacryptoserviceprovider-to-pem-strin 
 * Hope this help for looking key generator between .NET and Java when using RSA Algorithm 
 * Contact me at: http://blog.dicay.net/ or 
 */
using System;
using System.Windows.Forms;

namespace RsaGenerateKey.NET
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
