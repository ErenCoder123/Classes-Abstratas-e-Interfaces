public class Bicicleta : Veiculo, IAceleravel
{
    public Bicicleta(string marca, string modelo):base(marca, modelo)
    {
        
    }
    public override void Ligar()
    {
        Console.WriteLine("A bicicleta está ligada.");
    }
    public void Acelerar()
    {
        Console.WriteLine("A bicicleta esta pedalando mais rapido.");
    }

}