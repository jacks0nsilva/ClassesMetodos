Console.WriteLine("Exemplo de sobrecarga de métodos");

Cadastro cadastro = new();
var cliente = cadastro.Registrar();
cadastro.exibirDados(cliente);


// Alterar renda
cliente = cadastro.Registrar(cliente);
cadastro.exibirDados("Renda alterada", cliente);
class Cliente
{
    public string? Nome;
    public int Idade;
    public decimal Renda;

    public Cliente(string? nome, int idade, decimal renda)
    {
        Nome = nome;
        Idade = idade;
        Renda = renda;
    }
   
    public Cliente() // Construtor sem parâmetros, para atribuir valores padrão caso o objeto seja instanciado sem argumentos
    { }
}

class Cadastro
{
    public Cliente Registrar()
    {
        Cliente cliente = new("Maria", 23, 3000);
        return cliente;
    }

    public Cliente Registrar(Cliente cliente) // Sobrecarga do método Registrar
    {
        cliente.Renda = 3500;
        return cliente;
    }

    public void exibirDados( Cliente cliente)
    {
        Console.WriteLine($"{cliente.Nome} {cliente.Idade} {cliente.Renda:C}");
    }

    public void exibirDados(string texto, Cliente cliente)
    {
        Console.WriteLine($"\n{texto}\t");
        Console.WriteLine($"{cliente.Nome} {cliente.Idade} {cliente.Renda:C}");
    }
}