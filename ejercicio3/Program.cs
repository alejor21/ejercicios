namespace ejercicio
{
    public class program
    {
        public static void Main()
        {
            int contador;
            int sumatoria;
            int limite;
            sumatoria = 0;
            contador = 1;
            limite = 10;
            for (contador = 1; contador <= limite; contador++) ;
            sumatoria = sumatoria + limite;
            Console.WriteLine($"el resultado de la sumatoria{sumatoria}");

        }
    }
}