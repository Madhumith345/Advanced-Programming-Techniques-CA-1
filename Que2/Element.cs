// Definition of class Element
// Represents a chemical element in the periodic table

public class Element
{
    private int _atomicNumber;
    private string _name;
    private string _symbol;
    private string _elementClass;
    private string _info;

    public int AtomicNumber
    {
        get { return _atomicNumber; }
    }

    public string Name
    {
        get { return _name; }
    }

    public string Symbol
    {
        get { return _symbol; }
    }

    public string ElementClass
    {
        get { return _elementClass; }
    }

    public string Info
    {
        get { return _info; }
    }

    public Element(int atomicNumber, string name, string symbol, string elementClass, string info)
    {
        _atomicNumber = atomicNumber;
        _name = name;
        _symbol = symbol;
        _elementClass = elementClass;
        _info = info;
    }

    public void ShowElement()
    {
        Console.WriteLine("\nAtomic Number : {0}", _atomicNumber);
        Console.WriteLine("Name          : {0}", _name);
        Console.WriteLine("Symbol        : {0}", _symbol);
        Console.WriteLine("Class         : {0} ({1})", _elementClass, _info);
    }
}
