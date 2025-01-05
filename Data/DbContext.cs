using Mercado.Models;
namespace Mercado.Data;
    public class DbContext{
        private static List<Produto> estoque = new List<Produto>();
        static DbContext(){
            Estoque();
        }
        static void Estoque(){
            estoque.Add(new Produto(1, "Arroz", 27.50, 10));
            estoque.Add(new Produto(2, "Feijão", 9.79, 15));
            estoque.Add(new Produto(3, "Macarrão", 6.29, 20));
            estoque.Add(new Produto(4, "Óleo", 9.50, 8));
            estoque.Add(new Produto(5, "Leite", 5.64, 12));
            estoque.Add(new Produto(6, "Ovos", 6.99, 30));
            estoque.Add(new Produto(7, "Pão", 6.50, 25));
            estoque.Add(new Produto(8, "Açúcar", 7.49, 18));
            estoque.Add(new Produto(9, "Café", 11.99, 10));
            estoque.Add(new Produto(10, "Sabão em pó", 23.75, 5));
        }
        public static IReadOnlyList<Produto> EstoqueView => estoque;
    }