using projeto_estacionamento_csharp.Models;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!");
Console.WriteLine("Digite o preço inicial:");
Decimal precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o preço por hora:");
Decimal precoHora = Convert.ToDecimal(Console.ReadLine());

Estacionamento e1 = new Estacionamento(precoInicial, precoHora);

Boolean menuOpt = true;

while(menuOpt) {
    Console.Clear();
    Console.WriteLine("Digite uma opção:");
    Console.WriteLine("1 - Cadastrar Veículo");
    Console.WriteLine("2 - Remover Veículo");
    Console.WriteLine("3 - Listar Veículos");
    Console.WriteLine("4 - Encerrar");


    switch(Console.ReadLine()){
        case "1":
            e1.AdicionarVeiculo();
            break;

        case "2":
            e1.RemoerVeiculo();
            break;

        case "3":
            e1.ListarVeiculo();
            break;

        case "4":
            menuOpt = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

}

Console.WriteLine("O programa se encerrou!");


