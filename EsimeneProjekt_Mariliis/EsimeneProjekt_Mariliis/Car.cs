using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsimeneProjekt
{
	public enum CarMark
	{
		Toyota, Ford, Trashla, Subaru, Saab, Volvo, BMW, Mini, Škoda,
	}
	public class Car
	{
		public Car(
			string model,
			CarMark mark,
			string plate,
			string colour,
			decimal unloadedWeight,	//one unit is 1 ton
			List<string> equiptment)
		{
			Model = model;
			Mark = mark;
			LicencePlate = plate;
			Colour = colour;
			EmptyWeyght = unloadedWeight;
			Equiptment = equiptment;
		}
		public string Model { get; set; }
		public CarMark Mark { get; set; }
		public string LicencePlate { get; set; }
		public string Colour { get; set; }
		public decimal EmptyWeight { get; set; } = 0;
		public List<string>? equiptment { get; set; }
		

		public string GetInfo()
		{
			return $"Tis is a {Mark} {Model}, it is {Colour} color and weights {EmptyWeight} Tons. n\License plate number is {LicencePlate}";
		}
		public void SeeEquiptment()
		{
			Console.WriteLine("This car has: ");
			foreach (var thing)
		}
    }
}
