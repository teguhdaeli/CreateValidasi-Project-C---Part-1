using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "ACP122132112";
            //
            string KarSub = input.Substring(0, 3);
            int JlhKarSub = KarSub.Length;
            int JlhInput = input.Length;
            bool onlyAlphas = KarSub.All(c => (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'));
            bool ResultUpperKarSub = KarSub.All(c => (c >= 'a' && c <= 'z'));
            if (JlhKarSub == 3 && JlhInput == 12 && onlyAlphas == true && ResultUpperKarSub == false)
            {
               Console.WriteLine("Benar");
            }
            else
            {
                Console.WriteLine("Salah");
            }
            Console.ReadKey();
        }
    }
}
