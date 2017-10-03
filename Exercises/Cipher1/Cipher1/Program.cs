using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cipher1
{
    class Program
    {
        static void Main(string[] args)
        {
            String key = "CATCATCATCATCATCAT";
            String plainText = "We Attack At Dawn";
            String Cyphertext = Encrypt(plainText, key);
            String DecryptedText = Decrypt(Cyphertext, key);

            Console.WriteLine("PlainText :{0}", plainText);
            Console.WriteLine("Encrypt  :{0}", Cyphertext);
            Console.WriteLine("Decrypt  :{0}", plainText);
            Console.ReadKey();
        }

        static string Encrypt(string plainText, string key )    
        {
            char[] Chars = new char[plainText.Length];

            for(int i = 0; i < plainText.Length; i++)
            { 
                if(plainText[i] == ' ')
            {
                Chars[i] = ' ';
            }
            else
            {
                int j = plainText[i] - 97;
                    Chars[i] = key[i];
            }
        }
            return new string(Chars);
        }
        static string Decrypt(string Cyphertext, string key)
        {
            char[] Chars = new char[Cyphertext.Length];

            for(int i = 0; i < Cyphertext.Length; i++)
            {
                if (Cyphertext[i] == ' ')
                {
                    Chars[i] = ' ';
                }
                else
                    {
                    int j = key.IndexOf(Cyphertext[i]) - 97;
                    Chars[i] = (char)j;
                }
            }
            return new string(Chars);
        }
    }
}
