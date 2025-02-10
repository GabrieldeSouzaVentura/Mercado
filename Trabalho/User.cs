using Mercado.Data;
using Mercado.View;
namespace Mercado.Trabalho;
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
            Entrada.entrada();
        }
        else
        {
            Console.WriteLine("Inserir Senha de {0}", usuario);
            senha = Console.ReadLine();
            if (moderador.Validacao(usuario, senha))
            {
                Console.Clear();
                Console.WriteLine("Senha correta\nBem vindo {0}", usuario);
                Console.ReadLine();
                Worck.worck(usuario);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Senha ou Usuario incorreto");
                Console.ReadLine();
                user();
            }
        }
    }
}