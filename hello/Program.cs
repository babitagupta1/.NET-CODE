using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace hello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            task1();
            task2();
            task3();
            task4();
            Console.ReadLine();

        }
        //int babita = 4434333;
        //Console.Write("babita");
        //Console.WriteLine("hello world"+  babita);
        // Console.WriteLine("Enter your name");
        //string babita =Console. ReadLine();
        // Console.WriteLine( "hello "+babita);
        // Console.WriteLine("How many candes do you want ");
        // string cand=Console.ReadLine();
        // Console.WriteLine("you will get "+(Convert.ToInt32(cand)+4) );

        // Console.ReadLine();



        public static async void task1()
        {

            await Task.Run(() =>
            {
                Console.WriteLine("task 1 start");
                Thread.Sleep(4000);
                Console.WriteLine("task 1 is complete");


            });
        

        }
        public static async void task2()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("task 2 start");
                Thread.Sleep(2000);
                Console.WriteLine("task 2 is complete");
            });

        }
        public static async void task3()

        {
    await Task.Run(() =>
    {
        Console.WriteLine("task 3 start");
        Thread.Sleep(2000);
        Console.WriteLine("task 3 is complete");
    });

        }
        public static async void task4()
{
    await Task.Run(() =>
    {
        Console.WriteLine("task 4 start");
        Thread.Sleep(1000);
        Console.WriteLine("task 4 is complete");

    });
        }





    }
}
