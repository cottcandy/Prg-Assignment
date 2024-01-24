//========================================================
// Student Number : S10258514
// Student Name : Zhang Lixin
// Partner Name : Borra Sri Venkata Surya Nanditha  
//========================================================

using PRG_Assignment;

List<string> options = new List<string> { "Cup", "Cone", "Waffle" };
List<string> flavours = new List<string> { };
List<string> toppings = new List<string> { };
List<string> premiumFlavours = new List<string> { };
List<string> waffleFlavours = new List<string> { "Original", "Red Velvet", "Charcoal", "Pandan Waffle" };
Queue<Order> regularQueue = new();
Queue<Order> goldQueue = new();
List<Customer> customers = CreateCustomerList();

void DisplayMenu()
{
    Console.WriteLine("==========================================");
    Console.WriteLine("1. List all customers.");
    Console.WriteLine("2. List all current orders.");
    Console.WriteLine("3. Register a new customer.");
    Console.WriteLine("4. Create an order.");
    Console.WriteLine("5. Display order details of a customer.");
    Console.WriteLine("6. Modify order details.");
    Console.WriteLine("0. Exit.");
    Console.WriteLine("==========================================");
}

bool finish = false;
while (!finish)
{
    try
    {
        DisplayMenu();
        int choice;
        Console.Write("Enter your choice: ");
        choice = int.Parse(Console.ReadLine());
        if (choice == 1)
        {
            ListCustomers(customers);
        }
        else if (choice == 2)
        {
            // code
            break;
        }
        else if (choice == 3)
        {
            // code
            break;
        }
        else if (choice == 4)
        {
            // code
            break;
        }
        else if (choice == 5)
        {
            // code
            break;
        }
        else if (choice == 6)
        {
            // code
            break;
        }
        else if (choice == 0)
        {
            finish = true;
            break;
        }
        else
        {
            Console.WriteLine("Please enter a valid option.\n");
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Please enter a valid integer.\n");
    }
}


// Option 1
// List all customers
//  display the information of all the customers
List<Customer> CreateCustomerList() // Create customer objects for each customer in customers.csv 
{
    using (StreamReader reader = new StreamReader("customers.csv"))
    {
        List<Customer> result = new List<Customer>();
        // Read the header line and discard it 
        reader.ReadLine();

        while (!reader.EndOfStream)
        {
            string? line = reader.ReadLine();
            string[] lines = line.Split(",");
            Customer customer1 = new Customer(lines[0], int.Parse(lines[1]), Convert.ToDateTime(lines[2]));
            customer1.Rewards.Tier = lines[3];
            customer1.Rewards.Points = int.Parse(lines[4]);
            customer1.Rewards.PunchCard = int.Parse(lines[5]);
            result.Add(customer1);
        }
        return result;
    }
}

void ListCustomers(List<Customer> customers)
{
    Console.WriteLine("\n1. List all customers.");
    Console.WriteLine("{0,-10}{1,-15}{2,-18}{3,-25}{4,-30}{5,-35}", "Name", "MemberId", "DOB", "MembershipStatus", "MembershipPoints", "PunchCard");
    // Read and display each line of the file 
    foreach (Customer customer1 in customers)
    {
        Console.WriteLine("{0,-10}{1,-15}{2,-18:dd/MM/yyyy}{3,-25}{4,-30}{5,-35}", customer1.Name, customer1.MemberId, customer1.Dob, customer1.Rewards.Tier, customer1.Rewards.Points, customer1.Rewards.PunchCard);
    }
}


// Option 3
// Register a new customer
//  prompt user for the following information for the customer: name, id number, date of birth
//  create a customer object with the information given
//  create a Pointcard object
//  assign Pointcard object to the customer
//  append the customer information to the customers.csv file
//  display a message to indicate registration status

// Option 4
// Create a customer’s order
//  list the customers from the customers.csv
//  prompt user to select a customer and retrieve the selected customer
//  create an order object
//  prompt user to enter their ice cream order (option, scoops, flavours, toppings)
//  create the proper ice cream object with the information given
//  add the ice cream object to the order
//  prompt the user asking if they would like to add another ice cream to the order, repeating the previous three steps if [Y] or continuing to the next step if [N]
//  link the new order to the customer’s current order
//  if the customer has a gold-tier Pointcard, append their order to the back of the gold members order queue. Otherwise append the order to the back of the regular order queue
//  display a message to indicate order has been made successfully
