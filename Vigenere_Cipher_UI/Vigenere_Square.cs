using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vigenere_Cipher_UI
{
    public class Vigenere_Square
    {
        public static char[] alphabet = new char[26]
        {
            'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'
        };

        public static string decode(string toDecode, string key)
        {
            string preparedText = Prepare_Text.prepareInput(toDecode);
            string preparedKey = Prepare_Text.prepareInput(key);
            string decoded;
            List<char> results = new List<char>();
            int keyPosition = 0;
            foreach (char i in preparedText)
            {
                char keyChar = preparedKey[keyPosition];
                int decodePosition = countDistanceDecode(keyChar, i);
                results.Add(alphabet[decodePosition]);
                keyPosition++;
                if (keyPosition >= key.Length)
                {
                    keyPosition = 0;
                }
            }
            decoded = string.Concat(results);
            string finalDecoded = Prepare_Text.prepareOutput(decoded);
            return finalDecoded;
        }

        public static int countDistanceDecode(char start, char end)
        {
            int count = 0;
            int position = Array.IndexOf(alphabet, start);
            while (alphabet[position] != end)
            {
                count++;
                position++;
                if (position >= alphabet.Length)
                {
                    position = 0;
                }
            }
            //Console.WriteLine(count);   // Print debugging
            return count;
        }

        public static int countDistanceEncode(char end)
        {
            int count = 0;
            int position = 0;
            while (alphabet[position] != end)
            {
                count++;
                position++;
                if (position >= alphabet.Length)
                {
                    position = 0;
                }
            }
            //Console.WriteLine(count);   // Print debugging
            return count;
        }

        public static string encode(string toEncode, string key)
        {
            string preparedText = Prepare_Text.prepareInput(toEncode);
            string preparedKey = Prepare_Text.prepareInput(key);
            string coded;
            List<char> results = new List<char>();
            int keyPosition = 0;
            foreach (char i in preparedText)
            {
                char keyChar = preparedKey[keyPosition];
                int encodePosition = countDistanceEncode(keyChar);
                int charEncode = Array.IndexOf(alphabet, i);
                int move = charEncode + encodePosition;
                if (move >= alphabet.Length - 1)
                {
                    move = move - (alphabet.Length - 1);
                }
                results.Add(alphabet[move]);
                keyPosition++;
                if (keyPosition >= preparedKey.Length)
                {
                    keyPosition = 0;
                }
            }
            coded = string.Concat(results);
            string finalCoded = Prepare_Text.prepareOutput(coded);
            return finalCoded;
        }
    }
}
