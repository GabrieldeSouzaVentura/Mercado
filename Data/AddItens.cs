using Mercado.Trabalho;
namespace Mercado.Data
{
    public class AddItens
    {
        private string addnome;
        private double addpreco;
        private int addquantidade;

        public void AddItem()
        {
            Console.Clear();
            Console.WriteLine("Qual o nome do item que deseja adicionar ou V para sair??");
            addnome = ValidarEntradaString(Console.ReadLine());
            if (addnome == "V"|| addnome == "v")
            {
                Edicao_de_Estoque.EdicaoDEEstoque();
            }
            else
            {
                Console.WriteLine("Qual o valor do item que deseja adicionar ??");
                addpreco = ValidarEntradaDouble(Console.ReadLine());

                Console.WriteLine("Qual a quantidade que deseja adicionar ??");
                addquantidade = ValidarEntradaInt(Console.ReadLine());
                DbContext.additem(addnome, addpreco, addquantidade);
            }
        }
        private int ValidarEntradaInt(string input)
        {
            int valor;
            while (!int.TryParse(input, out valor))
            {
                Console.Clear();
                Console.WriteLine("Valor inválido. Digite um número inteiro válido.");
                input = Console.ReadLine();
                AddItem();
            }
            return valor;
        }
        private double ValidarEntradaDouble(string input)
        {
            double valor;
            while (!double.TryParse(input, out valor))
            {
                Console.Clear();
                Console.WriteLine("Valor inválido. Digite um número válido.");
                input = Console.ReadLine();
                AddItem();
            }
            return valor;
        }
        private string ValidarEntradaString(string input)
        {
            while (string.IsNullOrEmpty(input))
            {
                Console.Clear();
                Console.WriteLine("Valor inválido. O nome do item não pode ser vazio.");
                input = Console.ReadLine();
                AddItem();
            }
            return input;
        }
    }
}