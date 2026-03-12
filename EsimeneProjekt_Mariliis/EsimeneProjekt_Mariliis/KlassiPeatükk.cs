using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsimeneProjekt	//Nimeruum millises projektis antud kalss on
{
    //Klassi anatoomia:
    //A - klassi enda nimeruum mis sisaldab kõik mis klassil tema töö jaoks vaja on
    //      klassi nimeruum vajab
    //      A.1 - juurdepääsu modifikaatorit
    //      A.2 - sätestust et tegu on klassiga
    //      A.3 - klassi nimi
    //B - Klassi konstruktor defineerib ära spetsiaalse meetodi mis ütleb kuidas selle klassi tüüpi
    //      objekti instantseeritakse. Samamoodi nagu structil saab olla konstructoreid mitu, erinevalt
    //      Struvctist väärtused peab kaasa andma.
    //C - väljad mioda konstruktor ootab neile tuleb väärtus andad välaja arvatud ühel juhul
    //D - klssi omadused. Nende kaudu saab kasutatavas koodis selle klassi tüüpi objekti andmeid kätte,
    //      sdresseerides punktiga, Erinevalt structist vajavad omadused objekti tekitamisel mingit väärtust. Välja arvatud
    //      siis kui omaduse andmetüübi taga on küsimärk mis ütleb, et see omadus võib jääda nulliks D.1
    //Klassiomadusele saab anda bvaikeväärtuse . Vaikeväärtus on midagi mis antakse kaasa selle klassi tüüpiu uuele objektile kaasa,
    //selle objekti tekitamise hetkel, kui ei ole sellele väljake väärtust antud

    //A.1   A.2   A.3
    public class KlassiPeatükk  //A
    {
        public KlassiPeatükk(string värvus, string materjal, double paksus) //B
        {
            Värvus = värvus;        //C
            Materjale = materjal;
            Paksus = paksus;
        }
        public string Värvus? /*D.1*/ {  get; set; }     //D
        public string Materjal { get; set; }
        public double Paksus { get; set; }

        /// <summary>
        /// Returns a formatted string containing information about the material, thickness, and color of the object.
        /// </summary>
        /// <returns>A string that describes the object's material, thickness, and color.</returns>
        
        //E
        public string GetInfo()
        {
            return $"This object is made of {Materjal}, is {Paksus} thick and has color {Värvus}.";
        }
        /// <summary>
        /// Determines whether the specified thickness allows the item to be dremeled.
        /// </summary>
        /// <param name="freesipaksus">The thickness to evaluate, in the same units as the item's thickness. Must be a non-negative value.</param>
        /// <returns>true if the specified thickness is less than the item's thickness; otherwise, false.</returns>
        public bool CanThisBeDremled(double freesipaksus)
        {
            if (freesipaksus < Paksus)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
	}
}
