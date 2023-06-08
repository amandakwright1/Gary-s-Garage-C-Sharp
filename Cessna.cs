namespace Garage
{
    public class Cessna : Vehicle, IGas // Propellor light aircraft. Vehicle is a parent class and Cessna is a child class. Zero inherits the main color and max occup (property) from Vehicle class. 
    {
        public double FuelCapacity {get;set;}
        
        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }
        public double CurrentTankPercentage { get; set;} = 32;
         public override void Drive()//overides the drive method in the parent class so that Cessna can make it's own sound. 
        {
            Console.WriteLine("Zoooooom!");
        }
         public override void Stop()//overides the drive method in the parent class so that Cessna can make it's own stop message. 
        {
            Console.WriteLine("The white Cessna rolls to a stop after rolling a mile down the runway.");
        }
    }
}