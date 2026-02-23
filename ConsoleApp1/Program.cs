static void fila()
{
    string fil = "FAZ A FILA FILHA D APUTAA";
    Console.WriteLine(fil);
}

static void boas_Vindas()
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

static void Exibir_Menu()
{
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
        Mostrar_Bandas();
    }
}

static void Registrar_Banda()
{
    Console.Write("Digite o nome da banda:");
    string nome_banda = Console.ReadLine()!;
    Console.Clear();
    Exibir_Menu();
}

static void Mostrar_Bandas()
{

}

static void Main()
{
    // Screen Sound
    boas_Vindas();
    Exibir_Menu();
}

Main();