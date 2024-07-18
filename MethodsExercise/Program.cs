namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //MadLib();

            int added = Add(2, 2);
            Console.WriteLine(added);

            int subtracted = Subtract(10, 5);
            Console.WriteLine(subtracted);

            int multiplied = Multiply(2, 5);
            Console.WriteLine(multiplied);

            int divided = Divide(12, 6);
            Console.WriteLine(divided);


        }
        public static void MadLib()
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello, {userName}! What is your favorite color?");
            string favColor = Console.ReadLine();
            Console.WriteLine("Favorite band?");
            string favBand = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string favAnimal = Console.ReadLine();

            Console.WriteLine($" {userName} walked into a bar and sat by a/an {favAnimal}. A fight eruped because the {favAnimal} was wearing a {favColor} hat, which is a forbidden color in the bar. The {favColor} hat was destroyed in the brawl, but {userName} had a spare hat for the {favAnimal}. The bar patrons raised their glasses and sang along to a song on the jukebox by {favBand}. Cheers!");
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

    }
}
