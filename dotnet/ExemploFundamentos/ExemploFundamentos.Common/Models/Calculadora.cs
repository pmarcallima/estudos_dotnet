using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Models
{
		public class Calculadora
		{
				public void Somar(int x, int y)
				{
						Console.WriteLine($"{x} + {y} = {x + y}");
				}
				public void Subtrair(int x, int y)
				{
						Console.WriteLine($"{x} - {y} = {x - y}");
				}
				public void Multiplicar(int x, int y)
				{
						Console.WriteLine($"{x} * {y} = {x * y}");
				}
				public void Dividir(int x, int y)
				{
						Console.WriteLine($"{x} / {y} = {x / y}");
				}
				public void Potencia(int x, int y)
				{
						Console.WriteLine($"{x}^{y} = {Math.Pow(x, y)}");
				}
				public void RaizQuadrada(double x)
				{
						Console.WriteLine($"raiz quadrada de {x}  = {Math.Sqrt(x)}");
				}
				public void Seno(double angulo)
				{
						double radiano = angulo * Math.PI / 180;
						Console.WriteLine($"Seno de {angulo} = {Math.Sin(radiano)}");
				}
				public void Cosseno(double angulo)
				{
						double radiano = angulo * Math.PI / 180;
						Console.WriteLine($"Cosseno de {angulo} = {Math.Cos(radiano)}");
				}
				public void Tangente(double angulo)
				{
						double radiano = angulo * Math.PI / 180;
						Console.WriteLine($"Tangente de {angulo} = {Math.Tan(radiano)}");

				}
		}
}
