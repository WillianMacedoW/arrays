public abstract class Veiculo
{
protected int velocidade;
public abstract void Acelerar();
public abstract void Frear();

public void Exibirvelocidade(){
System.Console.WriteLine($" Valocidade atual {velocidade}");
}

}
