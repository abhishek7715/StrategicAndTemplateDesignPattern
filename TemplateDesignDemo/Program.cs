using TemplateDesignDemo.Model;

namespace TemplateDesignDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AlgorithamTemplate algorithm = new ConcreteAlgorithm();
            algorithm.ExecuteAlgorithm();
        }
    }
}