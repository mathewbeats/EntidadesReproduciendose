using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntitiesAreGrowing.Entities;

public class EntidadPadre
{

    public string Nombre {get; set;}

    public int Edad {get; set;}

    public List<EntidadHijo> entidadHijos {get; private set;}

    private static readonly Random random = new Random();


    public EntidadPadre(string nombre)
    {

        Nombre = nombre;
        Edad = random.Next(20, 50);
        entidadHijos = new List<EntidadHijo>();

        
    }


    public async Task ReproducirAsync(EntidadPadre pareja){


        Console.WriteLine($"{this.Nombre} y {pareja.Nombre} estan intentando reproducirse...");

        await Task.Delay(random.Next(1000, 5000));

        //generar un hijo

        var hijo = new EntidadHijo($"{Nombre}-{pareja.Nombre}-Hijo-{random.Next(1, 1000)}");

        entidadHijos.Add(hijo);

        pareja.entidadHijos.Add(hijo);

        Console.WriteLine($"Nuevo hijo creado  {hijo.Nombre}");


    }

    
}
