class Examen
{
    public static void Main()
    {
        Credito credito = new Credito();
        bool mientras = true;
        while (mientras)
        {
            Console.WriteLine(
                "Opciones: \n1. Registrar el valor total de compras\n2. Registrar avances\n3. Pagar credito\n4. Consultar cupo credito y saldo por pagar\n5. Consultar total puntos\n6. salir");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    credito.Compra();
                    break;
                case 2:
                    credito.Avances();
                    break;
                case 3: 
                    credito.Pago();
                    break;
                case 4:
                    credito.VerCredito();
                    break;
                case 5:
                    credito.VerPuntos();
                    break;
                case 6:
                    mientras = false;
                    break;

            }
        }
    }
}

public class Credito
{
    string? nombre;
    double compra;
    double saldo;
    double cupoCredito=1000000;
    double avances;
    int puntos = 0;

    public Credito() { }
    public Credito(string? nombre, double compra, double saldo)
    {
        this.nombre = nombre;
        this.compra = compra;
        this.saldo = saldo;
    }

    public void Compra()
    {
        Console.WriteLine("ingrese el nombre: ");
        nombre = Console.ReadLine();
        Console.WriteLine("ingrese la compra: ");
        compra = double.Parse(Console.ReadLine());
        if (compra > cupoCredito || compra <= 0)
        {
            Console.WriteLine("el valor de la compra no puede ser mayor que el cupo del credito(1.000.000)o menor o igual a cero");
            Console.WriteLine("vuelva a ingresar el valor de la compra: ");
            compra = double.Parse(Console.ReadLine());
        }
        else if (saldo == cupoCredito)
        {
            Console.WriteLine("no se puede realizar la compra por que el saldo a pagar es igual al cupo del credito");
        }
        else if (compra >= 100000)
        {
            puntos = puntos + 1;
            saldo = compra;
            cupoCredito = cupoCredito - saldo;
        }
        else
        {
            saldo = compra;
            cupoCredito = cupoCredito - saldo;
        }
    }

    public void Avances()
    {
        if (saldo > cupoCredito)
        {
            Console.WriteLine("no se pueden realizar avances por que el valor del saldo a pagar ya es igual al valor del cupo del credito");
        }
        else
        {
            Console.WriteLine("registre el avance: ");
            avances = double.Parse(Console.ReadLine());
            if (avances > cupoCredito || avances <= 0)
            {
                Console.WriteLine("el valor de los avances no puede ser mayor que el cupo disponible del credito");
                Console.WriteLine("vuelva a ingresar el valor del avance: ");
                avances = double.Parse(Console.ReadLine());
            }
            else if (avances == 0)
            {
                Console.WriteLine("el valor del avance no puede ser menor o igual a cero\nvuelva a ingresarlo:");
                avances = double.Parse(Console.ReadLine());
            }
            else if (avances >= 100000)
            {
                puntos = puntos + 1;
                cupoCredito = cupoCredito - avances;
                saldo = saldo + avances;
            }
            else
            {
                saldo = saldo + avances;
            }
        }
    }

    public void Pago()
    {
        Console.WriteLine("ingrese el pago del credito: ");
        double pago = double.Parse(Console.ReadLine());
        if (pago > 0 || pago <= saldo)
        {
            saldo = saldo - pago;
            cupoCredito= cupoCredito + pago;
        }
    }

    public void VerCredito()
    {
        Console.WriteLine("el cupo del credito es: {0}", cupoCredito);
        Console.WriteLine("el saldo por pagar es: {0}", saldo);
    }

    public void VerPuntos()
    {
        Console.WriteLine("el total de puntos es: {0}", puntos);
    }
}