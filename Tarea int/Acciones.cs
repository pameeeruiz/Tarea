using System.Collections.Generic;
using System.Linq;
using System.IO;
using System;

public class Acciones
{
    private List<int> Edades  = new List<int>();

    // Agregar edad a la lista
    public void AgregarEdad()
    {
        Console.WriteLine("Ingrese una edad para agregar:");
        int edad =Convert.ToInt32(Console.ReadLine());
        Edades.Add(edad);
        Console.WriteLine($"Edad {edad} agregada.");
    }

    // Eliminar una edad por índice o por valor, validando existencia y mostrando mensaje si no existe
    public void EliminarEdad()
    {
        Console.WriteLine("¿Cómo desea eliminar?");
        Console.WriteLine("1. Por índice");
        Console.WriteLine("2. Por valor");
        Console.Write("Seleccione una opción (1 o 2): ");
        string opcion = Console.ReadLine();

        if (opcion == "1")
        {
            Console.Write("Ingrese el índice a eliminar: ");
            if (int.TryParse(Console.ReadLine(), out int indice))
            {
                if (indice >= 0 && indice < Edades.Count)
                {
                    Edades.RemoveAt(indice);
                }
                else
                {
                    Console.WriteLine("El índice no existe.");
                }
            }
            else
            {
                Console.WriteLine("Índice no válido.");
            }
        }
        else if (opcion == "2")
        {
            Console.Write("Ingrese el valor de edad a eliminar: ");
            if (int.TryParse(Console.ReadLine(), out int valor))
            {
                if (Edades.Contains(valor))
                {
                    Edades.Remove(valor);
                    Console.WriteLine("El valor se elimino exitosamente...");
                }
                else
                {
                    Console.WriteLine("El valor no existe en la lista.");
                }
            }
            else
            {
                Console.WriteLine("Valor no válido.");
            }
        }
        else
        {
            Console.WriteLine("Opción no válida.");
        }
    }

    // Actualizar una edad existente 
    public void ActualizarEdad()
    {
        Console.Write("Ingrese la edad que desea actualizar: ");
        if (!int.TryParse(Console.ReadLine(), out int edadActual))
        {
            Console.WriteLine("Edad no válida.");
            return;
        }

        Console.Write("Ingrese la nueva edad: ");
        if (!int.TryParse(Console.ReadLine(), out int nuevaEdad))
        {
            Console.WriteLine("Nueva edad no válida.");
            return;
        }

        int index = Edades.IndexOf(edadActual);
        if (index != -1)
        {
            Edades[index] = nuevaEdad;
            Console.WriteLine("Edad actualizada correctamente.");
        }
        else
        {
            Console.WriteLine("La edad no se encontró en la lista.");
        }

    }

    // Consultar todas las edades registradas
    public void ConsultarEdades()
    {
        Console.WriteLine("Las edades son:");
        foreach (var edad in Edades)
        {
            Console.WriteLine(edad);
        }
    }

    // Ordenar la lista de menor a mayor y mostrar las edades ordenadas en consola
    public void OrdenarEdades()
    {
        Edades.Sort();
        Console.WriteLine("Las edades ordenadas son:");
        foreach (var edad in Edades)
        {
            Console.WriteLine(edad);
        }
    }

    // Calcular la suma de todas las edades usando .Sum()
    public int SumarEdades()
    {
        return Edades.Sum();
    }

    // Calcular el promedio de las edades usando .Average()
    public double PromedioEdades()
    {
        if (Edades.Count == 0)
            return 0;
        return Edades.Average();
    }

    // Exportar la lista de edades a un archivo edades.txt en el escritorio y mostrar el contenido exportado
    public void ExportarEdades()
    {
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string rutaArchivo = Path.Combine(desktopPath, "edades.txt");
        File.WriteAllLines(rutaArchivo, Edades.ConvertAll(e => e.ToString()));
        Console.WriteLine("Edades exportadas correctamente. El contenido del archivo es:");
        string[] lineas = File.ReadAllLines(rutaArchivo);
        foreach (var linea in lineas)
        {
            Console.WriteLine(linea);
        }
        Console.WriteLine($"Ruta del archivo exportado: {rutaArchivo}");
    }
}