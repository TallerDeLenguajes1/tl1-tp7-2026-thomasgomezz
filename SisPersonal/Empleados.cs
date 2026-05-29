namespace EspacioEmpleado;

//Enumeracion
    public enum Cargos
{
    Auxiliar,
    Administrativo,
    Ingeniero,
    Especialista,
    Investigador
}

    public class Empleados
    {
        //Campos privados
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
        private char estadoCivil;
        private DateTime fechaIngreso;
        private double sueldo;
        private Cargos cargo;

        //Propiedades 
        public string Nombre
        {
            get {return nombre;}
            set {nombre = value;}
        }

        public string Apellido
        {
            get {return apellido;}
            set {apellido = value;}
        }

        public DateTime FechaNacimiento
        {
            get {return fechaNacimiento;}
            set {fechaNacimiento = value;}
        }
        
        public char EstadoCivil
        {
            get {return estadoCivil;}
            set { estadoCivil = value;}
        }

        public DateTime FechaIngreso
        {
            get {return fechaIngreso;}
            set {fechaIngreso = value;}
        }

        public double Sueldo
        {
            get { return sueldo;}
            set {sueldo = value;}
        }

        public Cargos Cargo
        {
            get {return cargo;}
            set {cargo = value;}
        }

        //Para ejercicio 2
        public int Aniguedad()
    {
        return DateTime.Now.Year - fechaIngreso.Year;
    }

    public int Edad()
    {
        return DateTime.Now.Year - fechaNacimiento.Year;
    }

    public int AniosParaJubilarse()
    {
        return 65 - Edad();
    }

    }

