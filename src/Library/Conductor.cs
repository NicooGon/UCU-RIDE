using System;

namespace Ucu.Poo.Twitter;

public class Conductor : Persona
{
    public Conductor(string name, string surname, string CI, string calificacion)
    {
        this.Name = name;
        this.Surname = surname;
        this.CI = CI;
        this.Calificacion = Calificacion;
    }
    public void Biografia()
    {
        Console.WriteLine($"Biografia del conductor\nNombre : {this.Name}\nApellido : {this.Surname}\nCedula : {this.CI}\nCalificacion del conductor : {this.Calificacion}");
    }
}