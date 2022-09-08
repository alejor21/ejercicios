namespace ejercicio2
{
    public class program1
    {
        public static void Main()
        {
            int num1;
            int num2;
            int num3;
            int num4;

            int suma;
            int media;
            int producto;

            Console.WriteLine("digite el primer numero");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el swegundo numeo");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite el tercer numero");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite el cuarto numero");
            num4 = Convert.ToInt32(Console.ReadLine());

            suma = num1 + num2 + num3 + num4;
            media = suma / 4;
            producto = num1 * num2 * num3 * num4;

            Console.WriteLine($"el resultado de la suma es {suma}");
            Console.WriteLine($"el resultado de la media es {media}");
            Console.WriteLine($"el resultado de el producto es{producto}");

        }
    }
}
