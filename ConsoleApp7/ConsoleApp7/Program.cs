// See https://aka.ms/new-console-template for more information
using System;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task1
            /*int n = 2442;
            int a = (n - (n % 1000)) / 1000;//2
            int b = ((n % 1000) - (n % 100)) / 100;//4
            int c = ((n % 100) - (n % 10)) / 10;//4
            int d = n % 10;//2
            int result = a + (b * 10) + (c * 100) + (d * 1000);
            if (result == n && n > 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            } */


            //task3
            /*int n = 1789;
            if(n>0){
              Console.WriteLine(n%10);
            }else{
              Console.WriteLine("is not natural number");
            }*/


            //task4
            /*int num = 4582;
            int a = (num - (num % 1000)) / 1000;//4
            int b = ((num % 1000) - (num % 100)) / 100;//5
            int c = ((num % 100) - (num % 10)) / 10;//8
            int d = num % 10;//2
            int result = (d * 1000) + (c * 100) + (b * 10) + a;
           if(num>0){
             Console.WriteLine(result);
           }else{
             Console.WriteLine("is not natural number");
           } */


            //task5
            /* int num = 364 ;
             int a = (num - (num % 100)) / 100;//3
             int b = ((num % 100) - (num % 10)) / 10;//6
             int c = (num % 10);//4
             int result = a+b+c;
             Console.WriteLine(result);*/


            //task7
            /*int num1 = 100;
            int num2 = 20;
            string opr=null;
            switch (opr) {
    case "addition":
        Console.WriteLine(num1 + num2);
                break;
    case "subtraction":
        Console.WriteLine(num1 - num2);
                break;
    case "multiplication":
        Console.WriteLine(num1 * num2);
                break;
    case "division":
        Console.WriteLine(num1 / num2);
                break;
     default:
        Console.WriteLine("invalid input");
                    break; */
        }
    }
}

