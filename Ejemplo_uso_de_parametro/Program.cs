using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Un ejemplo sencillo que utiliza parámetro.
namespace Ejemplo_uso_de_parametro
{
    //Esta clase contiene el método par, que reibe un parámetro.
    class CheckearNumero
    {
        public bool par(int x)  //Aqui, x es un parámetro entero de par().
        {
            if ((x % 2) == 0) return true;
            else return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CheckearNumero MiChequeo = new CheckearNumero();
            if (MiChequeo.par(10)) Console.WriteLine("10 es par."); //Trasmite el argumento  a par()
            if (MiChequeo.par(9)) Console.WriteLine("9 es par.");
            if (MiChequeo.par(8)) Console.WriteLine("8 es par.");
            Console.ReadKey();

        }
    }
}

/*Los datos de salida generados por el programa son: 
 * 
 * 10 es par.
 * 8 es par.
 * 
 */
