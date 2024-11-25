import java.util.stream.LongStream;

public class Main {
    public static void main(String[] args) {
        long maxNumber = 10000000;

        long startTime = System.currentTimeMillis();

        long count = LongStream.rangeClosed(2, maxNumber)
                .parallel()
                .filter(n -> LongStream.rangeClosed(2, (long)Math.sqrt(n))
                        .noneMatch(d -> n % d == 0))
                .count();

        long endTime = System.currentTimeMillis();

        System.out.println("Found " + count + " prime numbers in " + (endTime - startTime) + " ms");
    }
}