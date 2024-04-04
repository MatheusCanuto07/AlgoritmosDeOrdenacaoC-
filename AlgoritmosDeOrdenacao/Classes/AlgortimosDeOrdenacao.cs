using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosDeOrdenacao.Classes
{
    class AlgoritmosDeOrdenacao
    {
        public static void bubbleSort(int[] vetor)
        {
            //Metodo de bolha
            //Esse metodo tem esse nome porque acontece muitas trocas(borbulhas de trocas)
            //Metodo mais ineficiente

            for (int i = 0; i < vetor.Length; i++)
            {
                for (int j = i + 1; j < vetor.Length; j++)
                {
                    if (vetor[i] > vetor[j])
                    {
                        int aux = vetor[i];
                        vetor[i] = vetor[j];
                        vetor[j] = aux;
                    }
                }
            }

            //Tempo em milisegundos
            //5 - 0, 10 - 0, 50 - 0, 100 - 0, 500 - 0, 1000 - 3, 5000 - 99, 10000 - 399, 50000 - 6761, 100000 - 24733  e 5000000 - Coloquei para fazer fiquei 3 minutos no instagram e não terminou.
        }
        public static void selectionSort(int[] vetor)
        {
            //Metodo selection short
            //A ideia central desse metodo é selecionar o menor elemento e coloca-lo na primeira posição
            //Um for que passa por todos os elementos do array
            //Lógica do selecion short, define o item como menor, vê se tem algum menor do que ele e depois faz a troca
            for (int i = 0; i < vetor.Length; i++)
            {
                //2- Definir que a posição i do vetor é a menor e fazer mais um for que vai ter as comparações, a ideia do selection short é definir o primeiro elemento como o menor e caminhar pelo vetor
                int menorPosicao = i;
                for (int j = i; j < vetor.Length; j++)
                {
                    if (vetor[j] < vetor[menorPosicao])
                    {
                        menorPosicao = j;
                    }
                }
                int aux = vetor[i];
                vetor[i] = vetor[menorPosicao];
                vetor[menorPosicao] = aux;
            }
            //Tempo em milisegundos
            //5 - 0, 10 - 0, 50 - 0, 100 - 0, 500 - 0, 1000 - 10, 5000 - 64, 10000 - 282, 50000 - 5623, 100000 - 22620  e 5000000 - Coloquei para fazer fiquei 3 minutos no instagram e não terminou.
        }
        public static void insertionSort(int[] vetor)
        {
            //Metodo Insertion Sort
            //Insertion Sort ou ordenação por inserção é o método que percorre um vetor de elementos da esquerda para a
            //direita e à medida que avança vai ordenando os elementos à esquerda
            for (int i = 0; i < vetor.Length; i++)
            {
                int aux = vetor[i];
                int j = i - 1;

                while (j >= 0 && vetor[j] > aux)
                {
                    vetor[j + 1] = vetor[j];
                    j = j - 1;
                }

                vetor[j + 1] = aux;
            }
            //O metodo de bolha é caro porque no seu melhor caso ele vai percorrer o vetor inteiro fazendo comparações - O(n^2)
            //O metodo selection short é caro porque no seu pior caso ele vai percorrer o vetor inteiro fazendo comparações, a diferença dele para o metodo de bolha
            //está na lógica, ao invez dele ir "varrendo" o vetor ele define que aquela posição representa o menor valor e vai tentando fazer trocas
            //O metodo  Insertion Sort aplica várias vezes a inserção ordenada para ordenar uma sequência. Possui O(n^2)
        }
        public static void mergeSort(int[] vetor, int ini, int fim)
        {
            //Metodo merge
            //Dividir e conquistar
            //Melhor, médio e pior caso: n log² n
            //Uso extra de memória por causa da funcao recursiva
            //1- Chamadas recursivas para obter um vetor pequeno
            //2- Juntar esse elementos que estão ordenados
            //Na hora de chamar a função esse fim deve ser o length do vetor - 1
            int i, j, k;
            int[] vetAux = new int[vetor.Length];
            //O objetivo é dividir o vetor até ele ter apenas um elementos
            if (ini < fim)
            {
                //Difinir o meio do vetor | Lembrando que vão acontecer chamadas recursivas
                int meio = (ini + fim) / 2;
                //Chamada recursiva para a primeira metade do vetor
                mergeSort(vetor, ini, meio);
                //Chamada recursiva para a segunda metade do vetor
                mergeSort(vetor, meio + 1, fim);
                //Juntar os elementos de forma ordenada
                //Variaveis auxiliadoras
                i = ini;
                j = meio + 1;
                k = ini;
                //Comparar os elementos do primeiro vetor com os elementos do segundo
                //Essas atribuições vão garantir que o que está sendo colocado dentro do vetor original está ordenado
                //Logo a parte que sobra também está ordenada
                while (i <= meio && j <= fim)
                {
                    //Compara os elementos do "primeiro" vetor com os elementos do "segundo"
                    if (vetor[i] < vetor[j])
                    {
                        vetAux[k] = vetor[i];
                        i++;
                    }
                    else
                    {
                        vetAux[k] = vetor[j];
                        j++;
                    }
                    k++;
                }
                //2 whiles que vão o vetor auxiliar fique completo
                //Esses dois whiles não vão ser na mesma execução
                //Vamos supor que todos os elementos do segundo vetor passaram para a posição inicial do vetor auxiliar
                //Desse forma o vetor auxiliar não tem a segunda parte do vetor que está ordenada, logo é necessário adicionar
                //Essa segunda parte no vetor auxiliar

                //Preenche a primeira parte do vetor caso seja nela que falte item
                while (i <= meio)
                {
                    vetAux[k] = vetor[i];
                    i++;
                    k++;
                }

                //Preenche a segunda parte do vetor caso seja nela que falte algum item
                while (j <= fim)
                {
                    vetAux[k] = vetor[j];
                    j++;
                    k++;
                }

            }
        }
        public static void mergeSortRecursivo(int[] vetor, int inicio, int fim)
        {
            if (inicio < fim)
            {
                Console.WriteLine(inicio);
                int meio = (inicio + fim) / 2;
                //mergeSortFinal(vetor, inicio, meio);
                //mergeSortFinal(vetor, meio + 1, fim);
                //O melhor metodo para ordenar o vetor´é o insertion por que ele não vai percorrer o vetor inteiro novamente
                insertionSort(vetor);
            }
        }
        public static void shellSort(int[] lista, int tamanho)
        {
            int i, j, aux;
            //Determinação de k de acordo com o metodo cientifico explicado no vídeo: https://www.youtube.com/watch?v=N5flk53THTo
            double k = Math.Log(tamanho + 1) / Math.Log(3);
            k = Math.Round(k);
            int h = Convert.ToInt32((Math.Pow(3, k) - 1) / 2);
            while (h > 0)
            {
                for (i = 0; i < tamanho - h; i++)
                {
                    if (lista[i] > lista[i + h])
                    {
                        aux = lista[i + h];
                        lista[i + h] = lista[i];
                        lista[i] = aux;
                        j = i - h;
                        while (j >= 0)
                        {
                            if (aux < lista[j])
                            {
                                lista[j + h] = lista[j];
                                lista[j] = aux;
                            }
                            else
                            {
                                break;
                            }
                            j = j - h;
                        }
                    }
                }
                h = (h - 1) / 3;
            }
        }
        public static void countSort(int[] vetor)
        {
            int maiorValorVetor = vetor.Max();
            //Esse mais um é por causa do zero
            int[] vetorAuxiliar = new int[maiorValorVetor + 1];
            for (int i = 0; i < vetor.Length; i++)
            {
                //Conta a frequência
                //O que acontece com o vetor nesse momento:
                //// frequência
                //[1,9,1,3,4,7,6,7]
                //[2,0,1,1,0,1,2,0,1]
                vetorAuxiliar[vetor[i] - 1]++;
            }
            for (int i = 1; i < vetorAuxiliar.Length; i++)
            {
                //Cumulativa
                //Vetor fica dessa forma
                //[2,2,3,4,4,5,7,7,8]
                vetorAuxiliar[i] += vetorAuxiliar[i - 1];
            }
            int[] vetorFinal = new int[vetor.Length];
            for (int i = vetor.Length - 1; i >= 0; i--)
            {
                //Volta os valores para o vetor original começando de trás para frente
                vetorFinal[vetorAuxiliar[vetor[i] - 1] - 1] = vetor[i];
                vetorAuxiliar[vetor[i] - 1] -= 1;
            }
            //500 - 0, 1000 - 0, 5000 - 0, 10000 - 0, 50000 - 1, 100000 - 2 e 5000000 - 94
        }
    }
}
