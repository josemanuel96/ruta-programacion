internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== Sistema de Empleados ===");
        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine()!;

        Console.Write("Ingrese edad: ");
        string edadTexto = Console.ReadLine()!;

        int edad;

        if (int.TryParse(edadTexto, out edad))
        {
            Console.WriteLine($"Hola {nombre}, tienes {edad} años.");
        }
        else
        {
            Console.WriteLine("Edad inválida. Debe de ingresar un número.");
        }

        Console.WriteLine("Presione una tecla para salir...");
        Console.ReadKey();

    }
}