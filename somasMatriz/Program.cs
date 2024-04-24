int qtdLinha = 2, opcao = 0, resultado = 0;
int[,] matriz = new int[qtdLinha, qtdLinha];

do
{
    Console.WriteLine("Digite se deja aleatorizar as matrizes [1] ou colocar os dados a mão [2]: ");
    opcao = int.Parse(Console.ReadLine());

} while (opcao != 1 && opcao != 2);

switch (opcao)
{
    case 1:
        for (int linha = 0; linha < qtdLinha; linha++)
            for (int coluna = 0; coluna < qtdLinha; coluna++)
            {
                matriz[linha, coluna] = new Random().Next(1, 100);
            }
        break;

    case 2:
        for (int linha = 0; linha < qtdLinha; linha++)
            for (int coluna = 0; coluna < qtdLinha; coluna++)
            {
                Console.WriteLine("Digite os valores da primeira Matriz");
                matriz[linha, coluna] = int.Parse(Console.ReadLine());

            }
        break;

    default:
        break;
}

Console.WriteLine("\nMatriz");
for (int linha = 0; linha < qtdLinha; linha++)
{
    Console.WriteLine();
    for (int coluna = 0; coluna < qtdLinha; coluna++)
        Console.Write(matriz[linha, coluna] + " ");

}

Console.WriteLine();
Console.WriteLine();

for (int linha = 0; linha < qtdLinha; linha++)
{
    resultado = 0;
    for (int coluna = 0; coluna < qtdLinha; coluna++)
        resultado += matriz[linha, coluna];

    Console.WriteLine("Soma linhas: " + resultado);

}

Console.WriteLine();
Console.WriteLine();

for (int coluna = 0; coluna < qtdLinha; coluna++)
{
    resultado = 0;
    for (int linha = 0; linha < qtdLinha; linha++)
        resultado += matriz[linha, coluna];

    Console.WriteLine("Soma Colunas: " + resultado);

}


Console.WriteLine();
Console.WriteLine();
resultado = 0;

for (int coluna = 0, linha = 0; coluna < qtdLinha; coluna++, linha++)
{
        resultado += matriz[linha, coluna];


}
Console.WriteLine("Soma diagonal: " + resultado);


Console.WriteLine();
Console.WriteLine();
resultado = 0;

for (int coluna = qtdLinha - 1, linha = 0 ; coluna >= 0 && linha < qtdLinha ; coluna--, linha++)
{
    resultado += matriz[linha, coluna];

}
Console.WriteLine("Soma diagonal Inversa: " + resultado);



Console.WriteLine();
