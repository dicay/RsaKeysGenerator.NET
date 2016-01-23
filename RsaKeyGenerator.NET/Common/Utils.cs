using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace RsaGenerateKey.NET.Common
{
   public class Utils
    {
       public static string ExportToPEM(X509Certificate cert)
       {
           StringBuilder builder = new StringBuilder();

           builder.AppendLine("-----BEGIN CERTIFICATE-----");
           builder.AppendLine(Convert.ToBase64String(cert.Export(X509ContentType.Cert), Base64FormattingOptions.InsertLineBreaks));
           builder.AppendLine("-----END CERTIFICATE-----");

           return builder.ToString();
       }
    }
}
