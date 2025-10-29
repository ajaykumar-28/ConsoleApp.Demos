// Declare Variables 
string? firstName = string.Empty;
string LastName = string.Empty;
int age;
int retirementAge = 65;
decimal salary;
char gender = char.MinValue;
bool working = true;

// Prompt the user for input
Console.Write("Please enter your first name: ");
firstName = Console.ReadLine();

Console.Write("Please enter your Last name: ");
LastName = Console.ReadLine();

Console.Write("Please enter your age: ");
age = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter your salary: ");
salary = Convert.ToDecimal(Console.ReadLine());

Console.Write("Please enter your gender (M/F): ");
gender = Convert.ToChar(Console.ReadLine());

Console.Write("Are you Working? (true/False): ");
working = Convert.ToBoolean(Console.ReadLine());

// Process the data
int workingYearsLeft = retirementAge - age;

// Output the results to the user
Console.WriteLine($"Full name: {firstName} {LastName}!");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Your Salary: {salary}");
Console.WriteLine($"Your Gender: {gender}");
Console.WriteLine($"You are Employed: {working}");
Console.WriteLine($"No of working years left: {workingYearsLeft}");