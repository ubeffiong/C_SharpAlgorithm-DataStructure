﻿using System;
using System.Text.RegularExpressions;

namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 2; i++)
            {
                string sentence = Console.ReadLine();
                if (sentence == sentence.ToLower())
                {
                    sentence = Regex.Replace(sentence, @"\s", "");
                    var array = sentence.ToCharArray();
                    Array.Reverse(array);
                    string words = new string(array);
                    if (words == sentence)
                    {
                        Console.WriteLine("Yes is Palindrome: " + words);
                    }
                    else
                    {
                        Console.WriteLine("Not Palindrome");
                    }
                }
                else
                {
                    Console.WriteLine(sentence + " Should all be entered in lower cases");
                }
            }           
            Console.ReadKey();
        }
    }
}
