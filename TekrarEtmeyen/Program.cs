using System;
using System.Collections.Generic;
using System.Linq;

namespace TekrarEtmeyen
{
    internal class Program
    {
        public class TekrarEtmeyenClass
        {
            public static void TekrarEtmeyen()
            {
                bool yanlisKarakter = true;
                while (yanlisKarakter is true)
                {
                    Console.WriteLine("Bir string değer girin");
                    var str = Console.ReadLine();

                    var chars = str.ToCharArray();
                    if (chars.Length < 2)
                    {
                        Console.WriteLine("En az 2 karakter girilmeli");
                    }
                    else
                    {

                        Dictionary<char, int> charMap = new Dictionary<char, int>();

                        foreach (var c in chars)
                        {
                            if (charMap.ContainsKey(c))
                            {
                                charMap[c] = charMap[c] + 1;
                            }
                            else
                            {
                                charMap.Add(c, 1);
                            }
                        }

                        var keys = new HashSet<char>(charMap.Keys);
                        foreach (var ch in keys)
                        {
                            if (charMap[ch] == 1)
                            {
                                Console.WriteLine($"Tekrar etmeyen Karakter {ch}");
                            }
                            else
                            {
                                continue;
                            }
                        }

                        yanlisKarakter = false;
                    }
                }
                
            }
        }

        public static void Main(string[] args)
        {

            TekrarEtmeyenClass.TekrarEtmeyen();
            
            
        }
    }
}