// day 21 cs
// 21. Ask for a number input, print an error when it's not a number using if else

Console.WriteLine("Please enter a number:");
string input = Console.ReadLine();

if (Int32.TryParse(input, out var value))
{
    Console.WriteLine("You entered a valid number: " + value);
}
else
{
    Console.WriteLine("Error: The input is not a valid number.");
    Console.WriteLine("Please enter a valid number.");
}