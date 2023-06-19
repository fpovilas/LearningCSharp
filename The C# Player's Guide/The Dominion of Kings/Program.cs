// Defining value variables for estate, duchy and province
int estateValue = 1;
int duchyValue = 3;
int provinceValue = 6;

Console.WriteLine("How much estates do you have?");
int estateNumber = Convert.ToInt32(Console.ReadLine()); // Getting estate number
int totalWorthOfEstates = estateNumber * estateValue; // Calculating estates total worth

Console.WriteLine("How much duchys do you have?");
int duchyNumber = Convert.ToInt32(Console.ReadLine()); // Getting duchy number
int totalWorthOfDuchys = duchyNumber * duchyValue; // Calculating duchys total worth

Console.WriteLine("How much provinces do you have?");
int provinceNumber = Convert.ToInt32(Console.ReadLine()); // Getting province number
int totalWorthOfProvince = provinceNumber * provinceValue; // Calculating provinces total worth

int totalWorth = totalWorthOfEstates + totalWorthOfDuchys + totalWorthOfProvince; // Calculating total worth
Console.WriteLine("Total worth of estates, duchys and provinces are " + totalWorth); // Displaying result