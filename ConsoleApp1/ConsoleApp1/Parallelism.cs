class Parallelism {

    //Basic Threads
    static Thread thread1 = new Thread((name) => {
        for (int i = 0; i < 10000; i++) {
            Console.WriteLine(name);
        }
    });
    static Thread thread2 = new Thread((name) => {
        for (int i = 0; i < 10000; i++) {
            Console.WriteLine(name);
        }
    });

    //Asynchronous Functions

    static async Task asyncMethod() {
        await Task.Delay(10);
        Console.WriteLine("Async Done!");
    }
    
    

    public static void Main() {

        //PLINQ

        var numbers = Enumerable.Range(1, 10000);
        var result = numbers.AsParallel()
            .Where(x => x % 2 == 0).Sum();
        
        Console.WriteLine(result);

        //Async & Await
        asyncMethod();
        Console.WriteLine("Called after async.");
        
        //thread1.Start("THREAD 1");
        //thread2.Start("thread            2");

        //Task Parallel Libraray (TPL)
        int[] jobs = { 1, 2, 3, 4, 5, 6, 7 };
        Random random = new Random();
        Parallel.ForEach(jobs, job => {
            Task.Delay(random.Next(1, 5)).Wait();
            Console.WriteLine(job);
        });
    }
}

