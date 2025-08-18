/*

TODO:
- Present the user with 2 integers
- They need to enter the sum of those two ints

*/


Console.WriteLine("Welcome to MathGame!");
Console.WriteLine("Enter an operator and answer the given question!");
Console.WriteLine("Get all 3 questions right to win!");

// Score counter, if it reaches 3 they win
int score = 0;
int attempts = 0;
int games = 0;

// Generating random numbers
Random random = new Random();
int number1 = random.Next(1, 50);
int number2 = random.Next(1, 50);
int answer;
char operatorInput = '+';

// This is where user input will be stored and collected
int number1Int;
int number2Int;

// Main program loop
SelectOperator();
GetAnswer(number1, operatorInput, number2);

// Allows user to select operator
void SelectOperator()
{
    Console.WriteLine("Enter the operator you wish to use.");
    Console.WriteLine("1. + Addition, 2. - Subtraction, 3. / Division, 4. * Multiplication");
    int operatorInt;
    bool active = true;

    while (active)
    {
        string operatorString = Console.ReadLine();

        if (int.TryParse(operatorString, out operatorInt))
        {
            switch (operatorInt)
            {
                case 1:
                    OperatorSelectionFinal(1);
                    active = false;
                    break;
                case 2:
                    OperatorSelectionFinal(2);
                    active = false;
                    break;
                case 3:
                    OperatorSelectionFinal(3);
                    active = false;
                    break;
                case 4:
                    OperatorSelectionFinal(4);
                    active = false;
                    break;
                default:
                    Console.WriteLine("Unsupported value detected, reverting to default value (addition)");
                    active = false;
                    OperatorSelectionFinal(1);
                    break;
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid option");
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
            if (num1 > num2)
            {
                answer = num1 / num2;
            }
            else
            {
                answer = num2 / num1;

            }
            Console.WriteLine($"Target Answer: {answer}");
            break;
        case '*':
            answer = num1 * num2;
            Console.WriteLine($"Target Answer: {answer}");
            break;
    }
}
