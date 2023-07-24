namespace HerancaComposicao
{
    public class Homem : Animal
    {
        private readonly ComportamentoAndar _comportamentoAndar;
        // A propriedade privada e somente leitura para não poder ser alterada após receber a instância do construtor.

        public Homem(ComportamentoAndar comportamentoAndar)
        {
            _comportamentoAndar = comportamentoAndar;
        }

        public void Locomocao()
        {
            Console.WriteLine(nameof(Homem));
            _comportamentoAndar.Andar();
        }
    }
}
