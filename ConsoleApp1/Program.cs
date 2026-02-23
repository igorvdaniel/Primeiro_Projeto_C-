 void fila()
{
    string fil = "FAZ A FILA FILHA D APUTAA";
    Console.WriteLine(fil);
}

List<string> bandas =  new List<string>();

 void boas_Vindas()
{
    //O @ faz a string aparecer literal igual ao console
    string mensagem = @"
██████╗░░█████╗░░█████╗░░██████╗  ██╗░░░██╗██╗███╗░░██╗██████╗░░█████╗░░██████╗  ░█████╗░░█████╗░
██╔══██╗██╔══██╗██╔══██╗██╔════╝  ██║░░░██║██║████╗░██║██╔══██╗██╔══██╗██╔════╝  ██╔══██╗██╔══██╗
██████╦╝██║░░██║███████║╚█████╗░  ╚██╗░██╔╝██║██╔██╗██║██║░░██║███████║╚█████╗░  ███████║██║░░██║
██╔══██╗██║░░██║██╔══██║░╚═══██╗  ░╚████╔╝░██║██║╚████║██║░░██║██╔══██║░╚═══██╗  ██╔══██║██║░░██║
██████╦╝╚█████╔╝██║░░██║██████╔╝  ░░╚██╔╝░░██║██║░╚███║██████╔╝██║░░██║██████╔╝  ██║░░██║╚█████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚═════╝░  ░░░╚═╝░░░╚═╝╚═╝░░╚══╝╚═════╝░╚═╝░░╚═╝╚═════╝░  ╚═╝░░╚═╝░╚════╝░

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░";
    Console.WriteLine(mensagem);
}

 void Exibir_Menu()
{
    boas_Vindas();
    Console.WriteLine("\n1 - registrar banda \n2 - mostrar todas as bandas \n3 - avaliar uma banda \n4 - exibir a avalição média de uma banda \n0 - Sair\n");
    Console.Write("Digite o número da sua ação:");
    string opcao_escolhida = Console.ReadLine()!; //O ! faz não receber nulo
    int opcao = int.Parse(opcao_escolhida);

    if (opcao == 1)
    {
        Console.Clear();
        Console.WriteLine("Você selecionou a opção {0}", opcao);
        Registrar_Banda();
    }
    else if (opcao == 2)
    {
        Console.Clear();
        Console.WriteLine("Você selecionou a opção {0}", opcao);
        Mostrar_Bandas();
    }
    else if (opcao == 3)
    {
        Console.Clear();
        Console.WriteLine("Você selecionou a opção {0}", opcao);
        Avaliar_Bandas();
    }
    else if (opcao == 4)
    {
        Console.Clear();
        Console.WriteLine("Você selecionou a opção {0}", opcao);
        Consultar_Banda();

    }
}

 void Registrar_Banda()
{
    Console.Write("Digite o nome da banda:");
    string nome_banda = Console.ReadLine()!;
    bandas.Add(nome_banda);
    Console.WriteLine($"A banda {nome_banda} foi registrada!");
    Thread.Sleep(2000);
    Console.Clear();
    Exibir_Menu();
}

static void Mostrar_Bandas()
{
    Console.WriteLine("As bandas cadastradas são:");
}

static void Avaliar_Bandas()
{

}

static void Consultar_Banda()
{

}

void Main()
{
    // Screen Sound
    Exibir_Menu();
}

Main();