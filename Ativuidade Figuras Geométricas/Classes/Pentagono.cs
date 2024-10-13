public class Pentagono : Forma
{
    private double lado;

    public Pentagono(double lado)
    {
        this.lado = lado;
        CaminhoImagem = @"Classes\img\Pentagono.png";
    }

    public override double CalcularArea()
    {
        return (5 * lado * lado) / (4 * Math.Tan(Math.PI / 5));
    }

    public override double CalcularPerimetro()
    {
        return 5 * lado;
    }

    public override string Mostrar()
    {
        return base.Mostrar() + $"\nÁrea: {CalcularArea():F2}\nPerímetro: {CalcularPerimetro():F2}";
    }
}
