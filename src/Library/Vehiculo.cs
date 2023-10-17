using System;

namespace Library;

public class Vehiculo
{
    public int Capacidad { get; set;}

    public Vehiculo()
    {
        this.Capacidad = 1;
    }
    public Vehiculo(int capacidad)
    {
        this.Capacidad = capacidad;
    }
}