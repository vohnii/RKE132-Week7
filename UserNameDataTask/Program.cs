using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime;
            //programm küsib kasutajal sisestada numbrit 1-3 (tee char'iga)
            //kui kasutaja sisestab '1', siis kuvatakse kasutaja eesnimi targurpidi;
            //kui kasutaja valib '2', siis kuvatakse kasutaja eesnime esimene täht;
            //kui kasutaja valib '3', siis kuvatakse kasutaja kasutaja eesnime pikkust;

            Console.WriteLine("Sisesta oma eesnimi:");
            string userName = Console.ReadLine();

            Console.WriteLine("Sisesta number 1 kuni 3.");
            char userNumber = Convert.ToChar(Console.ReadLine());

            //kontroll millist numbrit valis kas 1, 2, 3 
            switch (userNumber)
            {
                case '1':
                    reversedName(userName);
                    break;

                case '2':
                    firstLetterName(userName);
                    break;

                case '3':
                    lengthName(userName);
                    break;

                default:
                    Console.WriteLine("Kasutasid valet numbrit. Kena päeva!");
                    break;

            }

        }

        public static void reversedName(string userInput)
        {
            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                Console.Write(userInput[i]);
            }
        }
        public static void firstLetterName(string userInput)
        {
            Console.WriteLine($"Sinu eesnime esimene täht on {userInput[0]}");
        }

        public static void lengthName(string userInput)
        {
            Console.WriteLine($"Sinu nimi on {userInput.Length} sümbolit pikk.");
        }


    }

}