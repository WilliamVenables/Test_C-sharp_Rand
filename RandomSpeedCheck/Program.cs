// See https://aka.ms/new-console-template for more information

class Test
{
    static void Main(string[] args)
    {
        const int Runs = 10000000;

        var watch = new System.Diagnostics.Stopwatch();
        
        int randVal;
        
        watch.Start();
        
        for (var i = 0; i < Runs; ++i)
        {
            randVal = new System.Random(System.DateTime.Now.Millisecond).Next(1, 101);
        }
        
        watch.Stop();
        Console.WriteLine($"Defined range + instantiated time: {watch.ElapsedMilliseconds}");

        
        
        watch.Restart();
        
        for (var i = 0; i < Runs; ++i)
        {
            randVal = new System.Random(System.DateTime.Now.Millisecond).Next() % 100 + 1;
        }
        
        watch.Stop();
        Console.WriteLine($"Mod range + instantiated time: {watch.ElapsedMilliseconds}");

        var rand = new System.Random(System.DateTime.Now.Millisecond);

        
        
        watch.Restart();
        
        for (var i = 0; i < Runs; ++i)
        {
            randVal = rand.Next(1, 101);
        }
        
        watch.Stop();
        Console.WriteLine($"Defined range: {watch.ElapsedMilliseconds}");
        
        
        
        watch.Restart();
        
        for (var i = 0; i < Runs; ++i)
        {
            randVal = rand.Next() % 100 + 1;
        }
        
        watch.Stop();
        Console.WriteLine($"Mod range: {watch.ElapsedMilliseconds}");
    }
}