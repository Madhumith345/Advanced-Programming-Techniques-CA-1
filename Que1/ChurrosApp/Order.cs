// Definition of class Order
// Represents a customer order at the Churros food truck

public class Order
{
    private static int _nextOrderNo = 1;

    private int _order_no;
    private string _order_details;
    private int _quantity;
    private double _bill;

    public int OrderNo
    {
        get { return _order_no; }
    }

    public string OrderDetails
    {
        get { return _order_details; }
    }

    public int Quantity
    {
        get { return _quantity; }
    }

    public double Bill
    {
        get { return _bill; }
    }

    public Order(string orderDetails, int quantity, double pricePerItem)
    {
        _order_no = _nextOrderNo++;
        _order_details = orderDetails;
        _quantity = quantity;
        _bill = quantity * pricePerItem;
    }

    public void place_order()
    {
        Console.WriteLine("\nOrder placed successfully!");
        Console.WriteLine("Order No   : {0}", _order_no);
        Console.WriteLine("Item       : {0}", _order_details);
        Console.WriteLine("Quantity   : {0}", _quantity);
        Console.WriteLine("Total Bill : EUR {0:F2}", _bill);
        Console.WriteLine("Please wait for your order number to be called.");
    }

    public double pay_bill()
    {
        return _bill;
    }

    public void collect_order()
    {
        Console.WriteLine("\nOrder No {0} is ready for collection.", _order_no);
        Console.WriteLine("Item: {0}", _order_details);
        Console.WriteLine("Thank you for visiting Delicious Churros!");
    }
}
