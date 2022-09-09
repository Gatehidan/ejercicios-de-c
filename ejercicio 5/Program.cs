namespace ejercicio5
{
    public class program
    {
        public static void Main()
        {

            int limite;
            double cuadrado;
            int numero = 2;
            int cotador;
            cotador = 0;
            limite = 10;
            for (cotador = 0; cotador <= limite; cotador++)
            {
                cuadrado = Math.Pow(numero, cotador);
                Console.WriteLine($"El resultado del número 2 elevado en {cotador} es : {cuadrado}");
            }

        }
    }
}
