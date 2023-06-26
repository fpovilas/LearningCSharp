Console.WriteLine("The following items are available:");
Console.WriteLine("1 - Rope");
Console.WriteLine("2 - Torches");
Console.WriteLine("3 - Climbing Equipment");
Console.WriteLine("4 - Clean Water");
Console.WriteLine("5 - Machete");
Console.WriteLine("6 - Canoe");
Console.WriteLine("7 - Food Supplies");
Console.Write("What number do you want to see the price of? ");
int itemNumber = Convert.ToInt32(Console.ReadLine());

string itemName = itemNumber switch
{
    1 => "Rope",
    2 => "Torches",
    3 => "Climbing Equipment",
    4 => "Clean Water",
    5 => "Machete",
    6 => "Canoe",
    7 => "Food Supplies",
    _ => "_"
};

int itemCost = itemName switch
{
    "Rope" => 10,
    "Torches" => 16,
    "Climbing Equipment" => 26,
    "Clean Water" => 2,
    "Machete" => 20,
    "Canoe" => 200,
    "Food Supplies" => 2,
    _ => 0
};

Console.Write("What is your name? ");
string name = Console.ReadLine();

Console.WriteLine($"{itemName} costs {(name == "Povka" ? itemCost / 2 : itemCost)} gold");