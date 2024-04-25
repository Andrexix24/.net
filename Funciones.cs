public class Funciones
{
    public static void Main()
    {
        puntoCritico(valorConversion(1));
        Console.WriteLine(dolaresPesos(1000));
        variacion(1000,100);
        Console.WriteLine(maximo(1000,8000,5000,6000,50000));
    }

    public static double valorConversion(int cantidadPesos)
    {
        return cantidadPesos / 4200;
    }

    public static void puntoCritico(double valorConversion)
    {
        String mensaje = "Normalidad economica";
        if (valorConversion>5000)
        {
            mensaje = "alerta economica";
        }
        Console.WriteLine(mensaje);
    }

    //agregar una función que convierta dolares a pesos
    public static double dolaresPesos(double dolares)
    {
        return dolares * 4800.78;
    }

    //agregar un metodo que reciba el precio actual y el precio anterior del dólar e imprima el % de la variación del precio actual con respecto al anterior
    public static void variacion(double precioActual, double precioAnterior)
    {
        double variacion = (precioAnterior * 100) / precioActual;
        Console.WriteLine("la variacion es del "+variacion+"%");
    }

    //agregar una función que reciba 5 precios de dolar y devuelva el valor maximo
    public static double maximo(double precio1, double precio2, double precio3, double precio4, double precio5)
    {
        double[] numeros= [precio1,precio2,precio3,precio4,precio5];

        double auxiliar = 0;

        for (int i = 0; i < numeros.Length - 1; i++)
        {
            for (int j = i + 1; j < numeros.Length; j++)
            {
                if (numeros[i] > numeros[j])
                {
                    auxiliar = numeros[i];
                    numeros[i] = numeros[j];
                    numeros[j] = auxiliar;
                }
            }
        }

        double maximo = numeros[4];

        return maximo;
    }
}