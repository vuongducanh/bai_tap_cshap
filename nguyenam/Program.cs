using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
    string str;
    int i,len,nguyenam=0;
    Console.Write("nhap chuoi str = ");
    str = Console.ReadLine();
    len = str.Length;
    for(i = 0;i<len;i++){
    if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || 
        str[i] == 'u' || str[i] == 'A' || str[i] == 'E' || str[i] == 'I' || 
        str[i] == '0' || str[i] == 'U')
        {
            nguyenam++;
        }
    }
       Console.WriteLine("so nguyen am {0}",nguyenam);
        }
    }
}
