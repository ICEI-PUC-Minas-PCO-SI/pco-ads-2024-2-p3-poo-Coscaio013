internal class Program
{
    private static void Main(string[] args)
    {   
        //PARTE 1
         Console.WriteLine("Parte 1 - Questao 1");
            Questao1();
         Console.WriteLine("Parte 1 - Questao 2");
            Questao2();
         Console.WriteLine("Parte 1 - Questao 3");
            Questao3();
        Console.WriteLine("Parte 2 - Questao 4");
            Questao4();
    }

     static void Questao1()
    {
        int numero;

        while (true)
        {
            try
            {
                Console.Write("Digite um numero inteiro: ");
                numero = int.Parse(Console.ReadLine());
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Valor invalido! Insira um numero inteiro.");
            }
        }

        if (fValPrimo(numero))
            Console.WriteLine($"{numero} é primo.");
        else
            Console.WriteLine($"{numero} não primo.");
    }

    private static bool fValPrimo(int num)
    {
        if (num < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
                return false;
        }
        return true;
    }

    private static void Questao2()
    {
        try
        {
            Console.Write("Digite o primeiro numero: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo numero: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Escolha uma operação: ");
            Console.WriteLine("1 - Soma (+)");
            Console.WriteLine("2 - Subtração (-)");
            Console.WriteLine("3 - Multiplicação (*)");
            Console.WriteLine("4 - Divisão (/)");
            Console.WriteLine("5 - Módulo (%)");
            Console.Write("Digite a operação desejada : ");
            int operacao = int.Parse(Console.ReadLine());

            double resultado = operacao switch
            {
                1 => num1 + num2,
                2 => num1 - num2,
                3 => num1 * num2,
                4 => num2 != 0 ? num1 / num2 : throw new DivideByZeroException("Divisão por zero não permitida."),
                5 => num2 != 0 ? num1 % num2 : throw new DivideByZeroException("Divisão por zero não permitida."),
                _ => throw new InvalidOperationException("Operação inválida! Selecione uma operação entre 1 e 5.")
            };

            Console.WriteLine($"Resultado: {resultado}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Erro: Entrada inválida. Por favor, insira numeros válidos.");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }


 static void Questao4()
    {
        int[] vetor = new int[10];

        Console.WriteLine("Preenchendo o vetor de 10 posições.");
        for (int i = 0; i < 10; i++)
        {
            while (true)
            {
                try
                {
                    Console.Write($"Digite a posição (0-9) onde deseja inserir o valor [{i + 1}/10]: ");
                    int posicao = int.Parse(Console.ReadLine());

                    Console.Write("Digite o valor para inserir na posição: ");
                    int valor = int.Parse(Console.ReadLine());

                    vetor[posicao] = valor;
                    break;
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Erro: A posição informada está fora do intervalo permitido (0-9).");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Erro: Por favor, insira apenas numeros inteiros.");
                }
            }
        }

        Console.WriteLine("\nVetor preenchido com sucesso! Valores:");
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.WriteLine($"Posição {i}: {vetor[i]}");
        }
    }
    public static void SomarNumeros()
    {
        int soma = 0;
        int quantidadeNumeros = 0;

        Console.WriteLine("Digite numeros para somar. A soma será interrompida se ultrapassar 100.");

        while (true)
        {
            try
            {
                Console.Write("Digite um numero: ");
                int numero = int.Parse(Console.ReadLine());

                if (soma + numero > 100)
                {
                    throw new ExcecaoAcimaDeCem($"A soma ultrapassou o limite de 100 ao adicionar {numero}. Soma atual: {soma}");
                }

                soma += numero;
                quantidadeNumeros++;
            }
            catch (ExcecaoAcimaDeCem ex)
            {
                Console.WriteLine($"\n{ex.Message}");
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: Entrada inválida. Por favor, insira um numero inteiro.");
            }
        }

        if (quantidadeNumeros > 0)
        {
            double media = (double)soma / quantidadeNumeros;
            Console.WriteLine($"\nResultados:");
            Console.WriteLine($"Soma total antes de ultrapassar 100: {soma}");
            Console.WriteLine($"Quantidade de numeros somados: {quantidadeNumeros}");
            Console.WriteLine($"Média: {media:F2}");
        }
        else
        {
            Console.WriteLine("Nenhum numero válido foi somado.");
        }
    }

}