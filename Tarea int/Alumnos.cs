using System;

public class Alumnos
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Carrera { get; set;}

    public Alumnos(string nombre, int edad, string carrera)
    {
        Nombre = nombre;
        Edad = edad;
        Carrera = carrera;
    }

    public void MostrarInfo()
    {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Edad: {Edad}");
        Console.WriteLine($"Carrera: {Carrera}");
    }
}