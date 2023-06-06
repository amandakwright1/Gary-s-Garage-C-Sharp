namespace Garage
{
    public class Tesla : Vehicle // Electric car. Vehicle is a parent class and Tesla is a child class. Tesla inherits the main color and max occup (property) from Vehicle class. 
    {
        public double BatteryKWh { get; set; }
     
        public void ChargeBattery()
        {
            // method definition omitted
        }
        public override void Drive()//overides the drive method in the parent class(Vehicle) so that Tesla can make it's own sound. 
        {
            Console.WriteLine("Whiz Whiz!");
        }
    }
}