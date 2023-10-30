using System;

using System.Threading;

namespace ThreadingDemo
{

   


    public class Program
    {
        public static void Print()
        {
            int i = 10;
            for( int j = 0; j < i;j++)
            Console.WriteLine(j);
        }
        public static void Greet()
        {
            Console.WriteLine("Good morning.......");

        }



        static void Main(string[] args)
        {
            //ThreadStart del = new ThreadStart(Program.Print);
            ////Thread t = new Thread(del);
            //t.Start();
            //Console.WriteLine($" Managed Print Thread id = {t.ManagedThreadId}" );
            //Console.ReadLine();

            Thread tobj = new Thread(Program.Greet);
            tobj.Start();
            Console.WriteLine($"Managed Greeting Thread id={tobj.ManagedThreadId}");
            Console.ReadLine( );
        }
    }
}
