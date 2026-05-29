using System.Globalization;
using EspacioEmpleado;

    Empleados[] empleados = new Empleados[3];

    empleados[0] = new Empleados();
    empleados[0].Nombre = "Thomas";
    empleados[0].Apellido = "Gomez";
    empleados[0].FechaNacimiento = new DateTime(2000,2,14);
    empleados[0].EstadoCivil = 'S';
    empleados[0].FechaIngreso = new DateTime(2020, 3 , 1);
    empleados[0].Sueldo = 956000;
    empleados[0].Cargo = Cargos.Ingeniero;

    //Empleado N2}
    empleados[1] = new Empleados();
    empleados[1].Nombre = "Juan";
    empleados[1].Apellido = "Perez";
    empleados[1].FechaNacimiento = new DateTime(1995, 5, 10);
    empleados[1].EstadoCivil = 'C';
    empleados[1].FechaIngreso = new DateTime(2015, 5 , 1);
    empleados[1].Sueldo = 672000;
    empleados[1].Cargo = Cargos.Administrativo;

    empleados[2] = new Empleados();
    empleados[2].Nombre = "Maria";
    empleados[2].Apellido = "Lopez";
    empleados[2].FechaNacimiento = new DateTime(1988, 8 , 20);
    empleados[2].EstadoCivil = 'C';
    empleados[2].FechaIngreso = new DateTime(2010, 2 ,1);
    empleados[2].Sueldo = 1100000;
    empleados[2].Cargo = Cargos.Especialista;

    //para mostrar los datos colocarlos en un bucle for
    for(int i = 0; i < empleados.Length; i++)
    {
        Console.WriteLine("\n--EMPLEADO " + (i +1) + "---");

        Console.WriteLine("Nombre: " + empleados[i].Nombre);
        Console.WriteLine("Apelido: " + empleados[i].Apellido);
        Console.WriteLine("Cargo: " + empleados[i].Cargo);
        Console.WriteLine("Salario: " + "$" + empleados[i].Salario());

    }

    //para punto d obtener el monto total de salarios
    double montoTotal = 0;
    for(int i = 0; i < empleados.Length; i++)
    {
         montoTotal = montoTotal + empleados[i].Salario();
    }

    Console.WriteLine("Monto total en salarios : $" + montoTotal);


    //para punto e
    Empleados proximoJubilado = empleados[0];
    for(int i = 0; i < empleados.Length; i++)
    {
         //para el punto e
        if(empleados[i].AniosParaJubilarse() < proximoJubilado.AniosParaJubilarse())
        {
            proximoJubilado = empleados[i];
        }
    }

    
    Console.WriteLine("\n---EMPLEADO PROXIMO A JUBILARSE ---");
    Console.WriteLine("Nombre: " + proximoJubilado.Nombre);
    Console.WriteLine("Apellido. " + proximoJubilado.Apellido);
    Console.WriteLine("Edad: " + proximoJubilado.Edad());
    Console.WriteLine("Antiguedad: " + proximoJubilado.Antiguedad());
    Console.WriteLine("Anios para jubilarse: " + proximoJubilado.AniosParaJubilarse());
    Console.WriteLine("Cargo: "+ proximoJubilado.Cargo);
    Console.WriteLine("Salario : $" + proximoJubilado.Salario());



/*
    empleado1.Nombre = "Thomas";
    empleado1.Apellido = "Gomez";
    empleado1.FechaNacimiento = new DateTime(2000, 2, 14);
    empleado1.EstadoCivil = 'C';
    empleado1.FechaIngreso = new DateTime(2010, 3 , 1);
    empleado1.Sueldo = 650000;
    empleado1.Cargo = Cargos.Ingeniero;

    Console.WriteLine("---DATOS DEL EMPLEADO---");
    Console.WriteLine("Nombre: " + empleado1.Nombre);
    Console.WriteLine("Apellido: " + empleado1.Apellido);
    Console.WriteLine("Cargo: " + empleado1.Cargo);
    Console.WriteLine("Sueldo: " + empleado1.Sueldo);
   
    Console.WriteLine("Edad: " + empleado1.Edad());
    Console.WriteLine("Antiguedad: " + empleado1.Antiguedad() +" anios");
    Console.WriteLine("Anios para jubilarse: " + empleado1.AniosParaJubilarse() + " anios");
   
    Console.WriteLine("Salario total:" + empleado1.Salario());*/