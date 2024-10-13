 using System;

public abstract class Forma
    {
        public abstract double CalcularArea();
        public abstract double CalcularPerimetro();
        public virtual string Mostrar()
        {
            return "Forma: " + GetType().Name;
        }
    }
