# Algoritmos De Ordenação em C#
Principais algoritmos de ordenação em C#

### Bubble Sort

Compara elemento com elemento, o jeito que eu implementei faz a comparação mesmo que já esteja ordenado, é importante resaltar que é possível fazer uma melhoria para evitar isso, mas a ordem de complexidade ainda vai ser O(n^2).

### Selection Sort

O Selection Sort divide a lista em duas partes: uma parte ordenada e uma parte não ordenada. Ele busca repetidamente o menor elemento da parte não ordenada e o move para o final da parte ordenada. Esse processo continua até que toda a lista esteja ordenada.

### Insertion Sort

Ele percorre a lista e, para cada elemento, o insere na posição correta na parte ordenada da lista, deslocando os elementos maiores conforme necessário.

### Merge Sort

Ele divide a lista em sublistas menores, ordena cada sublista e, em seguida, combina as sublistas ordenadas para produzir a lista final ordenada

### Merge Sort Recursivo

A versão recursiva do Merge Sort segue a mesma abordagem do Merge Sort padrão, mas implementa a divisão e a combinação das sublistas de forma recursiva.

### Shell Sort

O Shell Sort é uma melhoria do Insertion Sort que visa reduzir o número de deslocamentos necessários. Ele divide a lista em várias sublistas menores, que são então ordenadas separadamente usando o Insertion Sort. Gradualmente, as sublistas tornam-se maiores até que toda a lista seja ordenada.

### Count Sort

O Count Sort é um algoritmo de ordenação não comparativo que funciona bem para listas com um intervalo limitado de valores possíveis. Ele conta o número de ocorrências de cada elemento e usa essa informação para posicionar cada elemento na lista ordenada. O Count Sort tem uma eficiência de tempo linear, tornando-o extremamente rápido em comparação com outros algoritmos de ordenação para conjuntos de dados específicos.

### Pré-requisitos

Antes de começar, certifique-se de ter as seguintes ferramentas instaladas em sua máquina:

- .NET Core SDK 7.0: [Download aqui]([https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/pt-br/download/dotnet))

### Passos para Inicializar o Projeto

#### 1. Clone o repositório

Abra um terminal e clone o repositório do seu projeto:

```bash
git clone https://github.com/MatheusCanuto07/AlgoritmosDeOrdenacaoC-
cd [seucaminho]/AlgoritmosDeOrdenacaoC-
```

#### 2. No arquivo program.cs crie os vetor e chame os metodos para fazer as ordenações
