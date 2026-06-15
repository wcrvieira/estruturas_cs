// Declaração de variáveis
int valor = 0;

Console.WriteLine("*** Gerador de tabuadas ***");

// Usamos 'true' para o loop rodar indefinidamente até que o usuário digite 0
while (true)
{
    Console.Write("Por favor, digite um número (maior que 1 e menor que 10)");
    Console.Write("\nOu digite 0 para sair: ");
    valor = Convert.ToInt16(Console.ReadLine());

    // Condição de parada imediata
    if (valor == 0)
    {
        Console.WriteLine("Saindo do programa!!!");
        break;
    }

    // Validação: maior que 1 E menor que 10 (conforme seu enunciado)
    if (valor >= 1 && valor <= 10)
    {
        Console.WriteLine($"\nTabuada do {valor}");

        // Criamos o contador aqui dentro para rodar de 1 a 10 toda vez
        int contador = 0;
        while (contador <= 10)
        {
            Console.WriteLine(valor + " X " + contador + " = " + (valor * contador));
            contador++; // Incrementa o multiplicador
        }        
    }
    else
    {
        Console.WriteLine("Número fora do intervalo permitido. Tente novamente.\n");
    }
}