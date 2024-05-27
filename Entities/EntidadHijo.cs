using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntitiesAreGrowing.Entities;

public class EntidadHijo
{


    public string Nombre {get; set;}

    public int Edad {get; set;}

    public bool EsAdulto{get; set;}


    public EntidadHijo(string nombre)
    {
        Nombre = nombre;
        Edad = 0;

        EsAdulto = false;
        
    }



    public async Task EnvejecerAsync(){

        while(Edad < 18){

            await Task.Delay(1000);

            Edad ++;

            Console.WriteLine($"{Nombre} ha envejecido a {Edad} años");


            if(Edad >= 18){

                EsAdulto = true;

                Console.WriteLine($"{Nombre} ahora es adulto y puede reproducirse");
            }
        }
    }

    





    
}
