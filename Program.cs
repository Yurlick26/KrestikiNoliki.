using System;

class Program
{
    static string[] c = { "", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

    static void Print()
    {
        Console.Clear();
        Console.WriteLine($"{c[1]} | {c[2]} | {c[3]}");
        Console.WriteLine("--+---+--");
        Console.WriteLine($"{c[4]} | {c[5]} | {c[6]}");
        Console.WriteLine("--+---+--");
        Console.WriteLine($"{c[7]} | {c[8]} | {c[9]}");
        Console.WriteLine();
    }

    static bool Win(string p)
    {
        int[,] w = {
            {1,2,3},{4,5,6},{7,8,9},
            {1,4,7},{2,5,8},{3,6,9},
            {1,5,9},{3,5,7}
        };

        for (int i = 0; i < w.GetLength(0); i++)
            if (c[w[i, 0]] == p && c[w[i, 1]] == p && c[w[i, 2]] == p)
                return true;
        return false;
    }

    static void Main()
    {
        string cur = "X"; 
        while (true)
        {
            Print();
            Console.Write($"Player's turn {cur}. Enter the cell number (1-9): ");
            int pos = int.Parse(Console.ReadLine()); 

            c[pos] = cur; 

            if (Win(cur))
            {
                Print();
                Console.WriteLine($"The player wins {(cur == "X" ? 1 : 2)}!");
                break;
            }

            cur = (cur == "X") ? "O" : "X"; 
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
