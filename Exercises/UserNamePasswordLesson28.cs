using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace UserNamePasswordLesson28
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = "";
            string pass = "";
            string Key = "123456789qwerty12345678qwertyui";
            string IV = "12345678qwertyui";

            Console.WriteLine("Please enter your Username as FirstNameLastName: ");
            username = Console.ReadLine();
            Console.WriteLine("Please enter your password in plain text: ");
            pass = Console.ReadLine();

            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Encrypter");
            key.SetValue("Password", pass);
            pass = Encrypt("My Password");
        
            if(username == "MarshaBrooks")
            {
                (pass = Convert.ToString(key.GetValue("Password")));
                    Console.WriteLine("Password", pass);
            }
            else
            {
                Console.WriteLine("Enter correct username");
            }
        }
        private static string Encrypt(string text)
        {
            byte[] plaintextbytes = System.Text.ASCIIEncoding.ASCII.GetBytes(text);
            AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
            aes.BlockSize = 128;
            aes.KeySize = 256;
            aes.Key = System.Text.ASCIIEncoding.ASCII.GetBytes(Key);
            aes.IV = System.Text.ASCIIEncoding.ASCII.GetBytes(IV);
            aes.Padding = PaddingMode.PKCS7;
            aes.Mode = CipherMode.CBC;
            ICryptoTransform crypto = aes.CreateEncryptor(aes.Key, aes.IV);
            byte[] encrypted = crypto.TransformFinalBlock(plaintextbytes, 0, plaintextbytes.Length);
            return Convert.ToBase64String(encrypted);

        }
        
        
    }
}
