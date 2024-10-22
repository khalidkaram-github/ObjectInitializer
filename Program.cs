namespace ObjectInitializer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region By Constructor

            var myCar = new Car();
            myCar.Make = "Ford";
            myCar.Model = "Mustang";
            myCar.Engine = new Engine();
            myCar.Engine.HorsePower = 450;

            #endregion

            #region By ObjectInitializer

            //var myCar = new Car
            //{
            //    Make = "Ford",
            //    Model = "Mustang",
            //    Engine = new Engine { HorsePower = 450 }
            //}; 
            #endregion

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
