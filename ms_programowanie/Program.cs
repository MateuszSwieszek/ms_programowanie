using System;

namespace ms_programowanie
{
    class Program
    {
        static bool Czy_jest_l_pierwsza(int podano)
        {
            if (podano < 2)
            {
                return true;
            }    
            else
            {
               for (int i = 3; i < podano; i++)
                {
                    if (podano%i != 0)
                    {
                        return false;
                    }
                }
            }
 

            return true;

        }
        

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

            bool test = Czy_jest_l_pierwsza(podano);
            Console.WriteLine(test);
//zadanie użytkownik wpisuje liczbę , a program ma wypoisać 7 liczb pierwszych od 2





        }
    }
}
