public class Circulo : Forma
{
    private double raio;

    public Circulo(double raio)
    {
        this.raio = raio;
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
        return base.Mostrar() + $"\nÁrea: {CalcularArea():F2}\nPerímetro: {CalcularPerimetro():F2}";
    }

    public Bitmap ObterImagem()
    {
        return new Bitmap(@"C:\Users\caiof\Desktop\Projetos\POO\pco-ads-2024-2-p3-poo-Coscaio013\Ativuidade Figuras Geométricas\Classes\img\Circulo.png");
    }
}
