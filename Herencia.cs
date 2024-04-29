public class Modulos
{
    public static void Main()
    { 
        Usuarios[] usuarios = new Usuarios[3];
        for (int i = 0; i < usuarios.Length; i++)
        {
            Console.WriteLine("ingrese el correo: ");
            string? correo=Console.ReadLine();
            Console.WriteLine("ingrese la contraseña: ");
            string? contrasena=Console.ReadLine();
            Console.WriteLine("ingrese el rol: ");
            string? rol=Console.ReadLine();
            Console.WriteLine("-------------------");
            usuarios[i] = new Usuarios(i, correo, contrasena, rol);
        }
        for (int i = 0; i < usuarios.Length; i++)
        {
            usuarios[i].Usuario();
            Console.WriteLine("-------------------");
        }
        
        Compras[] compras = new Compras[3];
        for (int i = 0; i < compras.Length; i++)
        {
            Console.WriteLine("ingrese el numero de recibo: ");
            string? nro_recibo = Console.ReadLine();
            Console.WriteLine("ingrese el proveedor: ");
            string? proveedor = Console.ReadLine();
            Console.WriteLine("ingrese el costo: ");
            double costo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("-------------------");
            compras[i] = new Compras(i, costo, proveedor, nro_recibo);
        }

        for (int i = 0; i < compras.Length; i++)
        {
            compras[i].Compra();
            Console.WriteLine("-------------------");
        }
    }
}

public class Compras
{
    int id;
    double costo;
    string? estado;
    string? proveedor;
    string? nro_recibo;

    public Compras() { }

    public Compras(int id, double costo, string? proveedor, string? nro_recibo)
    {
        this.id = id;
        this.costo = costo;
        this.estado = "activo";
        this.proveedor = proveedor;
        this.nro_recibo = nro_recibo;
    }

    public void Compra()
    {
        Console.WriteLine("id: {0}", id);
        Console.WriteLine("nro_recibo: {0}", nro_recibo);
        Console.WriteLine("proveedor: {0}", proveedor);
        Console.WriteLine("costo: {0}", costo);
        Console.WriteLine("estado: {0}", estado);
    }
}

public class Usuarios
{
    int id;
    string? correo;
    string? contrasena;
    string? rol;

    public Usuarios() { }

    public Usuarios(int id, string? correo, string? contrasena, string? rol)
    {
        this.id=id;
        this.correo=correo;
        this.contrasena=contrasena;
        this.rol=rol;
    }

    public void Usuario()
    {
        Console.WriteLine("id: {0}", id);
        Console.WriteLine("correo: {0}", correo);
        Console.WriteLine("contraseña: {0}", contrasena);
        Console.WriteLine("rol: {0}", rol);
    }
}