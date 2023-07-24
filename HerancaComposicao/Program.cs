using HerancaComposicao;

Console.WriteLine("## Herança e Composição ##");

ComportamentoNadar nadar = new();
ComportamentoAndar andar = new();

Homem homem = new(andar);
homem.Locomocao();

Macaco macaco = new(andar);
macaco.Locomocao();

Sardinha sardinha = new(nadar);
sardinha.Locomocao();