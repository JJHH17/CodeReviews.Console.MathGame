Console.WriteLine("Welcome to MathGame!");
Console.WriteLine("Enter an operator and answer the given question!");
Console.WriteLine("Get all 3 questions right to win!");

// Score counter, if it reaches 3 they win
int score = 0;
int attempts = 0;

// Generating random numbers
Random random = new Random();
int number1 = random.Next(1, 50);
int number2 = random.Next(1, 50);
int answer;
char operatorInput = '+';

// Selecting the operator based on user input
OperatorSelection();
// Calculating the randomly generated answer
AnswerCalculation(number1, number2);
// Printing the question for user
Console.WriteLine($"Question {attempts + 1}: {number1} {operatorInput} {number2}");
// Taking the number input from the user
int userNumber1 = numberInput();
int userNumber2 = numberInput();

// User selects an operator
void OperatorSelection()
{
    Console.WriteLine("Enter a number to select an operator");
    Console.WriteLine("1. Addition, 2. Subtraction, 3. Division, 4. Multiplication");
    int operatorInt;

    while (true)
    {
        string operatorString = Console.ReadLine();
        if (int.TryParse(operatorString, out operatorInt))
        {
            break;
        }
        else
        {
            Console.WriteLine("Please enter a valid number");
        }
    }

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

int numberInput()
{
    Console.WriteLine("Enter a number");
    int numberInt;

    while (true)
    {
        string number = Console.ReadLine();
        if (int.TryParse(number, out numberInt))
        {
            return numberInt;
        }
        else
        {
            Console.WriteLine("Invalid number, please try again");
        }
    }
}
