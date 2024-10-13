public class Octagono : Forma
{
    private double lado;

    public Octagono(double lado)
    {
        this.lado = lado;
        CaminhoImagem = @"Classes\img\Octagono.png";
    }

    public override double CalcularArea()
    {
        return 2 * (1 + Math.Sqrt(2)) * Math.Pow(lado, 2);
    }

    public override double CalcularPerimetro()
    {
        return 8 * lado;
    }

    public override string Mostrar()
    {
        return base.Mostrar() + $"\nÁrea: {CalcularArea():F2}\nPerímetro: {CalcularPerimetro():F2}";
    }
}
