using System;

namespace Prog_Assignment
{
    public class Car 
    {
        //These are private fields 
        private string _Colour;
        private string _Make;
        private string _Gearbox;

        public string GetColour() 
        {
            return _Colour;
            
        }

        //Gets colour than changes the _Colour value to col which get its value from colour_input 
        public void SetColour(string col) 
        {
            _Colour = col;
        }

        public string GetMake() {
            return _Make;
        }

        public void SetMake(string mk)
        {
            _Make = mk;
        }

        public string GetGearbox() {
            return _Gearbox;
        }

        public void SetGearbox(string gbox)
        {
            _Gearbox = gbox;
        }

        //This method describes the car
        public string DescribeCar() 
        {
            return $"This car is a {GetColour()} {GetMake()} with a {GetGearbox()} transmission";
        }
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            //Start the program with Clear();
            Console.Clear();


            var user = new Car();

            Console.WriteLine("******************************************************");
            Console.WriteLine("************ ENTER NEW CAR DETAILS BELOW *************");
            Console.WriteLine("******************************************************");
            Console.Write(">> Colour: ");
            var colour_input = Console.ReadLine();
            Console.WriteLine("******************************************************");
            Console.Write(">> Make: ");
            var make_input = Console.ReadLine();
            Console.WriteLine("******************************************************");
            Console.Write(">> Gearbox: ");
            var gearbox_input = Console.ReadLine();
            
            //These set all of the input values to each selected Method
            user.SetColour(colour_input);
            user.SetMake(make_input);
            user.SetGearbox(gearbox_input);

            Console.WriteLine("******************************************************");
            //This is then called that describes the car
            Console.WriteLine(user.DescribeCar());
            Console.WriteLine("******************************************************");



            //End the program with blank line and instructions
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Press <Enter> to quit the program");
            Console.ReadKey();
        }
    }
}
