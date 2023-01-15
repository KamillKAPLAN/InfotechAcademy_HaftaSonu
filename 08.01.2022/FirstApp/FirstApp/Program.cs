using System;

namespace FirstApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Ornekler ex = new Ornekler();

            int a = 8, b, c;
            Console.WriteLine($"a ilk deger : {a}");  // 8
            b = ++a;                                  
            c = a--;                                  
            Console.WriteLine($"b deger : {b}");      // 9 9 
            Console.WriteLine($"c deger : {c}");      // 9 7 
            Console.WriteLine($"a son deger : {a}");  // 8 7 

            // 11. sayfa

            Console.ReadLine();
        }
    }
}
