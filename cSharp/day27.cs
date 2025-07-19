// 27. Create a function that will subtract y from x, but only until zero


static void subtract(int x, int y)
{
    while (x > 0)
    {
        x -= y;
        Console.WriteLine($"The current value of x: {x}");
    }

    Console.WriteLine("Finished the last value of x is: "+ x);
}

subtract(10, 5);