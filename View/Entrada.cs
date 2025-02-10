using Mercado.Trabalho;
namespace Mercado.View;
public class Entrada
{
    public static void entrada()
    {
        Console.Clear();
        Console.WriteLine("Bem vindo ao Mercado\n1 - Cliente\n2 - Funcionario\n3 - Sair");
        string escolha = Console.ReadLine();

        switch (escolha)
        {
            case "1":Atendimento.atendimento(); break;
            case "2":User.user(); break;
            case "3":Console.Clear(); Environment.Exit(0); break;
            default: entrada(); break;
        }
    }
}