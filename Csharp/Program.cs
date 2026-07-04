



Console.WriteLine("## PROGRAMA DA INVERSÃO DA LISTA ##");

Console.WriteLine("Digite a quantidade de itens quer na lista: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] lista = new int[num];
Console.WriteLine("Digite os numeros: ");
for (int i = 0; i < num; i++)
{
    Console.Write("Digite:");
    lista[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = lista.Length - 1; i >= 0; i--)
{
    Console.Write(lista[i] + " ");
}


