Console.Title = "The Defense of Consolas"; // Changing console window name

int targetRow = AskForNumber("Target Row? ");
int targetColumn = AskForNumber("Target Column? ");

// X = Row Y = Column
int deployNorthX, deploySouthX;
deployNorthX = targetRow + 1;
deploySouthX = targetRow - 1;
int deployNorthY, deploySouthY;
deployNorthY = deploySouthY = targetColumn;

int deployWestX, deployEastX;
deployWestX = deployEastX = targetRow;
int deployWestY, deployEastY;
deployWestY = targetColumn - 1;
deployEastY = targetColumn + 1;

Console.ForegroundColor = ConsoleColor.Magenta; // Changing color of Text
Console.WriteLine($"Deploy to:");
Console.WriteLine($"({deployWestX}, {deployWestY})");
Console.WriteLine($"({deploySouthX}, {deploySouthY})");
Console.WriteLine($"({deployEastX}, {deployEastY})");
Console.WriteLine($"({deployNorthX}, {deployNorthY})");

// Making Beep Boop sound of calculation
Console.Beep(1000, 200);
Console.Beep(800, 400);

Console.ForegroundColor = ConsoleColor.Gray; // Changing color of Text


/// <summary>
/// Writes out given string and waits for integer input. (Improvement task from level 13)
/// </summary>
int AskForNumber(string v)
{
    Console.Write(v);
    return Convert.ToInt32(Console.ReadLine());
}