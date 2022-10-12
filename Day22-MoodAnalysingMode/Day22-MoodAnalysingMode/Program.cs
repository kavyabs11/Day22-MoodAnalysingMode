namespace Day22_MoodAnalysingMode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to MoodAnalyser MSTesting");
            Console.WriteLine("Enter your mood to check");
            string mood = Console.ReadLine();
            MoodAnalyser obj = new MoodAnalyser(mood);
            Console.WriteLine($"The user mood is {obj.analyseMood()}");
        }
    }
}