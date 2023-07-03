internal class Program
{
    private static void Main()
    {
        string hesapmakinasi = "-calcu(int)";
        string yardim = "-help(string)";
        Console.WriteLine("****SANAL ASISTAN***");
        Console.WriteLine("Komutlar: " + hesapmakinasi + " , " + yardim);
        string komut;
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
        komut = Convert.ToString(Console.ReadLine());
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

        if (komut == hesapmakinasi)
        {
            Console.WriteLine("**HESAP MAKINASI**");
            string toplama = "-hm toplama";
            string cikarma = "-hm cikarma";
            string carpma = "-hm carpma";
            string bolme = "-hm bolme";
            string modulus = "-hm modulus";
            Console.WriteLine("İşlemler:" + toplama + " , " + cikarma + " , " + carpma + " , " + bolme + " , " + modulus);
            string komuthm;
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            komuthm = Convert.ToString(Console.ReadLine());
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            if (komuthm == toplama)
            {
                Console.WriteLine("**TOPLAMA**");
                int toplamasayi1;
                int toplamasayi2;
                int toplamatoplam;
                Console.WriteLine();
                Console.Write("1.Sayıyı giriniz: ");
                toplamasayi1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("2.Sayıyı giriniz: ");
                toplamasayi2 = Convert.ToInt32(Console.ReadLine());
                toplamatoplam = toplamasayi1 + toplamasayi2;
                Console.WriteLine("Sonuç: " + toplamatoplam);
                Console.ReadLine();
            }
            if (komuthm == cikarma)
            {
                Console.WriteLine("**CIKARMA**");
                int cikarmasayi1;
                int cikarmasayi2;
                int cikarmatoplam;
                Console.WriteLine();
                Console.WriteLine("1.Sayıyı giriniz: ");
                cikarmasayi1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("2.Sayıyı giriniz: ");
                cikarmasayi2 = Convert.ToInt32(Console.ReadLine());
                cikarmatoplam = cikarmasayi1 - cikarmasayi2;
                Console.WriteLine("Sonuç: " + cikarmatoplam);
                Console.ReadLine();
            }
            if (komuthm == carpma)
            {
                Console.WriteLine("**CARPMA**");
                int cikarmasayi1;
                int cikarmasayi2;
                int cikarmatoplam;
                Console.WriteLine();
                Console.Write("1.Sayıyı giriniz: ");
                cikarmasayi1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("2.Sayıyı giriniz: ");
                cikarmasayi2 = Convert.ToInt32(Console.ReadLine());
                cikarmatoplam = cikarmasayi1 * cikarmasayi2;
                Console.WriteLine("Sonuç: " + cikarmatoplam);
            }
            if (komuthm == bolme)
            {
                Console.WriteLine("**BOLME**");
                int sayi1;
                int sayi2;
                int toplam;
                Console.WriteLine();
                Console.WriteLine("1.Sayıyı giriniz: ");
                sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("2.Sayıyı giriniz: ");
                sayi2 = Convert.ToInt32(Console.ReadLine());
                toplam = sayi1 / sayi2;
                Console.WriteLine("Sonuç: " + toplam);
                Console.Read();
            }
            if (komuthm == modulus)
            {
                Console.WriteLine("**MODULUS**");
                int sayi1;
                int sayi2;
                int toplam;
                Console.WriteLine("1.Sayıyı giriniz: ");
                sayi1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("2.Sayıyı giriniz: ");
                sayi2 = Convert.ToInt32(Console.ReadLine());

                toplam = sayi1 % sayi2;
                Console.WriteLine("Sonuç: " + toplam);
                Console.Read();
            }
            else
            {
                Console.WriteLine("****SANAL ASISTAN***");
                Console.WriteLine("Komutlar: " + hesapmakinasi + " , " + yardim);
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                komut = Convert.ToString(Console.ReadLine());
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                if (komut == hesapmakinasi)
                {
                    Console.WriteLine("**HESAP MAKINASI**");
                    string toplama2 = "-hm toplama";
                    string cikarma2 = "-hm cikarma";
                    string carpma2 = "-hm carpma";
                    string bolme2 = "-hm bolme";
                    string modulus2 = "-hm modulus";
                    Console.WriteLine("İşlemler:" + toplama + " , " + cikarma + " , " + carpma + " , " + bolme + " , " + modulus);
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                    komuthm = Convert.ToString(Console.ReadLine());
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                    if (komuthm == toplama2)
                    {
                        Console.WriteLine("**TOPLAMA**");
                        int toplamasayi1;
                        int toplamasayi2;
                        int toplamatoplam;
                        Console.WriteLine();
                        Console.Write("1.Sayıyı giriniz: ");
                        toplamasayi1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("2.Sayıyı giriniz: ");
                        toplamasayi2 = Convert.ToInt32(Console.ReadLine());
                        toplamatoplam = toplamasayi1 + toplamasayi2;
                        Console.WriteLine("Sonuç: " + toplamatoplam);
                        Console.ReadLine();
                    }
                    if (komuthm == cikarma2)
                    {
                        Console.WriteLine("**CIKARMA**");
                        int cikarmasayi1;
                        int cikarmasayi2;
                        int cikarmatoplam;
                        Console.WriteLine();
                        Console.WriteLine("1.Sayıyı giriniz: ");
                        cikarmasayi1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("2.Sayıyı giriniz: ");
                        cikarmasayi2 = Convert.ToInt32(Console.ReadLine());
                        cikarmatoplam = cikarmasayi1 - cikarmasayi2;
                        Console.WriteLine("Sonuç: " + cikarmatoplam);
                        Console.ReadLine();
                    }
                    if (komuthm == carpma2)
                    {
                        Console.WriteLine("**CARPMA**");
                        int cikarmasayi1;
                        int cikarmasayi2;
                        int cikarmatoplam;
                        Console.WriteLine();
                        Console.Write("1.Sayıyı giriniz: ");
                        cikarmasayi1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("2.Sayıyı giriniz: ");
                        cikarmasayi2 = Convert.ToInt32(Console.ReadLine());
                        cikarmatoplam = cikarmasayi1 * cikarmasayi2;
                        Console.WriteLine("Sonuç: " + cikarmatoplam);
                    }
                    if (komuthm == bolme2)
                    {
                        Console.WriteLine("**BOLME**");
                        int sayi1;
                        int sayi2;
                        int toplam;
                        Console.WriteLine();
                        Console.WriteLine("1.Sayıyı giriniz: ");
                        sayi1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("2.Sayıyı giriniz: ");
                        sayi2 = Convert.ToInt32(Console.ReadLine());
                        toplam = sayi1 / sayi2;
                        Console.WriteLine("Sonuç: " + toplam);
                        Console.Read();
                    }
                    if (komuthm == modulus2)
                    {
                        Console.WriteLine("**MODULUS**");
                        int sayi1;
                        int sayi2;
                        int toplam;
                        Console.WriteLine("1.Sayıyı giriniz: ");
                        sayi1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("2.Sayıyı giriniz: ");
                        sayi2 = Convert.ToInt32(Console.ReadLine());
                        toplam = sayi1 % sayi2;
                        Console.WriteLine("Sonuç: " + toplam);
                        Console.Read();
                    }
                    else
                    {
                        Console.WriteLine("****SANAL ASISTAN***");
                        Console.WriteLine("Komutlar: " + hesapmakinasi + " , " + yardim);
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                        komut = Convert.ToString(Console.ReadLine());
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                    }
                }
                if (komut == yardim)
                {
                    Console.WriteLine("**YARDIM**");
                    Console.WriteLine("Komutlar: " + hesapmakinasi + " , " + yardim);
                }
            }
        }
        if (komut == yardim)
        {
            Console.WriteLine("**YARDIM**");
            Console.WriteLine("Komutlar: " + hesapmakinasi + " , " + yardim);
        }
        else
        {
            Console.WriteLine("Konsol İşlemi Sonlandırıldı.");
        }
        Console.Read();
    }
}