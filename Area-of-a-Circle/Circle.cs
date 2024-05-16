namespace Area_of_a_Circle;

public class Circle
{
    public static double Area(double radius)
    {
        return Math.PI * radius * radius;
    }
    public static double Circumference(double radius)
    {
        return 2 * Math.PI * radius;
    }
    public static double Diameter(double radius)
    {
        return 2 * radius;
    }


    
}
