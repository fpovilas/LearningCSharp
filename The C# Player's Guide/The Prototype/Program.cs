int user1Number;

user1Number = AskForNumberInRange("User 1, enter a number between 0 and 100: ", 0, 100);

Console.Clear(); // Clear the console window

int user2Number = -1;
Console.WriteLine("User 2, guess the number.");

while (user2Number != user1Number)
{
    user2Number = AskForNumber("What is your next guess? ");

    if (user2Number < user1Number) Console.WriteLine($"{user2Number} is too low.");
    if (user2Number > user1Number) Console.WriteLine($"{user2Number} is too high.");
}

Console.WriteLine("You guessed the number!");

//Improvements from level 13
///<summary>
/// Writes out given string and waits for input of integer that are in given range.
///</summary>
int AskForNumberInRange(string v1, int min, int max)
{
    while (true)
    {
        Console.Write(v1);
        int number = Convert.ToInt32(Console.ReadLine());
        if (min <= number && max >= number)
            return number;
    }
}

/// <summary>
/// Writes out given string and waits for integer input.
/// </summary>
int AskForNumber(string v)
{
    Console.Write(v);
    return Convert.ToInt32(Console.ReadLine());
}