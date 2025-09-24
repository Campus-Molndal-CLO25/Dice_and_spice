using Figgle;
using Figgle.Fonts;
using System;

class Dice
{
    private static Random random = new Random();

    public int Roll()
    {
        // Random.Next(start, end) ger ett heltal >= start och < end.
        // Vi vill ha 1..6, därför använder vi Next(1, 7).
        // Metoden returnerar ett heltal som representerar resultatet av en tärningskast.
        // Random tar alltid emot ett startvärde och ett slutvärde. Man kan nöja sig med att bara skicka in ett värde också, då ser den det som att startvärdet är 0 och slutvärdet är det man skickat in.
        return random.Next(1, 7);
    }
}

class Program
{
    static void Main()
    {
        Dice dice = new Dice();
        int sum = 0;
        int EnemySum = 0;

        for (int i = 1; i <= 3; i++)
        {
            // Anropa Roll() för att slå tärningen och få ett värde mellan 1 och 6.
            int Player1result = dice.Roll();

            // Skriv ut resultatet för den här tärningen.
            Console.WriteLine($"Tärning {i}: {Player1result}");

            // Lägg till resultatet till summan.
            sum += Player1result;

        }

        Console.WriteLine($"Summan av tre tärningar är: {sum}");

        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Mottståndarens tur");
        Thread.Sleep(3000); // Pausa i 1 sekund för att simulera motståndarens tur

        for (int i = 1; i <= 3; i++)
        {
            // Anropa Roll() för att slå tärningen och få ett värde mellan 1 och 6.
            int Enemyresult = dice.Roll();
            // Skriv ut resultatet för den här tärningen.
            Console.WriteLine($"Tärning {i}: {Enemyresult}");
            // Lägg till resultatet till summan.
            EnemySum += Enemyresult;

        }
        Console.WriteLine($"Summan av tre tärningar är: {EnemySum}");


        Thread.Sleep(2000); // Pausa i 1 sekund innan resultatet visas

        if (sum > EnemySum)
        {
            string asciiArt = FiggleFonts.Standard.Render("Hello, World!");
            Console.WriteLine(asciiArt);




        }
        else if (sum < EnemySum)
        {
            Console.WriteLine("Du förlorade!");
        }
        else
        {
            Console.WriteLine("Oavgjort!");
        }



    }
}