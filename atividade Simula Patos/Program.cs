class Program
{
    static void Main(string[] args)
    {
        //Codigo para testar exercicios
        Duck[] ducks = {
            new IronDuck(),
            new MallardDuck(),
            new RedHeadDuck(),
            new RubberDuck()
        };

        for (int i = 0; i < ducks.Length; i++)
        {
            Duck duck = ducks[i];
            duck.Display();
            
            if (duck is IFlyable flyableDuck)
            {
                flyableDuck.Fly();
            }

            if (duck is IQuackable quackableDuck)
            {
                quackableDuck.Quack();
            }

            if (duck is ISwimable swimableDuck)
            {
                swimableDuck.Swin();
            }
            
            Console.WriteLine();
        }
    }
}