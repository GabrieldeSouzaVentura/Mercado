using Mercado.View;
namespace Mercado.Models;
    public class CarrinhoItem{
        public static List<Produto> carrinhoItem = new List<Produto>();
        public static void carrinhoAdd(int escolha, int quantidade, List<Produto> estoqueView, List<Produto> carrinhoItem){
            Produto selecionado = estoqueView[escolha - 1];
            carrinhoItem.Add (new Produto (selecionado.Id, selecionado.Nome, selecionado.Preco, quantidade));
            estoqueView[escolha - 1].Quantidade -= quantidade;
            Console.Clear();
            Estoque.estoque();
        }
    }