using System;
namespace MoneyExchange
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 23000;
            Console.Write("Enter how mush USD$ you would like to exchange : ");
            float USD = float.Parse(Console.ReadLine());
            Console.WriteLine("You exchanged "+x+"$ to "+USD * x+ "VND");
        }
    }
}