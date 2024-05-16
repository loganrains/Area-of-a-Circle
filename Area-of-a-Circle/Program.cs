// See https://aka.ms/new-console-template for more information
using Area_of_a_Circle;

Console.WriteLine("Please enter radius of Circle");
double radius = double.Parse(Console.ReadLine());
// Console.WriteLine(radius);

Console.WriteLine("The area of a circle of a radius " + radius + " is: " + Circle.Area(radius));
Console.WriteLine("The circumference of a circle of a radius " + radius + " is: " + Circle.Circumference(radius));
Console.WriteLine("The diameter of a circle of a radius " + radius + " is: " + Circle.Diameter(radius));

double gasTotal = Circle.Circumference(radius) / MilesPerGallon.Input();
Console.WriteLine("It would take " + gasTotal + " gallons to drive around the circle.");