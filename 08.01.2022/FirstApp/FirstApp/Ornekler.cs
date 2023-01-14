using System;

namespace FirstApp
{
    public class Ornekler
    {
        public int InfotechAcademy { get; set; }

        public void orn1()
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
            Console.WriteLine("{0} {1}", f, g);
            Console.WriteLine($"{f} {g}");

            int x = 5;
            int y = 6;
            Console.WriteLine(" x + y " + (x + y));
        }

        public void orn2()
        {
            {
                int x = 15;
                Console.WriteLine(x);
            }
            {
                int x = 20;
                Console.WriteLine(x);
            }

            int y = 15;
            Console.WriteLine(y);

            y = 20;
            Console.WriteLine(y);

            const double piSayisi = 3.14;
            //piSayisi = piSayisi + 1;
            Console.WriteLine(piSayisi);

            double xSayisi = 5.12;
            xSayisi = xSayisi + 1;
            Console.WriteLine(xSayisi);

            const int xx = 10, yy = 20;
            const int tplm = xx + yy;

            char[] chr = { 'K', 'A', 'M', 'İ', 'L' };
            char[] cFor = { 'K', 'K', 'K', 'K', 'K' };

            string s = new string(chr);
            string ss = new string('K', 5);
            Console.WriteLine(s);
            Console.WriteLine(ss);

            for (int i = 0; i < 5; i++)
            {
                Console.Write(cFor[i] + " ");
            }

            Ornekler ex = new Ornekler();
            ex.orn2();
            ex.InfotechAcademy = 5;
            Console.WriteLine(ex.InfotechAcademy);
        }

        public void orn3()
        {
            object x = 5;
            Console.WriteLine($"{x} type : {x.GetType()}");
            x = "Infotech";
            Console.WriteLine($"{x} type : {x.GetType()}");
            x = 32.4;
            Console.WriteLine($"{x} type : {x.GetType()}");
            x = 12.5f;
            Console.WriteLine($"{x} type : {x.GetType()}");
            x = true;
            Console.WriteLine($"{x} type : {x.GetType()}");

            int y = 0;
            Console.WriteLine(y);
            y = Convert.ToInt32(12.5);
            Console.WriteLine($"Round : {Math.Round(12.51d)}");
            Console.WriteLine(y);
            y = Convert.ToInt32(true);
            Console.WriteLine(y);

            var vrDegisken = "InfotechAcademy";
            Console.WriteLine($"{vrDegisken} type : {vrDegisken.GetType()}");
            vrDegisken = Convert.ToString(15);
            Console.WriteLine($"{vrDegisken} type : {vrDegisken.GetType()}");

            int sayi = 400;
            Console.WriteLine($"{sayi} sayısının bitsel karşılığı : {(byte)sayi}");

            int iValue = 256;
            byte bValue;
            unchecked
            {
                bValue = (byte)iValue;
            }
            Console.WriteLine($"iValue : {iValue} => bValue : {bValue}");
            checked
            {
                bValue = (byte)iValue;
            }
            Console.WriteLine($"iValue : {iValue} => bValue : {bValue}");
        }

        public void orn4()
        {
            int int1 = 15, int2 = 20;
            Console.WriteLine($"int1 Value : {int1} int2 Value : {int2} " +
                              $"\n int1 Type : {int1.GetType()} int2 Type: {int2.GetType()} " +
                              $"\n int1({int1}) + int2({int2}) = {int1 + int2}");
            Console.WriteLine("-----------------------------------");
            string str1 = int1.ToString();
            Console.WriteLine($"str1 Value : {str1} str2 Value : {int2.ToString()} " +
                              $"\n str1 Type : {str1.GetType()} str2 Type: {int2.ToString().GetType()} " +
                              $"\n str1({str1}) + str2({int2.ToString()}) = {str1 + int2.ToString()}");

            int iiV = 5;
            byte bValue = Convert.ToByte(iiV);
            Console.WriteLine(bValue);
            string c = "12,54";
            float fValue = float.Parse(c);
            Console.WriteLine($"fValue : {fValue} fType = {fValue.GetType()}");
            Console.WriteLine(Convert.ToSingle(c));
        }
    }
}
