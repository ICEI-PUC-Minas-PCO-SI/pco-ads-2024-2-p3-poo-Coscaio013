using System;

namespace Ativuidade_Figuras_Geométricas
{
    public class Hexagono : Forma
    {
        private double lado;

        public Hexagono(double lado)
        {
            this.lado = lado;
            CaminhoImagem = @"Classes\img\Hexagono.png";
        }

        public override double CalcularArea()
        {
            return (3 * Math.Sqrt(3) * lado * lado) / 2;
        }

        public override double CalcularPerimetro()
        {
            return 6 * lado;
        }

        public override string Mostrar()
        {
            return base.Mostrar() + $"\nÁrea: {CalcularArea():F2}\nPerímetro: {CalcularPerimetro():F2}";
        }
    }
}
