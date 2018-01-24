using System;

namespace nhiphan
{
    class Program
    {
        static void Main(string[] args)
        {
            try
      {
        int n, i, j, binno = 0;
        Console.Write("Nhap mot so thap phan bat ky: ");
        n = Convert.ToInt32(Console.ReadLine());
        i = 1;
        for (j = n; j > 0; j = j / 2)
        {
            binno = binno + (n % 2) * i;
            i = i * 10;
            n = n / 2;
        }
        Console.Write(" nhị phan là  {0} ", binno);

      }
      catch (System.DivideByZeroException d)
      {
        System.Console.WriteLine(d.Message);
        
      }
      catch(System.FormatException e)
      {
        System.Console.WriteLine(e.Message);
      }
      catch(System.Exception g)
      {
          System.Console.WriteLine(g.Message);
      }
        }
    }
}
