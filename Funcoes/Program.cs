bool Primo (int numero)
{
    if(numero <= 1)
    {
        return false;
    }
    int contador = 0;
    for(int i = 1; i <= numero; i++)
    {
        if (numero % i == 0)
        {
            contador++;
        }
    }
    if(contador > 2)
    {
        return false;
    }
    else
    {
        return true;
    }
}

Console.Write("Informe o numero desejado: ");
int x = int.Parse(Console.ReadLine());
for(int i = x; i >= 1; i--)
{
    if (Primo(i))
    {
        Console.WriteLine(i);
    }
}
