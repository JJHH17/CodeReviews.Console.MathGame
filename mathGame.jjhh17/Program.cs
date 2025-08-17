/*
Step 1: Welcome the user
Step 2: Provide instructions 
Step 3: Generate a random number and use the operator to find a given answer
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
    int answer = number1 + OperatorInput() + number2;
    Console.WriteLine(answer);

    Console.WriteLine("What is number 1?");
    int number1Input = Console.Read();
    Console.WriteLine("What is number 2?");
    int number2Input = Console.Read();

}

// Take operator from user



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
    int operatorSelection = Console.Read();
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