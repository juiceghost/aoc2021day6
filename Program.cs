namespace AoC2021day6;
class Program
{
    // https://adventofcode.com/2021/day/6
    static void Main(string[] args)
    {
        Console.WriteLine("AoC 2021 day 6");

        List<int> initialState = new List<int>() { 3, 4, 3, 1, 2 };
        /*
         
        for (int i = 0; i < lanternFish.Count; i++)
        {
            lanternFish[i] = lanternFish[i] - 1;
            Console.WriteLine($"i:{i}, lF[i]:{lanternFish[i]} ");
        }
        Console.ReadLine();
        */
        // Skriv en funktion som tar in en lista av integers som argument
        // funktionen skapar en ny lista där varje element är lika med
        // motsvarande element i inputlistan - 1
        // denna nya lista returnas ifrån funktionen


         static List<int> simulateDay(List<int> lanternFish)
            {
            List<int> newLanternFish = new List<int>() { };

            // varje element i lanternFish ska existera i newLanternfish
            // med den skillnaden att elementet i newLanternFish =
            // lanternfish - 1
            for (int i = 0; i < lanternFish.Count; i++)
            {
                //int newNumber = lanternFish[i] - 1;
                newLanternFish.Add(lanternFish[i] - 1);
                Console.WriteLine($"nLF Count: {newLanternFish.Count}");
                Console.WriteLine($"nLF[i]: {newLanternFish[i]} ");

            }

            return newLanternFish;

            }
        simulateDay(initialState).ForEach(item => Console.WriteLine(item));
    }
}

