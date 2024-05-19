namespace Ejercicios.Class
{
    class Empresa
    {
        public void CalcularSueldos()
        {
            Console.Write("Ingrese la cantidad de empleados: ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.Write("Entrada inválida. Ingrese la cantidad de empleados (número entero positivo): ");
            }

            int sueldosEntre100y300 = 0, sueldosMayores300 = 0;
            double gastoTotal = 0;
            int contador = 0;
            while (contador < n)
            {
                Console.Write("Ingrese el sueldo del empleado: ");
                double sueldo;
                while (!double.TryParse(Console.ReadLine(), out sueldo) || sueldo < 100 || sueldo > 500)
                {
                    Console.Write("Entrada inválida. Ingrese el sueldo del empleado (entre $100 y $500): ");
                }
                gastoTotal += sueldo;
                if (sueldo >= 100 && sueldo <= 300)
                {
                    sueldosEntre100y300++;
                }
                else if (sueldo > 300)
                {
                    sueldosMayores300++;
                }
                contador++;
            }

            Console.WriteLine("Cantidad de empleados con sueldos entre $100 y $300: " + sueldosEntre100y300);
            Console.WriteLine("Cantidad de empleados con sueldos mayores a $300: " + sueldosMayores300);
            Console.WriteLine("El importe que gasta la empresa en sueldos es: $" + gastoTotal);
        }
    }
}