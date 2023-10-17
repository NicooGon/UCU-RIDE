using System;
using System.Collections.Generic;
using Ucu.Poo.Twitter;

namespace Library;

public class UcuRideShare
{
    public List<Persona> ConductoresPasajeros = new List<Persona>();

    public void Add(Persona persona)
    {
        ConductoresPasajeros.Add(persona);
        var twitter = new TwitterImage();
        if (persona == Conductor conductor)
        {
            twitter.PublishToTwitter("Se publica un nuevo conductor !", @"PathToImage.png");
        }
        if (persona == ConductorPool conductorPool)
        {
            twitter.PublishToTwitter("Se publica un nuevo conductorPool !", @"PathToImage.png");
        }
        if (persona == Pasajero pasajero)
        {
            twitter.PublishToTwitter("Se publica un nuevo pasajero !", @"PathToImage.png");
        }   
    }
}
