using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesStoreManagmentSystem.Helpers
{
    public static class CryptingHelper
    {
        public const string ALPAHBET = "abcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+=-";
        public static string Encrypt(string text)
        {
            string cryptingtext=string.Empty;
            foreach (var ch in text)
            {
                int index = ALPAHBET.IndexOf(ch);
                cryptingtext += index;
                cryptingtext += "#";
            }

            return cryptingtext.Remove(cryptingtext.Length-1);
        }

        public static string Decrypt(string text)
        {
            var splittedText=text.Split('#');
            string result = string.Empty;
            for (int i = 0; i < splittedText.Length; i++)
            {
                int index = int.Parse(splittedText[i]);
                result += ALPAHBET[index];
            }
            return result;
            
        }
    }
}
