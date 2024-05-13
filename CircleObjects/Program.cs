// See https://aka.ms/new-console-template for more information
using CircleObjects;








Circle NewCircle = null;
bool repeat = true;
while (repeat == true)
{

    Console.WriteLine("Please enter the radius of a circle.");
    bool validate = true;
    while (validate == true)
    {
        double radiusInput = double.Parse(Console.ReadLine());
         NewCircle = new Circle(radiusInput); //this will take the user input for radius and send it to the circle constructor.

        if (radiusInput <= 0)
        {

            Console.WriteLine("Invalid input. Please enter a positive number.");
            validate = true;

        }

        else
        {
            
            NewCircle.CalculateDiameter();
            Console.WriteLine($"Diameter:{NewCircle.CalculateDiameter()}   Circumfrence: {NewCircle.CalculateCircumfrence()}   Area:{NewCircle.CalculateArea()}");
            validate = false;
        }
    }
        Console.WriteLine("Would you like the circle to grow?y/n");
        string grow = Console.ReadLine();
        if (grow == "n")
        {
        
            Console.WriteLine($"The radius of the circle is {NewCircle.GetRadius()} Goodbye!");
            repeat = false;
            break;
        }
        else
        {
            NewCircle.Grow();
        
            repeat = true;
        }

    }



