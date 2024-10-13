public class Circulo : Forma
{
    private double raio;

    public Circulo(double raio)
    {
        this.raio = raio;
        CaminhoImagem = @"Classes\img\Circulo.png";
    }

    public override double CalcularArea()
    {
        return Math.PI * Math.Pow(raio, 2);
    }

    public override double CalcularPerimetro()
    {
        return 2 * Math.PI * raio;
    }

    public override string Mostrar()
    {
        return base.Mostrar() + $"\nRaio: {raio}\nÁrea: {CalcularArea():F2}\nPerímetro: {CalcularPerimetro():F2}";
    }
}
