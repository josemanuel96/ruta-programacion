internal class Program
{
    private static void Main(string[] args)
    {
        bool salir = false;

        while (!salir)
        {
            Console.Clear();
            Console.WriteLine("=== SISTEMA DE EMPLEADOS ===");
            Console.WriteLine("1. Crear empleado");
            Console.WriteLine("2. Listar empleado");
            Console.WriteLine("3. Buscar empleado");
            Console.WriteLine("4. Editar empleado");
            Console.WriteLine("5. Eliminar empleado");
            Console.WriteLine("6. Salir");
            Console.Write("\nSeleccione una opcion: ");

            string opcion = Console.ReadLine()!;

            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Opcion Crear seleccionada");
                    break;

                case "2":
                    Console.WriteLine("Opcion Listar seleccionada");
                    break;

                case "3":
                    Console.WriteLine("Opcion Buscar seleccionada");
                    break;

                case "4":
                    Console.WriteLine("Opcion Editar seleccionada");
                    break;

                case "5":
                    Console.WriteLine("Opcion Eliminar seleccionada");
                    break;

                case "6":
                    salir = true;
                    Console.WriteLine("Saliendo del sistema...");
                    break;

                default:
                    Console.WriteLine("Opcion invalida.");
                    break;

            }

            if (!salir)
            {
                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();
            }

        }

    }
}