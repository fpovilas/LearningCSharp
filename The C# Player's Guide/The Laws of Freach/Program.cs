/*
int[]  array  =  new int[] { 4, 51,  -7, 13,  -99, 15,  -8,  45, 90 };
int currentSmallest =  int.MaxValue; // Start higher than  anything in the array.
for (int index = 0; index < array.Length; index++)
{
    if (array[index] <  currentSmallest)
        currentSmallest = array[index];
}
Console.WriteLine(currentSmallest);
*/

int[] smallestNumberArray = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

int currentSmallest = int.MaxValue;

foreach (int i in smallestNumberArray)
{
    if(i < currentSmallest)
        currentSmallest = i;
}
Console.WriteLine(currentSmallest);

/*
int[]  array  =  new int[] { 4, 51,  -7, 13,  -99, 15,  -8,  45, 90 };
int total = 0;
for (int index = 0; index < array.Length; index++)
    total += array[index];

float average =  (float)total / array.Length;
Console.WriteLine(average);
 */

int[] averageNumberArray = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
int total = 0;
foreach (int i in averageNumberArray)
    total += i;

float average = (float)total / averageNumberArray.Length;
Console.WriteLine($"{average:f}");