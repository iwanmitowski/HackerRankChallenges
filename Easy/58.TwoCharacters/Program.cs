using System;
using System.Collections.Generic;
using System.Linq;

namespace _58.TwoCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            //8/33 failed

            //int n = int.Parse(Console.ReadLine());
            //List<char> word = Console.ReadLine().ToCharArray().ToList();

            //List<char> distinctedWord = word.Distinct().ToList();
            //int maxLength = 0;

            //foreach (var c in distinctedWord)
            //{

            //    foreach (var c2 in distinctedWord.Where(x => x != c))
            //    {
            //        char[] temp = word.Where(x => x != c && x != c2).ToArray();

            //        bool isAcceptable = true;

            //        int distinctedLength = temp.Length;

            //        for (int i = 1; i < temp.Length; i++)
            //        {
            //            if (temp[i - 1] == temp[i])
            //            {
            //                isAcceptable = false;
            //                break;
            //            }
            //        }
            //        if (isAcceptable && temp.Distinct().Count() >= 2)
            //        {
            //            if (maxLength < distinctedLength)
            //            {
            //                maxLength = distinctedLength;
            //            }


            //        }
            //        else if (temp.Length == 0)
            //        {
            //            maxLength = word.Count;
            //        }

            //    }

            //}


            int n = int.Parse(Console.ReadLine());
            List<char> word = Console.ReadLine().ToCharArray().ToList();

            List<char> distinctedWord = word.Distinct().ToList();
            int maxLength = 0;

            var copyWord = word.ToList();

            foreach (var c in distinctedWord)
            {

                foreach (var c2 in distinctedWord.Where(x => x != c))
                {
                    char[] temp = copyWord.Where(x => x == c || x == c2).ToArray();


                    bool isAcceptable = true;

                    int distinctedLength = temp.Length;

                    for (int i = 1; i < temp.Length; i++)
                    {
                        if (temp[i - 1] == temp[i])
                        {
                            isAcceptable = false;
                            break;
                        }
                    }
                    if (isAcceptable && temp.Distinct().Count() >= 2)
                    {
                        if (maxLength < distinctedLength)
                        {
                            maxLength = distinctedLength;

                        }


                    }
                    else if (temp.Length == 0)
                    {
                        maxLength = word.Count;
                    }

                }

            }




            Console.WriteLine(maxLength);

        }
    }
}
