using System;

namespace FirstApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            string s1 = "5";
            string s2 = "6";
            Console.WriteLine(s1 + s2);

            string s = new string('a', 4);
            Console.WriteLine(s);
            object o = 5.5d;
            Console.WriteLine(o.GetType());
            o = "Kamil";
            Console.WriteLine(o.GetType());
            Console.WriteLine($"string değer : {s} ve string type : {s.GetType()} - " +
                              $"object değeri : {o} ve object type : {o.GetType()}".GetType());          

            string f = "zeynep ";
            string g = "ÖZTÜRK";
            Console.WriteLine("{0} {1}",f,g);
            Console.WriteLine($"{f} {g}");

            int x =5;
            int y =6;
            Console.WriteLine(" x + y "+ ( x+y));

            //  sayfa 78
            Console.ReadLine();
        }
    }
}
