using System;

public struct EstacionDelAnio
{
    public string Nombre;
    public string[] Meses;

    public EstacionDelAnio(string nombre, string[] meses)
    {
        Nombre = nombre;
        Meses = meses;
    }

}


public class Program
{
    public static void Main()
    {
        EstacionDelAnio[] estaciones = new EstacionDelAnio[]
        {
            new EstacionDelAnio("Primavera", new string[] { "Marzo","Abril","Mayo" }),
            new EstacionDelAnio("Verano", new string[] {"Junio","Julio","Agosto" }),
            new EstacionDelAnio("Otonio", new string[] { "Septiembre","Octubre","Noviembre" }),
            new EstacionDelAnio("Invierno", new string[] {"Diciembre","Enero","Febrero" }),
        };       Console.WriteLine("Escribe la estación del año (Primavera, Verano, Otonio, Invierno):");
        string probando = Console.ReadLine();

        EstacionDelAnio estacionSeleccionada = new EstacionDelAnio();

        foreach (var estacion in estaciones)
        {
            if (estacion.Nombre.Equals(probando, StringComparison.OrdinalIgnoreCase))
            {
                estacionSeleccionada = estacion;
                break;
            }
        }

        if (estacionSeleccionada.Nombre == null)
        {
            Console.WriteLine("Estación Inválida. Por favor, ingresa una estación Válida.");

        }

        else 
        
        {
            Console.WriteLine("Los meses de  " + estacionSeleccionada.Nombre + "son:");
            foreach (var mes in estacionSeleccionada.Meses)
            {
                Console.WriteLine(mes);
            }
        
        }
    }

}
