using System.Globalization;
using ExemploExplorer.Models;
using Newtonsoft.Json;

string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach (Venda venda in listaVenda)
{
    Console.WriteLine(
        $"Id:  {venda.Id}, Produto: {venda.Produto}, Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}"
    );
}







































//List<Venda> listaVendas = new List<Venda>();
//DateTime dataAtual = DateTime.Now;
//
//Venda v1 = new Venda(1, "Material de escritório", 25.00M, dataAtual);
//Venda v2 = new Venda(2, "Software", 110.00M, dataAtual);
//
//listaVendas.Add(v1);
//listaVendas.Add(v2);
//
//string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);
//
//File.WriteAllText("Arquivos/vendas.json", serializado);
//
//Console.WriteLine(serializado);



































//int numero = 20;
//bool ehPar = false;
//
//ehPar = numero % 2 == 0;
//
//Console.WriteLine($"O numero {numero} é " + (ehPar ? "par" : "impar"));

//if(numero % 2 == 0
//		  )
//{
//	Console.WriteLine($"O número {numero} é par");
//}
//else
//{
//	Console.WriteLine($"O número {numero} não é par");
//}





































//Pessoa p1 = new Pessoa("Pedro", "Lima");
//
//(string nome, string sobrenome) = p1;
//
//Console.WriteLine(nome + " " + sobrenome);




























//LeituraArquivo arquivo = new LeituraArquivo();
//
//var (sucesso, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");
//
//if (sucesso == true)
//{
//    Console.WriteLine("Quantidade de linhas do arquivo:" + quantidadeLinhas);
//    foreach (string linha in linhasArquivo)
//    {
//        Console.WriteLine(linha);
//    }
//}
//else
//{
//    Console.WriteLine("Não foi possível ler o arquivo");
//}



































//(int, string, string, decimal) tupla = (1, "Pedro", "Lima", 10.5M);
//ValueTuple<int, string, string, decimal> outroExemploTupla = (1, "Pedro", "Lima", 10.5M);
//var outroExemploTuplaCreate = Tuple.Create(1, "Pedro", "Lima", 10.5M);
//
//Console.WriteLine($"Id: {tupla.Item1}");
//Console.WriteLine($"Nome: {tupla.Item2}");
//Console.WriteLine($"Sobrenome: {tupla.Item3}");
//Console.WriteLine($"Altura: {tupla.Item4}");





























//Dictionary<string, string> estados = new Dictionary<string, string>();
//
//estados.Add("MG", "Minas Gerais");
//estados.Add("SP", "São Paulo");
//estados.Add("BA", "Bahia");
//
//foreach (KeyValuePair<string, string> item in estados)
//{
//    Console.WriteLine($"chave: {item.Key}, valor: {item.Value}");
//}
//
//Console.WriteLine("----------------");
//estados.Remove("BA");
//estados["SP"] = "São Paulo - valor alterado";
//foreach (KeyValuePair<string, string> item in estados)
//{
//    Console.WriteLine($"chave: {item.Key}, valor: {item.Value}");
//}
//
//string chave = "BA";
//Console.WriteLine($"verificando o elemento: {chave}");
//
//if (estados.ContainsKey(chave))
//{
//    Console.WriteLine($"Valor existente: {chave}");
//}
//else
//{
//    Console.WriteLine($"Valor não existe. É segura adicionar a chave {chave}");
//}

















































//Stack<int> pilha = new Stack<int>();
//
//pilha.Push(2);
//pilha.Push(4);
//pilha.Push(6);
//pilha.Push(8);
//
//foreach (int item in pilha)
//{
//    Console.WriteLine(item);
//}
//
//Console.WriteLine($"Removendo o numero {pilha.Pop()}");
//pilha.Push(10);
//
//foreach (int item in pilha)
//{
//    Console.WriteLine(item);
//}








































//Queue<int> fila = new Queue<int>();
//
//fila.Enqueue(2);
//fila.Enqueue(4);
//fila.Enqueue(6);
//fila.Enqueue(8);
//
//foreach(int item in fila)
//{
//	Console.WriteLine(item);
//}
//
//Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
//fila.Enqueue(10);
//
//foreach(int item in fila)
//{
//	Console.WriteLine(item);
//}





















































//new ExemploExcecao().Metodo1();








































//try
//{
//    string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");
//    foreach (string linha in linhas)
//    {
//        Console.WriteLine(linha);
//    }
//}
//catch (FileNotFoundException ex)
//{
//    Console.WriteLine(
//        $"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}"
//    );
//}
//catch (DirectoryNotFoundException ex)
//{
//    Console.WriteLine(
//        $"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrada. {ex.Message}"
//    );
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. {ex.Message}");
//}
//finally
//{
//    Console.WriteLine("Chegou até aqui");
//}














































//string dataString = "2022-04-17 18:00";
//bool sucesso = DateTime.TryParseExact(
//    dataString,
//    "yyyy-MM-dd HH:mm",
//    CultureInfo.InvariantCulture,
//    DateTimeStyles.None,
//    out DateTime data
//);
//
//if(sucesso == true)
//{
//	Console.WriteLine($"Conversão com sucesso! Data : {data}");
//}
//else
//{
//	Console.WriteLine($"{dataString} não é uma data válida");
//}







































//CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-br");
//decimal valorMonetario = 82.40M;
//
//Console.WriteLine(valorMonetario.ToString("N2", CultureInfo.CreateSpecificCulture("en-US")));
//
//double porcentagem = .3421;
//
//Console.WriteLine(porcentagem.ToString("P"));
//
//int numero = 123456;
//
//Console.WriteLine(numero.ToString("##-##-##"));
















































//string numero1 = "10";
//int numero2 = 20;
//
//string resultado = numero1+numero2;
//Console.WriteLine(resultado);



















































//Pessoa p1 = new Pessoa("Pedro", "Lima");
//Pessoa p2 = new Pessoa("Lucas", "Buta");
//
//Curso cursoDeIngles = new Curso();
//cursoDeIngles.Nome = "Ingles";
//cursoDeIngles.Alunos = new List<Pessoa>();
//
//cursoDeIngles.AdicionarAluno(p1);
//cursoDeIngles.AdicionarAluno(p2);
//cursoDeIngles.ListarAlunos();







































//Pessoa p1 = new Pessoa();
//p1.Nome = "Pedro";
//p1.Sobrenome = "Lima";
//p1.Idade = 19;
//p1.A.presentar();
