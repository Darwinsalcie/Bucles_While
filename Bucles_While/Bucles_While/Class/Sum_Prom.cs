

namespace SumProm.Class
{

    class Sumaypromedio {
        
        public void sumarypromediar()
        {
            int suma = 0, valor;
            int contador = 0;
            float promedio = 0.0f;
            int numcant = 10;
           
            while (contador < numcant) {

                Console.Write("Ingrese un valor: ");
                valor = int.Parse(Console.ReadLine());
                suma += valor;
                contador++;
            }
            promedio = (float)suma / (float)numcant;

            Console.WriteLine("La suma de los valores ingresados es: " + suma);
            Console.WriteLine("El promedio es: " + (promedio));

        }

    }

}
