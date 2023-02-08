namespace Ordenacao_Por_Selecao;

class Program
{
    static void Main(string[] args)
    {
        int[] valores = new int[] { 5, 3, 6, 2, 10, 67, 4, 25, 0, 8 };
        int[] valoresOrdernados = OrdenacaoPorSelecao(valores);

        for (int i = 0; i < valoresOrdernados.Length; i++)
            Console.Write($"{valoresOrdernados[i]} ");
    }

    public static int BuscarMenor(int[] arr)
    {
        int menor = arr[0];
        int menor_indice = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < menor)
            {
                menor = arr[i];
                menor_indice = i;
            }
        }
        return menor_indice;
    }

    public static int[] OrdenacaoPorSelecao(int[] arr)
    {
        int[] novoArr = new int[arr.Length];
        int n = arr.Length;

        for (int i = 0; i < n; i++)
        {
            int menor = BuscarMenor(arr);
            novoArr[i] = arr[menor];
            arr = arr.Where(x => x != arr[menor]).ToArray();
        }

        return novoArr;
    }
}