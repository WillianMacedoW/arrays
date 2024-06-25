List<Veiculo> veiculos = new List<Veiculo> ();
Carro carro= new Carro();
Moto moto= new Moto();
veiculos.Add(carro);
veiculos.Add(moto);

foreach (var veiculo in veiculos){
    veiculo.Acelerar();
    veiculo.Exibirvelocidade();
    veiculo.Frear();
    veiculo.Exibirvelocidade();
    Console.WriteLine();
}
