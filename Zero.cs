namespace Garage
{
    public class Zero : Vehicle // Electric motorcycle. Vehicle is a parent class and zero is a child class. Zero inherits the main color and max occup (property) from Vehicle class. 
    {
        public double BatteryKWh { get; set; }
        public void ChargeBattery()
        {
            // method definition omitted
        }
        public override void Drive()//overides the drive method in the parent class(Vehicle) so that Zero can make it's own sound. 
        {
            Console.WriteLine("Vroom-Vroom-Vroom!");
        }
    }
}