
Test jeden = new Test("Dawid");

jeden.napisz();

int[] lista = new []{1,2,3,4,5,6};

float testowa = Test.CalculateAverage(lista);
Console.WriteLine(testowa);

class Test
{
    private string name;

    public Test(string name)
    {
        if (name != null)
        {
            this.name = name;
        }
        else
        {
            this.name = "Domyslne";
        }
    }

    public void napisz()
    {
        Console.WriteLine("Nazywam sie: " + name);
    }
    public static float CalculateAverage(int[] values)
    {
        int sum = 0;
        for (int i = 0; i < values.Length; i++)
        {
            sum += values[i];
        }
        return sum / values.Length;
    }
}