// Churros Food Truck - Main Program
// Menu-driven console application using Queue data structure

class Program
{
    static Queue<Order> orderQueue = new Queue<Order>();
    static Churros churros = new Churros();

    public static void Main(string[] args)
    {
        Console.WriteLine("\nWelcome to Delicious Churros Food Truck");

        bool running = true;
        while (running)
        {
            Console.WriteLine("\nChoose your option:");
            Console.WriteLine("1. Place order");
            Console.WriteLine("2. Deliver order");
            Console.WriteLine("0. Exit");
            Console.Write("\nEnter your choice: ");

            string? input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    PlaceOrder();
                    break;
                case "2":
                    DeliverOrder();
                    break;
                case "0":
                    Console.WriteLine("\nThank you for visiting. Goodbye!");
                    running = false;
                    break;
                default:
                    Console.WriteLine("\nInvalid option. Please try again.");
                    break;
            }
        }
    }

    static void PlaceOrder()
    {
        churros.ShowMenu();

        Console.Write("\nSelect item (1-4): ");
        string? itemInput = Console.ReadLine();

        if (!int.TryParse(itemInput, out int itemChoice) || itemChoice < 1 || itemChoice > 4)
        {
            Console.WriteLine("Invalid item selection.");
            return;
        }

        Console.Write("Enter quantity: ");
        string? qtyInput = Console.ReadLine();

        if (!int.TryParse(qtyInput, out int quantity) || quantity <= 0)
        {
            Console.WriteLine("Invalid quantity.");
            return;
        }

        string itemName = churros.ItemNames[itemChoice];
        double itemPrice = churros.ItemPrices[itemChoice];

        Order newOrder = new Order(itemName, quantity, itemPrice);
        newOrder.place_order();

        Console.WriteLine("\nBill Amount: EUR {0:F2}", newOrder.pay_bill());

        orderQueue.Enqueue(newOrder);
        Console.WriteLine("Orders in queue: {0}", orderQueue.Count);
    }

    static void DeliverOrder()
    {
        if (orderQueue.Count == 0)
        {
            Console.WriteLine("\nNo orders in the queue.");
            return;
        }

        Order nextOrder = orderQueue.Dequeue();
        nextOrder.collect_order();
        Console.WriteLine("Orders remaining in queue: {0}", orderQueue.Count);
    }
}
