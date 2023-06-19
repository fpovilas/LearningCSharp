Console.WriteLine("How much eggs chickens have laid today?");
string eggsLaidText = Console.ReadLine(); // Getting number of laid eggs

int eggsLaid = Convert.ToInt32(eggsLaidText); // Converting number from sting to int
int eggsForSisters = eggsLaid / 4; // Calculating how much eggs sisters will get
int eggsforDuckbear = eggsLaid % 4; // Calculateing how much eggs Duckbear will get

Console.WriteLine("Today sister will get " + eggsForSisters + " each and Duckbears leftover eggs is " + eggsforDuckbear);

// Answer this question: What are three total egg counts where the duckbear gets more than each sister does?
// You can use the program you created to help you find the answer.

// Answer is 1, 2, 3, 6, 7, 11