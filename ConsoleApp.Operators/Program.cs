// See https://aka.ms/new-console-template for more information

Console.Write("Please enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());


/*
    Math operations and operators 
*/

// Add numbers
int sum = num1 + num2;
// Subtraction
int difference = num1 - num2;
// Multiplication
int product = num1 * num2;
// Division
int quotient = num1 / num2;
// Modulus
int mod = num1 % num2;

Console.WriteLine("*********** Math Results ***********");
Console.WriteLine();
Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Difference: {difference}");
Console.WriteLine($"Product: {product}");
Console.WriteLine($"Quotient: {quotient}");
Console.WriteLine($"Modulus: {mod}");
Console.WriteLine();
Console.WriteLine("*********** End Math Results ***********");


/*
    Logic operations and operators 
*/

bool isGreaterThan = num1 > num2;
bool isLessThan = num1 < num2;
bool isEqual = num1 == num2;
bool isNotEqual = num1 != num2;
bool isGreaterThanOrEqual = num1 >= num2;
bool isLessThanOrEqual = num1 <= num2;

Console.WriteLine("*********** Logic Results ***********");
Console.WriteLine();
Console.WriteLine($"Is Greater Than: {isGreaterThan}");
Console.WriteLine($"Is Less Than: {isLessThan}");
Console.WriteLine($"Is Equal: {isEqual}");
Console.WriteLine($"Is Not Equal: {isNotEqual}");
Console.WriteLine($"Is Greater Than Or Equal: {isGreaterThanOrEqual}");
Console.WriteLine($"Is Less Than Or Equal: {isLessThanOrEqual}");
Console.WriteLine();
Console.WriteLine("*********** End Logic Results ***********");


/*
    Assignment operations and operators 
*/

Console.WriteLine("Enter random value for Assignment operations: ");
int randomNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("*********** Assignment Results ***********");
Console.WriteLine();
num1 += randomNumber; // num1 = num1 + randomNumber
Console.WriteLine($"Num 1 increased by {randomNumber}: {num1}");
num1 -= randomNumber; // num1 = num1 - randomNumber
Console.WriteLine($"Num 1 decreased by {randomNumber}: {num1}");
num1 *= randomNumber; // num1 = num1 * randomNumber
Console.WriteLine($"Num 1 multiplied by {randomNumber}: {num1}");
num1 /= randomNumber; // num1 = num1 / randomNumber
Console.WriteLine($"Num 1 divided by {randomNumber}: {num1}");
num1 %= randomNumber; // num1 = num1 % randomNumber
Console.WriteLine($"Num 1 mod by {randomNumber}: {num1}");
Console.WriteLine();
Console.WriteLine("*********** End Assignment Results ***********");