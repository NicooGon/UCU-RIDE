using System;

namespace Ucu.Poo.Twitter;

public class ConductorPool : Persona
{
    public void Biografia()
    {
        Console.WriteLine($"Biografia del conductor Pool\nNombre : {this.name}\nApellido : {this.surname}\nCedula : {this.CI}\nCalificacion del conductor : {this.Clasificacion}");
    }
}