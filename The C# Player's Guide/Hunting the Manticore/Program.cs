// Initializing the game main variables
int manticoreHealth = 10;
int consolasHealth = 15;
int roundCount = 1;

// Getting Manticores starting location
int manticoreLocation = AskForNumberInRange(
    "Player1, how far away from the city do you want to station the Manticore? ",
    0, 100);
Console.Clear(); // Cleaning console window

Console.WriteLine("Player 2, it is your turn.");

// Initializing current health and cannon damage variables
int manticoreCurrentHealth = manticoreHealth;
int consolasCurrentHealth = consolasHealth;
int cannonDamage;

// Starting round using recursive function
StartRound(manticoreCurrentHealth, consolasCurrentHealth);

// Displaying if Won or Lost
if (manticoreCurrentHealth <= 0) Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
if (consolasCurrentHealth <= 0) Console.WriteLine("The city of Consolas has been destroyed! The Manticore destroyed the city!");

// Recursive function whole game
void StartRound(int enemyCurrentHealth, int playerCurrentHealth)
{
    if (enemyCurrentHealth <= 0 || playerCurrentHealth <= 0)
    {
        manticoreCurrentHealth = enemyCurrentHealth;
        consolasCurrentHealth = playerCurrentHealth;
        return;
    }
    else
    {
        Status(roundCount, enemyCurrentHealth, manticoreHealth, playerCurrentHealth, consolasHealth);
        CannonDamage(roundCount);
        int guessedLocation = AskForNumber("Enter desired cannon range: ");
        bool isHit = CheckIfHit(guessedLocation, manticoreLocation);
        if (isHit) enemyCurrentHealth -= cannonDamage;
        if (enemyCurrentHealth > 0) playerCurrentHealth--;
        roundCount++;
        StartRound(enemyCurrentHealth, playerCurrentHealth);
    }
}

// Return if boolean true or false it hit and also write out
bool CheckIfHit(int locationToShoot, int enemyLocationToHit)
{
    if (locationToShoot > enemyLocationToHit)
    {
        Console.Write("That round ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("OVERSHOT");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine(" the target");
        return false;
    }

    if (locationToShoot < enemyLocationToHit)
    {
        Console.Write("That round ");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("FELL SHORT");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine(" the target");
        return false;
    }

    if (locationToShoot == enemyLocationToHit)
    {
        Console.Write("That round ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("DIRECT HIT!");
        Console.ForegroundColor = ConsoleColor.Gray;
        return true;
    }

    return false;
}

// Calculates cannon damage using current round number
// If round number dividable from 3 or 5 damage is 3
// If round number dividable from 3 and 5 damage is 10
// And if round number is not dividable from 3 or 5 damage is 1
void CannonDamage(int roundCount)
{
    if (roundCount % 3 == 0 && roundCount % 5 == 0)
    {
        cannonDamage = 10;
        Console.Write("The cannon is expected to deal ");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write($"{cannonDamage} ");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("damage this round.");
        return;
    }
    if (roundCount % 3 == 0 || roundCount % 5 == 0) 
    {
        cannonDamage = 3;
        Console.Write("The cannon is expected to deal ");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write($"{cannonDamage} ");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("damage this round.");
        return;
    }
    else
    {
        cannonDamage = 1;
        Console.Write("The cannon is expected to deal ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write($"{cannonDamage} ");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("damage this round.");
        return;
    }
}

// Displays game status
void Status(int round, int enemyCurrentHealth, int enemyHealth, int playerCurrentHealth, int playerHealth)
{
    Console.WriteLine("-----------------------------------------------------------");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("STATUS: ");
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write($"Round: {round} ");
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write($"City: {playerCurrentHealth}/{playerHealth} ");
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine($"Manticore: {enemyCurrentHealth}/{enemyHealth}");
    Console.ForegroundColor = ConsoleColor.Gray;
}

// Asks form number in range and makes sure number is in range
int AskForNumberInRange(string sentence, int min, int max)
{
    while (true)
    {
        Console.Write(sentence);
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > min && number < max)
            return number;
    }
}

// Asks form number using text prompt
int AskForNumber(string sentence)
{
    Console.Write(sentence);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}