using System;
using System.Collections.Generic;

namespace ReversalTest
{
    public class ReverseSentence
    {
        public ReverseSentence()
        {
        }

        public string ReverseSent(string input)
        {
            string[] split = input.Split(' ');
            List<string> reversed = new List<string>();
            foreach(string a in split)
            {
                bool addPunct = false;
                string temp = "";
                char punct = ' ';
                char[] temparr = a.ToCharArray();
                for(int i = temparr.Length - 1; i >= 0; i--)
                {
                    if (char.IsPunctuation(temparr[i]))
                    {
                        addPunct = true;
                        punct = temparr[i];
                    }
                    else
                    {
                        temp += temparr[i];
                    }
                }
                if (addPunct)
                {
                    temp += punct;
                }
                reversed.Add(temp);
            }
            string end = "";
            for(int i = 0; i < reversed.Count; i++)
            {
                if (i == reversed.Count - 1)
                {
                    end += reversed[i];
                }
                else
                {
                    end += reversed[i] + " ";
                }
            }
            return end;
        }
    }
}
