namespace ObjectInitializer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car
            {
                Make = "Ford",
                Model = "Mustang",
                Engine = new Engine { HorsePower = 450 }
            };

        }
    }

    public class Engine
    {
        public int HorsePower { get; set; }
    }

    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public Engine Engine { get; set; }
    }


}
