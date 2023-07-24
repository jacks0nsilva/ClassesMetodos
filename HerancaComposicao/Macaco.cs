namespace HerancaComposicao
{
    public class Macaco : Animal
    {
        private readonly ComportamentoAndar _comportamentoAndar;
        // A propriedade privada e somente leitura para não poder ser alterada após receber a instância do construtor.

        public Macaco(ComportamentoAndar comportamentoAndar)
        {
            _comportamentoAndar = comportamentoAndar;
        }

        public void Locomocao()
        {
            Console.WriteLine(nameof(Macaco));
            _comportamentoAndar.Andar();
        }
    }
}
