namespace Vendas
{
    internal class ProdutoListaDAO : BuscarProduto
    {
        public int Id_Produto { get; set; }
        public string Nome { get; set; }
        public int Preco { get; set; }
    }
}