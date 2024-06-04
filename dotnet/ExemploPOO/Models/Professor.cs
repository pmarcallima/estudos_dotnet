namespace ExemploPOO.Models;

public class Professor : Pessoa
{
    public Professor() { }

    public Professor(string nome)
        : base(nome) { }

    public decimal Salario { get; set; }

    public override void Apresentar()
    {
        Console.WriteLine(
            $"Olá, meun ome é {Nome}, tenho {Idade} anos, e meu salário é de {Salario.ToString("C")}"
        );
    }
}
