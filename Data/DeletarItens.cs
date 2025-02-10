using Mercado.Trabalho;
namespace Mercado.Data;
public static class DeletarItens
{
    public static void deletaritens()
    {
        Console.Clear();
        Console.WriteLine("Qual item deseja deletar ou 0 para voltar?");
        var estoqueView = DbContext.EstoqueView;
        for (int i = 0; i < estoqueView.Count; i++)
        {
            Console.WriteLine("{0}: - {1} - R$ {2} - quantidade: {3}", estoqueView[i].Id, estoqueView[i].Nome, estoqueView[i].Preco, estoqueView[i].Quantidade);
        }
        int escolha = int.Parse(Console.ReadLine());
        if (escolha == 0)
        {
            Edicao_de_Estoque.EdicaoDEEstoque();
        }
        else if (escolha <= estoqueView.Count && escolha > 0)
        {
            DbContext.Deletar(escolha);
        }
        else
        {
            Console.WriteLine("Produto não encontrado");
            Console.ReadLine();
            deletaritens();
        }
    }
}