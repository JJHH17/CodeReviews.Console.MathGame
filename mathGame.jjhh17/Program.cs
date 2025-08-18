// Allow the user to print their scores


Console.WriteLine("Welcome to Math Game!");
Console.WriteLine("Enter an operator and we will give you a math question");

// Implementing score variable
int score = 0;
int games = 1;
// Array to contain scores
int[] scoreArray = new int[games];
bool menuLoop = true;

// Main menu
while (menuLoop)
{
    Console.WriteLine("Select an option");
    Console.WriteLine("'New' to play new game, 'Print' to print scores, 'Quit' to exit");
    string userChoice = Console.ReadLine();
    // Resets score for a new game
    score = 0;

    switch (userChoice)
    {
        case "new":
            GameLoop();
            break;
        case "print":
            Console.WriteLine("Coming soon!");
            break;
        case "quit":
            menuLoop = false;
            break;
        default:
            Console.WriteLine("Please enter a valid input");
            break;
    }
}

// Adds score to array
scoreArray[games - 1] = score;
// Increments quantity of games
games++;
// Resizes array
Array.Resize(ref scoreArray, games + 1);

// Main game loop
void GameLoop()
{
    while (score != 3)
    {
        // Selecting the operator via number input
        string operatorInputString;
        int operatorInputInt;
        while (true)
        {
            Console.WriteLine("1. Addition +, 2. Subtraction -, 3. Division /, 4. Multiplication *");
            operatorInputString = Console.ReadLine();
            if (int.TryParse(operatorInputString, out operatorInputInt) && operatorInputInt > 0 && operatorInputInt < 5)
            {
                break;
            }
            else
            {
                Console.WriteLine("Please enter a valid input");
            }
        }

        // Generate 2 random numbers that we will do our calculation with
        Random random = new Random();
        int number1 = random.Next(1, 50);
        int number2 = random.Next(1, 50);
        int answer;

        // Generate an answer, based on the operator input
        switch (operatorInputInt)
        {
            case 1:
                answer = number1 + number2;
                Console.WriteLine($"What is {number1} + {number2}?");
                break;
            case 2:
                answer = number1 - number2;
                Console.WriteLine($"What is {number1} - {number2}?");
                break;
            case 3:
                answer = number1 / number2;
                Console.WriteLine($"What is {number1} / {number2}?");
                break;
            case 4:
                answer = number1 * number2;
                Console.WriteLine($"What is {number1} * {number2}?");
                break;
        }

        // Prompting the user for an answer
        int userAnswer;
        while (true)
        {
            string userAnswerString = Console.ReadLine();
            if (int.TryParse(userAnswerString, out userAnswer))
            {
                break;
            }
            else
            {
                Console.WriteLine("Please enter a valid numeric answer");
            }
        }

        // Checking if answer is correct
        if (operatorInputInt == 1 && number1 + number2 == userAnswer)
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else if (operatorInputInt == 2 && number1 - number2 == userAnswer)
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else if (operatorInputInt == 3 && number1 / number2 == userAnswer)
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else if (operatorInputInt == 4 && number1 * number2 == userAnswer)
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect");
        }
    }
}