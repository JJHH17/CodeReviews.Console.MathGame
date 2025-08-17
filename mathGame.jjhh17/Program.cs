/* 

if number 1 and number 2 operate to the answer, increase 1 to the score and keep loop running

if the answer if wrong, end the loop and print their score

*/


PrintIntro();

// Score counter, if it reaches 5 they win
int score = 0;

// Generating random numbers
Random random = new Random();
int number1 = random.Next(0, 30);
int number2 = random.Next(0, 30);

// Loop program for user, 5 times
while (true)
{
    Console.WriteLine("Enter an operator (+ Addition, - Subtraction, * Multiplication, / Division)");
    // TODO: Add error handling here, only allow them to enter a correct operator

    // Generating an answer
    Console.WriteLine("Answer:");
    char operatorSelection = OperatorInput();
    int answer = number1 + operatorSelection + number2;
    Console.WriteLine(answer);

    Console.WriteLine("What is number 1?");
    int number1Input = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("What is number 2?");
    int number2Input = Convert.ToInt32(Console.ReadLine());

    if (number1Input + operatorSelection + number2Input == answer)
    {
        Console.WriteLine("You win!");
        score++;
    }
    else
    {
        Console.WriteLine("You lose!");
        Console.WriteLine($"You scored {score}");
        break;
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

// Determinds if game was won or not
