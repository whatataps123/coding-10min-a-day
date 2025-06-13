// day 22
// 22. Ask for a number input, throw an error if it's more than 100 or less than zero

Console.WriteLine("Please enter a number:");
string input = Console.ReadLine();

if (Int32.TryParse(input, out var value) && value >= 0 && value <= 100)
{
    Console.WriteLine("The number you entered is within the valid range: " + value);
}
else
{
    Console.WriteLine("Error: The input is not a valid number.");
    Console.WriteLine("Please enter a valid number.");
}

// number test 
// 1. 50 it should print "The number you entered is within the valid range: 50"
// 2. -1 it should print "Error: The input is not a valid number."
// 3. 101 it should print "Error: The input is not a valid number."
// 4. "abc" it should print "Error: The input is not a valid number."