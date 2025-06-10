// day 18
// 18. Ask for a input, print out the unique characters on that input

Console.WriteLine("Please enter an input:"); // for title

string input = Console.ReadLine(); // input from user
string unique = new String(input.Distinct().ToArray()); // Get unique characters from the input
Console.WriteLine("Your input text: " + input);
Console.WriteLine("Unique characters: " + unique); // Output the unique characters
