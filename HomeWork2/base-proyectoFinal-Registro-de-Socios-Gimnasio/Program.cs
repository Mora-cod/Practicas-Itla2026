using System;

var socios = new System.Collections.Generic.List<string[]>();
int nextId = 1;

while (true)
{
    Console.WriteLine("\n Registro de Socios (Gimnasio) ");
    Console.WriteLine("1. Agregar socio");
    Console.WriteLine("2. Buscar socio por ID");
    Console.WriteLine("3. Modificar socio");
    Console.WriteLine("4. Eliminar socio");
    Console.WriteLine("5. Listar socios");
    Console.WriteLine("6. Salir");
    Console.Write("Opcion: ");

    string opcion = Console.ReadLine() ?? "";

    if (opcion == "6")
    {
        Console.WriteLine("Hasta luego.");
        break;
    }
    else if (opcion == "1")
    {
        Console.Write("Nombre: ");
        string nombre = Console.ReadLine() ?? "";

        Console.Write("Apellido: ");
        string apellido = Console.ReadLine() ?? "";

        socios.Add(new string[] { nextId.ToString(), nombre, apellido });
        Console.WriteLine("Socio agregado con ID: " + nextId);
        nextId++;
    }
    else if (opcion == "2")
    {
        Console.Write("ID: ");
        string id = Console.ReadLine() ?? "";
        bool encontrado = false;

        foreach (var s in socios)
        {
            if (s[0] == id)
            {
                Console.WriteLine("ID: " + s[0] + " | " + s[1] + " " + s[2]);
                encontrado = true;
                break;
            }
        }

        if (!encontrado)
            Console.WriteLine("Socio no encontrado.");
    }
    else if (opcion == "3")
    {
        Console.Write("ID del socio a modificar: ");
        string id = Console.ReadLine() ?? "";
        bool encontrado = false;

        for (int i = 0; i < socios.Count; i++)
        {
            if (socios[i][0] == id)
            {
                Console.Write("Nuevo nombre: ");
                string nombre = Console.ReadLine() ?? "";

                Console.Write("Nuevo apellido: ");
                string apellido = Console.ReadLine() ?? "";

                socios[i] = new string[] { id, nombre, apellido };
                Console.WriteLine("Socio modificado.");
                encontrado = true;
                break;
            }
        }

        if (!encontrado)
            Console.WriteLine("Socio no encontrado.");
    }
    else if (opcion == "4")
    {
        Console.Write("ID del socio a eliminar: ");
        string id = Console.ReadLine() ?? "";
        bool encontrado = false;

        for (int i = 0; i < socios.Count; i++)
        {
            if (socios[i][0] == id)
            {
                socios.RemoveAt(i);
                Console.WriteLine("Socio eliminado.");
                encontrado = true;
                break;
            }
        }

        if (!encontrado)
            Console.WriteLine("Socio no encontrado.");
    }
    else if (opcion == "5")
    {
        if (socios.Count == 0)
            Console.WriteLine("No hay socios registrados.");
        else
            foreach (var s in socios)
                Console.WriteLine("ID: " + s[0] + " | " + s[1] + " " + s[2]);
    }
    else
    {
        Console.WriteLine("Opcion no reconocida.");
    }
}