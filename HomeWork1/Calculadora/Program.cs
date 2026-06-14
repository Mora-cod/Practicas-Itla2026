using System;

while (true)
{
    Console.WriteLine("\nQue desea hacer?");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar ");
    Console.WriteLine("4. Dividir ");
    Console.WriteLine("5. Verificar si un estudiante aprobo ");
    Console.WriteLine("6. Salir ");
    Console.Write("Opcion: ");

    string opcion = Console.ReadLine() ?? "";

    if (opcion == "6")
    {
        Console.WriteLine("hasta luego.");
        break;
    }
    else if (opcion == "1" || opcion == "2" || opcion == "3" || opcion == "4")
    {
        Console.Write("Primer numero: ");
        string entrada1 = Console.ReadLine() ?? "";

        Console.Write("Segundo numero: ");
        string entrada2 = Console.ReadLine() ?? "";

        if (!double.TryParse(entrada1, out double n1) || !double.TryParse(entrada2, out double n2))
        {
            Console.WriteLine("no es numero valido.");
            continue;
        }

        if (opcion == "1")
        Console.WriteLine("Resultado: " + (n1 + n2));
        else if (opcion == "2")
        Console.WriteLine("Resultado: " + (n1 - n2));
        else if (opcion == "3")
        Console.WriteLine("Resultado: " + (n1 * n2));
        else if (opcion == "4")
        {
            if (n2 == 0)
            Console.WriteLine("No se puede dividir entre cero.");
            else
            Console.WriteLine("Resultado: " + (n1 / n2));
        }
    }
    else if (opcion == "5")
    {
        Console.Write("Nombre del estudiante: ");
        string nombre = Console.ReadLine() ?? "";

        Console.Write("Nota 1 (0-100): ");
        string entrada1 = Console.ReadLine() ?? "";

        Console.Write("Nota 2 (0-100): ");
        string entrada2 = Console.ReadLine() ?? "";

        Console.Write("Nota 3 (0-100): ");
        string entrada3 = Console.ReadLine() ?? "";

        if (!double.TryParse(entrada1, out double nota1) ||
            !double.TryParse(entrada2, out double nota2) ||
            !double.TryParse(entrada3, out double nota3))
        {
            Console.WriteLine("Una o mas notas no son validas.");
            continue;
        }

        if (nota1 < 0 || nota1 > 100 || nota2 < 0 || nota2 > 100 || nota3 < 0 || nota3 > 100)
        {
            Console.WriteLine("Las nota deben estar entre 0 y 100.");
            continue;
        }

        double promedio = (nota1 + nota2 + nota3) / 3;

        Console.WriteLine("Promedio: " + Math.Round(promedio, 2));

        if (promedio >= 70)
        Console.WriteLine(nombre + " aprobo con promedio " + Math.Round(promedio, 2));
        else
        Console.WriteLine(nombre + " reprobo con promedio " + Math.Round(promedio, 2));
    }
    else
    {
        Console.WriteLine("Opcion no reconocida.");
    }

}