int linhaColunas = EscolherTamanhoMatriz();
int[,] matriz;

int EscolherTamanhoMatriz()
{
    int tamanho;
    do
    {
        Console.WriteLine("Digite o numero de linhas da Matriz(diferente de 0): ");
        tamanho = int.Parse(Console.ReadLine());

    } while (tamanho <= 0);

    return tamanho;
}

int EscolherFormaInsercaoDados()
{
    int opcao = 0; 
    do
    {
        Console.WriteLine("Digite se deja aleatorizar as matrizes [1] ou colocar os dados a mão [2]: ");
        opcao = int.Parse(Console.ReadLine());

    } while (opcao != 1 && opcao != 2);

    return opcao;
}

int[,] insercaoDados(int tipoInsercao, int linhaColunas)
{
    int[,] matrizPreenchida = new int[linhaColunas, linhaColunas];

    switch (tipoInsercao)
    {
        case 1:
            for (int linha = 0; linha < linhaColunas; linha++)
                for (int coluna = 0; coluna < linhaColunas; coluna++)
                {
                    matrizPreenchida[linha, coluna] = new Random().Next(0, 10);
                }
            break;
        case 2:
            for (int linha = 0; linha < linhaColunas; linha++)
                for (int coluna = 0; coluna < linhaColunas; coluna++)
                {
                    Console.WriteLine("Digite os valores da primeira Matriz");
                    matrizPreenchida[linha, coluna] = int.Parse(Console.ReadLine());

                }
            break;
        default:
            Console.WriteLine("Invalido");
            break;
    }
    return matrizPreenchida;
}
int EscolherMenu(){

    int opcao;
    Console.WriteLine("\nDigite se Deseja Soma as Linhas [1]");
    Console.WriteLine("Digite se Deseja Soma as Calunas [2]");
    Console.WriteLine("Digite se Deseja Soma a Diagonaç=l [3]");
    Console.WriteLine("Digite se Deseja Soma a Diagonal Inversa[4]");

    opcao = int.Parse(Console.ReadLine());

    return opcao;
}

void SomarLinhas()
{
    int resultado = 0;
    for (int linha = 0; linha < linhaColunas; linha++)
    {
        resultado = 0;
        for (int coluna = 0; coluna < linhaColunas; coluna++)
            resultado += matriz[linha, coluna];

        Console.WriteLine("Soma linhas: " + resultado);

    }

}

void SomarColunas()
{
    int resultado = 0;
    for (int coluna = 0; coluna < linhaColunas; coluna++)
    {
        resultado = 0;
        for (int linha = 0; linha < linhaColunas; linha++)
            resultado += matriz[linha, coluna];

        Console.WriteLine("Soma Colunas: " + resultado);

    }

}

void SomarDiagonal()
{
    int resultado = 0;
    for (int coluna = 0, linha = 0; coluna < linhaColunas; coluna++, linha++)
    {
        resultado += matriz[linha, coluna];


    }
    Console.WriteLine("Soma diagonal: " + resultado);
}

void SomarDiagonalReversa()
{
    int resultado = 0;

    for (int coluna = linhaColunas - 1, linha = 0; coluna >= 0 && linha < linhaColunas; coluna--, linha++)
    {
        resultado += matriz[linha, coluna];

    }
    Console.WriteLine("Soma diagonal Inversa: " + resultado);

}

void ImprimirMatriz(int[,] m1)
{

    Console.WriteLine("\nMatriz");
    for (int linha = 0; linha < linhaColunas; linha++)
    {
        Console.WriteLine();
        for (int coluna = 0; coluna < linhaColunas; coluna++)
            Console.Write(m1[linha, coluna] + " ");

    }

}

matriz = new int[linhaColunas, linhaColunas];

switch (EscolherFormaInsercaoDados())
{
    case 1:
        matriz = insercaoDados( 1 , linhaColunas);
        break;

    case 2:
        matriz = insercaoDados( 2 , linhaColunas);
        break;

    default:
        Console.WriteLine("Invalido");
        break;
}

ImprimirMatriz(matriz);
do
{
    switch (EscolherMenu())
    {
        case 1:
            SomarLinhas();
            break;

        case 2:
            SomarColunas();
            break;

        case 3:
            SomarDiagonal();
            break;

        case 4:
            SomarDiagonalReversa();
            break;


        default:
            Console.WriteLine("Invalido");
            break;
    }

}while(true);











