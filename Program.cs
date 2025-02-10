using Mercado.View;
namespace Mercado;
public class Atendimento
{
    public static void Main()
    {
        Entrada.entrada();
    }
    public static void atendimento()
    {
        Console.Clear();
        Console.WriteLine("O que deseja ?");
        Console.WriteLine("1 - Carrinho\n2 - Caixa\n3 - Estoque\n4 - Sair\n5 - Voltar");

        string escolha = Console.ReadLine();
        switch (escolha)
        {
            case "1": Carrinho.carrinho(); break;
            case "2": Caixa.caixa(); break;
            case "3": Estoque.estoque(); break;
            case "4": Console.Clear(); Environment.Exit(0); break;
            case "5": Entrada.entrada(); break;
            default: atendimento(); break;
        }
    }
}