// day 15
// 15. Print a defined array, then remove the last item using array pop or equivalent

string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
Console.WriteLine("Original array: " + string.Join(", ", cars)); // Output: Volvo, BMW, Ford, Mazda

Stack<string> carsStack = new Stack<string>(cars); // Use Stack to simulate pop
carsStack.Pop(); // Removes the last item (Mazda)

cars = (string[])carsStack.ToArray(); // Convert back to array
Console.WriteLine("Array after pop: " + string.Join(", ", cars)); // Output: Volvo, BMW, Ford
Array.Reverse(cars); // Reverse to maintain original order
Console.WriteLine("Array after pop and reverse: " + string.Join(", ", cars)); // Output: Volvo, BMW, Ford
