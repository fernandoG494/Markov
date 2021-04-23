﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Markov;

namespace Markov
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t === Markov chains ===");
            string txt1 = "El unicornio es una criatura mitologica representada habitualmente " +
                "como un caballo blanco con patas de antilope, barba de chivo y un cuerno en la frente. " +
                "En las representaciones modernas, sin embargo, es identico a un caballo, " +
                "solo diferenciandose en la existencia del cuerno mencionado. El unicornio es " +
                "protagonista de numerosas historias y leyendas. En la Edad Media significaba fuerza" +
                " y estaba considerado como un animal fabuloso capaz de derrotar a animales mas fuertes " +
                "fisicamente, incluso elefantes. Existen tres hipotesis que intentan explicar la aparicion " +
                "de la leyenda del unicornio en Europa: La primera procede de las exploraciones griega, romana " +
                "y macedonia en la India: existian relatos de criaturas de un solo cuerno, probablemente" +
                " rinocerontes indicos. Si el hipopotamo fue llamado caballo de rio por los exploradores griegos, " +
                "parece verosimil suponer que igualmente describirian a un rinoceronte indio como un caballo con un" +
                " cuerno sobre la cabeza. La segunda proviene de los pueblos vikingos que comerciaban en el interior " +
                "de Europa dientes de narval las primeras representaciones artisticas conocidas de este cetaceo en el" +
                " interior de Europa eran similares a un unicornio marino. Muy probablemente, y puesto que el mito esta" +
                " documentado desde la antigua Grecia, los pueblos nordicos tan solo aprovecharon la leyenda preexistente" +
                " para vender colmillos de narval como si fueran cuernos de unicornio, asociados a todo tipo" +
                " de propiedades curativas. Los duendes son criaturas mitologicas fantasticas de forma humanoide" +
                " pero del tamano de un nino pequeno que estan presentes en el folclore de muchas culturas." +
                " La etimologia de su nombre proviene de la expresion duen de casa o dueno de casa, por el " +
                "caracter de los duendes al apoderarse de los hogares y encantarlos, o bien del arabe duar " +
                "de la casa que habita, habitante En Castilla y Leon la palabra duende define a un tipo " +
                "de ser sobrenatural de la cultura popular equivalente al goblin de otros folclores europeos" +
                " del frances normando gobelin, nombre originado en el de un fantasma que se decia asolo el " +
                "pueblo de Evreux en el siglo XII,​ de naturaleza maliciosa hacia los humanos.";

            Markov markov = new Markov(txt1);
        }
    }
}
