using System;

namespace ChallengeApp
{
    class Program
    {
        static void Main(string[] args) {
            LongestWord longestWord = new LongestWord(new string[] { "small", "big", "largestttt" });
            longestWord.findLongestWord();
            Console.WriteLine(longestWord.word);
            Console.WriteLine(longestWord.reverseWord);
        }
    }
}
