using System;
using System.Collections;

using Ucu.Poo.Twitter;
namespace Program;
    class Program
    {
        static void Main(string[] args)
        {
            Pasajero pasajero1 =new Pasajero("Ignacio", "Rodriguez", "54211450","3.0");
            Pasajero pasajero2 =new Pasajero("Nicolas", "Gonzalez", "51199460","4.0");
            Pasajero pasajero3 =new Pasajero("Guillermo", "Mourelle", "55569870","4.0");
            ConductorPool conductorPool1= new ConductorPool("Valentin","Hernandez","53378910","5.0",3);
            Conductor conductor= new Conductor("Joaquin","Scarone","5332220","4.0");
            /*
            En éste método deberas mostrar un ejemplo de funcionamiento de tu programa. A continuación te 
            planteamos un ejemplo de como hacerlo. Esto no significa que te limites a hacer solamente esto, debes pensar 
            en grande!

            Usuario pasajero1 = nuevo Pasajero()
            Usuario pasajero2 = nuevo Pasajero()
            Usuario pasajero3 = nuevo Pasajero()
            Usuario conductor1 = nuevo Conductor()
            Usuario conductorPool1 = nuevo ConductorPool(maxPasajeros = 3)
            UcuRideShare rideShare = nuevo UcuRideShare()
            
        
            rideShare.Add(conductor1)
            Se publica en Twitter un nuevo conductor!

            rideShare.Add(conductorPool1)
            Se publica en Twitter un nuevo conductor!
            
            rideShare.Add(pasajero1)
            Se publica en Twitter nuevo registro de pasajero!
            
            rideShare.Add(pasajero2)
            Se publica en Twitter nuevo registro de pasajero!

            rideShare.Add(pasajero3)
            Se publica en Twitter nuevo registro de pasajero!

            */
        }
    }

