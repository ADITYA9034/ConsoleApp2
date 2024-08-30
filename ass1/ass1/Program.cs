using System;

class Program
{
    static void Main()
    {
       double[] prices = new double[5];

        for (int i = 0; i < prices.Length; i++)
        {
            Console.Write($"Enter the price of item {i + 1}: ");
            prices[i] = double.Parse(Console.ReadLine());
        }
        double totalPrice = 0;
        foreach (double price in prices)
        {
            totalPrice += price;
        }
        if (totalPrice > 3000)
        {
            totalPrice -= totalPrice * 0.10;
            Console.WriteLine("A 10% discount has been applied.");
        }
        Console.WriteLine($"The total price after any applicable discount is: Rs. {totalPrice}");
    }
}
using System;

class Program
{
    static void Main()
    {
      Console.Write("Enter the temperature in Celsius: ");
        double celsius = double.Parse(Console.ReadLine());

        
        double fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine($"The temperature in Fahrenheit is: {fahrenheit}°F");

        if (celsius < 0)
        {
            Console.WriteLine("Warning: The temperature is below freezing (0°C).");
        }
    }
}
using System;

class Program
{
    static void Main()
    {
        double balance = 1000.00;

        while (true)
        {
           
            Console.WriteLine("\nATM Menu:");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit Money");
            Console.WriteLine("3. Withdraw Money");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option (1-4): ");

            
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    
                    Console.WriteLine($"Your current balance is: Rs. {balance}");
                    break;

                case "2":
                    
                    Console.Write("Enter the amount to deposit: Rs. ");
                    double depositAmount = double.Parse(Console.ReadLine());
                    if (depositAmount > 0)
                    {
                        balance += depositAmount;
                        Console.WriteLine($"Rs. {depositAmount} has been deposited. New balance: Rs. {balance}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid amount. Please enter a positive value.");
                    }
                    break;

                case "3":
                    
                    Console.Write("Enter the amount to withdraw: Rs. ");
                    double withdrawAmount = double.Parse(Console.ReadLine());
                    if (withdrawAmount > 0)
                    {
                        if (withdrawAmount <= balance)
                        {
                            balance -= withdrawAmount;
                            Console.WriteLine($"Rs. {withdrawAmount} has been withdrawn. New balance: Rs. {balance}");
                        }
                        else
                        {
                            Console.WriteLine("Insufficient funds. Please try a smaller amount.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid amount. Please enter a positive value.");
                    }
                    break;

                case "4":
                    // Exit
                    Console.WriteLine("Thank you for using the ATM. Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid option. Please choose a number between 1 and 4.");
                    break;
            }
        }
    }
}*/
/*using System;

class Program
{
    static void Main()
    {
        double[] marks = new double[5];
        double total = 0;

        
        for (int i = 0; i < marks.Length; i++)
        {
            Console.Write($"Enter the marks for subject {i + 1}: ");
            marks[i] = double.Parse(Console.ReadLine());
            total += marks[i];
        }

        
        double average = total / marks.Length;

        
        char grade;
        if (average >= 90 && average <= 100)
        {
            grade = 'A';
        }
        else if (average >= 80 && average < 90)
        {
            grade = 'B';
        }
        else if (average >= 70 && average < 80)
        {
            grade = 'C';
        }
        else if (average >= 60 && average < 70)
        {
            grade = 'D';
        }
        else
        {
            grade = 'F';
        }

        
        Console.WriteLine($"Your average marks are: {average}");
        Console.WriteLine($"Your grade is: {grade}");
    }
}*/
/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a password: ");
        string password = Console.ReadLine();
        bool isValid = ValidatePassword(password);

        
        if (isValid)
        {
            Console.WriteLine("Password is valid.");
        }
        else
        {
            Console.WriteLine("Password is invalid. It must meet the following criteria:");
            Console.WriteLine("- At least 8 characters long");
            Console.WriteLine("- Contains at least one uppercase letter (A-Z)");
            Console.WriteLine("- Contains at least one lowercase letter (a-z)");
            Console.WriteLine("- Contains at least one digit (0-9)");
        }
    }

    static bool ValidatePassword(string password)
    {
        if (password.Length < 8)
            return false;

        bool hasUppercase = false;
        bool hasLowercase = false;
        bool hasDigit = false;

        foreach (char c in password)
        {
            if (char.IsUpper(c))
                hasUppercase = true;
            if (char.IsLower(c))
                hasLowercase = true;
            if (char.IsDigit(c))
                hasDigit = true;
        }

        return hasUppercase && hasLowercase && hasDigit;
    }
}*/
/*using System;

class Program
{
    static void Main()
    {
        // Input: Total distance traveled
        Console.Write("Enter the total distance traveled (in kilometers): ");
        double distance = double.Parse(Console.ReadLine());

        // Input: Time of the ride (in hours, 24-hour format)
        Console.Write("Enter the time of the ride (hour in 24-hour format): ");
        int hour = int.Parse(Console.ReadLine());

        // Constants
        double baseFare = 20;           // Rs. 20 for the first 2 km
        double additionalFareRate = 10; // Rs. 10 per km beyond the first 2 km
        double nightSurchargeRate = 0.20; // 20% night surcharge
        double totalFare;

        // Calculate the fare
        if (distance <= 2)
        {
            totalFare = baseFare;
        }
        else
        {
            double additionalDistance = distance - 2;
            totalFare = baseFare + (additionalDistance * additionalFareRate);
        }
        if (hour >= 22)
        {
            totalFare += totalFare * nightSurchargeRate;
        }
        Console.WriteLine($"The total fare for your taxi ride is: Rs. {totalFare}");
    }
}*/
/*using System;

class Program
{
    static void Main()
    {
        
        bool[] attendance = new bool[5];
        int totalDaysAttended = 0;

        
        for (int i = 0; i < attendance.Length; i++)
        {
            Console.Write($"Was the student present on day {i + 1}? (yes/no): ");
            string input = Console.ReadLine().Trim().ToLower();

            if (input == "yes")
            {
                attendance[i] = true;
                totalDaysAttended++;
            }
            else if (input == "no")
            {
                attendance[i] = false;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
                i--; 
            }
        }

        
        bool perfectAttendance = totalDaysAttended == 5;

        
        Console.WriteLine($"\nTotal days attended: {totalDaysAttended}");
        if (perfectAttendance)
        {
            Console.WriteLine("The student has perfect attendance.");
        }
        else
        {
            Console.WriteLine("The student does not have perfect attendance.");
        }
    }
}*/
/*using System;

class Program
{
    static void Main()
    {
        
        double[] expenses = new double[12];
        double totalExpenses = 0;
        int highestExpenseMonth = 0;
        int lowestExpenseMonth = 0;

        
        for (int i = 0; i < expenses.Length; i++)
        {
            Console.Write($"Enter expenses for month {i + 1}: Rs. ");
            expenses[i] = double.Parse(Console.ReadLine());
            totalExpenses += expenses[i];

            
            if (expenses[i] > expenses[highestExpenseMonth])
            {
                highestExpenseMonth = i;
            }
            if (expenses[i] < expenses[lowestExpenseMonth])
            {
                lowestExpenseMonth = i;
            }
        }

     
        string[] monthNames =
        {
            "January", "February", "March", "April", "May", "June",
            "July", "August", "September", "October", "November", "December"
        };

        
        Console.WriteLine($"\nTotal expenses for the year: Rs. {totalExpenses}");
        Console.WriteLine($"Month with the highest expenses: {monthNames[highestExpenseMonth]} (Rs. {expenses[highestExpenseMonth]})");
        Console.WriteLine($"Month with the lowest expenses: {monthNames[lowestExpenseMonth]} (Rs. {expenses[lowestExpenseMonth]})");
    }
}
*/
/*using System;
using System.Collections.Generic;

class Item
{
    public string Name { get; set; }
    public double Price { get; set; }

    public Item(string name, double price)
    {
        Name = name;
        Price = price;
    }
}

class ShoppingCart
{
    private List<Item> items = new List<Item>();

    
    public void AddItem(Item item)
    {
        items.Add(item);
        Console.WriteLine($"{item.Name} has been added to the cart.");
    }

  
    public void RemoveItem(string name)
    {
        Item itemToRemove = items.Find(item => item.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        if (itemToRemove != null)
        {
            items.Remove(itemToRemove);
            Console.WriteLine($"{name} has been removed from the cart.");
        }
        else
        {
            Console.WriteLine($"{name} is not found in the cart.");
        }
    }

    public double CalculateTotalPrice()
    {
        double total = 0;
        foreach (var item in items)
        {
            total += item.Price;
        }
        return total;
    }

    
    public void DisplayItems()
    {
        if (items.Count > 0)
        {
            Console.WriteLine("\nItems in your cart:");
            foreach (var item in items)
            {
                Console.WriteLine($"- {item.Name}: Rs. {item.Price}");
            }
        }
        else
        {
            Console.WriteLine("\nYour cart is empty.");
        }
    }
}

class Program
{
    static void Main()
    {
        ShoppingCart cart = new ShoppingCart();
        bool shopping = true;

        while (shopping)
        {
            Console.WriteLine("\nOptions: 1. Add Item  2. Remove Item  3. View Total Price  4. View Cart  5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter the name of the item: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter the price of the item: Rs. ");
                    double price = double.Parse(Console.ReadLine());
                    cart.AddItem(new Item(name, price));
                    break;

                case "2":
                    Console.Write("Enter the name of the item to remove: ");
                    string itemName = Console.ReadLine();
                    cart.RemoveItem(itemName);
                    break;

                case "3":
                    double totalPrice = cart.CalculateTotalPrice();
                    Console.WriteLine($"Total price of items in the cart: Rs. {totalPrice}");
                    break;

                case "4":
                    cart.DisplayItems();
                    break;

                case "5":
                    shopping = false;
                    Console.WriteLine("Exiting the shopping cart. Thank you!");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please choose a valid option.");
                    break;
            }
        }
    }
}*/
using System;

class Program
{
    static void Main()
    {
        // Input: Hourly wage
        Console.Write("Enter the hourly wage of the employee (in Rs.): ");
        double hourlyWage = double.Parse(Console.ReadLine());
        Console.Write("Enter the number of hours worked per week: ");
        double hoursPerWeek = double.Parse(Console.ReadLine());

        double weeklySalary = hourlyWage * hoursPerWeek;
        double monthlySalary = weeklySalary * 4;
        Console.WriteLine($"\nThe monthly salary of the employee is: Rs. {monthlySalary}");
    }
}







