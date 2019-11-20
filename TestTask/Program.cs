using System;
using System.Collections.Generic;

namespace TestTask
{
    class Program
    {       
        static void Main(string[] args)
        {
            void Find(string findStr, int len)
            {                
                List<string> listStr = new List<string>();
                for(int i = 0; i <= findStr.Length - len; i++)
                {
                    listStr.Add(findStr.Substring(i, len));
                }

                List<int> listCount = new List<int>();
                List<int> maxIndex = new List<int>();
                int max = 0;
                for (int i = 0; i < listStr.Count - 1; i++)
                {
                    listCount.Add(1);
                    for(int j = i + 1; j < listStr.Count; j++)
                    {
                        if(String.Compare(listStr[i], listStr[j]) == 0)
                        {
                            listCount[i]++;
                        }
                    }
                    if(max <= listCount[i])
                    {
                        if (max < listCount[i])
                        {
                            maxIndex.Clear();
                            maxIndex.Add(i);
                            max = listCount[i];
                        }
                        else
                        {
                            maxIndex.Add(i);
                        }
                    }
                }
                for(int i = 0; i < maxIndex.Count; i++)
                {
                    Console.WriteLine("maxStr " + listStr[maxIndex[i]] + " => " + max);
                }
            }

            Find("aabcava baavur aabd", 3);
            Console.WriteLine();
            Find("aabaabbbcbbc bbchnhhnhvlvvlvvlv", 3);
            Console.WriteLine();
            Find("kjshbfksadnfljbasnkdbhjsgfbksdklfjhsfkbnskdjhb", 2);
        }
    }
}
