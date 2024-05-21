namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Car car1= new Car();
            car1.WheelCount = 6;
            car1.Color = "Green";
            car1.FuelCapacity = 200;
            car1.FuelPerKm = 5;
            car1.Drive(10);
            car1.ShowFullData();
            Console.WriteLine(car1.GetFullData());  
        }
    }
}   