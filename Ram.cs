namespace Garage
{
    public class Ram : Vehicle // Gas powered truck. Vehicle is a parent class and Ram is a child class. Ram inherits the main color and max occup (property) from Vehicle class. 
    {
        public double FuelCapacity { get; set; }
        
        public void RefuelTank()
        {
            // method definition omitted
        }
        public override void Drive()//overides the drive method in the parent class so that Ram can make it's own sound. 
        {
            Console.WriteLine("Rumble Rumble!");
        }
    }
}