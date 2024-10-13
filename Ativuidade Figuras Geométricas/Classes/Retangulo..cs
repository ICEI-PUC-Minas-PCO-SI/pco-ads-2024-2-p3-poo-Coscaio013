public class Retangulo : Forma
{
    private double largura;
    private double altura;

    public Retangulo(double largura, double altura)
    {
        this.largura = largura;
        this.altura = altura;
        CaminhoImagem = @"Classes\img\Retangulo.jpg";
    }

    public override double CalcularArea()
    {
        return largura * altura;
    }

    public override double CalcularPerimetro()
    {
        return 2 * (largura + altura);
    }

    public override string Mostrar()
    {
        return base.Mostrar() + $"\nÁrea: {CalcularArea():F2}\nPerímetro: {CalcularPerimetro():F2}";
    }
}
