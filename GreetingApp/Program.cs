namespace GreetingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the total number of your enrolled courses: ");
            int Courses;
            Courses = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the price of your favorite book: ");
            Double Price;
            Price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Total of enrolled courses: " + Courses);
            Console.WriteLine("Price of my favorite book " + Price);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}