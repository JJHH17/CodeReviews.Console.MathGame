﻿Console.WriteLine("Welcome to MathGame!");
Console.WriteLine("We will present a calculation based on an operator that you enter, answer 3 questions correctly to win!");
Console.WriteLine("Get all 3 questions right to win!");

// Score counter, if it reaches 3 they win
int score = 0;
int attempts = 0;
int games = 0;

// Generating random numbers
Random random = new Random();

// Generating a calculation
int number1 = random.Next(2, 75);
int number2 = random.Next(2, 75);
int answer;
char operatorInput;

// Allowing user to enter an operator

// Presenting target answer to user
Console.WriteLine();


void OperatorSelectionInitial()
{
    Console.WriteLine("Enter an Operator");
    Console.WriteLine("1. + Addition, 2. - Subtraction, 3. / Division, 4. * Multiplication");

    string operatorStringInput;
    int operatorIntInput;

    while (true)
    {
        operatorStringInput = Console.ReadLine();
        if (int.TryParse(operatorStringInput, out operatorIntInput))
        {
            OperatorSelectionFinal(operatorIntInput);
            break;
        }
        else
        {
            Console.WriteLine("Please enter a valid integer");
        }
    }
}

void OperatorSelectionFinal(int input)
{
    switch (input)
    {
        case 1:
            operatorInput = '+';
            break;
        case 2:
            operatorInput = '-';
            break;
        case 3:
            operatorInput = '/';
            break;
        case 4:
            operatorInput = '*';
            break;
        default:
            Console.WriteLine("Invalid input, reverting to default operator (Addition, +)");
            break;
    }
}

// Fetches target answer based on operator
void GetAnswer(int num1, char operatorInput, int num2)
{
    switch (operatorInput)
    {
        case '+':
            answer = num1 + num2;
            Console.WriteLine($"Target Answer: {answer}");
            break;
        case '-':
            answer = num1 - num2;
            Console.WriteLine($"Target Answer: {answer}");
            break;
        case '/':
            answer = num1 / num2;
            Console.WriteLine($"Target Answer: {answer}");
            break;
        case '*':
            answer = num1 * num2;
            Console.WriteLine($"Target Answer: {answer}");
            break;
    }
}
