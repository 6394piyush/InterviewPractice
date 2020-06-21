using System;

namespace CodeSnippets
{
    class Program
    {
        static int MAX_NUM = 26;
        static void Main(string[] args)
        {
            string str = "piiiyush"; //only works for small case
            int[] charCount = new int[MAX_NUM];

            for(int i=0;i<str.Length;i++)
            {
                charCount[str[i] - 'a']++;
            }
            for(int i=MAX_NUM-1;i>0;i--)
            {
                for(int j=0;j<charCount[i];j++)
                {
                    Console.Write((char)('a' + i));
                }
            }
        }
    }
}
