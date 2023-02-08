namespace Introducao_a_Algoritmos;

#nullable disable

class Program
{
    static void Main(string[] args)
    {
        int[] minha_lista = new int[] { 1, 3, 5, 7, 9, 13, 17, 23 };

        string operation1 = Pesquisa_binaria(01, minha_lista, 7);
        Console.WriteLine($"\nOperação 1 - Posição do item {(operation1 != null ? "é " + operation1 + "." : "não foi encontrado!")}");

        string operation2 = Pesquisa_binaria(2, minha_lista, 15);
        Console.WriteLine($"\nOperação 2 - Posição do item {(operation2 != null ? "é " + operation2 + "." : "não foi encontrado!")}");
    }

    public static string Pesquisa_binaria(int nOperation, int[] lista, int item)
    {
        int baixo = 0;
        int alto = lista.Length;

        Console.WriteLine($"\n\n###########################");
        Console.WriteLine($"## Início da Operação {nOperation} ##");
        Console.WriteLine($"\n- item: {item}.\n");
        Console.WriteLine($"- baixo: {baixo}.");
        Console.WriteLine($"- alto: {alto}.");

        Console.WriteLine("\n# Iníciando os chutes...");
        while (baixo <= alto)
        {
            int meio = (baixo + alto) / 2;
            int chute = lista[meio];

            Console.WriteLine($"\n- meio: {meio}.");
            Console.WriteLine($"- chute: {chute}.");

            if (chute == item)
            {
                return meio.ToString();
            }
            else if (chute > item)
            {
                alto = meio - 1;
                Console.WriteLine("- O chute foi muito alto!");
            }
            else
            {
                baixo = meio + 1;
                Console.WriteLine("- O chute foi muito baixo!");
            }
        }
        return null;
    }
}