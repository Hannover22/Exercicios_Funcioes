int[] numbers = new int[3];
int i = 0;
void PopulaVetor()
{
    do
    {
        Console.Write($"Informe o {i + 1}º número: ");
        numbers[i] = Console.Read();
        i++;
    } while (i < numbers.Length);
}

void ImprimeVetor()
{
    for(int j = 0; j < numbers.Length; j++)
    {
        Console.WriteLine($"[{numbers[j]}]");
    }
}
PopulaVetor();
ImprimeVetor();
