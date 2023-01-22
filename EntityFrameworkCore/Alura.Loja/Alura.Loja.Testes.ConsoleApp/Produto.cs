namespace Alura.Loja.Testes.ConsoleApp
{
    public class Produto
    {
        public int Id { get; internal set; }
        public string Nome { get; internal set; }
        public string Categoria { get; internal set; }
        public double PrecoUnitario { get; internal set; }
        public string Unidade { get; internal set; }



        public override string ToString()
        {
            return $"Produto N° {this.Id}\n" +
                $"Nome: {this.Nome}\n" +
                $"Categoria: {this.Categoria}\n" +
                $"Preço unitário: {this.PrecoUnitario:C}\n" +
                $"Unidade: {this.Unidade}\n" +
                $"\n";
        }
    }
}