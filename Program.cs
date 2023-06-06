namespace Garage
{
    class Program
    {
        static void Main(string[] args) 
        {
            Zero fxs = new Zero(); // this is an instance of the vehicle object
            Tesla modelS = new Tesla();
            Cessna mx410 = new Cessna();
            Ram promaster = new Ram();

            fxs.Drive();//calls the method of drive from vehicle.cs
            modelS.Drive();
            mx410.Drive();
            promaster.Drive();

            fxs.Stop();//calls the method of stop from vehicle.cs
            modelS.Stop();
            mx410.Stop();
            promaster.Stop();

            modelS.MainColor= "blue";//gives value to the color property for Tesla.
            promaster.MainColor= "purple";
        }
    }
}


