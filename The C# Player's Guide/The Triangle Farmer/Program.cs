Console.Write("Input triangles Base: "); // Asking for triangle Base
float triangeBase = Convert.ToSingle(Console.ReadLine()); // Getting triangle Base

Console.Write("Input triangles Height: "); // Asking for triangle Height
float triangleHeight = Convert.ToSingle(Console.ReadLine()); // Getting triangle Height

float triangleArea = triangeBase * triangleHeight / 2; // Calculateing triangles Area

Console.WriteLine("Triangles Area is: " +  triangleArea); // Displaying triangles Area