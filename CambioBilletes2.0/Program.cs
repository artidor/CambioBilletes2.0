using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CambioBilletes2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa el billete");
            int monto;
            monto = Convert.ToInt32(Console.ReadLine());
            List<int> lista = new List<int>() { 2000, 1000, 500, 100, 50, 25, 10, 5, 1 };
            List<string> devuelta = new List<string>();
            int division = 0;
            int restante = 0;
            int contador = 0;

            for (int i = 0; i < lista.Count; i++)
            {
                if (contador > 0)
                {
                    division = restante / lista[i];
                    restante = restante - (division * Convert.ToInt32(lista[i]));
                }
                else
                {
                    division = monto / lista[i];
                    restante = monto - (division * Convert.ToInt32(lista[i]));
                }
                contador++;
                devuelta.Add(division + " " + lista[i].ToString());
            }

            foreach (var item in devuelta)
            {

                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
