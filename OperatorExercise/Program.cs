namespace OperatorExercise
{
    public class Program
    {
        public static double AreaOfCircle (double radius)
        {
            return Math.PI * Math.Pow (radius, 2);  
        }

        public static void PrintAreaOfCircle()
        {
            Console.WriteLine("what is the radius of the circle?");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"The area of the circle with a radius of {radius} is {Math.Round(AreaOfCircle(radius), 2)}");
        }     
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4; 
            
            int addition = a + b;
            int subtraction = a - b;
            int multiplication = a * b;
            int division = a / b;
            int remainder = a % b;

            Console.WriteLine($"{a}/ {b} is the {division} remainder {remainder}"); 

            PrintAreaOfCircle();
        }
    }
}
