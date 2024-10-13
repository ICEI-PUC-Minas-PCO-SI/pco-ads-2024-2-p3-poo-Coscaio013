public class Quadrado : Forma
    {
        private double lado;

        public Quadrado(double lado)
        {
            this.lado = lado;
        }

        public override double CalcularArea()
        {
            return lado * lado;
        }

        public override double CalcularPerimetro()
        {
            return 4 * lado;
        }

        public override string Mostrar()
        {
            return base.Mostrar() + $"\nÁrea: {CalcularArea():F2}\nPerímetro: {CalcularPerimetro():F2}\nImagem: [imagem do quadrado]";
        }
    }