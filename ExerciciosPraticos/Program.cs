Console.WriteLine("## Classes e Objetos ##");

Carro chevrolet = new("Sedan", "Chevrolet", "Onix", 2016, 110);
Carro ford = new("SUV", "Ford", "EcoSport", 2018, 120);

Carro volkswagen = new("Subcompacto", "Volkswagen");
volkswagen.Acelerar(volkswagen.Marca); // Marca = null || pois não foi atribuido nenhuma string

chevrolet.Acelerar(chevrolet.Marca);
ford.Acelerar(ford.Marca);

chevrolet.VelocidadeMaxima(chevrolet.Potencia); 

ford.VelocidadeMaxima(ford.Potencia);

class Carro
{
    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    public int Ano;
    public int Potencia;

    public Carro(string modelo, string montadora, string marca, int ano, int potencia) 
    {
        Modelo = modelo;
        Montadora = montadora;
        Marca = marca;
        Ano = ano;
        Potencia = potencia;
    }

    public Carro(string modelo, string montadora)
    {
        Modelo = modelo;
        Montadora = montadora;
    }


    public void Acelerar(string? marca)
    {
        Console.WriteLine($"Acelerando o meu {marca}");
    }

    public int VelocidadeMaxima(int potencia)
    {
        int velocidade = (int)(potencia * 1.75);
        Console.WriteLine($"A velocidade máxima do {Marca} é de {velocidade} km/h");
        return velocidade;
    }
}