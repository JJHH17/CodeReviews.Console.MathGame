Console.WriteLine("\nWelcome to Math Game!");
Console.WriteLine("Enter an operator and we will give you a math question");
Console.WriteLine("Score up to 3 points to win!\n");

int score = 0;
int games = 0;
int attempts = 0;

int[] scoreArray = new int[0];
bool menuLoop = true;

while (menuLoop)
{
    Console.WriteLine("Select an option");
    Console.WriteLine("'New' to play new game, 'Print' to print scores, 'Quit' to exit\n");
    string userChoice = Console.ReadLine();
    // Resets score for a new game
    score = 0;

    switch (userChoice)
    {
        case "new":
            GameLoop();
            games++;
            break;
        case "print":
            PrintScores();
            break;
        case "quit":
            menuLoop = false;
            break;
        default:
            Console.WriteLine("Please enter a valid input");
            break;
    }
}

void GameLoop()
{
    while (score != 3)
    {
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

        // Random number generation
        Random random = new Random();
        int number1 = random.Next(1, 50);
        int number2 = random.Next(1, 50);
        int answer;

        switch (operatorInputInt)
        {
            case 1:
                answer = number1 + number2;
                Console.WriteLine($"\nWhat is {number1} + {number2}?");
                break;
            case 2:
                answer = number1 - number2;
                Console.WriteLine($"\nWhat is {number1} - {number2}?");
                break;
            case 3:
                int divisor, quotient, dividend;
                do
                {
                    divisor = random.Next(1, 11);
                    quotient = random.Next(1, 11);
                    dividend = divisor * quotient;
                } while (dividend > 100);

                number1 = dividend;
                number2 = divisor;
                answer = quotient;

                Console.WriteLine($"\nWhat is {number1} / {number2}?");
                break;
            case 4:
                answer = number1 * number2;
                Console.WriteLine($"\nWhat is {number1} * {number2}?");
                break;
        }

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

        if (operatorInputInt == 1 && number1 + number2 == userAnswer)
        {
            Console.WriteLine("Correct!");
            score++;
            attempts++;
        }
        else if (operatorInputInt == 2 && number1 - number2 == userAnswer)
        {
            Console.WriteLine("Correct!");
            score++;
            attempts++;
        }
        else if (operatorInputInt == 3 && number1 / number2 == userAnswer)
        {
            Console.WriteLine("Correct!");
            score++;
            attempts++;
        }
        else if (operatorInputInt == 4 && number1 * number2 == userAnswer)
        {
            Console.WriteLine("Correct!");
            score++;
            attempts++;
        }
        else
        {
            Console.WriteLine("Incorrect");
            attempts++;
        }
    }

    Array.Resize(ref scoreArray, games + 1);
    scoreArray[games] = attempts;
}

void PrintScores()
{
    if (games == 0)
    {
        Console.WriteLine("There are currently 0 games stored");
    }
    else if (games > 0)
    {
        for (int i = 0; i < scoreArray.Length; i++)
        {
            Console.WriteLine($"Game {i + 1}: This game took {scoreArray[i]} attempts to complete");
        }
    }
}