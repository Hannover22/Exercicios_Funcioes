string[] caracteres = new string[10];
int[] numeros = new int[10];
string[] todos = new string[20]; 
void leCaracteres()
{
    for (int i = 0; i < caracteres.Length; i++)
    {
        Console.Write($"Digite {i + 1}º caractere: ");
        caracteres[i] = Console.ReadLine();
    }
}

void passaCaracteres()
{
    for (int i = 0; i < caracteres.Length; i++)
    {
        numeros[i] = caracteres[i].ToCharArray()[0];
    }
}

void imprimeVetores()
{
    for(int i = 0; i < caracteres.Length; i++)
    {
        todos[i] = caracteres[i];
        todos[i + 1] = numeros[i].ToString();
    }
    Console.Write("Vetor de caracteres: ");
    for (int i = 0; i < todos.Length; i++)
    {
        Console.Write($"[{todos[i]}]");
    }
    Console.WriteLine("\n");
}

leCaracteres();
passaCaracteres();
imprimeVetores();