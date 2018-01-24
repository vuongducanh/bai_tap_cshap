using System;

namespace ucln_bcnn
{
    class Program
    {
        static int USCLN(int a, int b)
        {
            for (int i = b; i >= 1; i--)
            {
                if (a % i == 0 && b % i == 0)
                {
                    return i;
                }
            }
            return a;
        }
        static int BCNN(int a, int b)
        {
            return (a * b) / USCLN(a, b);

        }
        static void Main(string[] args)
        {
            try
            {
                int a, b;
                Console.Write("Nhap so nguyen thu nhat:");
                a = int.Parse(Console.ReadLine());
                Console.Write("NHap so nguyen thu hai:");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("UCLN cua hai so:{0}", USCLN(a, b));
                Console.WriteLine("BCNN cua hai so:{0}", BCNN(a, b));
            }
            catch (System.FormatException e)
            {
                System.Console.WriteLine(e.Message);
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
            finally
            {
                System.Console.WriteLine("the end !!!");
            }
        }
    }
}
