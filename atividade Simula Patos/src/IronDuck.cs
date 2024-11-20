class IronDuck : Duck , IFlyable
{
    public override void Display()
    {
       Console.WriteLine("Displaying a IronDuck");
    }

    public void Fly()
    {
        Console.WriteLine("IronDuck Duck is flying");
    }

}