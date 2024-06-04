namespace ExemploPOO.Models;

public abstract class Conta
{
    protected decimal saldo { get; set; }

    public abstract void Creditar(decimal valor);

    public void ExibirSaldo()
    {
        Console.WriteLine("O seu saldo é: " + saldo);
    }
}
