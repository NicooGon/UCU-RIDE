using System;

namespace Library;

public class Conductor : Persona
{
    public Conductor(string name, string surname, string CI, string calificacion)
    {
        this.Name = name;
        this.Surname = surname;
        this.CI = CI;
        this.Calificacion = calificacion;
        Vehiculo vehiculo = new Vehiculo();
    }
    public void Biografia()
    {
        Console.WriteLine($"Biografia del conductor\nNombre : {this.Name}\nApellido : {this.Surname}\nCedula : {this.CI}\nCalificacion del conductor : {this.Calificacion}");
    }
}