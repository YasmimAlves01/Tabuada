int numeroTabu;
string decisao;

Console.WriteLine("Bem-Vindo ao Tabuada Rapida!");



while (true)
{
    Console.WriteLine("Por favor digite o numero que deseja:");
    numeroTabu = Convert.ToInt32(Console.ReadLine()!);


    for (int x = 0; x <= 10; x++)
    {
        Console.WriteLine($"{numeroTabu} x {x} = {numeroTabu * x}");

    }

    Console.WriteLine("\nDeseja ver outras tabuada?");
    Console.WriteLine("Digite S para sim e N para não");
    decisao = Console.ReadLine()!.ToUpper();
    if (decisao == "S")
    {
        Console.WriteLine("\nOk então, vamos continuar :)");
        Console.Clear();
        continue;
    }
    else
    {
        Console.WriteLine("\nVamos encerrar por aqui então");
        Console.WriteLine("Muito obrigado por utilizar o nosso programa ;)\n");
        break;
    }

}
