public class AdvancedPrinter : IPrinter, IScanner
{
    public void Print()
    {
        Console.WriteLine("Printing");
    }

    public void Scan()
    {
        Console.WriteLine("Scanning is progress");
    }
}