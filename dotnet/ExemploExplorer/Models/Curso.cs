namespace ExemploExplorer.Models;

public class Curso
{
    public string Nome { get; set; }
    public List<Pessoa> Alunos { get; set; }

    public void AdicionarAluno(Pessoa aluno)
    {
        Alunos.Add(aluno);
    }

    public int ObterQuantidadeDeAlunosMatriculados()
    {
        int quantidade = Alunos.Count;
        return quantidade;
    }

    public bool RemoverAluno(Pessoa aluno)
    {
        return Alunos.Remove(aluno);
    }

    public void ListarAlunos()
    {
        Console.WriteLine($"Alunos do curso de: {Nome}");

        for (int count = 0; count < Alunos.Count; count++)
        {
            //string texto = "N⁰ " + count + " - " + Alunos[count].NomeCompleto;
            int exibicao = count + 1;
            string texto = $"N⁰ {exibicao} - {Alunos[count].NomeCompleto}";
            Console.WriteLine(texto);
        }
    }
}
