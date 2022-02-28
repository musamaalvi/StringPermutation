using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringPermutation
{
    public class Permutation
    {
        public bool CheckPermutation(string word)
        {
            Regex sWhitespace = new Regex(@"\s+");
            word = sWhitespace.Replace(word, "");
            Dictionary<string, int> dic = new Dictionary<string, int>();
            for(int i=0;i<word.Length; i++)
            {
                if (dic.ContainsKey(word[i].ToString().ToLower()))
                {
                    dic[word[i].ToString().ToLower()] += 1;
                }
                else
                {
                    dic.Add(word[i].ToString().ToLower(), 1);
                }
            }
            bool singleCharacterCheck = false;
            foreach (KeyValuePair<string, int> val in dic)
            {
                if(dic[val.Key] % 2 != 0)
                {
                    if (singleCharacterCheck)
                    {
                        return false;
                    }
                    singleCharacterCheck = true;
                }
            }
            return true;
        }
    }
}
