// day 20
// 20. output fibonacci sequence (base 1) on each keypress

int a = 0, b = 1;
Console.WriteLine("Press any key to display the next Fibonacci number. Press ESC to stop.");

while (true)
{
    var key = Console.ReadKey(true).Key;
    if (key == ConsoleKey.Escape)
        break;

    Console.WriteLine("Current number: " + b);

    int temp = b;
    b = a + b;
    a = temp;
}