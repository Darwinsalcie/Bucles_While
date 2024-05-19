namespace NotasdeAlumnos.Class
{
    class Notas
    {
        int notasMayores = 0, notasMenores = 0;
        int contador = 0;

        public void ClasificarNotas()
        {
            while (contador < 10)
            {
                bool notaValida = false;

                while (!notaValida)
                {
                    Console.Write("\nIngrese la nota del alumno: ");

                    if (int.TryParse(Console.ReadLine(), out int nota))
                    {
                        if (nota >= 0 && nota <= 10)
                        {
                            if (nota >= 7)
                            {
                                notasMayores++;
                            }
                            else
                            {
                                notasMenores++;
                            }

                            contador++;
                            notaValida = true;
                        }
                        else
                        {
                            Console.WriteLine("Debe ingresar una calificación entre 0 y 10");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Solo se admiten números entre 0 y 10");
                    }
                }
            }

            Console.WriteLine("\n\nCantidad de alumnos con notas mayores o iguales a 7: " + notasMayores);
            Console.WriteLine("Cantidad de alumnos con notas menores a 7: " + notasMenores);
        }
    }
}