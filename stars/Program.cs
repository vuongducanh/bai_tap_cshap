using System;

namespace vesao
{
    class Program
    {
        static void Main(string[] args)
        {
           try
            {
            int n=1;
            while (n!=0)                             
            {    
                 Console.WriteLine("nhap 0 ket thuc vong lap");
                 Console.Write("nhap chieu cao cua hinh tam giac  n  = ");
                  
                 n = Convert.ToInt32(Console.ReadLine()); 
                
               for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            }
            catch (System.FormatException e)
            {
                 System.Console.WriteLine(e.Message);
            }
            catch (System.Exception g)
            {  
                System.Console.WriteLine(g.Message);
            }
            finally
            {
            System.Console.WriteLine("kết thúc ứng dụng  !!!");
            }
            
        }
    }
}
