 void fila()
{
    string fil = "FAZ A FILA FILHA D APUTAA";
    Console.WriteLine(fil);
}

//List<string> bandas =  new List<string>();

Dictionary<string, List<int>> bandas = new Dictionary<string, List<int>>();

bandas.Add("Linkin Park", new List<int>() {10, 1, 3});
bandas.Add("Green Day", new List<int>());

void exibir_bandas()
{
    foreach(string banda in bandas.Keys)
    {
        Console.WriteLine($"- {banda}"); 
    }    
}
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

void exibir_titulo(string titulo)
{
    for(int i = 0; i < titulo.Length; i++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
    Console.WriteLine(titulo);
    int qtd = titulo.Length;
    string asteriscos = string.Empty.PadLeft(qtd, '*');
    Console.WriteLine(asteriscos + '\n');

}

 void Exibir_Menu()
{
    boas_Vindas();
    Console.WriteLine("\n1 - registrar banda \n2 - mostrar todas as bandas \n3 - avaliar uma banda \n4 - exibir a avalições médias \n0 - Sair\n");
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
    Console.Clear();
    exibir_titulo("Registro de Banda");
    Console.Write("Digite o nome da banda:");
    string nome_banda = Console.ReadLine()!;
    bandas.Add(nome_banda, new List<int>());
    Console.WriteLine($"A banda {nome_banda} foi registrada!");
    Thread.Sleep(1000);
    Console.Clear();
    Exibir_Menu();
}

void Mostrar_Bandas()
{
    Console.Clear();
    exibir_titulo("Listar Bandas");
    Console.WriteLine("As bandas cadastradas são:");
    Console.WriteLine("Bandas com for");
    for (int i = 0; i < bandas.Count; i++)
    {
        Console.WriteLine($"- {bandas.ElementAt(i).Key}");
    }
    Console.WriteLine();
    Console.WriteLine("Bandas com foreach");
    foreach(string banda in bandas.Keys)
    {
        Console.WriteLine($"- {banda}"); 
    }

    Console.WriteLine("Digite qualquer tecla para retornar ao menu");
    Console.ReadKey();
    Console.Clear();
    Exibir_Menu();
}
void Avaliar_Bandas()
{
    Console.Clear();
    exibir_titulo("Avaliar Bandas");
    Console.WriteLine("Bandas Cadastradas:");
    exibir_bandas();
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nome_banda = Console.ReadLine()!;
    if(bandas.ContainsKey(nome_banda))
    {
        Console.WriteLine($"Digite o valor da avaliação da banda {nome_banda}: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandas[nome_banda].Add(nota);
        Console.WriteLine($"A nota {nota} foi registrada para {nome_banda}");
        Thread.Sleep(1000);
        Console.Clear();
        Exibir_Menu();

    }
    else
    {
        Console.WriteLine($"A banda {nome_banda} não existe!");
        Thread.Sleep(1000);
        Console.Clear();
        Exibir_Menu();
    }
    
}

void Consultar_Banda()
{
    exibir_titulo("Avaliação Media");
    Console.WriteLine("Bandas Cadastradas: ");
    foreach(string banda in bandas.Keys)
    {
        Console.WriteLine($"{banda}: {bandas[banda].Average()}");
        Console.WriteLine("Digite qualquer tecla para retornar ao menu");
        Console.ReadKey();
        Console.Clear();
        Exibir_Menu();        
    }
}

void Main()
{
    // Screen Sound
    Exibir_Menu();
}

Main();