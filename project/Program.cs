// Prompting the user to input the marks for the assessments
Console.Write("Enter the marks the student received for Test 1 out of a hundred: ");
double test1Marks = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the marks the student received for Test 2 out of a hundred: ");
double test2Marks = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the marks the student received for Assignment 1 out of a hundred: ");
double assignment1Marks = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the marks the student received for the Project out of a hundred: ");
double projectMarks = Convert.ToDouble(Console.ReadLine());

// Applying weights to the assessments
const double test1Weight = 30.0;
const double test2Weight = 50.0;
const double assignment1Weight = 10.0;
const double projectWeight = 10.0;

// Calculating the weighted average
double weightedAverage = ((test1Marks/100) * test1Weight) +
                         ((test2Marks/100) * test2Weight) +
                         ((assignment1Marks/100) * assignment1Weight) +
                         ((projectMarks/100) * projectWeight);

// Checking if the student qualifies for the exam
const double passMark = 50.0;
Console.WriteLine($" The total average is:{weightedAverage}");

// Outputting the qualification status
if (weightedAverage >= passMark)
{
    Console.WriteLine("Well done! You qualify to write the exam.");
}
else
{
    Console.WriteLine("Sorry, you don't qualify to write the exam.");
}
Console.ReadKey();
