namespace MethodsExercise
{
    public class Program
    {
        public static void MadLib()
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello, {userName}! What is your favorite color?");
            string favColor = Console.ReadLine();
            Console.WriteLine($"Hello, {userName}! What is your favorite animal?");
            string favAnimal = Console.ReadLine();
            Console.WriteLine("Favorite band?");
            string favBand = Console.ReadLine();

            Console.WriteLine($" One day, {userName} heard shrieking sounds coming from the woods, while wearing a  {favColor} hoodie. {userName} saw a {favAnimal} and listening to {favBand}.");
        }


        public static int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        public static int Subtract(int numOne, int numTwo)
        {
            return numOne - numTwo;
        }

        public static int Multiply(int numOne, int numTwo)
        {
            return numOne * numTwo;
        }

        public static int Divide(int numOne, int numTwo)
        {
            return numOne / numTwo;
        }

        public static int Sum(params int[] numbers)
        {
            int sum = 0;

            foreach (int number in numbers)
            {
                //sum = sum + number;
                sum += number;
            }

            return sum;
        }
        
        static void Main(string[] args)
        
        {
            //MadLib();
            //Console.WriteLine(Add(numOne: 2, numTwo: 2));
            //int addedNums = Add(numOne: 2, numTwo: 2);
            //Console.WriteLine(addedNums);
            //Console.WriteLine(Subtract(numOne: 2, numTwo: 2));
            //Console.WriteLine(Multiply(numOne:2, numTwo:2));
            //Console.WriteLine(Divide(numOne: 2, numTwo: 2));
            //Console.WriteLine(Sum(params numbers:5));
        }
    }
}