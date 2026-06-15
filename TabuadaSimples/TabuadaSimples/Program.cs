// Tabuada simples
// Declaração de variáveis
int numero = 0;
int cont = 0;

// Interagindo com o usuário
Console.WriteLine("*** Tabuada simples ***");
Console.Write("Digite um número inteiro (maior que 1 e menor que 10): ");
numero = Convert.ToInt16(Console.ReadLine());
// numero = int.Parse(Console.ReadLine());

while (cont <= 10)
{
    Console.WriteLine($"{numero} X {cont} = {numero*cont}");
    cont++;
}