using Mercado.Models;
using Mercado.Trabalho;
namespace Mercado.Data;
public class DbContext
{
    private static List<Produto> estoque = new List<Produto>();
    private static int proximoId = 1;
    static DbContext()
    {
        Estoque();
    }
    static void Estoque()
    {
        if (estoque.Count == 0)
        {
            estoque.Add(new Produto(proximoId++, "Arroz", 27.50, 10));
            estoque.Add(new Produto(proximoId++, "Feijão", 9.79, 15));
            estoque.Add(new Produto(proximoId++, "Macarrão", 6.29, 20));
            estoque.Add(new Produto(proximoId++, "Óleo", 9.50, 8));
            estoque.Add(new Produto(proximoId++, "Leite", 5.64, 12));
            estoque.Add(new Produto(proximoId++, "Ovos", 6.99, 30));
            estoque.Add(new Produto(proximoId++, "Pão", 6.50, 25));
            estoque.Add(new Produto(proximoId++, "Açúcar", 7.49, 18));
            estoque.Add(new Produto(proximoId++, "Café", 11.99, 10));
            estoque.Add(new Produto(proximoId++, "Sabão em pó", 23.75, 5));
        }
    }
    public static void Deletar(int escolha)
    {
        var Delete =estoque.OrderBy(p => p.Id).FirstOrDefault(p => p.Id == escolha);
        if (Delete != null)
        {
            Console.WriteLine("Produto de:\nId: {0}\nNome: {1}\nValor: {2}\nQuantidade: {3}\nREMOVIDO", Delete.Id,  Delete.Nome, Delete.Preco, Delete.Quantidade);
            estoque.Remove(Delete);
            Console.ReadLine();
            DeletarItens.deletaritens();
        }else
        {
            Console.WriteLine("Produto não encontrado");
            Console.ReadLine();
            DeletarItens.deletaritens();
        }
    }
    public static void additem(string addnome, double addpreco, int addquantidade)
    {
        estoque.Add(new Produto(proximoId++, addnome, addpreco, addquantidade));
        Console.WriteLine("Produto\nNome: {0}\nValor: {1}\nQuantidade: {2}\nAdicionado com sucesso", addnome, addpreco, addquantidade);
        Console.ReadLine();
        Edicao_de_Estoque.EdicaoDEEstoque();
    }
    public static IReadOnlyList<Produto> EstoqueView => estoque;
}