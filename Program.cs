using System;
using System.Collections.Generic;
using System.Linq;

namespace Encryption
{
    class Program
    {
        static void Main(string[] args)
        {

            //  string baza = "qpalIDvtFH12ygQPALBRM89WwufhosZJ67kxn45OzmrSKXNeidjcbEUVTYG30;,./'[]+-_"; brakuje cyfry
            string encryptionKey = "qUer45Xufh67woskZ89vyALaMWpxOSK3NEtgQPIDjcbFHVYTGidlzm1nJCBR20;,./'[]+-_";

            string yourString = "Marcin0";
            List<char> lettersOfYourString = new List<char>();
            string decrypted = "";
            string encrypted = "";
            List<int> positions = new List<int>();
            List<int> positions2 = new List<int>();

            foreach (char element in yourString)
            {
                lettersOfYourString.Add(element);
            }


            //encrypting

            foreach (char element in lettersOfYourString)
            {
                int position = 0;
               char currentLetter = element;
                    for (int j = 0; j < encryptionKey.Count<char>(); j++)
                    {
                        if (currentLetter == encryptionKey[j])
                        {
                            position = j;
                            break;
                        }
                    }
                positions.Add(position);
            }


            for (int i = 0; i < yourString.Count<char>(); i++)
            {
                encrypted += encryptionKey[positions[i] + 10]; //adding positions of letters
            }

            //decrypting
            foreach (char element in encrypted)
            {
                int position = 0;
               char currentLetter = element;
                for (int j = 0; j < encryptionKey.Count<char>(); j++)
                {
                    if (currentLetter == encryptionKey[j])
                    {
                        position = j;
                        break;
                    }
                }
                positions2.Add(position);
            }

            for (int i = 0; i < yourString.Count<char>(); i++)
            {
                decrypted += encryptionKey[positions2[i] - 10];
            }

            Console.WriteLine("Original: " + yourString);
            Console.WriteLine("Encrypted: " + encrypted);
            Console.WriteLine("Decrypted: " + decrypted);

            Console.ReadKey();

        }
    }
}
