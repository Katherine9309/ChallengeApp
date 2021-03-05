using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChallengeApp;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit.Sdk;

namespace ChallengeApp.Tests
{
    [TestClass()]
    public class LongestWordTests
    {
        [TestMethod()]

        public void testLongestWord()
        {
            LongestWord longestWord = new LongestWord(new string[] { "rusia", "colombia" });
            longestWord.findLongestWord();
            Assert.AreEqual("colombia", longestWord.word);
        }

        [TestMethod()]
        public void testReverseWord()
        {
            LongestWord longestWord = new LongestWord(new string[] { "rusia", "colombia" });
            longestWord.findLongestWord();
            Assert.AreEqual("aibmolocc", longestWord.reverseWord);
        }

        [TestMethod()]
        public void testBadInput()
        {
            LongestWord longestWord = new LongestWord(new string[] { null, "colombia" });
            try
            {
                longestWord.findLongestWord();
            } catch (Exception e)
            {
                StringAssert.Contains(e.Message, "The word cannot be null or empty");
                return;
            }
            Assert.Fail("No exception was thrown");
        }
    }
}