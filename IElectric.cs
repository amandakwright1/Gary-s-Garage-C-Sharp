namespace Garage
{
public interface IElectric
{
    void ChargeBattery();
    double CurrentChargePercentage { get; set;}
   
}
}
