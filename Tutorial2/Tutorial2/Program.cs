// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

Test jeden = new Test("Dawid");

jeden.napisz();

class Test
{
    private string name;

    public Test(string name)
    {
        this.name = name;
    }

    public void napisz()
    {
        Console.WriteLine("Nazwa: " + name);
    }
}