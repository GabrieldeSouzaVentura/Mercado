using Mercado.Models;
namespace Mercado.View;
    public class Carrinho{
        public static void carrinho(){
            Console.Clear();
            if(CarrinhoItem.carrinhoItem.Count == 0){
                Console.WriteLine("O carrinho esta vazio");
                Console.ReadLine();
                Atendimento.Main();
            }else{
                double total = 0;
                foreach(var Produto in CarrinhoItem.carrinhoItem){
                    double subtotal = Produto.Preco * Produto.Quantidade;
                    Console.WriteLine("{0} - R${1} X {2} = {3}", Produto.Nome, Produto.Preco, Produto.Quantidade, subtotal.ToString("N2"));
                    total += subtotal;
                }
                Console.WriteLine("\nTotal da conta: R${0}\n", total.ToString("N2"));
                Console.WriteLine("Deseja voltar para o atendimento? (S/N)");
                string escolha = Console.ReadLine();
                if(escolha == "s"){
                    Atendimento.Main();
                }else{
                    carrinho();
                }
            }
        }
    }