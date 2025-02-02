using Mercado.View;
namespace Mercado.Trabalho;
public class Worck
{
    public static void worck(string usuario)
    {
        Console.WriteLine("Bem vindo ao trabalho {0}\nO que deseja ??", usuario);
        Console.WriteLine("1 - Edição de estoque\n2 - Sair\n3 - Voltar para tela inicial");
        string escolha = Console.ReadLine();
        switch (escolha)
        {
            case "1": Edicao_de_Estoque.EdicaoDEEstoque(); break;
            case "2": Console.Clear(); Environment.Exit(0); break;
            case "3": login.Login(); break;
            default: worck(usuario); break;
        }
    }
}
