// day 23
// 23. Ask for a string input for numbers 1 to 10 in words (e.g. one, two...) then output it's translation in tagalog

Console.WriteLine("Please enter a number in words from 1 to 10 to translate:");
string input = Console.ReadLine();

Dictionary<string, string> translations
    = new Dictionary<string, string>
{
    { "one", "isa" },
    { "two", "dalawa" },
    { "three", "tatlo" },
    { "four", "apat" },
    { "five", "lima" },
    { "six", "anim" },
    { "seven", "pito" },
    { "eight", "walo" },
    { "nine", "siyam" },
    { "ten", "sampu" }
};

if (translations.TryGetValue(input.ToLower(), out var translation))
{
    Console.WriteLine($"The translation of '{input}' in Tagalog is: {translation}");
}
else
{
    Console.WriteLine("Error: The input is not a valid number in words from 1 to 10.");
}