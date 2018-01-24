using System;

namespace fibonacci
{
    class Program
    {
        static void fibonacci()
        {
            try
            {
                Console.Write(" bạn nhập một số nguyên a = ");
                int a = Convert.ToInt32(Console.ReadLine());
                int prv = 0, pre = 1, num;
                Console.Write("{0} {1}", prv, pre);
                for (int i = 3; i <= a; i++)
                {
                    num = prv + pre;
                    Console.Write(" {0}", num);
                    prv = pre;
                    pre = num;
                }
                Console.WriteLine();
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
                System.Console.WriteLine("Application ends !!!");
            }

        }
        
        static void Main(string[] args)
        {
            fibonacci();
        }
    }
}
