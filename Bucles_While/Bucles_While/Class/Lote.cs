

namespace Lote.Class
{

    class Piezaslote

    {
        int n = 0;
        float piezasAptas = 0f;
        float longitud = 0f;
        int contador = 0;
        bool exit = false;

        public void clasificarpiezas() {

            while (exit == false)
            {
                try
                {

                    Console.Write("Ingrese la cantidad de piezas a procesar: ");
                    n = int.Parse(Console.ReadLine());
                    exit = true;

                }

                catch (Exception)
                {

                    Console.WriteLine("Solo puede ingresar números enteros");

                }

            }

            while (contador < n)
            {

                try
                {
                    Console.Write("Ingrese la longitud de la pieza: ");
                    longitud = float.Parse(Console.ReadLine());

                }
                
                catch(Exception)
                {
                    Console.WriteLine("Solo puede ingresar números");
                }



                if (longitud >= 1.20 && longitud <= 1.30)
                {

                    piezasAptas++;

                }

                contador++;

            }

            Console.WriteLine("La cantidad de piezas aptas en el lote es: " + piezasAptas);

        }

    }
}