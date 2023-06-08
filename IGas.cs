namespace Garage
{
    public interface IGas : IVehicle
    {
        void RefuelTank();
        double CurrentTankPercentage { get; set;}
    }
}