// namespace Garage -----FIRST EXERCISE--Inheritence
// {
//     class Program
//     {
//         static void Main(string[] args) 
//         {
//             Zero fxs = new Zero(); // this is an instance of the vehicle object
//             Tesla modelS = new Tesla();
//             Cessna mx410 = new Cessna();
//             Ram promaster = new Ram();

//             fxs.Drive();//calls the method of drive from vehicle.cs
//             modelS.Drive();
//             mx410.Drive();
//             promaster.Drive();

//             fxs.Stop();//calls the method of stop from vehicle.cs
//             modelS.Stop();
//             mx410.Stop();
//             promaster.Stop();

//             modelS.MainColor= "blue";//gives value to the color property for Tesla.
//             promaster.MainColor= "purple";
//         }
//     }
// }

namespace Garage
{
    class Program
    {
        static void Main (string[] args)
        {
            Zero fxs = new Zero();//creates 3 electric vehicles
            Zero fx = new Zero();
            Tesla modelS = new Tesla();

            List<IElectric> electricVehicles = new List<IElectric>() {//Puts the elec vehicles in a list
                fx, fxs, modelS
            };

            Console.WriteLine("Electric Vehicles");
            foreach(IElectric ev in electricVehicles) //Loops thru list of electic vehicles. 
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");//prints current charge % of each vehicle.
            }

            foreach(IElectric ev in electricVehicles)// loops thru the vehicles and updates the charge to 100
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            foreach(IElectric ev in electricVehicles)//loops thru again and prints the current charge. 
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            /***********************************************/

            Ram ram = new Ram ();//create 2 gas vehicles
            Cessna cessna150 = new Cessna ();

            List<IGas> gasVehicles = new List<IGas>() { //list of gas vehicles.
                ram, cessna150
            };

            Console.WriteLine("Gas Vehicles");
            
            foreach(IGas gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }

            foreach(IGas gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            foreach(IGas gv in gasVehicles)
            {
                gv.Drive();
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }
        }
    }
}


