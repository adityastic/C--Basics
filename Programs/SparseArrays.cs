using System;
using System.Collections.Generic;

namespace Practise.Programs
{
    public class SparseArrays
    {
        public SparseArrays()
        {
        }

        static void addToDictionary(Dictionary<string, int> dict, string word)
        {
            if (dict.ContainsKey(word))
                dict[word]++;
            else
                dict.Add(word, 1);
        }

        static int[] matchingStrings(string[] strings, string[] queries)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (string s in strings)
            {
                addToDictionary(dict,s);
            }

            int[] result = new int[queries.Length];
            for (int i = 0; i < queries.Length; i++)
            {
                if (dict.ContainsKey(queries[i]))
                    result[i] = dict[queries[i]];
                else
                    result[i] = 0;
            }

            return result;
        }

        public static void execute()
        {
            System.Console.Write(matchingStrings(new string[] { "aba", "baba", "aba", "xzxb"}, new string[] { "aba", "xzxb", "ab"}));
        }
    }
}
