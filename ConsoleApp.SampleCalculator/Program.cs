// See https://aka.ms/new-console-template for more information

// Welcome message
Console.WriteLine("Welcome to the Sample Calculator!");

// Prompt for user input
Console.Write("Please enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

// Show calculator options
Console.WriteLine("Select an operation to perform:");
Console.WriteLine("1 - Addition");
Console.WriteLine("2 - Subtraction");
Console.WriteLine("3 - Multiplication");
Console.WriteLine("4 - Division");
Console.Write("Enter your choice (1-4): ");
int choice = Convert.ToInt32(Console.ReadLine());

// Decide which operation is needed based on selected option
// Using If...Else If...Else statement
if (choice == 1)
{
    int sum = num1 + num2;
    Console.WriteLine($"The sum of {num1} and {num2} is: {sum}");
}
else if (choice == 2)
{
    int difference = num1 - num2;
    Console.WriteLine($"The difference between {num1} and {num2} is: {difference}");
}
else if (choice == 3)
{
    int product = num1 * num2;
    Console.WriteLine($"The product of {num1} and {num2} is: {product}");
}
else if (choice == 4)
{
    if (num2 != 0)
    {
        int quotient = num1 / num2;
        Console.WriteLine($"The quotient of {num1} divided by {num2} is: {quotient}");
    }
    else
    {
        Console.WriteLine("Error: Division by zero is not allowed.");
    }
}
else
{
    Console.WriteLine("Invalid choice. Please select a valid operation.");
}

// using Switch statement
switch (choice)
{
    case 1:
        {
            int sum = num1 + num2;
            Console.WriteLine($"[Switch] The sum of {num1} and {num2} is: {sum}");
            break;
        }
    case 2:
        {
            int difference = num1 - num2;
            Console.WriteLine($"[Switch] The difference between {num1} and {num2} is: {difference}");
            break;
        }
    case 3:
        {
            int product = num1 * num2;
            Console.WriteLine($"[Switch] The product of {num1} and {num2} is: {product}");
            break;
        }
    case 4:
        {
            if (num2 != 0)
            {
                int quotient = num1 / num2;
                Console.WriteLine($"[Switch] The quotient of {num1} divided by {num2} is: {quotient}");
            }
            else
            {
                Console.WriteLine("[Switch] Error: Division by zero is not allowed.");
            }
            break;
        }
    default:
        {
            Console.WriteLine("[Switch] Invalid choice. Please select a valid operation.");
            break;
        }
}

