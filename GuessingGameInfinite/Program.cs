using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;   
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis ta on mängu võitnud ;
            //katsete arv on piiramatu
            //programm genereerib juhuslikku numbrit ühte korda.


            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            bool loopActive = true;
            int i = 0;

            while (loopActive)
            {
                Console.WriteLine("Hello, are you ready to play a game!!");
                Console.WriteLine("Sisesta oma number, mis on vahemikus 1 kuni 10.");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if(userNumber == cpuNumber)
                {
                    Console.WriteLine("Palju õnne mängu võidu puhul!!");
                    loopActive = false;
                }
                else
                {
                    i++;
                    Console.WriteLine("Vale number, proovi uuesti!");
                    Console.WriteLine($"Oled valet numbrit sisestanud {i} korda.");
                }
                

            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
