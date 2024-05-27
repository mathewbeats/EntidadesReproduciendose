

using EntitiesAreGrowing.Entities;

public class Program
{

    private static readonly Random random = new Random();

    public static async Task Main(string[] args)
    {
        // Crear entidades padres
        var entidad1 = new EntidadPadre("MonstruoA");
        var entidad2 = new EntidadPadre("MonstruoB");

        // Crear tareas de reproducción
        var tareasReproduccion = new List<Task>
        {
            entidad1.ReproducirAsync(entidad2)
        };

        // Esperar a que todas las tareas de reproducción se completen
        await Task.WhenAll(tareasReproduccion);

        // Crear tareas de envejecimiento para los hijos
        var tareasEnvejecimiento = entidad1.entidadHijos.Concat(entidad2.entidadHijos)
                                                  .Distinct()
                                                  .Select(hijo => hijo.EnvejecerAsync())
                                                  .ToList();

        // Esperar a que todos los hijos envejezcan
        await Task.WhenAll(tareasEnvejecimiento);

        // Mostrar el resultado final
        Console.WriteLine($"{entidad1.Nombre} tiene {entidad1.entidadHijos.Count} hijos.");
        Console.WriteLine($"{entidad2.Nombre} tiene {entidad2.entidadHijos.Count} hijos.");

        foreach (var hijo in entidad1.entidadHijos)
        {
            Console.WriteLine($"Hijo: {hijo.Nombre}, Edad: {hijo.Edad}, Adulto: {hijo.EsAdulto}");
        }
    }
}