using System.Diagnostics;

class Comparison {

    public static void Main() {
        int maxNumber = 10000000;

        Stopwatch stopwatch = Stopwatch.StartNew();

        var primes = ParallelEnumerable.Range(2, maxNumber - 1)
            .Where(num => Enumerable.Range(2, (int)Math.Sqrt(num) - 1)
                .All(divisor => num % divisor != 0));

        stopwatch.Stop();

        Console.WriteLine($"Found {primes.Count()} prime numbers in {stopwatch.ElapsedMilliseconds} ms");
    }
}

