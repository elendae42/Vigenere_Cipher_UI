using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vigenere_Cipher_UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vigenere_Cipher_UI.Tests
{
    [TestClass()]
    public class Prepare_TextTests
    {
        [TestMethod()]
        public void prepareOutputTest()
        {
            const string output = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string expectedPrepared = "ABCDE FGHIJ KLMNO PQRST UVWXY Z";

            // ACT
            string testOutput = Prepare_Text.prepareOutput(output);

            // Assert
            testOutput.Equals(expectedPrepared);
        }
        [TestMethod()]
        public void prepareInputTest()
        {
            const string input = "abcde f g hijklmn o PQR sTuvWX Yz";
            const string expectedPrepared = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            // ACT
            string testInput = Prepare_Text.prepareInput(input);

            // Assert
            testInput.Equals(expectedPrepared);
        }
        [TestMethod()]
        public void prepareInputTestv2()
        {
            const string input = "abcde f g hijklmn o PQR sTuvWX Yz !@#$%^&*()_+ 1234567890";
            const string expectedPrepared = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            // ACT
            string testInput = Prepare_Text.prepareInput(input);

            // Assert
            testInput.Equals(expectedPrepared);
        }
    }
}