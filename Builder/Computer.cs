namespace Builder;

public class Computer
{
    private string _computerType;
    private Dictionary<string, string> _parts =
        new Dictionary<string, string>();
    // Constructor
    public Computer(string computerType)
    {
        this._computerType = computerType;
    }
    // Indexer
    public string this[string key]
    {
        get { return _parts[key]; }
        set { _parts[key] = value; }
    }
    public void Show()
    {
        Console.WriteLine("\n---------------------------");
        Console.WriteLine("Computer Type: {0}", _computerType);
        Console.WriteLine(" Processor : {0}", _parts["processor"]);
        Console.WriteLine(" Storage : {0}", _parts["storage"]);
        Console.WriteLine(" RAM : {0}", _parts["ram"]);
        Console.WriteLine(" Videocard : {0}", _parts["videocard"]);
    }
}