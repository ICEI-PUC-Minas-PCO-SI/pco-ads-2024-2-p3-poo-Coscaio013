class RubberDuck : Duck, IQuackable,ISwimable
{
    public override void Display()
    {
        Console.WriteLine("Displaying a Rubber Duck");
    }


    public void Quack()
    {
        Console.WriteLine("Quack, quack!!");
    }

    public void Swin()
    {
        Console.WriteLine("The Rubberduck is swimming");
    }
}