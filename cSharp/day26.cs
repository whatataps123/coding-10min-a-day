// 26. Create functions: subtract(x,y), divide(x,y), multiple(x,y)
// day 26
static void subtract(int x, int y)
{
    int diff = x - y;
    Console.WriteLine($"The difference of {x}-{y} is {diff}");
}
static void divide(int x, int y)
{
    int quotient = x / y;
    Console.WriteLine($"The quotient of {x}/{y} is {quotient}");
}

static void multiply(int x, int y)
{
    int product = x * y;
    Console.WriteLine($"The product of {x}*{y} is {product}");
}

subtract(10, 5);
divide(10, 5);
multiply(10, 5);
