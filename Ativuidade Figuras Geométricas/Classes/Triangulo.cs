public class Triangulo : Forma
    {
        private double baseTriangulo;
        private double altura;

        public Triangulo(double baseTriangulo, double altura)
        {
            this.baseTriangulo = baseTriangulo;
            this.altura = altura;
        }

        public override double CalcularArea()
        {
            return (baseTriangulo * altura) / 2;
        }

        public override double CalcularPerimetro()
        {
            return baseTriangulo + 2 * (Math.Sqrt(Math.Pow(baseTriangulo / 2, 2) + Math.Pow(altura, 2)));
        }

        public override string Mostrar()
        {
            return base.Mostrar() + $"\nÁrea: {CalcularArea():F2}\nPerímetro: {CalcularPerimetro():F2}\nImagem: [imagem do triângulo]";
        }
    }