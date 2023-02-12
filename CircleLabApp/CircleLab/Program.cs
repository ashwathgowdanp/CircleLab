//  Calculate a circle’s circumference and area.

using CircleLab;


int Counter = 0;
Console.WriteLine("Welcome to the Circle Tester");
do
{
    Console.Write("Enter Radius: ");
    string? radius = Console.ReadLine();
    double radiusValue = 0;
    bool ValidNumber = Validator.validateVNumber(radius, ref radiusValue);    
    if (ValidNumber)
    {
        Circle circle = new Circle(radiusValue);
        circle.MyProperty = radiusValue;
        string Circumference = circle.CalculateFormattedCircumference();
        Console.WriteLine($"Circumference is: {Circumference}");
        string Area  = circle.CalculateFormattedArea();
        Console.WriteLine($"Area of the circle is: {Area}");

        Counter++;
    }
    else
        Console.WriteLine("Please enter a valid number for Radius:");

    Console.Write("Continue?(y/n): ");
}while(Console.ReadLine().ToLower() == "y");