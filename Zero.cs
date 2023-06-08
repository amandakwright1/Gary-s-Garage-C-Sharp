namespace Garage
{
    public class Zero : Vehicle, IElectric // Electric motorcycle. Vehicle is a parent class and zero is a child class. Zero inherits the main color and max occup (property) from Vehicle class. 
    {
        public double BatteryKWh { get; set; }
        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }

        public double CurrentChargePercentage {get;set;} = 60;
        public override void Drive()//overides the drive method in the parent class(Vehicle) so that Zero can make it's own sound. 
        {
            Console.WriteLine("Vroom-Vroom-Vroom!");
        }
    }
}