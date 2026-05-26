using EspacioCalculadora;

Calculadora calc = new Calculadora();

string opcion;

    do
    {
        Console.WriteLine("\n---CALCULADORA---");
        Console.WriteLine("Resultado actual: " + calc.Resultado);

        Console.WriteLine("1-Sumar");
        Console.WriteLine("2-Restar");
        Console.WriteLine("3-Multiplicar");
        Console.WriteLine("4-Dividir");
        Console.WriteLine("5-Limpiar");
        Console.WriteLine("0-Salir");

        Console.WriteLine("Seleccione una opcion: ");

        opcion = Console.ReadLine();

        double numero;

        switch (opcion)
        {
            case "1":
                    Console.WriteLine("Ingrese un numero: ");
                    numero = Convert.ToDouble(Console.ReadLine());
                    calc.Sumar(numero);
                    break;

            case "2":
                    Console.WriteLine("Ingrese un numero: ");
                    numero = Convert.ToDouble(Console.ReadLine());
                    calc.Restar(numero);
                    break;

            case "3":
                    Console.WriteLine("Ingrese un numero: ");
                    numero = Convert.ToDouble(Console.ReadLine());
                    calc.Multiplicar(numero);
                    break;
            
            case "4":
                    Console.WriteLine("Ingrese un numero: ");
                    numero = Convert.ToDouble(Console.ReadLine());
                    calc.Dividir(numero);
                    break;
            
            case "5":
                    calc.Limpiar();
                    break;

            case "0":
                    Console.WriteLine("Fin del programa.");
                    break;

            default:
                    Console.WriteLine("Opcion incorrecta.");
                    break;
        }

    } while (opcion != "0");
