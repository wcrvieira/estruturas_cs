
int contador = 3;
string usuario = "admin";
string senha = "Complicado@123";

while (contador != 0)
{
    Console.Write("Digite o usuário: ");
    string user = Console.ReadLine();

    Console.Write("Informe a senha: ");
    string pass = Console.ReadLine();

    if (usuario == user && pass == senha)
    {
        Console.WriteLine("Sejam bem-vindo!!!");
        break;
    }
    else
    {
        Console.WriteLine("Acesso negado");
    }
    contador--;
}