using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of test cases (1-64): ");
        int testCases = int.Parse(Console.ReadLine());

        CalculateRookPossibleMoves(testCases);
        Console.ReadKey();
    }

    static void CalculateRookPossibleMoves(int testCases)
    {
        for (int i = 0; i < testCases; i++)
        {
            Console.Write("Enter the rook's location (e.g., a1, b3, h8): ");
            string rookLocationInput = Console.ReadLine().ToLower(); // Convert to lowercase for case-insensitivity

            // Validate the input format
            if (rookLocationInput.Length != 2 || !Char.IsLetter(rookLocationInput[0]) || !Char.IsDigit(rookLocationInput[1]))
            {
                Console.WriteLine("Invalid input. Please enter a valid location (e.g., a1, b3, h8).");
                i--;
                continue;
            }

            // Convert characters to corresponding indices (e.g., a1 -> (1, 1), b3 -> (2, 3))
            int col = rookLocationInput[0] - 'a' + 1;
            int row = rookLocationInput[1] - '0';

            // Validate row and column values
            if (row < 1 || row > 8 || col < 1 || col > 8)
            {
                Console.WriteLine("Invalid input. Please enter a valid location (e.g., a1, b3, h8).");
                i--;
                continue;
            }


            // Calculate and display possible moves
            for (int c = 1; c <= 8; c++)
            {
                if (c != row)
                {
                    Console.WriteLine($"{(char)('a' + col - 1)}{c}");
                }
                if (c != col)
                {
                    Console.WriteLine($"{(char)('a' + c - 1)}{row}");
                }
            }
        }
    }
}

