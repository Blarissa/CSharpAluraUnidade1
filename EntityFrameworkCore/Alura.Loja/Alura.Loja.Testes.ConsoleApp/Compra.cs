namespace Alura.Loja.Testes.ConsoleApp
{
    public class Compra
    {
        public int Id { get; internal set; }
        public int Quantidade { get; internal set; }
        public int ProdutoId { get; internal set; }
        public Produto Produto { get; internal set; }
        public double Preco { get; internal set; }

        public override string ToString()
        {
            return $"Compra N° {this.Id}\n" +
                $"Quantidade: {this.Quantidade}\n" +
                $"Produto N° {this.ProdutoId}\n" +                
                $"Preço total: {this.Preco:C}\n" +
                $"\n"; ;
        }
    }
}