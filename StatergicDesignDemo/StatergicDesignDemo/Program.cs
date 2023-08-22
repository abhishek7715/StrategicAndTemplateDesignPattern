using StatergicDesignDemo.Model;

namespace StatergicDesignDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TravelPlanner travelPlanner = new TravelPlanner();
            travelPlanner.SetStartegy(new Car());
            travelPlanner.Drive(1100);
        }
    }
}