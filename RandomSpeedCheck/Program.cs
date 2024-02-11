// See https://aka.ms/new-console-template for more information

class Test
{
    static void Main(string[] args)
    {
        const int Loops = 50;
        const int RunsPerLoop = 10000000;

        var watch = new System.Diagnostics.Stopwatch();
        
        int randVal;

        long[] totalRunTime = new long[4];

        for (int j = 0; j < Loops; ++j)
        {
            watch.Start();

            for (var i = 0; i < RunsPerLoop; ++i)
            {
                randVal = new System.Random(System.DateTime.Now.Millisecond).Next(1, 101);
            }
            
            watch.Stop();
            totalRunTime[0] += watch.ElapsedMilliseconds;



            watch.Restart();

            for (var i = 0; i < RunsPerLoop; ++i)
            {
                randVal = new System.Random(System.DateTime.Now.Millisecond).Next() % 100 + 1;
            }

            watch.Stop();
            totalRunTime[1] += watch.ElapsedMilliseconds;
            


            var rand = new System.Random(System.DateTime.Now.Millisecond);

            watch.Restart();

            for (var i = 0; i < RunsPerLoop; ++i)
            {
                randVal = rand.Next(1, 101);
            }

            watch.Stop();
            totalRunTime[2] += watch.ElapsedMilliseconds;



            watch.Restart();

            for (var i = 0; i < RunsPerLoop; ++i)
            {
                randVal = rand.Next() % 100 + 1;
            }

            watch.Stop();
            totalRunTime[3] += watch.ElapsedMilliseconds;
        }
        
        Console.WriteLine(totalRunTime[0] / Loops);
        Console.WriteLine(totalRunTime[1] / Loops);
        Console.WriteLine(totalRunTime[2] / Loops);
        Console.WriteLine(totalRunTime[3] / Loops);
    }
}