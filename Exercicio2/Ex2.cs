int[] numeros = new int[5];
int[] numerosInvertidos = new int[5];
int[] numerosPares = new int[5];
int[] numerosImpares = new int[5];
int contador = 0;
int cont2 = 0;

void leNumeros()
{
    for (int i = 0; i < numeros.Length; i++)
    {
        Console.Write($"Informe o {i + 1}º número: ");
        numeros[i] = int.Parse(Console.ReadLine());
    }
}

void passaNumeros()
{
    for(int i = 0; i < numeros.Length; i++)
    {
        numerosInvertidos[numeros.Length - 1 - i] = numeros[i];
        if (numeros[i] %2 == 0)
        {
            numerosPares[contador] = numeros[i];
            contador++;
        }
        if (numeros[i] %2 != 0)
        {
            numerosImpares[cont2] = numeros[i];
            cont2++;
        }
    }
}

void imprimeVetores()
{
    Console.Write("Vetor original: ");
    for (int i = 0; i < numeros.Length; i++)
    {
        Console.Write($"[{numeros[i]}]");
    }
    Console.WriteLine("\n");

    Console.Write("Vetor invertido: ");
    for (int j = 0; j < numerosInvertidos.Length; j++)
    {
        Console.Write($"[{numerosInvertidos[j]}]");
    }
    Console.WriteLine("\n");
    Console.Write("Vetor de números pares: ");
    for (int k = 0; k < numerosPares.Length; k++)
    {
        Console.Write($"[{numerosPares[k]}]");
    }
    Console.WriteLine("\n");
    Console.Write("Vetor de números ímpares: ");
    for (int l = 0; l < numerosImpares.Length; l++)
    {
        Console.Write($"[{numerosImpares[l]}]");
    }
}

leNumeros();
passaNumeros();
imprimeVetores();