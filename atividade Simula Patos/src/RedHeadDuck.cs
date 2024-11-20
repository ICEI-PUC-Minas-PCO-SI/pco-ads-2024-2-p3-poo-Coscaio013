class RedHeadDuck : Duck, IFlyable, IQuackable,ISwimable
{
    public override void Display()
    {
        Console.WriteLine("Displaying a RedHead Duck");
    }

    public void Fly()
    {
        Console.WriteLine("RedHead Duck is flying");
    }

    public void Quack()
    {
        Console.WriteLine("Quack, quack!!");
    }


    public void Swin()
    {
         Console.WriteLine("The RedHeadDuck is swimming");
    }
}