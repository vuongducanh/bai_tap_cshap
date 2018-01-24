using System;

namespace project2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for(int i = 1;i<=100;i++){
                if(i%3==0){
                  Console.WriteLine("Fizz");
                }
                else if(i%5==0){
                    Console.WriteLine("Buzz");
                }
                else if(i%5==0 && i%3==0){
                    Console.WriteLine("FizzBuzz");
                }
                else{
                    Console.WriteLine(i);
                }
            } 
        }
    }
   
}

