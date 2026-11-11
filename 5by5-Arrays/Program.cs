//Variáveis
int [] numeros = new int [4];
int contador = 0;

//Funções
void PopularVetor()
{
    contador = 0;
    do
    {
        Console.Write($"informe o numero desejado na posição {contador}:  ");
        numeros[contador] = int.Parse(Console.ReadLine());
        contador++;
    } while (numeros.Length > contador);
}

void MostraVetor()
{
    contador = 0;
    while (contador < numeros.Length)
    {
        Console.Write($"[{numeros[contador]}] ");
        contador++;
    }
};


//Execução
PopularVetor();
MostraVetor();
