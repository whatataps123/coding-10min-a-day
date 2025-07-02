// 24. (formerly day18) print out unique characters and their count on a string
// day 24

Console.WriteLine("Please enter an input:"); // for title

string input = Console.ReadLine(); // input from user
string unique = new String(input.Distinct().ToArray()); // Get unique characters from the input
Console.WriteLine("Your input text: " + input);
Console.WriteLine("Unique characters: " + unique); // Output the unique characters
Console.WriteLine("Character counts:"); // Title for character counts
foreach (char c in unique)
{
    int count = input.Count(x => x == c); // Count occurrences of each unique character
    Console.WriteLine($"'{c}': {count}"); // Output the character and its count
}