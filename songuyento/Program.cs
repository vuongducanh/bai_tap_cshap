using System;

namespace songuyento
{
    class Program
    {
        static void songuyento(int a)
        {
            int bien_dem = 0;
            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                    bien_dem++;
            }
            if (bien_dem == 2)
            {
                Console.WriteLine("So da cho la so nguyen to.");
            }
            else
            {
                Console.WriteLine("So da cho khong phai la so nguyen to.");
            }
        }
        static void Main(string[] args)
        {
            Console.Write("nhap so input = ");
            int input = Convert.ToInt32(Console.ReadLine());
            songuyento(input);
        }
    }
}
