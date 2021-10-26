using System;

namespace ms_programowanie
{
    class Program
    {
        static bool Czy_jest_l_pierwsza(int podano)
        {
            if (podano == 2)
            {
                return true;
            }
            if (podano <= 1)
            {
                return false;
            }
            else
            {
               for (int i = 3; i < podano; i++)
                {
                    if (podano%i == 0)
                    {
                        return false;
                    }
                }
            }
 

            return true;

        }

        static void wyypisz_n_liczb_pierwszych(int n)
        {
            int licznik = 0;
            int iterator = 0;
            Console.WriteLine("Oh shit, here we are again");
            while (licznik < n)
            {
                //Console.WriteLine(iterator);
                //Console.WriteLine(Czy_jest_l_pierwsza(iterator));


                if (Czy_jest_l_pierwsza(iterator))
                {
                    Console.WriteLine(iterator);
                    licznik++;
                }
                iterator++;
          
            }
        }
        

        static void Main(string[] args)
        {
            //Random rnd = new Random();
            //int wylosowano = rnd.Next(0, 10);

            //Console.WriteLine(wylosowano);
            //int podano = Convert.ToInt32(Console.ReadLine());
            //if (wylosowano == podano)
            //{
            //    Console.WriteLine("trafiłeś");
            //}
            //else
            //{
            //    Console.WriteLine("Jeszcze raz");
            //}

            //bool test = Czy_jest_l_pierwsza(podano);
            //Console.WriteLine(test);
            //Console.WriteLine(test);

            //zadanie użytkownik wpisuje liczbę , a program ma wypoisać 7 liczb pierwszych od 2

            int liczby_pierwsze = Convert.ToInt32(Console.ReadLine());

            wyypisz_n_liczb_pierwszych(liczby_pierwsze);




        }
    }
}
