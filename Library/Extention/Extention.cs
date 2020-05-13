using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Library.Extention
{
    public static class Extention
    {
        public static bool Is_Email(this string email)
        {
            try
            {
                MailAddress mail = new MailAddress(email);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static string HashPassword(this string password)
        {
            byte[] bytePassw = Encoding.ASCII.GetBytes(password);
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] hashBytePassw = md5.ComputeHash(bytePassw);

            return Encoding.ASCII.GetString(hashBytePassw);
        }

    }
}
