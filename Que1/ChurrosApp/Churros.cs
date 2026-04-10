// Definition of class Churros
// Represents the menu items available at the Churros food truck

public class Churros
{
    private Dictionary<int, string> _itemNames;
    private Dictionary<int, double> _itemPrices;

    public Dictionary<int, string> ItemNames
    {
        get { return _itemNames; }
    }

    public Dictionary<int, double> ItemPrices
    {
        get { return _itemPrices; }
    }

    public Churros()
    {
        _itemNames = new Dictionary<int, string>();
        _itemPrices = new Dictionary<int, double>();

        _itemNames.Add(1, "Churros with plain sugar");
        _itemNames.Add(2, "Churros with cinnamon sugar");
        _itemNames.Add(3, "Churros with chocolate sauce");
        _itemNames.Add(4, "Churros with Nutella");

        _itemPrices.Add(1, 6.00);
        _itemPrices.Add(2, 6.00);
        _itemPrices.Add(3, 8.00);
        _itemPrices.Add(4, 8.00);
    }

    public void ShowMenu()
    {
        Console.WriteLine("\nDelicious Churros:");
        foreach (KeyValuePair<int, string> item in _itemNames)
        {
            Console.WriteLine("  {0}. {1}: EUR {2:F2}", item.Key, item.Value, _itemPrices[item.Key]);
        }
    }
}
