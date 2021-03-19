using System;

namespace _59.CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[] word = Console.ReadLine().ToCharArray();
            int rotation = int.Parse(Console.ReadLine());
            rotation = rotation % 26;

            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsLetter(word[i]))
                {
                    if ((int)word[i] + rotation > 122 || (char.IsUpper(word[i]) && (int)word[i] + rotation > 90))
                    {
                        int a = 0;

                        if (char.IsUpper(word[i]))
                        {
                            a = 64+(Math.Abs(90-(rotation+(int)word[i])));
                            word[i] = (char)(a);

                        }
                        else
                        {
                            a = 96 - (122 - (int)word[i]);
                            word[i] = (char)(a + rotation);
                        }

                    }
                    else
                    {
                        word[i] = (char)((int)word[i] + rotation);

                    }
                }
            }
            Console.WriteLine(string.Join("", word));

        }
    }
}
