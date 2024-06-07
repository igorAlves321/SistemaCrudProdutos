namespace SistemaCrudProdutos;

public class Produto
{
    private static List<Produto> produtos = new List<Produto>();
    public int CodigoProduto { get; set; }
    public string Nome { get; set; }
    public decimal Preco { get; set; }

    public Produto(int codigoProduto, string nome, decimal preco)
    {
        CodigoProduto = codigoProduto;
        Nome = nome;
        Preco = preco;
    }

    public void AdicionarProduto()
    {
        Console.Write("Digite o código do produto: ");
        int codigo = int.Parse(Console.ReadLine());
        Console.Write("Digite o nome do produto: ");
        string nome = Console.ReadLine();
        Console.Write("Digite o preço do produto: ");
        decimal preco = decimal.Parse(Console.ReadLine());
        Produto produto = new Produto(codigo, nome, preco);
        produtos.Add(produto);
        Console.WriteLine("Produto cadastrado com exito.");
    }

    public void ListarProdutos()
    {
        Console.WriteLine("Lista de Produtos:");
        foreach (var produto in produtos)
        {
            Console.WriteLine(produto);
        }
    }

    public void EditarProduto()
    {
        Console.Write("Digite o código do produto que deseja editar: ");
        int codigo = int.Parse(Console.ReadLine());
        Produto produto = produtos.Find(p => p.CodigoProduto == codigo);

        if (produto != null)
        {
            Console.Write("Digite o novo nome do produto: ");
            produto.Nome = Console.ReadLine();
            Console.Write("Digite o novo preço do produto: ");
            produto.Preco = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Produto editado com sucesso!");
        }
        else
        {
            Console.WriteLine("Produto não encontrado.");
        }
    }

    public void ExcluirProduto()
    {
        Console.Write("Digite o código do produto que deseja excluir: ");
        int codigo = int.Parse(Console.ReadLine());
        Produto produto = produtos.Find(p => p.CodigoProduto == codigo);

        if (produto != null)
        {
            produtos.Remove(produto);
            Console.WriteLine("Produto excluído com sucesso!");
        }
        else
        {
            Console.WriteLine("Produto não encontrado.");
        }
    }

    public override string ToString()
    {
        return $"Código: {CodigoProduto}, Nome: {Nome}, Preço: {Preco:C}";
    }

}
