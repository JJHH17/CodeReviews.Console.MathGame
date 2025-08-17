Console.WriteLine("Welcome to MathGame!");
Console.WriteLine("Enter an operator and answer the given question!");
Console.WriteLine("Get all 3 questions right to win!");

// Score counter, if it reaches 3 they win
int score = 0;
int attempts = 0;

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

        case '-':
            SubtractionResult(number1Int, number2Int);
            break;

        case '/':
            DivisionResult(number1Int, number2Int);
            break;

        case '*':
            MultiplicationResult(number1Int, number2Int);
            break;
    }
}

Console.WriteLine("You reached a score of 3 points, well done!");
Console.WriteLine($"You had {attempts} attempts");

// Allowing user to select an operator
char OperatorInput()
{
    Console.WriteLine("Select an operator");
    Console.WriteLine("1. + Addition, 2. - Subtraction, 3. * Multiplication, 4. / Division");
    int operatorSelection = Convert.ToInt32(Console.ReadLine());
    char output = '+';

    switch (operatorSelection)
    {
        case 1:
            output = '+';
            break;
        case 2:
            output = '-';
            break;
        case 3:
            output = '*';
            break;
        case 4:
            output = '/';
            break;
        default:
            Console.WriteLine("Invalid input, please try again");
            break;
    }
    return output;
}

// Addition method
void AdditionResult(int num1, int num2)
{
    if (num1 + num2 == answer)
    {
        Console.WriteLine("Correct!");
        score++;
        attempts++;
    }
    else
    {
        Console.WriteLine("Incorrect!");
        attempts++;
    }
}

// Subtractionn method
void SubtractionResult(int num1, int num2)
{
    if (num1 - num2 == answer)
    {
        Console.WriteLine("Correct!");
        score++;
        attempts++;
    }
    else
    {
        Console.WriteLine("Incorrect!");
        attempts++;
    }
}

// Division method (handles zero division)
void DivisionResult(int num1, int num2)
{
    if (num1 <= 0 || num2 <= 0)
    {
        Console.WriteLine("You cannot divide by zero or less");
    }
    else if (num1 / num2 == answer)
    {
        Console.WriteLine("You Win!");
        score++;
        attempts++;
    }
    else
    {
        Console.WriteLine("You Lose");
        attempts++;
    }
}

// Multiplication method
void MultiplicationResult(int num1, int num2)
{
    if (num1 * num2 == answer)
    {
        Console.WriteLine("You Win!");
        score++;
        attempts++;
    }
    else
    {
        Console.WriteLine("You Lose");
        attempts++;
    }
}

void SetNumber1()
{
    while (true)
    {
        string number1Input = Console.ReadLine();
        if (int.TryParse(number1Input, out number1Int))
        {
            break;
        }
        else
        {
            Console.WriteLine("Please enter a valid number");
        }
    }
}

void SetNumer2() {
    while (true)
    {
        string number2Input = Console.ReadLine();
        if (int.TryParse(number2Input, out number2Int))
        {
            break;
        }
        else
        {
            Console.WriteLine("Please enter a valid number");
        }
    }
}