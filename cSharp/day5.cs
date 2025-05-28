// day 5
//capitalize(uppercase first letter of each word) strings using built in function

// syntax type variableName = value;
// day 5
// capitalize (uppercase first letter of each word) strings using built in function

using System;
using System.Globalization;

 string input = "hello world title";
        
// Get the current culture's TextInfo object
TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;

// Convert to title case
string titleCase = textInfo.ToTitleCase(input);

Console.WriteLine(titleCase); // Output: "This Is A Title Case Example"


string a = "heLLo world pogi";

// capitalize first letter of each word
string[] words = a.Split(' '); // split the string into words
for (int i = 0; i < words.Length; i++)
{
    if (words[i].Length > 0)
    {
        words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
    }
}
string capitalized = string.Join(" ", words); // join the words back into a string
Console.WriteLine(capitalized); // output Hello