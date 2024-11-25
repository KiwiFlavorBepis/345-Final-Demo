class Program {

    //Syntax Examples
    //Assignment
    string example = "example";
    int[] list = [1, 2, 3];
    //Function
    void printSum(int a, int b) {
        Console.WriteLine(a + b);
    }
    string echo(string message) {
        return message;
    }

    //Classes and construction
    class Animal {
        private string sound;
        public Animal(string sound) {
            this.sound = sound;
        }
       public void speak() {
            Console.WriteLine(sound);
        }
    }
    class Dog : Animal {
        public Dog(string sound) : base(sound) { }
    }

   

    static void Main(string[] args) {
        Console.WriteLine("Hello, World!");

        //Control Examples
        //If and else
        bool boolean = true;
        if (boolean) {
            Console.WriteLine("True!");
        } else {
            Console.WriteLine("False!");
        }
        //Switch
        int selector = 1;
        switch (selector) {
            case 1:
                Console.WriteLine("Case 1");
                break;
            case 2:
                Console.WriteLine("Case 2");
                break;
            case 3:
                Console.WriteLine("Case 3");
                break;
            default:
                Console.WriteLine("Invalid Case!");
                break;
        }

        //For
        for (int i = 0; i < 10; i++) {
            Console.WriteLine(i);
        }
        //While and do-while
        int count = 0;
        while (count < 10) {
            Console.WriteLine(count);
            count++;
        }
        do {
            Console.WriteLine(count);
            count--;
        } while (count > 0);
        
        //Goto
        myLabel:
        Console.WriteLine("Went to label");
        count++;
        if (count < 5) goto myLabel;
        Console.WriteLine(count);

        //Lambda Expressions
        List<int> numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        List<int> evenNumbers = numbers.Where(x => x % 2 == 0).ToList();
        evenNumbers.ForEach(x => Console.WriteLine(x));

        //Higher-Order Function
        Func<int, int, int> add = (x, y) => x + y;
        Console.WriteLine(add(5, 8));

        //LINQ
        var queryEvens = from x in numbers
                         where x % 2 == 0
                         select x;
        Console.WriteLine(queryEvens.Count<int>());
    }
    
}