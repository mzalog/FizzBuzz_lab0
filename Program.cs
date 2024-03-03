namespace FizzBuzz_lab0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj gorny zakres:");
            int upperLimit = Convert.ToInt32(Console.ReadLine());
            FizzBuzz fizzBuzz = new FizzBuzz(upperLimit);
            fizzBuzz.Display();
        }
    }
}
