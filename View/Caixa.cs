using Mercado.Models;
namespace Mercado.View;
    public class Caixa{
        public static void caixa(){
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
                try{
                    Console.WriteLine("\nTotal da conta: R${0}\n", total.ToString("N2"));
                    Console.Write("Valor a pagar:R$");
                    double dinheiro = double.Parse(Console.ReadLine());
                    if(dinheiro < total){
                        Console.WriteLine("Valor insuficiente");
                        Console.ReadLine();
                        caixa();
                    }else{
                        double troco = dinheiro - total;
                        Console.WriteLine("Compra confirmada\nTroco: R${0}", troco.ToString("N2"));
                        Console.ReadLine();
                        CarrinhoItem.carrinhoItem.Clear();
                        Atendimento.Main();
                    }
                }catch(FormatException){
                    Console.WriteLine("Valor não reconhecido");
                    Console.ReadLine();
                    caixa();
                }
            }
        }
    }