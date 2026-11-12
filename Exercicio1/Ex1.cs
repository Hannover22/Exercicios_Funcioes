char[] caracteres = new char[6];
void ImprimeCaracteres()
{
    for(int i = 0; i < caracteres.Length; i++)
    {
        Console.WriteLine($"[{caracteres[i]}]");
    }
    Console.WriteLine("Imprimindo o vetor de caracteres ao contrário: ");
    for(int j = caracteres.Length - 1; j >= 0; j--)
    {
        Console.WriteLine($"[{caracteres[j]}]");
    }
}

void LeCaracteres()
{
    for (int i = 0; i < caracteres.Length; i++)
    {
        Console.Write($"Informe o {i + 1}º caractere: ");
        caracteres[i] = char.Parse(Console.ReadLine());
    }
}

LeCaracteres();
ImprimeCaracteres();