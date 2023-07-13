Countdown(10);

void Countdown(int number)
{
    if (number == 1)
    {
        Console.WriteLine(number);
        return;
    }
    else Console.WriteLine(number);
    Countdown(--number);
}