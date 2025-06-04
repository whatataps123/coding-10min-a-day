// 13. loop through a numeric array printing both the index and the value

string[] numbers = ["one", "two", "three", "four", "five"];
int index = 0;
foreach (string number in numbers)
{
    Console.WriteLine(number + " at index " + index);
    // Increment the index manually
    index++;
}