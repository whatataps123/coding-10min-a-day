// day 17
// 17. print out unique characters from a string using built-in array-unique function or it's equivalent

string input = "hello world";
char[] inputArray = input.ToCharArray();
char[] uniqueChars = inputArray.Distinct().ToArray(); // Use Distinct to get unique characters

string uniqueString = string.Join('\n', uniqueChars); // Join the unique characters back into a string
Console.WriteLine("Unique characters: " + '\n' + uniqueString); // Output: Unique characters: helo wrd


