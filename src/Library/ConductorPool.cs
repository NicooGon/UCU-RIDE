using System;

namespace Library;

public class ConductorPool : Persona
{
    public int Capacidad {get; set;}
    public ConductorPool(string name, string surname, string CI, string calificacion, int capacidad)
    {
        this.Name = name;
        this.Surname = surname;
        this.CI = CI;
        this.Calificacion = calificacion;
        this.Capacidad = capacidad;
        Vehiculo vehiculo = new Vehiculo(this.Capacidad);
    }
    public void Biografia()
    {
        Console.WriteLine($"Biografia del conductor Pool\nNombre : {this.Name}\nApellido : {this.Surname}\nCedula : {this.CI}\nCalificacion del conductor : {this.Calificacion}");
    }
}