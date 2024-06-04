namespace ExemploPOO.Models;

using ExemploPOO.Interface;

public class Calculadora : iCalculadora
{
    public int Dividir(int num1, int num2)
    {
        return num1 / num2;
    }

    public int Multiplicar(int num1, int num2)
    {
        return num1 * num2;
    }

    public int Somar(int num1, int num2)
    {
        return num1 + num2;
    }

    public int Subtrair(int num1, int num2)
    {
        return num1 - num2;
    }
}
