namespace Garage
{
    public class Vehicle //parent class that holds the property of main color and max occup for the children classes to inherit.
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

         public virtual void Drive()//virtual means the method can be overridden by the children(vehicle types). 
        {
            Console.WriteLine("Vrooom!");
        }
        public virtual void Stop()//virtual means the method can be overridden by the child.
        { 
            Console.WriteLine("The vehicle comes to a stop.");
        }

    }
}