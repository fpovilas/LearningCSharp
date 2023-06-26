Console.Write("Enter x value: ");
int xValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter y value: ");
int yValue = Convert.ToInt32(Console.ReadLine());

bool notHere = true; // Assuming enemy is not here
string location = ""; // Initializing string to be empty

if (xValue < 0 && yValue > 0) location = "north werst";
if (xValue == 0 && yValue > 0) location = "north";
if (xValue > 0 && yValue > 0) location = "north east";
if (xValue < 0 && yValue == 0) location = "west";
if (xValue == 0 && yValue == 0)
{
    Console.WriteLine("The enemy is here!");
    notHere = false; // Assinging false to know that enemy is here
}
if (xValue > 0 && yValue == 0) location = "east";
if (xValue < 0 && yValue < 0) location = "south west";
if (xValue == 0 && yValue < 0) location = "south";
if (xValue > 0 && yValue < 0) location = "south east";

if (notHere) Console.WriteLine($"The enemy is to the {location}!"); // If enemy is not here say where is the enemy