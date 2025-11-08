using System;

class Program
{
    static void Main()
    {
        // --- AI Assistant used: ChatGPT (OpenAI GPT-5) ---
        // Questions asked:
        // 1. How to structure the program with methods in C# for a chessboard.
        // 2. How to validate user input and render Unicode squares.
        // 3. How to comment and organize Git workflow for the assignment.
        //
        // Adjustments made:
        // - Simplified loop logic for readability.
        // - Kept Swedish text for user messages as required.
        // ----------------------------------------------------

        Console.OutputEncoding = System.Text.Encoding.Unicode; // Enables Unicode output for black/white squares

        int size = ReadSize(); // Get size from user
        RenderBoard(size);     // Draw the board
    }

    // Reads and validates the board size from user input
    static int ReadSize()
    {
        int n;
        while (true)
        {
            Console.Write("Ange storlek (3–50): "); // Ask user for number
            string input = Console.ReadLine();

            // TryParse for safe conversion
            if (int.TryParse(input, out n) && n >= 3 && n <= 50)
                return n;
            else
                Console.WriteLine("Ogiltig siffra, försök igen."); // Invalid number message
        }
    }

    // Draws the N×N chessboard pattern
    static void RenderBoard(int n)
    {
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                // Alternating pattern: white if even, black if odd
                Console.Write(((row + col) % 2 == 0) ? "◻︎" : "◼︎");
            }
            Console.WriteLine();
        }
    }
}
