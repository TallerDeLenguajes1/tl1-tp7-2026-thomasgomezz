using EspacioEmpleado;

    Empleados empleado1 = new Empleados();

    empleado1.Nombre = "Thomas";
    empleado1.Apellido = "Gomez";
    empleado1.FechaNacimiento = new DateTime(2000, 2, 14);
    empleado1.EstadoCivil = 'S';
    empleado1.FechaIngreso = new DateTime(2026, 3 , 1);
    empleado1.Sueldo = 250000;
    empleado1.Cargo = Cargos.Ingeniero;

    Console.WriteLine("---DATOS DEL EMPLEADO---");
    Console.WriteLine("Nombre: " + empleado1.Nombre);
    Console.WriteLine("Apellido: " + empleado1.Apellido);
    Console.WriteLine("Cargo: " + empleado1.Cargo);
    Console.WriteLine("Sueldo: " + empleado1.Sueldo);
   
    Console.WriteLine("Edad: " + empleado1.Edad());
    Console.WriteLine("Antiguedad: " + empleado1.Antiguedad());
    Console.WriteLine("Anios para jubilarse: " + empleado1.AniosParaJubilarse());
   
