/*Project 1a
You have been hired by a local Tea shop to write a program that will calculate
the cost of a Tea order. The shop sells four types of Teas in three different
sizes; Small (8 oz), Medium (16 oz) and Large (24 oz). Your program should use
a menu for the type of Tea and a second menu for the Tea size. Calculate the
total cost of the order including tax and display a bill for the Tea. See the
Sample Output. The current sales tax rate is 4.5%.  Use named constants to hold
the cost per ounce of each of the products and the sales tax rate. Use the
constants in your calculations and wherever else they are appropriate in your
program.
 
Product                  Cost per Ounce     
Plain Tea                         $0.43    
Black Tea                        $0.53
Green Tea                       $0.65 
White Tea                        $0.78
*/

namespace CarlinProject1;
class Program
{
    static void Main(string[] args)
    {
        // Declaring Variables
        const float plain_tea = 0.43F;
        const float black_tea = 0.53F;
        const float green_tea = 0.65F;
        const float white_tea = 0.78F;
        // Totals
        const float tax_rate = 0.045F;
        float sales_tax = 0.0F;
        float total_price = 0.0F;
        float order_total = 0.0F;

        // Welcoming user and displaying types of tea
        Console.WriteLine("Welcome to the World's Best Tea Shop :\n\t1 - Plain Tea\n\t2 - Black Tea\n\t3 - Green Tea\n\t4 - White Tea");

        // Asking user to choose a type of tea then converting the input to int
        Console.WriteLine("Enter choice of Tea: ");
        int tea_choice = Convert.ToInt32(Console.ReadLine());

        // If/Else statement for types of tea

        if (tea_choice == 1)
        {
            // Plain tea
            total_price = plain_tea;
        }
        else if (tea_choice == 2)
        {
            // Black tea
            total_price = black_tea;
        }
        else if (tea_choice == 3)
        {
            // Green tea
            total_price = green_tea;
        }
        else if (tea_choice == 4)
        {
            // White Tea
            total_price = white_tea;
        }
        else
        {
            //Invalid Input
            Console.WriteLine("ERROR: INVALID MENU CHOICE. PROGRAM WILL TERMINATE.");
            Environment.Exit(0);
        }

        // Asking user to select a size and inpit a number for the size
        Console.WriteLine("Select a Size:\n\t1 - Small (8oz)\n\t2 - Medium (16oz)\n\t3 - Large (24oz)");
        Console.Write("Enter choice of Size: ");

        // Converting number to int
        int type_choice = Convert.ToInt32(Console.ReadLine());

        // If/Else statement for sizes
        if (type_choice == 1)
        {
            // Small size
            total_price = total_price * 8;
        }
        else if (type_choice == 2)
        {
            // Medium size
            total_price = total_price * 16;
        }
        else if (type_choice == 3)
        {
            // Large size
            total_price = total_price * 24;
        }
        else
        {
            // Invalid input
            Console.WriteLine("ERROR: INVALID MENU CHOICE. PROGRAM WILL TERMINATE.");
            Environment.Exit(0);
        }

        // Output calculations
        sales_tax = (total_price * tax_rate);
        order_total = (total_price + (total_price * tax_rate));

        // Asking for customer name of the order
        Console.Write("\nEnter the name of the customer : ");

        // Displaying order information and totals
        string name = Console.ReadLine();
        Console.WriteLine("\nName on Order : " + name);
        Console.WriteLine("Price of Tea: " + $"{total_price:C2}");
        Console.WriteLine("Sales Tax: " + $"{sales_tax:C2}");
        Console.WriteLine("Order Total: " + $"{order_total:C2}");


    }
}

