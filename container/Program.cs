using System;

namespace arrayproject
{
    class Program
    {
        static void arrays()
        {
            int[] numberArr = new int[3];
            numberArr[0] = 2;
            numberArr[1] = 5;
            numberArr[2] = 3;
           
            Console.Write("vi tri cua so thu muoi la  = ");
            System.Console.WriteLine(Array.IndexOf(numberArr, 5));
            string  name = "vuongducanh";
            char[]namearr  = name.ToCharArray();
            foreach (var item in namearr)
            {
                Console.Write(item);
            }
            string[] arr1 = new string[] {"10","2","9","8"};
            int[] arr2 = Array.ConvertAll(arr1, Convert.ToInt32);
            Array.Sort(arr2);
            Console.Write("mang sau khi sap xep la arr1 = ");
            foreach (var item2 in arr2)
            {
                Console.Write(item2+" ");
            }
        }
        static void Main(string[] args)
        {
            arrays();
        }
    }
}
