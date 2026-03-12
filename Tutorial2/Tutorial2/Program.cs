
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
    public float CalculateAverage(int[] values)
    {
        int sum = 0;
        for (int i = 0; i < values.Length; i++)
        {
            sum += values[i];
        }
        return sum / values.Length;
    }
}