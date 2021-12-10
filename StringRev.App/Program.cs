using System;
using static System.Console;

namespace StringRev.App
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "";

            while ((sentence = ReadLine()) != "exit")
            {
                WriteLine(sentence.ReverseWordsInString());
            }
        }
    }

    static class StringReverser
    {
        static public string ReverseWordsInString(this string str)
        {
            char[] ch_arr = str.ToCharArray();
            int d_index = 0;

            int i = 0;
            int j = 0;
            for (; i < str.Length; i++)
            {
                if (ch_arr[i] == ' ' || ch_arr[i] == '.' || ch_arr[i] == ',')
                {
                    for (j = 0; j < (i - d_index) / 2; j++)
                    {
                        SwapCharacters(ref ch_arr[d_index + j], ref ch_arr[i - j - 1]);
                    }

                    d_index = i + 1;
                }
            }

            for (j = 0; j < (i - d_index) / 2; j++)
            {
                SwapCharacters(ref ch_arr[d_index + j], ref ch_arr[i - j - 1]);
            }

            return new string(ch_arr);
        }

        static private void SwapCharacters(ref char a, ref char b)
        {
            a = (char)(a + b);
            b = (char)(a - b);
            a = (char)(a - b);
        }
    }
}
