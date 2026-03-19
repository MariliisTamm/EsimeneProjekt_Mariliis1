using System;

namespace EsimeneProjekt.Vehicles
{
    public class Car : Vehicle
    {
        public int BootVolume { get; set; }
        public int SeatCount { get; set; }

        public Car(string model, CarMark mark, string plate, string colour, decimal unloadedWeight, List<string> equiptment) : base(model, mark, plate, colour, unloadedWeight, equiptment)
        {

        }
    }
}
