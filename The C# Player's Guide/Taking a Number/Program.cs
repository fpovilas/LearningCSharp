int result = AskForNumber("Please enter one number: ");

int range = AskForNumberInRange("Enter number between 1 and 10: ", 1, 10);

///<summary>
/// Writes out given string and waits for input of integer that are in given range.
///</summary>
int AskForNumberInRange(string v1, int min, int max)
{
    while (true)
    {
        Console.Write(v1);
        int number = Convert.ToInt32(Console.ReadLine());
        if(min <= number && max >= number)
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