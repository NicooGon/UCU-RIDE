using System;
using System.Collections;
using Library;

namespace Program;
class Program
{
    static void Main(string[] args)
    {
        Persona pasajero1 = new Pasajero("Ignacio", "Rodriguez", "54211450","3.0");
        Persona pasajero2 = new Pasajero("Nicolas", "Gonzalez", "51199460","4.0");
        Persona pasajero3 = new Pasajero("Guillermo", "Mourelle", "55569870","4.0");
        Persona conductorPool1 = new ConductorPool("Valentin","Hernandez","53378910","5.0",3);
        Persona conductor = new Conductor("Joaquin","Scarone","5332220","4.0");
        
        UcuRideShare rideShare = new UcuRideShare();
        
        rideShare.Add(conductor);
        
        rideShare.Add(conductorPool1);
        
        rideShare.Add(pasajero1);
        
        rideShare.Add(pasajero2);
        
        rideShare.Add(pasajero3);
    }
}

