// day 10
//split string using a delimiter

string animals = "cat__dog__+bird";
string[] splitWord = animals.Split("__");

Console.WriteLine("Original string: " + animals); // Output: Original string: cat,dog,bird
Console.WriteLine(splitWord[0]); // Output: cat, dog, birdd
Console.WriteLine(splitWord[1]);
Console.WriteLine(splitWord[2]);