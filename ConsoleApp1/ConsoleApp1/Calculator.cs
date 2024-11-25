class CalcTest {
    public delegate int Operation(int x, int y);

    public class Calculator {
        public int add(int x, int y) { return x + y; }
        public int subtract(int x, int y) { return x - y; }

        public void calculate(Operation operation, int a, int b) {
            Console.WriteLine(operation(a, b));
        }
    }

    public static void Main() {
        Calculator calculator = new Calculator();
        calculator.calculate(calculator.add, 2, 3);
    }
}
