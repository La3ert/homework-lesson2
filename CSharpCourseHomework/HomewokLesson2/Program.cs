namespace HomeworkLesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Homework1
            Console.WriteLine("What`s your name?");
            
            string name = Console.ReadLine();
            
            Console.WriteLine($"Hello, {name}");
            
            //Homework2
            Console.WriteLine("Enter two numbers: ");
            
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine($"a = {a}, b = {b}");
            
            (a, b) = (b, a);
            
            Console.WriteLine($"a = {a}, b = {b}");

            //Homework3
            Console.WriteLine("Enter number: ");
            
            int number = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(number.ToString().Length);
            
            //Heron's formula
            Console.WriteLine("Enter the length of the sides of the triangle");
            double AB = Convert.ToDouble(Console.ReadLine());
            double BC = Convert.ToDouble(Console.ReadLine());
            double CA = Convert.ToDouble(Console.ReadLine());

            double p = (AB + BC + CA) / 2;
            double S = Math.Sqrt(p*(p-AB)*(p-BC)*(p-CA));
            Console.WriteLine($"The square of a triangle {S}");
            
            //User profile
            Console.WriteLine("Enter tour last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter your first name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter your age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your weight in kilograms");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your height in meters");
            double height = double.Parse(Console.ReadLine());

            double BMI = weight / (height * height);

            Console.WriteLine($"Your profile:\n" +
                              $"Full name: {lastName} {firstName}\n" +
                              $"Age: {age}\n" +
                              $"Weight: {weight}\n" +
                              $"Height: {height}\n" +
                              $"Body Mass Index: {BMI}");
        }
    }   
}