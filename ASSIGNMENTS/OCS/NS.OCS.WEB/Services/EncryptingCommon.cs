using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NS.OCS.WEB.Services
{
    public class EncryptingCommon
    {
        public static string EnryptString(string strEncrypted)
        {
            byte[] b = System.Text.ASCIIEncoding.ASCII.GetBytes(strEncrypted);
            string encrypted = Convert.ToBase64String(b);
            return encrypted;
        }

        public static string DecryptString(string encrString)
        {
            byte[] b;
            string decrypted;
            try
            {
                b = Convert.FromBase64String(encrString);
                decrypted = System.Text.ASCIIEncoding.ASCII.GetString(b);
            }
            catch (FormatException )
            {
                decrypted = "";
            }
            return decrypted;
        }




    }
}
