

using System.Security.Cryptography.X509Certificates;

namespace EsimeneProjekt.Vehicles
{
    public class Truck : Vehicle
    {
        public int Mass { get; set; }
        public int Load { get; set; }

        public Truck(string model, CarMark mark, string plate, string colour, decimal unloadedWeight, List<string> equiptment) : base(model, mark, plate, colour, unloadedWeight, equiptment)
        {
        }
    }
}
