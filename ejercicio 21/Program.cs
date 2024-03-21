using System;

namespace ejercicio_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool calcularDeNuevo = true;

            while (calcularDeNuevo)
            {
                int numeroDePacientes = PedirNumeroDePacientes();

                for (int i = 0; i < numeroDePacientes; i++)
                {
                    double peso = PedirValor("\nPeso (kg): ");
                    double altura = PedirValor("Altura (m): ");
                    double imc = CalcularIMC(peso, altura);
                    MostrarCategoriaIMC(i + 1, imc);
                }

                calcularDeNuevo = PreguntarSiCalcularDeNuevo();
            }
        }

        static int PedirNumeroDePacientes()
        {
            Console.WriteLine("\nIngrese el número de pacientes:");
            return int.Parse(Console.ReadLine());
        }

        static double PedirValor(string mensaje)
        {
            Console.Write(mensaje);
            return double.Parse(Console.ReadLine());
        }

        static double CalcularIMC(double peso, double altura)
        {
            return peso / (altura * altura);
        }

        static void MostrarCategoriaIMC(int numeroPaciente, double imc)
        {
            string categoria = DeterminarCategoriaIMC(imc);
            Console.WriteLine($"El paciente {numeroPaciente} tiene un IMC de {imc:f2} y se encuentra en la categoría: {categoria}");
        }

        static string DeterminarCategoriaIMC(double imc)
        {
            if (imc < 18.5)
            {
                return "Peso insuficiente";
            }
            else if (imc <= 24.9)
            {
                return "Peso saludable";
            }
            else if (imc <= 29.9)
            {
                return "Sobrepeso";
            }
            else
            {
                return "Obesidad";
            }
        }

        static bool PreguntarSiCalcularDeNuevo()
        {
            Console.WriteLine("\n¿Quiere calcular de nuevo? (s/n)");
            char respuesta = char.Parse(Console.ReadLine());
            return (respuesta == 's' || respuesta == 'S');
        }
    }
}
