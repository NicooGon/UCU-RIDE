using System;

namespace Ucu.Poo.Twitter;

public class Conductor : Persona
{
    public void Biografia()
    {
        Console.WriteLine($"Biografia del conductor\nNombre : {this.name}\nApellido : {this.surname}\nCedula : {this.CI}\nCalificacion del conductor : {this.Calificacion}");
    }
}