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
    public class Vigenere_SquareTests
    {
        [TestMethod()]
        public void encodeTest()
        {
            const string key = "key";
            const string toEncode = "Hello World";
            const string expected = "RIJVS UYVJN";

            // ACT
            string test = Vigenere_Square.encode(toEncode, key);

            // Assert
            test.Equals(expected);
        }
        [TestMethod()]
        public void encodeTestWithZ()
        {
            const string key = "key";
            const string toEncode = "The quick brown fox jumps over the lazy dog.";
            const string expected = "ELDBY HMOAC SVXJN INTWT RYADC XGOPY KDCYK";

            // ACT
            string test = Vigenere_Square.encode(toEncode, key);

            // Assert
            test.Equals(expected);
        }

        [TestMethod()]
        public void decodeTest()
        {
            const string key = "key";
            const string toDecode = "rijv suyvj n";
            const string expcected = "HELLO WORLD";

            // ACT
            string test = Vigenere_Square.decode(toDecode, key);

            // Assert
            test.Equals(expcected);
        }
        [TestMethod()]
        public void decodeTestV2()
        {
            const string key = "key";
            const string toDecode = "ELDBY HMOAC SVXJN INTWT RYADC XGOPY KDCYK";
            const string expcected = "THEQU ICKBR OWNFO XJUMP SOVER THELA ZYDOG";

            // ACT
            string test = Vigenere_Square.decode(toDecode, key);

            // Assert
            test.Equals(expcected);
        }
    }
}