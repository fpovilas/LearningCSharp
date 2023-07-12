int[] array1 = new int[5]; // Creating and initalizing array of legth 5

Console.WriteLine("Type in 5 numbers:");

for  (int i = 0; i < array1.Length; i++)
    array1[i] = Convert.ToInt32(Console.ReadLine());

int[] array2 = new int[5];

for (int i = 0; i < array2.Length; i++)
    array2[i] = array1[i];

for(int i  = 0; i < array2.Length;i++)
{
    Console.WriteLine($"array1[{i}] = {array1[i], 3} || array2[{i}] = {array2[i], 3}");
    Console.ReadKey(true);
}