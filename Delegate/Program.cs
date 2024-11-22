
public class Program
{

    public static void Main()
    {
        int n1 = 0, n2 = 0 ,x = 0;;
        Calcular operacao ;
        //teste
        while (x < 5)
        {
            GetValores(ref n1, ref n2);
    
            operacao = Sum;
            Console.WriteLine("Soma:" + operacao(n1, n2));

            operacao = Sub;
            Console.WriteLine("Subtraçao:" + operacao(n1, n2));

            x++;
        }
    }

    public delegate int Calcular(int a, int b);

    public static int Sum(int a, int b)
    {
        return a + b;
    }

    public static int Sub(int a, int b)
    {
        return a - b;
    }

    public static void GetValores(ref int a, ref int b)
    {
        Console.WriteLine("Digite o primeiro número:");
        a = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        b = int.Parse(Console.ReadLine());
    }
}
