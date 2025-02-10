using Mercado.Data;
using Mercado.View;

namespace Mercado.Trabalho;
public class Edicao_de_Estoque
{
    public static void EdicaoDEEstoque()
    {
        Console.Clear();
        Console.WriteLine("O que deseja ??");
        Console.WriteLine("1 - Adicionar\n2 - Editar\n3 - Remover\n4 - voltar\n5 - Sair");
        string escolha = Console.ReadLine();

        switch (escolha)
        {
            case "1": AddItens addItens = new AddItens(); addItens.AddItem(); break;
            case "2":
            case "3": DeletarItens.deletaritens(); break;
            case "4": Entrada.entrada(); break;
            case "5": Environment.Exit(0); break;
            default: EdicaoDEEstoque(); break;
        }
    }
}