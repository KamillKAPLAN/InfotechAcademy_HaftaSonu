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

        public void orn5()
        {
            Console.Write("1. Sayıyı giriniz : ");
            string sayi1 = Console.ReadLine();
            Console.Write("2. Sayıyı giriniz : ");
            string sayi2 = Console.ReadLine();
            //Console.WriteLine("1. Sayı : " + sayi1 + " 2. Sayı : " + sayi2);
            Console.WriteLine($"1. Sayı Value : {sayi1} 2. Sayı Value : {sayi2}");
            Console.WriteLine($"1. Sayı Type : {sayi1.GetType()} 2. Sayı Type : {sayi2.GetType()}");
            int toplam = 0;
            if (Convert.ToInt32(sayi1) > Convert.ToInt32(sayi2))
            {
                toplam = Convert.ToInt32(sayi1) + Convert.ToInt32(sayi2);
            }
            else if (Convert.ToInt32(sayi1) == Convert.ToInt32(sayi2))
            {
                toplam = (2 * (Convert.ToInt32(sayi1) + Convert.ToInt32(sayi2)));
            }
            else
            {
                toplam = ((Convert.ToInt32(sayi1) + Convert.ToInt32(sayi2)) - 5);
            }
            Console.WriteLine($"1. Sayı : {sayi1} + 2. Sayı : {sayi2} = {toplam}");
            Console.ReadLine();
        }

        public void orn6()
        {
            Console.Write("1. Değeri giriniz : ");
            string deger1 = Console.ReadLine();
            Console.Write("2. Değeri giriniz : ");
            string deger2 = Console.ReadLine();
            Console.Write("3. Değeri giriniz : ");
            string deger3 = Console.ReadLine();
            Console.Write("İşlem operatörünü (+,-,*,/) giriniz : ");
            string operat = Console.ReadLine();
            // Console.WriteLine($"Kullanıcıdan alınan değerler : {deger1} - {deger2} - {deger3} - {operat} alındı.");

            // Console.WriteLine($"Alınan değer toplamı : {deger1 + deger2 + deger3}");

            int s1, s2, s3, sonuc = 0;
            s1 = Int32.Parse(deger1);
            s2 = Convert.ToInt32(deger2);
            s3 = Int32.Parse(deger3);

            // Console.WriteLine($"Int deger toplamı : {s1 + s2 + s3}");

            if (operat == "+")
            {
                sonuc = (s1 + s2 + s3);
            }
            else if (operat == "-")
            {
                sonuc = (s1 - s2 - s3);
            }
            else if (operat == "*")
            {
                sonuc = (s1 * s2 * s3);
            }
            else if (operat == "/")
            {
                if (s2 == 0 || s3 == 0)
                {
                    Console.WriteLine("2. veya 3. sayı 0 'dan farklı olmalıdır.");
                }
                else
                {
                    sonuc = (s1 / s2 / s3);
                }
            }
            else
            {
                /* +,-,*,/  ++ */
                Console.WriteLine("Tanımsız operatör");
            }

            /* 0 -10 arasında ise */
            if (sonuc > 0 && sonuc <= 10)
            {
                Console.WriteLine("FF");
            }
            else if (sonuc >= 11 && sonuc <= 20)
            {
                Console.WriteLine("DD");
            }
            else if (sonuc >= 21 && sonuc <= 30)
            {
                Console.WriteLine("CC");
            }
            else if (sonuc >= 31 && sonuc <= 40)
            {
                Console.WriteLine("CB");
            }
            else if (sonuc >= 41 && sonuc <= 50)
            {
                Console.WriteLine("BB");
            }
            else if (sonuc >= 51 && sonuc <= 70)
            {
                Console.WriteLine("BA");
            }
            else if (sonuc >= 71 && sonuc <= 100)
            {
                Console.WriteLine("AA");
            }
            else
            {
                Console.WriteLine("Harf notunuz tanımsız");
            }
        }

        public void orn6_1()
        {
            /*
              Dışarıdan 3 tane sayı al, ve bu sayıları +,-,/,* operatörlerine 
              göre işlemleri yaptır. çıkan sonuç 
               70-100 arasında ise : AA
               50-70 arasında ise : BA 
               40-50 arasında ise : BB
               30-40 arasında ise : CB
               20-30 arasında ise : CC
               10-20 arasında ise : DD
               0-10 arasında ise : FF yazacak algoritmayı kurunuz.
            */
            int s1, s2, s3, sonuc = 0;
            Console.Write("1. Değeri giriniz : ");
            s1 = Int32.Parse(Console.ReadLine());

            Console.Write("2. Değeri giriniz : ");
            s2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("3. Değeri giriniz : ");
            s3 = Int32.Parse(Console.ReadLine());

            Console.Write("İşlem operatörünü (+,-,*,/) giriniz : ");
            string operat = Console.ReadLine();

            if (operat == "+")
                sonuc = (s1 + s2 + s3);
            else if (operat == "-")
                sonuc = (s1 - s2 - s3);
            else if (operat == "*")
                sonuc = (s1 * s2 * s3);
            else if (operat == "/")
            {
                if (s2 == 0 || s3 == 0)
                    Console.WriteLine("2. veya 3. sayı 0 'dan farklı olmalıdır.");
                else
                    sonuc = (s1 / s2 / s3);
            }
            else
                Console.WriteLine("Tanımsız operatör");

            if (sonuc > 0 && sonuc <= 10)
                Console.WriteLine("FF");
            else if (sonuc >= 11 && sonuc <= 20)
                Console.WriteLine("DD");
            else if (sonuc >= 21 && sonuc <= 30)
                Console.WriteLine("CC");
            else if (sonuc >= 31 && sonuc <= 40)
                Console.WriteLine("CB");
            else if (sonuc >= 41 && sonuc <= 50)
                Console.WriteLine("BB");
            else if (sonuc >= 51 && sonuc <= 70)
                Console.WriteLine("BA");
            else if (sonuc >= 71 && sonuc <= 100)
                Console.WriteLine("AA");
            else
                Console.WriteLine("Harf notunuz tanımsız");
        }

        public void orn7()
        {
            int s1, s2;
            string sonuc;
            Console.Write("1. Değeri giriniz : ");
            s1 = Int32.Parse(Console.ReadLine());

            Console.Write("2. Değeri giriniz : ");
            s2 = Convert.ToInt32(Console.ReadLine());

            if (s1 > s2)
                Console.WriteLine($"{s1} büyük {s2}");
            else if (s1 == s2)
                Console.WriteLine($"{s1} eşittir {s2}");
            else
                Console.WriteLine($"{s1} küçük {s2}");

            sonuc = (s1 > s2) ? $"{s1} büyük {s2}" : $"{s1} küçük {s2} ";
            Console.WriteLine($"Sonuç : {sonuc}");

            int x = 10, y = 100;

            string result = x > y ? "x büyük y" :
                                x < y ? "x küçük y" :
                                    x == y ? "x eşit y" : "";
            Console.WriteLine(result);

            int? snc = s1 > s2 ? 2 : s1 < s2 ? 1 : s1 == s2 ? 0 : null;
        }

        public void sinifListesi()
        {
            Console.WriteLine("Kamil");
            Console.WriteLine("Ahunaz");
            Console.WriteLine("Zeynep");
            Console.WriteLine("Çizdem");
            Console.WriteLine("Yunus");
            Console.WriteLine("Elif");
            Console.WriteLine("Caner");
            Console.WriteLine("Oğuz");
            Console.WriteLine("Ertan");
            Console.WriteLine("Abdulbaki");
        }

        public void orn8()
        {
            int a = 8, b, c;
            Console.WriteLine($"a ilk deger : {a}");  // 8
            b = ++a;
            c = a--;
            Console.WriteLine($"b deger : {b}");      // 9 9 
            Console.WriteLine($"c deger : {c}");      // 9 7 
            Console.WriteLine($"a son deger : {a}");  // 8 7 

            // 11. sayfa
        }
    }
}
