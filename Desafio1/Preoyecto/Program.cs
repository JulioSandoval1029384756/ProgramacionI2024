using System;

public class Calculadora
{
    public string Marca { get; set; }
    public string Serie { get; set; }

    public Calculadora(string marca, string serie)
    {
        Marca = marca;
        Serie = serie;
    }
    public virtual double Sumar(double a, double b)
    {
        Console.WriteLine($"Sumando {a} y {b}");
        return a + b;
    }

    public virtual double Restar(double a, double b)
    {
        Console.WriteLine($"Restando {b} de {a}");
        return a - b;
    }

    public virtual double Multiplicar(double a, double b)
    {
        Console.WriteLine($"Multiplicando {a} por {b}");
        return a * b;
    }
    public virtual double Dividir(double a, double b)
    {
        Console.WriteLine($"Dividiendo {a} entre {b}");
        if (b != 0)
            return a / b;
        else
        {
            Console.WriteLine("Error: No se puede dividir por cero.");
            return double.NaN;
        }
    }

    public virtual void MostrarInfo()
    {
        Console.WriteLine($"Marca: {Marca}, Serie: {Serie}");
    }
}

public class CalculadoraCientifica : Calculadora
{
    public CalculadoraCientifica(string marca, string serie) : base(marca, serie)
    {
    }

    public double Potencia(double baseNum, double exponente)
    {
        Console.WriteLine($"Calculando {baseNum} elevado a la potencia {exponente}");
        return Math.Pow(baseNum, exponente);
    }

    public double Raiz(double num)
    {
        Console.WriteLine($"Calculando raíz cuadrada de {num}");
        return Math.Sqrt(num);
    }

    public double Modulo(double a, double b)
    {
        Console.WriteLine($"Calculando el módulo de {a} entre {b}");
        return a % b;
    }
    public double Logaritmo(double a, double nuevoBase)
    {
        Console.WriteLine($"Calculando el logaritmo de {a} en base {nuevoBase}");
        return Math.Log(a, nuevoBase);
    }
    public override void MostrarInfo()
    {
        base.MostrarInfo();
    }
}

class Program
{
    static void Main(string[] args)
    {

        Calculadora calculadoraBasica = new Calculadora("MarcaX", "12345");

        Console.WriteLine("Información de la calculadora básica:");
        calculadoraBasica.MostrarInfo();
        Console.WriteLine("Operaciones básicas:");
        Console.WriteLine("Suma: " + calculadoraBasica.Sumar(10, 5));
        Console.WriteLine("Resta: " + calculadoraBasica.Restar(10, 5));
        Console.WriteLine("Multiplicación: " + calculadoraBasica.Multiplicar(10, 5));
        Console.WriteLine("División: " + calculadoraBasica.Dividir(10, 5));
        Console.WriteLine();

        CalculadoraCientifica calculadoraCientifica = new CalculadoraCientifica("MarcaY", "54321");

        Console.WriteLine("Información de la calculadora científica:");
        calculadoraCientifica.MostrarInfo();
        Console.WriteLine("Operaciones científicas:");
        Console.WriteLine("Potencia: " + calculadoraCientifica.Potencia(2, 3));
        Console.WriteLine("Raíz cuadrada: " + calculadoraCientifica.Raiz(25));
        Console.WriteLine("Módulo: " + calculadoraCientifica.Modulo(10, 3));
        Console.WriteLine("Logaritmo: " + calculadoraCientifica.Logaritmo(100, 10));
    }
}


