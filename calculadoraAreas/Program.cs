using CalculadoraAreas.Models;
using CalculadoraAreas.Utils;

namespace CalculadoraAreas
{
	public class Program
	{

		public static void Main(string[] args)
		{
			CalcularAreaFiguras();
		}
		public static void CalcularAreaFiguras()
		{
			while (true)
			{
				Console.WriteLine("¿Qué figura geométrica desea calcular?");
				Console.WriteLine("1. Círculo");
				Console.WriteLine("2. Rectángulo");
				Console.WriteLine("0. Salir");

				int opcion;
				while (!int.TryParse(Console.ReadLine(), out opcion) || (opcion != 0 && opcion != 1 && opcion != 2))
				{
					Console.WriteLine("Opción inválida. Intente nuevamente.");
				}

				if (opcion == 0)
				{
					Console.WriteLine("Saliendo del programa...");
					break;
				}

				FiguraGeometrica figura;
				switch (opcion)
				{
					case 1:
						Console.WriteLine("Ingrese el radio del círculo:");
						double radio;
						while (!double.TryParse(Console.ReadLine(), out radio))
						{
							Console.WriteLine("Valor inválido. Intente nuevamente.");
						}
						figura = new Circulo { Radio = radio };
						break;
					case 2:
						Console.WriteLine("Ingrese la base del rectángulo:");
						double @base;
						while (!double.TryParse(Console.ReadLine(), out @base))
						{
							Console.WriteLine("Valor inválido. Intente nuevamente.");
						}
						Console.WriteLine("Ingrese la altura del rectángulo:");
						double altura;
						while (!double.TryParse(Console.ReadLine(), out altura))
						{
							Console.WriteLine("Valor inválido. Intente nuevamente.");
						}
						figura = new Rectangulo { Base = @base, Altura = altura };
						break;
					default:
						throw new InvalidOperationException("Opción inválida.");
				}

				double area = figura.CalcularArea();
				Console.WriteLine($"El área de la figura es: {area}");
			}
		}
	}
}