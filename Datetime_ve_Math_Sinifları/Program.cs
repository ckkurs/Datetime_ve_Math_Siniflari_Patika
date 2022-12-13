using System;

namespace Datetime_ve_Math_Sinifları
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);//günün tarihini getiriyor.
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            //haftanın gününü string halde getirme
            Console.WriteLine(DateTime.Now.DayOfWeek);
            //yılın kaçıncı günündeyiz.
            Console.WriteLine(DateTime.Now.DayOfYear);
            //Gün ay ve yıl günle ayı string formatında getiriyor.
            Console.WriteLine(DateTime.Now.ToLongDateString());
            //Gün ay ve yıl sayı olarak
            Console.WriteLine(DateTime.Now.ToShortDateString());
            //saat dakika saniye sayı olarak 
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            //saat ve dakika sayı olarak
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(2));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(10));
            Console.WriteLine(DateTime.Now.AddMilliseconds(50));

            //Datetime Format
             Console.WriteLine(DateTime.Now.ToString("dd"));//gün int
             Console.WriteLine(DateTime.Now.ToString("ddd"));//3 karakter olarak gün
             Console.WriteLine(DateTime.Now.ToString("dddd"));//string olarak gün

             Console.WriteLine(DateTime.Now.ToString("MM"));//ay int
             Console.WriteLine(DateTime.Now.ToString("MMM"));//3 karakter olarak ay
             Console.WriteLine(DateTime.Now.ToString("MMMM"));//string olarak ay

             Console.WriteLine(DateTime.Now.ToString("yy"));//2022 -> 22
             Console.WriteLine(DateTime.Now.ToString("yyyy"));//yıl int

             
             Console.WriteLine("***Math Kütüpahnesi***");
             //Mat Kütüphanesi

             Console.WriteLine(Math.Abs(-25));//mutlak
             Console.WriteLine(Math.Sin(10));//Sinüs karşılığı
             Console.WriteLine(Math.Cos(-25));//Cosinüs Karşılığı
             Console.WriteLine(Math.Tan(-25));//Tanjant Karşılığı
             
             //double ve float gibi küsüratlı değişkenlerde karar vermemizi sağlamak için
             Console.WriteLine(Math.Ceiling(22.3));//22.3ten büyük en küçük tam sayı
             Console.WriteLine(Math.Round(22.3));//22 getirir 
             Console.WriteLine(Math.Round(22.7));//23 
             Console.WriteLine(Math.Floor(22.7));//22.7den küçük en büyük tam sayı 22

             Console.WriteLine(Math.Min(2,6));
             Console.WriteLine(Math.Max(2,6));

             Console.WriteLine(Math.Pow(3,4));//üs
             Console.WriteLine(Math.Sqrt(9));//karekök

             Console.WriteLine(Math.Log(9));//9'un e tabanında logaritmik karşılığı
             Console.WriteLine(Math.Exp(3));//e üzeri 3 ü verir.
             Console.WriteLine(Math.Log10(10));//10 sayısının logaritma 10 tabanındaki karşılığı




             



            

        }
    }
}
