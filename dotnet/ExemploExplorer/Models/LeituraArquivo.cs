﻿
namespace ExemploExplorer.Models;

public class LeituraArquivo
{
    public (bool Sucesso, string[] Linhas, int QuantidadeLinhas) LerArquivo(string caminho)
    {
        try
        {
            string[] linhas = File.ReadAllLines(caminho);
            return (true, linhas, linhas.Count());
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu uma exceção{ex.Message}");
            return (false, new string[0], 0);
        }
    }
}
