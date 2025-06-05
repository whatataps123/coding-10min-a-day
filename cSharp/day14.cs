// alt + z toggle wrap 
//split a name string into a char-array, then capitalize the first letter by overwriting char-array item zero, then reconstruct into a string

string animals = "single";
char[] splitWord = animals.ToCharArray();
Console.WriteLine("Original string: " + animals); // Output: Original string: single
Console.WriteLine("Capitalized first letter: " + splitWord[0].ToString().ToUpper()); // Output: Capitalized first letter: S