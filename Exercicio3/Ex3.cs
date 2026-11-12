Console.Write("Digite o tamanho do vetor: ");
int tamanho = int.Parse(Console.ReadLine());

int[] fibonacci = new int[tamanho];

void PreencheFibonacci()
{
    fibonacci[0] = 0;
    fibonacci[1] = 1;
    for(int i = 2; i < fibonacci.Length; i++)
    {
        fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
    }
}

void imprimeFibonacci()
{
    for(int i = 0; i < fibonacci.Length; i++)
    {
        Console.Write($"[{fibonacci[i]}]");
    }
}

PreencheFibonacci();
imprimeFibonacci();
