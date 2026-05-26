namespace EspacioCalculadora;

    public class Calculadora
{
    //Campo privado
        private double dato;

    //Propiedad solo lectura
    public double Resultado
    {   
        get
        {
            return dato;
        }
    }

    //Metodos
    public void Sumar(double termino)
    {
        dato = dato + termino;
    }

    public void Restar(double termino)
    {
        dato = dato - termino;
    }

    public void Multiplicar(double termino)
    {
        dato = dato * termino;
    }

    public void Dividir(double termino)
    {
        if(termino != 0)
        {
             dato = dato / termino;
        }else
        {
            Console.WriteLine("No se puede dividir por 0.");
        }
    }

    public void Limpiar()
    {
        dato = 0;
    }
}