using System;
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
            string txt = "El unicornio es una es una criatura mitologica representada habitualmente " +
                "como un caballo blanco con patas de antilope, barba de chivo y un cuerno en la frente.";
            string txt1 = "El unicornio es una criatura mitologica representada habitualmente " +
                "como un caballo blanco con patas de antilope, barba de chivo y un cuerno en la frente. " +
                "En las representaciones modernas, sin embargo, es identico a un caballo, " +
                "solo diferenciandose en la existencia del cuerno mencionado. El unicornio es " +
                "protagonista de numerosas historias y leyendas. En la edad media significaba fuerza" +
                " y estaba considerado como un animal fabuloso capaz de derrotar a animales mas fuertes " +
                "fisicamente, incluso elefantes. Existen tres hipotesis que intentan explicar la aparicion " +
                "de la leyenda del unicornio en europa: la primera procede de las exploraciones griega, romana " +
                "y macedonia en la india: existian relatos de criaturas de un solo cuerno, probablemente" +
                " rinocerontes indicos. Si el hipopotamo fue llamado caballo de rio por los exploradores griegos, " +
                "parece verosimil suponer que igualmente describirian a un rinoceronte indio como un caballo con un" +
                " cuerno sobre la cabeza. La segunda proviene de los pueblos vikingos que comerciaban en el interior " +
                "de europa dientes de narval las primeras representaciones artisticas conocidas de este cetaceo en el" +
                " interior de europa eran similares a un unicornio marino. Muy probablemente, y puesto que el mito esta" +
                " documentado desde la antigua grecia, los pueblos nordicos tan solo aprovecharon la leyenda preexistente" +
                " para vender colmillos de narval como si fueran cuernos de unicornio, asociados a todo tipo" +
                " de propiedades curativas. Los duendes son criaturas mitologicas fantasticas de forma humanoide" +
                " pero del tamano de un niño pequeno que estan presentes en el folclore de muchas culturas." +
                " La etimologia de su nombre proviene de la expresion duen de casa o dueno de casa, por el " +
                "caracter de los duendes al apoderarse de los hogares y encantarlos, o bien del arabe duar " +
                "de la casa que habita, habitante en castilla y leon la palabra duende define a un tipo " +
                "de ser sobrenatural de la cultura popular equivalente al goblin de otros folclores europeos" +
                " del frances normando gobelin, nombre originado en el de un fantasma que se decia asolo el " +
                "pueblo de evreux en el siglo XII,​ de naturaleza maliciosa hacia los humanos.";

            Markov markov = new Markov(txt1);
        }
    }
}
