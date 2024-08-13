// Create an empty list to store coffee names
List<string> coffee = new List<string>();

// Define the number of coffee names to be entered
int numberofCoffee = 5;

// Loop to get coffe names from the user
for (int i = 0;i < numberofCoffee;i++)
{
    Console.Write($"Coffee {i+1}: ");
    coffee.Add(Console.ReadLine());
}

Console.WriteLine("\nThe entered coffee names:");

// Loop to print the entered coffe names
for (int i = 0; i < coffee.Count; i++)
{
    Console.WriteLine(coffee[i]);
}