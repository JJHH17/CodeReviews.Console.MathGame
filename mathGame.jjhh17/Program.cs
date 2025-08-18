// prompt for a operator

// Generate 2 random numbers

// Generate an answer

// prompt user for answer

// Increment score

// Add score to array

// Loop game

// Allow user to print game results

// Hard difficulty, calulates 4 numbers

Console.WriteLine("Welcome to Math Game!");
Console.WriteLine("Enter an operator and we will give you a math question");

Console.WriteLine("1. Addition +, 2. Subtraction -, 3. Division /, 4. Multiplication *");

// Selecting the operator via number input
string operatorInputString;
int operatorInputInt;
while (true)
{
    operatorInputString = Console.ReadLine();
    if (int.TryParse(operatorInputString, out operatorInputInt) && operatorInputInt > 0 && operatorInputInt < 5)
    {
        break;
    }
    else
    {
        Console.WriteLine("Please enter a valid input");
    }
}

// Parsing the input into a operator char
char operatorSelection = '+';

