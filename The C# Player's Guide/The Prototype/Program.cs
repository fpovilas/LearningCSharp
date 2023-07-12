int user1Number;

do
{
    Console.Write("User 1, enter a number between 0 and 100: ");
    user1Number = Convert.ToInt32(Console.ReadLine());
} while (user1Number < 0 || user1Number > 100);

Console.Clear(); // Clear the console window

int user2Number = -1;
Console.WriteLine("User 2, guess the number.");

while (user2Number != user1Number)
{
    Console.Write("What is your next guess? ");
    user2Number = Convert.ToInt32(Console.ReadLine());

    if (user2Number < user1Number) Console.WriteLine($"{user2Number} is too low.");
    if (user2Number > user1Number) Console.WriteLine($"{user2Number} is too high.");
}

Console.WriteLine("You guessed the number!");