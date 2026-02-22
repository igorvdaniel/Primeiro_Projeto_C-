static void fila()
{
    string fil = "FAZ A FILA FILHA D APUTAA";
    Console.WriteLine(fil);
}

static void Main()
{
    // Screen Sound
    string mensagem = "Boas vindas ao Screen Sound";

    Console.WriteLine(mensagem);
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine("Hoje");
        fila();
    }
    Console.ReadLine();
}

Main();