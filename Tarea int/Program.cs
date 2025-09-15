using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_int
{
    public enum OpcionesMenu
    {
        AgregarEdad=1,
        EliminarEdad,
        ActualizarEdad,
        ConsultarEdades,
        OrdenarEdades,
        SumarEdades,
        PromedioEdades,
        ExportarEdades,
        Salir
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenid@");
            Alumnos alumno = new Alumnos("Pamela Ruiz", 18, "Ingeniería en Sistemas");
            alumno.MostrarInfo();

            Acciones acciones = new Acciones();

            while (true)
            {
                OpcionesMenu opcion = MostrarMenu();
                switch (opcion)
                {
                    case OpcionesMenu.AgregarEdad:
                        acciones.AgregarEdad();
                        break;
                    case OpcionesMenu.EliminarEdad:
                        acciones.EliminarEdad();
                        break;
                    case OpcionesMenu.ActualizarEdad:
                        acciones.ActualizarEdad();
                        break;
                    case OpcionesMenu.ConsultarEdades:
                        acciones.ConsultarEdades();
                        break;
                    case OpcionesMenu.OrdenarEdades:
                        acciones.OrdenarEdades();
                        Console.WriteLine("Edades ordenadas correctamente.");
                        break;
                    case OpcionesMenu.SumarEdades:
                        int suma = acciones.SumarEdades();
                        Console.WriteLine($"La suma de las edades es: {suma}");
                        break;
                    case OpcionesMenu.PromedioEdades:
                        double promedio = acciones.PromedioEdades();
                        Console.WriteLine($"El promedio de las edades es: {promedio:F2}");
                        break;
                    case OpcionesMenu.ExportarEdades:
                        acciones.ExportarEdades();
                        Console.WriteLine("Edades exportadas correctamente.");
                        break;
                    case OpcionesMenu.Salir:
                        Console.WriteLine("Gracias por usar el programa...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            }
        }

        static OpcionesMenu MostrarMenu()
        {
            Console.WriteLine("----- MENÚ -----");
            Console.WriteLine("1. Agregar Edad");
            Console.WriteLine("2. Eliminar Edad");
            Console.WriteLine("3. Actualizar Edad");
            Console.WriteLine("4. Consultar Edades");
            Console.WriteLine("5. Ordenar Edades");
            Console.WriteLine("6. Sumar Edades");
            Console.WriteLine("7. Promedio Edades");
            Console.WriteLine("8. Exportar Edades");
            Console.WriteLine("9. Salir");
            Console.WriteLine("----------------");
            Console.Write("Seleccione una opción: ");
            string entrada = Console.ReadLine();
            int opcion;
            if (!int.TryParse(entrada, out opcion) || opcion < 1 || opcion > 9)
            {
                Console.WriteLine("Opción no válida. Intente de nuevo.");
                return OpcionesMenu.Salir; // Para evitar errores, puedes retornar Salir o un valor por defecto
            }
            return (OpcionesMenu)opcion;
        }
    }
}
