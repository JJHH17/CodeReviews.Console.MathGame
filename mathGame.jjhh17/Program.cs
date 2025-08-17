/*

TODO - FIX ARRAY, MAKE SURE IT STORES CORRECT QUANTITY
Refactor game

*/


Console.WriteLine("Welcome to MathGame!");
Console.WriteLine("Enter an operator and answer the given question!");
Console.WriteLine("Get all 3 questions right to win!");

// Score counter, if it reaches 3 they win
int score = 0;
int attempts = 0;
int games = 0;

int number1;
int number2;
int answer;
char operatorInput;
int[] previousAttempts = new int[games + 1];

bool active = true;

// Main menu
while (active)
{
    Console.WriteLine("\nEnter an option");
    Console.WriteLine("'New' starts a new game, 'Print' prints previous game attempts, 'Quit' exits the application");
    string selection = Console.ReadLine().Trim().ToLower();

    switch (selection)
    {
        case "new":
            MainGameLoop();
            break;

        case "print":
            ViewPreviousGames();
            break;

        case "quit":
            active = false;
            break;

        default:
            Console.WriteLine("Please enter a valid input");
            break;
    }
}

// Main game loop
void MainGameLoop()
{
    int score = 0;

    while (score < 3)
    {
        // Generating random numbers
        Random random = new Random();
        number1 = random.Next(1, 50);
        number2 = random.Next(1, 50);
        answer = 0;
        operatorInput = '+';

        // Selecting the operator based on user input
        OperatorSelection();
        // Calculating the randomly generated answer
        AnswerCalculation(number1, number2);
        // Printing the question for user
        Console.WriteLine($"Question {attempts + 1}: Get the answer {answer}");
        // Taking the number input from the user
        int userNumber1 = NumberInput();
        int userNumber2 = NumberInput();
        // Checking whether the answer is correct or not, then tweaking score values
        CheckAnswer(userNumber1, operatorInput, userNumber2);

        // Add the number of attempts to an array
        previousAttempts[games] = attempts;
        Array.Resize(ref previousAttempts, 1);

    }
    // Print user score once game ends
    Console.WriteLine("Congratulations!");
    Console.WriteLine($"You tried {attempts} times");
    
    // Resetting score variable
    score = 0;
}

// User selects an operator
void OperatorSelection()
{
    Console.WriteLine("Enter a number to select an operator");
    Console.WriteLine("1. Addition, 2. Subtraction, 3. Division, 4. Multiplication");
    int operatorInt;

    // Ensuring user enters a valid integer value
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

    // Checking the operator input
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

// Calculating the generated answer based on the operator entered by the user
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

// Allowing the user to enter numbers for their answer
int NumberInput()
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

// Checking whether the inputted answer matches the targer number, increments score and attempt values
void CheckAnswer(int num1, char operatorSelection, int num2)
{
    switch (operatorSelection)
    {
        case '+':
            if (num1 + num2 == answer)
            {
                CorrectAnswerOutput();
            }
            else
            {
                IncorrectAnswerOutput();
            }
            break;

        case '-':
            if ((num1 - num2) == answer)
            {
                CorrectAnswerOutput();
            }
            else
            {
                IncorrectAnswerOutput();
            }
            break;

        case '/':
            if ((num1 / num2) == answer)
            {
                CorrectAnswerOutput();
            }
            else
            {
                IncorrectAnswerOutput();
            }
            break;

        case '*':
            if ((num1 * num2) == answer)
            {
                CorrectAnswerOutput();
            }
            else
            {
                IncorrectAnswerOutput();
            }
            break;
    }
}

void CorrectAnswerOutput()
{
    Console.WriteLine("Correct Answer");
    score++;
    attempts++;
}

void IncorrectAnswerOutput()
{
    Console.WriteLine("Incorrect Answer");
    attempts++;
}

// Allows user to view stats on previous games
void ViewPreviousGames()
{
    Console.WriteLine("Previous Attempt stats:");
    for (int i = 0; i < previousAttempts.Length; i++)
    {
        Console.WriteLine($"\nGame {i + 1}: {previousAttempts[i]} attempts");
    }
}