namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            IVehicle vehicle1 = VehicleFactory.GetVehicle("Wheels");
            IVehicle vehicle2 = VehicleFactory.GetVehicle("2");
        }
    }
}
