using System;

namespace FirstApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nasılsın");
            Console.WriteLine("Selam Sınıf");

            const int x = 15, y = 20; // field
            // public int y { get { return y; } set { value = y; } }
            const double piSayisi = 3.14;
            const int z = x + y;

            Console.WriteLine(z);
            /*
             * Adı : Kamil
             * Soyadı : Kaplan
             * Yaşı : 29
             * Memleketi : Malatya
             */
            const string name = "Kamil", lastName = "Kaplan", city = "Malatya";
            const int age = 29;

            Console.WriteLine("Adı : " + name + "\nSoyadı : " + lastName + "\nYaşı : " + age + "\nMemleketi : " + city);

            Console.WriteLine("\n-------------------------\n");

            Console.WriteLine("Adı : {0}" + " \nSoyadı : {1}" + "\nYaşı : {2}" + "\nMemleketi : {3}", name, lastName, age, city);

            Console.WriteLine("\n-------------------------\n");

            Console.WriteLine($"Adı : {name} \nSoyadı : {lastName} \nYaşı : {age} \nMemleketi : {city}");

            byte byt = byte.MaxValue;
            Console.WriteLine(byt);

            Console.ReadLine();
        }
    }
}
