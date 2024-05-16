namespace Area_of_a_Circle;

public class MilesPerGallon
{
    public static double Input()
    {
        Console.WriteLine("Please enter your vehicles miles per gallon");
        double milesPerGal = double.Parse(Console.ReadLine());
        
        while(milesPerGal < 0){
           Console.WriteLine("Please enter a positive MPG");
            milesPerGal = double.Parse(Console.ReadLine()); 
        }

        return milesPerGal;
    }
}
