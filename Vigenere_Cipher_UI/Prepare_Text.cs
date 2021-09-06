using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Vigenere_Cipher_UI
{
    public class Prepare_Text
    {
        public static string prepareInput(string input)
        {
            string inputUpper = input.ToUpper();
            string prepared = Regex.Replace(inputUpper, @"[^A-Za-z]", "");
            return prepared;
        }

        public static string prepareOutput(string output)
        {
            char[] outputArray = output.ToCharArray();
            List<char> results = new List<char>();
            for(int i = 0; i < outputArray.Length; i++)
            {
                if (i % 5 == 0)
                {
                    results.Add(' ');
                    results.Add(outputArray[i]);
                }
                else
                {
                    results.Add(outputArray[i]);
                }
            }
            string prepared = string.Concat(results);
            return prepared;
        }
    }
}
