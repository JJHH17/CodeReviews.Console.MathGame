Console.WriteLine("Welcome to MathGame!");
Console.WriteLine("Enter an operator and answer the given question!");
Console.WriteLine("Get all 3 questions right to win!");

// Score counter, if it reaches 3 they win
int score = 0;
int attempts = 0;
int games = 0;

// Generating random numbers
Random random = new Random();
int number1;
int number2;
int answer;

// This is where user input will be stored and collected
int number1Int;
int number2Int;

// Main program loop
while (score != 3)
{
    number1 = random.Next(0, 30);
    number2 = random.Next(0, 30);

    // Collecting the operator input and generating the answer
    char operatorSelection = OperatorInput();
    answer = number1 + operatorSelection + number2;
    Console.WriteLine($"Answer: {answer}");

    Console.WriteLine("Enter number 1");
    SetNumber1();

    Console.WriteLine("Enter number 2");
    SetNumer2();

    switch (operatorSelection)
    {
        case '+':
            AdditionResult(number1Int, number2Int);
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
