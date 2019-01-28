using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for(int t = 0; t < T; t++)
            {
                string line = Console.ReadLine();
                string[] space = line.Split('\n');
                foreach(string value in space)
                {
                    if (Ispalindrome(value))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No");
                    }
                }
            }
        }
        public static bool Ispalindrome(string word)
        {
            int min = 0;
            int max = word.Length - 1;
            while (true)
            {
                if (min > max)
                    return true;
                char a = word[min];
                char b = word[max];
                if (char.ToLower(a) != char.ToLower(b))
                    return false;
                min++;
                max--;
            }
        } 
    }
}
