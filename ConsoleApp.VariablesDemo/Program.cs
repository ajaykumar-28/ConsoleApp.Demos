// See https://aka.ms/new-console-template for more information

// Different datatypes
/*
    text - string
    integers - int
    decimal - double, float, decimal
    logical - bool
*/

string name = "Ajay";

Console.WriteLine(name);
Console.WriteLine("I am " + name); // String concatenation
Console.WriteLine($"They call me {name}"); // String Interpolation
Console.WriteLine("I was given the name {0}", name); //Formatted string

int age = 25;
int retirementAge = 65;
int yearsLeft = retirementAge - age;

Console.WriteLine("Years left to retire is: " + yearsLeft);
Console.WriteLine("My retirement age is: " + retirementAge);

bool isRetired = false;
Console.WriteLine("Am I retired? " + isRetired);