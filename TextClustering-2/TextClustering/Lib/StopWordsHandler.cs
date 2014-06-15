using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextClustering.Lib
{
    /// <summary>
    /// TODO: generally stop word are removed to make the indexing process effective, We can consider the term as stop words which has highest 
    /// term frequency on document corpus.
    /// </summary>
    public class StopWordsHandler
    {
        //you can defined other stop word list here
        public static string[] stopWordsList = new string[] { "The"};

        public static Boolean IsStotpWord(string word)
        {
            if (stopWordsList.Contains(word))
                return true;
            else
                return false;
        }
    }

}
