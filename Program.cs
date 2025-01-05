namespace Mercado;
    public class Atendimento{
        public static void Main(){
            Console.Clear();
            Console.WriteLine("Bem vindo ao mercado\nO que deseja ?");
            Console.WriteLine("1 - Carrinho\n2 - Caixa\n3 - Estoque\n4 - Sair");

            string escolha =  Console.ReadLine();
            switch (escolha){
                case "1": View.Carrinho.carrinho(); break;
                case "2": View.Caixa.caixa(); break;
                case "3": View.Estoque.estoque(); break;
                case "4": Console.Clear(); Environment.Exit(0); break;
                default: Main(); break; 
            }
        }
    }