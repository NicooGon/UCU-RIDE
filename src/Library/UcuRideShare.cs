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
        twitter.PublishToTwitter("text", @"PathToImage.png");
    }
}
