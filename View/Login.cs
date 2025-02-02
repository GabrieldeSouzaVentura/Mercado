namespace Mercado.View;
class login
{
    public static void Login()
    {
        Console.Clear();
        Console.WriteLine("Bem vindo ao Mercado\n1 - Cliente ou 2 - Funcionario ??");
        int escolha = int.Parse(Console.ReadLine());

        if (escolha == 1)
        {
            Atendimento.atendimento();
        }
        else if(escolha == 2)
        {
            User.user();
        }else
        {
            Login();
        }
    }
}
