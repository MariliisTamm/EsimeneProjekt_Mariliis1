using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsimeneProjekt.Vehicles
{
    internal class Train : Vehicle
    {
        public int Wagons { get; set; }
        public int TrainSpeed { get; set; }
        public bool HasCatering { get; set; }
        public Train(string model, CarMark mark, string plate, string colour, decimal unloadedWeight, List<string> equiptment) : base(model, mark, plate, colour, unloadedWeight, equiptment)
        {
        }

        public override string GetInfo()
        {
            return $"This is a {Mark} {Model}, it is {Colour} color and weighs" +
                   $" {Wagons} \ncatering avalible {HasCatering}" + $" goes that fast {TrainSpeed} ";

        }
    }
}
