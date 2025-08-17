
PrintIntro();

// Score counter, if it reaches 5 they win
int score = 0;

// Generating random numbers
Random random = new Random();
int number1 = random.Next(0, 30);
int number2 = random.Next(0, 30);

Console.WriteLine("Enter number 1");
int number1Int;

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

Console.WriteLine("Enter number 2");
int number2Int;

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


// Method used to print instructions to user
void PrintIntro()
{
    Console.WriteLine("Welcome to MathGame!");
    Console.WriteLine("Enter an operator and answer the given question!");
    Console.WriteLine("Get all 3 questions right to win!");
}

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