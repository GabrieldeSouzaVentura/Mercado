using Mercado.Models;
using Mercado.Data;
namespace Mercado.View;
    public class Estoque{
        public static void estoque(){
            Console.Clear();
            var estoqueView = DbContext.EstoqueView;
            for(int i = 0; i <estoqueView.Count; i++){
                Console.WriteLine("{0}: - {1} - R$ {2} - quantidade: {3}", i + 1, estoqueView[i].Nome, estoqueView[i].Preco, estoqueView[i].Quantidade);
            }
            Console.WriteLine("Escolha um produto para adicionar ou 0 para sair");
            try{
                int escolha = int.Parse(Console.ReadLine());
                if(escolha <= estoqueView.Count && escolha > 0){
                    Console.WriteLine("Quantos deseja adicionar ?");

                    int quantidade = int.Parse(Console.ReadLine());
                    if(quantidade > 0 && quantidade <= estoqueView[escolha - 1].Quantidade){
                        CarrinhoItem.carrinhoAdd(escolha, quantidade, (List<Produto>)estoqueView, CarrinhoItem.carrinhoItem);
                    }else{
                        Console.WriteLine("Quantidade invalida");
                        Console.ReadLine();
                        estoque();
                    }
                }else if(escolha == 0){
                        Console.Clear();
                        Atendimento.Main();
                }else{
                    Console.WriteLine("Escolha invalida");
                    Console.ReadLine();
                    estoque();
                }
            }catch(FormatException){
                Console.WriteLine("Valor não reconhecido");
                Console.ReadLine();
                estoque();
            }   
        }
    }