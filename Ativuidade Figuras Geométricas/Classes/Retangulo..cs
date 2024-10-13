public class Retangulo : Forma
    {
        private double largura;
        private double altura;

        public Retangulo(double largura, double altura)
        {
            this.largura = largura;
            this.altura = altura;
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
            return base.Mostrar() + $"\nÁrea: {CalcularArea():F2}\nPerímetro: {CalcularPerimetro():F2}\nImagem: [imagem do retângulo]";
        }
         public Bitmap ObterImagem()
    {
        return new Bitmap(@"C:\Users\caiof\Desktop\Projetos\POO\pco-ads-2024-2-p3-poo-Coscaio013\Ativuidade Figuras Geométricas\Classes\img\Circulo.png");
    }
    }