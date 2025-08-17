Console.WriteLine("Welcome to MathGame!");
Console.WriteLine("Enter an operator and answer the given question!");
Console.WriteLine("Get all 3 questions right to win!");

// Score counter, if it reaches 3 they win
int score = 0;
int attempts = 0;

// Generating random numbers
Random random = new Random();
int number1 = random.Next(1, 50);
int number2= random.Next(1, 50);
int answer;
char operatorInput = '+';

OperatorSelection();
AnswerCalculation(number1, number2);

// User selects an operator
void OperatorSelection()
{
    Console.WriteLine("Enter a number to select an operator");
    Console.WriteLine("1. Addition, 2. Subtraction, 3. Division, 4. Multiplication");
    string operatorString = Console.ReadLine();
    int operatorInt;

    int.TryParse(operatorString, out operatorInt);

    switch (operatorInt)
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
            Console.WriteLine("Invalid input detected, reverting to default operator (addition)");
            break;
    }
}

void AnswerCalculation(int num1, int num2)
{
    switch (operatorInput)
    {
        case '+':
            answer = num1 + num2;
            break;
        case '-':
            answer = num1 - num2;
            break;
        case '/':
            answer = num1 / num2;
            break;
        case '*':
            answer = num1 * num2;
            break;
    }
}