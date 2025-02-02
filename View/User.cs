using Mercado.Trabalho;
using Mercado.Data;
namespace Mercado.View;
public class User
{
    public static void user()
    {
        string usuario = "";
        string senha = "";

        Console.Clear();
        Moderador moderador = new Moderador();

        Console.WriteLine("Inserir nome de usuario ou 0 para voltar");
        usuario = Console.ReadLine();
        if (usuario == "0")
        {
            login.Login();
        }
        else
        {
            Console.WriteLine("Inserir Senha de {0}", usuario);
            senha = Console.ReadLine();
            if (moderador.Validacao(usuario, senha))
            {
                Console.WriteLine("Senha correta\nBem vindo {0}", usuario);
                Console.ReadLine();
                Worck.worck(usuario);
            }
            else
            {
                Console.WriteLine("Senha ou Usuario incorreto");
                Console.ReadLine();
                user();
            }
        }
    }
}