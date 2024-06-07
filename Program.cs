using SistemaCrudProdutos;

Produto produto = new Produto(0, "", 0);

while (true)
{
    Console.WriteLine("Sistema de Cadastro de Produtos");
    Console.WriteLine("1. Adicionar Produto");
    Console.WriteLine("2. Listar Produtos");
    Console.WriteLine("3. Editar Produto");
    Console.WriteLine("4. Excluir Produto");
    Console.WriteLine("5. Sair");
    Console.Write("Escolha uma opção: ");
    int opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            produto.AdicionarProduto();
            break;
        case 2:
            produto.ListarProdutos();
            break;
        case 3:
            produto.EditarProduto();
            break;
        case 4:
            produto.ExcluirProduto();
            break;
        case 5:
            return;
        default:
            Console.WriteLine("Opção inválida, tente novamente.");
            break;
    }
}