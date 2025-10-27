// Declare Variables 
string firstName = string.Empty;
string LastName = string.Empty;
int age = 0;
int retirementAge = 65;

// Prompt the user for input
Console.WriteLine("Please enter your first name: ");
firstName = Console.ReadLine();

Console.WriteLine("Please enter your Last name: ");
LastName = Console.ReadLine();

Console.WriteLine("Please enter your age: ");
age = Convert.ToInt32(Console.ReadLine());

// Process the data
int workingYearsLeft = retirementAge - age;

// Output the results to the user
Console.WriteLine($"Full name: {firstName} {LastName}!");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Working years left: {workingYearsLeft}");