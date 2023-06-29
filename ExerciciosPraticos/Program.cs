using ClasseDosCarros;

Console.WriteLine("## Classes e Objetos ##");

Carro chevrolet = new("Sedan", "Chevrolet", "Onix", 2016, 110);
Carro ford = new("SUV", "Ford", "EcoSport", 2018, 120);

Carro volkswagen = new("Subcompacto", "Volkswagen");
volkswagen.Acelerar(volkswagen.Marca); // Marca = null || pois não foi atribuido nenhuma string

chevrolet.Acelerar(chevrolet.Marca);
ford.Acelerar(ford.Marca);

chevrolet.VelocidadeMaxima(chevrolet.Potencia); 

ford.VelocidadeMaxima(ford.Potencia);

Console.WriteLine("--------------------------------------------------------------------------");

Console.WriteLine("Aumentando a Potencia (por valor : + 3CV) : ");
var novaPotenciaChevrolet = chevrolet.AumentarPotencia(chevrolet.Potencia);

Console.Write("-> " + novaPotenciaChevrolet);
Console.WriteLine("\nO valor do campo Potencia não foi alterado : " + chevrolet.Potencia);

Console.WriteLine("--------------------------------------------------------------------------");

Console.WriteLine("Aumentando a Potencia (por valor: +3CV) :");
var novaPotenciaFord = ford.AumentarPotencia(ref ford.Potencia);

Console.Write("-> " + novaPotenciaFord);

Console.WriteLine("\nO valor do campo Potencia foi alterado: " + ford.Potencia);

Console.WriteLine("--------------------------------------------------------------------------");

Console.WriteLine("\nUsando parâmetro out => Aumenta potencia e velocidade ");
double novaPotencia = chevrolet.AumentarPotenciaVelocidade(chevrolet.Potencia, out double velocidade);
Console.WriteLine("-Nova Potencia : " + novaPotencia);
Console.WriteLine("-Nova Velocidade Máxima : " + velocidade);

/* 
 A palavra-chave out é usada para passar um argumento por referência igual a ref, mas o argumento pode ser
passado sem atribuir nenhum valor a ele. Um argumento que é passado usando out deve ser inicializado no
método chamado antes de retornar ao método chamador.
Podemos usar a palavra-chave out para obter mais de um retorno de um método
 */

Console.WriteLine("--------------------------------------------------------------------------");

ford.ExibirInfo(modelo: ford.Modelo, montadora: ford.Montadora, marca: ford.Marca, potencia: ford.Potencia);
// Argumento ano opcional, nesse caso o parâmetro ano será padrão

chevrolet.ExibirInfo(modelo: chevrolet.Modelo, montadora: chevrolet.Montadora, marca: chevrolet.Marca, potencia: chevrolet.Potencia, ano: ford.Ano);