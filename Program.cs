internal class Program
{
    private static void Main(string[] args)
    {
        var fibonachiNumbers = new List<int> {1 , 1};

        for (int i = 0; i < 20; i++)
        {
            var previous = fibonachiNumbers[fibonachiNumbers.Count - 1];
            var previous2 = fibonachiNumbers[fibonachiNumbers.Count - 2];

            fibonachiNumbers.Add(previous + previous2);
        }

        foreach (var item in fibonachiNumbers)
        {
            Console.WriteLine(item);
        }


    }
}