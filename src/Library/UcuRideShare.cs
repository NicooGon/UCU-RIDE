using System;
using System.Collections.Generic;
using Ucu.Poo.Twitter;
using System.IO;


namespace Library;

public class UcuRideShare
{
    public List<Persona> ConductoresPasajeros = new List<Persona>();

    public void Add(Persona persona)
    {
        ConductoresPasajeros.Add(persona);
        var twitter = new TwitterImage();
        string path = File.Exists(@"../../../../../Downloads/momo.jpg") ? @"../../../../../Downloads/momo.jpg" : @"momo.jpg";
        
        if (persona is Conductor)
        {
            Console.WriteLine(twitter.PublishToTwitter("Se publica un nuevo conductor !", path));
        }
        if (persona is ConductorPool)
        {
            Console.WriteLine(twitter.PublishToTwitter("Se publica un nuevo conductorPool !", path));
        }
        if (persona is Pasajero)
        {
            Console.WriteLine(twitter.PublishToTwitter("Se publica un nuevo pasajero !", path));
        }   
    }
}
