// var numero1 = 200; 
// var numero2 = 300; 
// int soma = numero1 + numero2;
// Console.WriteLine($"a soma de {numero1} e {numero2} é: {soma}");

using System.ComponentModel.Design;

string mensagemDeBoasVindas = "boas vindas ao screen sound";

void exibirLogo()
{
    Console.WriteLine("🅂🄲🅁🄴🄴🄽 🅂🄾🅄🄽🄳");
    Console.WriteLine(mensagemDeBoasVindas);
    Console.WriteLine("*******************");
}

void exibirOpcoesDoMenu()
{   
    exibirLogo();
    Console.WriteLine("digite 1 para registrar uma banda");
    Console.WriteLine("digite 2 para mostrar todas as bandas");
    Console.WriteLine("digite 3 para avaliar uma banda");
    Console.WriteLine("digite 4 para exibir a media de uma banda");
    Console.WriteLine("digite 5 para sair do programa");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    
    switch (opcaoEscolhidaNumerica)
    {
        case 1: registrarBanda();                
            break;
        case 2: Console.WriteLine($"voce escolheu a opção {opcaoEscolhidaNumerica}");                
            break;
        case 3: Console.WriteLine($"voce escolheu a opção {opcaoEscolhidaNumerica}");                
            break;
        case 4: Console.WriteLine($"voce escolheu a opção {opcaoEscolhidaNumerica}");                
            break;
        case 5: Console.WriteLine($"Você saiu do programa");                
            break;
        default: Console.WriteLine("opção invalida");
            break;
    }
    
}

void registrarBanda()
{
    Console.Clear();
    Console.WriteLine("registro de bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    Console.WriteLine($"a banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    exibirOpcoesDoMenu();
    Console.Clear();
}

exibirLogo();
exibirOpcoesDoMenu();
