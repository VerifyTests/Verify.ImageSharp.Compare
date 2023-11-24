using System.Net;

[TestFixture]
public class Tests
{
    [Test]
    public void FailingCompare()
    {
        var files = Directory.EnumerateFiles(@"C:\Windows");
        Console.WriteLine(files.Any(_=>_.EndsWith("a")));
        Console.WriteLine(files.Count());
        Console.WriteLine(files.Any(_=>_.EndsWith("a")));
        Console.WriteLine(files.Count());
        Console.WriteLine(files.Any(_=>_.EndsWith("a")));
        Console.WriteLine(files.Count());
    }
}