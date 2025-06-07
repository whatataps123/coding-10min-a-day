// day 16
// 16. print array, and then push a new item using array push or equivalent

string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
Console.WriteLine("Original array: " + string.Join(", ", cars)); // Output: Volvo, BMW, Ford, Mazda

Stack<string> carsStack = new Stack<string>(cars); // Use Stack to simulate pop
carsStack.Pop(); // Removes the last item (Mazda)

cars = (string[])carsStack.ToArray(); // Convert back to array
Console.WriteLine("Array after pop: " + string.Join(", ", cars)); // Output: Volvo, BMW, Ford

Array.Reverse(cars); // Reverse to maintain original order
Console.WriteLine("Array after pop and reverse: " + string.Join(", ", cars)); // Output: Volvo, BMW, Ford

carsStack.Push("Toyota"); // Push a new item (Toyota)
cars = (string[])carsStack.ToArray(); 
Array.Reverse(cars); // Reverse again to maintain order after push
Console.WriteLine("Array after push: " + string.Join(", ", cars)); // Output: Volvo, BMW, Ford, Toyota