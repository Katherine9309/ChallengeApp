using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeApp
{
    public class LongestWord
    {

        string[] _words;
        string _word;
        string _reverseWord;


        public LongestWord(string[] words)
        {
            _words = words;
        }

        public string word { get { return _word; } }

        public string reverseWord { get { return _reverseWord; } }

        public void findLongestWord()
        {
            _word = _words[0];

            for (int i = 0; i < _words.Length; i++)
            {
                if (String.IsNullOrEmpty(_word))
                {
                    throw new Exception("The word cannot be null or empty");
                }

                if (_word.Length < _words[i].Length)
                {
                    _word = _words[i];
                }
            }

            char[] longestWordArray = _word.ToCharArray();
            Array.Reverse(longestWordArray);
            _reverseWord = new string(longestWordArray);
        }
    }
}
