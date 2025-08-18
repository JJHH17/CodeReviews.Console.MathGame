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

// Generate 2 random numbers that we will do our calculation with
Random random = new Random();
int number1 = random.Next(1, 50);
int number2 = random.Next(1, 50);
int answer;

// Generate an answer, based on the operator input
switch (operatorInputInt)
{
    case 1:
        answer = number1 + number2;
        Console.WriteLine($"What is {number1} + {number2}?");
        break;
    case 2:
        answer = number1 - number2;
        Console.WriteLine($"What is {number1} - {number2}?");
        break;
    case 3:
        answer = number1 / number2;
        Console.WriteLine($"What is {number1} / {number2}?");
        break;
    case 4:
        answer = number1 * number2;
        Console.WriteLine($"What is {number1} * {number2}?");
        break;
}

// Printing the result
