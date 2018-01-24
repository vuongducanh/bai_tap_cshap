using System;
namespace songuyento
{
    class TestCsharp
    {
        static void sortarray()
        {
            try
            {
            int[] a = new int[100];
            int n;
            Console.Write("nhap do dai cua mang a= ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap {0} phan tu vao mang", n);
            for (int i = 0; i < n; i++)
            {
                Console.Write("phan tu thu a[{0}] = ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            int j;
            for (int i = 0; i < n; i++)
            {
                for (j = n - 1; j >= i; j--)
                {
                    if ((a[i] % 2 == 1) && (a[j] % 2 == 0))
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " , ");
            }

            }
             catch (System.DivideByZeroException)
            {  
                System.Console.WriteLine("Invalid. Cannot be divided by zero");
            }
            catch (System.FormatException e)
            {  
                System.Console.WriteLine(e.Message);
            }
            catch (System.Exception e)
            {  
                System.Console.WriteLine(e.Message);
            }
            finally{
                System.Console.WriteLine("Application ends !!!");
            }
        }
        public static void Main(string[] args)
        {
            sortarray();
        }
    }
}
