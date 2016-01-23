/*
 *This project for RSA keys generator, XML,PEM,DER format using for .NET, JAVA
 * Created by: xonv,2016-01-24
 * In PEM Format, I reference at stackoverflow: http://stackoverflow.com/questions/23734792/c-sharp-export-private-public-rsa-key-from-rsacryptoserviceprovider-to-pem-strin 
 * Hope this help for looking key generator between .NET and Java when using RSA Algorithm 
 * Contact me at: http://blog.dicay.net/ or 
 */

using System.Security.Cryptography;

namespace RsaGenerateKey.NET.Common
{
  public  class XmlFormatter
    {
      public static string ExportPrivateKey(RSACryptoServiceProvider rsa)
      {
          return rsa.ToXmlString(true);
      }
      public static string ExportPublicKey(RSACryptoServiceProvider rsa)
      {
          return rsa.ToXmlString(false);
      }
      
      
    }
}
