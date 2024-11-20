class MallardDuck : Duck, IFlyable, IQuackable,ISwimable 
{
    public override void Display()
    {
        Console.WriteLine("Displaying a Mallard Duck");
    }

    public void Fly()
    {
        Console.WriteLine("Mallard Duck is flying");
    }

    public void Quack()
    {
        Console.WriteLine("Quack, quack!!");
    }

    public void Swin()
    {
        Console.WriteLine("The MallardDuck is swimming");
    }
}