﻿using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;   
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis ta on mängu võitnud;
            //kasutajal on kolm katset, kui kasutaja ei ole suutnud kolme katsega numbrit ära arvata
            //siis mängu võidab arvuti.
            //programm genereerib juhuslikku numbrit ühte korda.

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
           
            int i = 0;

            while(i < 3)
            {
                Console.WriteLine("Hello, are you ready to play a game!!");
                Console.WriteLine("Sisesta oma number, mis on vahemikus 1 kuni 10.");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (userNumber == cpuNumber)
                {
                    Console.WriteLine("Palju õnne mängu võidu puhul");
                    break;
                }
                
                
                
                 
                else
                {
                    i++;
                    Console.WriteLine($"Vale number. {3 - i} katset on jäänud");
                }

               

               

            }

            Console.WriteLine("Kena päeva!");

        }
    }
}
