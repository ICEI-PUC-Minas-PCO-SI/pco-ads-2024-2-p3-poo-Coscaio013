
public abstract class Forma
{
    public string CaminhoImagem { get; set; }

    public abstract double CalcularArea();
    public abstract double CalcularPerimetro();

    public virtual string Mostrar()
    {
        return $"Forma: {GetType().Name}";
    }
}
