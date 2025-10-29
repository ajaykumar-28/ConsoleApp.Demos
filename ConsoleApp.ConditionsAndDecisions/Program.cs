// See https://aka.ms/new-console-template for more information

// Prompt for input
Console.Write("Please enter student's score: ");
int score = Convert.ToInt32(Console.ReadLine());

// Simple If...Else... statement - Decide to print pass or fail based on score
Console.WriteLine("******** Simple If Results *********");
if (score >= 50)
{
    Console.WriteLine("Student has passed.");
}
else
{
    Console.WriteLine("Student has failed.");
    Console.WriteLine("Please recommend student to student Affiar's office.");
}
Console.WriteLine("******** Simple If Results End *********");


// If...Else If...Else statement - Decide grade based on score
Console.WriteLine("******** If...Else If...Else Results *********");
if(score < 0 || score > 100)
{
    Console.WriteLine("Invalid value entered");
}
else if (score >= 85)
{
    Console.WriteLine("Grade: A");
}
else if (score >= 70)
{
    Console.WriteLine("Grade: B");
}
else if (score >= 50)
{
    Console.WriteLine("Grade: C");
}
else
{
    Console.WriteLine("Grade: F");
}
Console.WriteLine("******** If...Else If...Else Results End *********");


// Ternary operator - Used to assign a value to a varible based on a condition
Console.WriteLine("******** Ternary operator Results *********");

string passStatus = score < 50 ? "Fail" : "Pass";
Console.WriteLine($"Student status is: {passStatus}");

Console.WriteLine("******** Ternary operator Results End *********");


Console.WriteLine("******** Switch statement Results *********");

/*
 * Write a program to accept an integer as the day of the week and print the appropriate message as outlined below.
 1 - Sunday
 2 - Monday
 3 - Tuesday
 4 - Wednesday (Hump Day!)
 5 - Thursday
 6 - Friday (TGIF!!!)
 7 - Saturday (Beach Day!!!)
*/
Console.Write("Please enter the day of the week (1-7): ");
int dayOfWeek = Convert.ToInt32(Console.ReadLine());
switch (dayOfWeek)
{
    case 1:
        Console.WriteLine("Today is Sunday");
        break;
    case 2:
        Console.WriteLine("Today is Monday");
        break;
    case 3:
        Console.WriteLine("Today is Tuesday");
        break;
    case 4:
        Console.WriteLine("Today is Wednesday (Hump Day!)");
        break;
    case 5:
        Console.WriteLine("Today is Thursday");
        break;
    case 6:
        Console.WriteLine("Today is Friday (TGIF!!!)");
        break;
    case 7:
        Console.WriteLine("Today is Saturday (Beach Day!!!)");
        break;
    default:
        Console.WriteLine("Invalid day entered.");
        break;
}

Console.WriteLine("******** Switch statement Results End *********");

// The rest of the Application
Console.WriteLine("Thank you for using the program.");
