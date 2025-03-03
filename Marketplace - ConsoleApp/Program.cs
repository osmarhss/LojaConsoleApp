using Marketplace___ConsoleApp.MétodosDePagamento;
using Marketplace___ConsoleApp.Pedidos;
using Marketplace___ConsoleApp.Produtos;
using Marketplace___ConsoleApp.Usuários;


//Executando um exemplo de filtro
var listaProdutos = Produto.GetProdutos();
var listaFiltrada1 = FiltroProdutos.ObterPrecoFiltrado(listaProdutos, new decimal[2] {200.00m, 2000.00m});
ExibirResultadoFiltrado(listaFiltrada1);



Console.ReadKey();

static void ExibirResultadoFiltrado(IEnumerable<Produto> listaP) 
{
    foreach (var item in listaP) 
    {
        Console.WriteLine(item.ToString());
    }
}