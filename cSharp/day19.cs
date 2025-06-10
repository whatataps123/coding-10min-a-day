// day 19
// 19. output a number, and wait for a keypress, then increment the number and print it out, then repeat

int number = 0; // Initialize the number

Console.WriteLine("Press ESC to stop");
do {
    while (Console.ReadKey(true).Key != ConsoleKey.Escape)
    {
        Console.Clear(); // Clear the console for a fresh display
        Console.WriteLine("Current number: " + number); // Display the current number
        number++; // Increment the number
        Console.WriteLine("Press any key to increment the number. Press ESC to stop.");
   }       
} while (Console.KeyAvailable);