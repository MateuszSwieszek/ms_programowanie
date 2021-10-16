using System;

namespace ms_programowanie
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int wylosowano = rnd.Next(0, 10);
             
            Console.WriteLine(wylosowano);
            int podano = Convert.ToInt32(Console.ReadLine());
            if (wylosowano == podano)
            {
                Console.WriteLine("trafiłeś");
            }
            else
            {
                Console.WriteLine("Jeszcze raz");
            }
        }
    }
}
