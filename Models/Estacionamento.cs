namespace projeto_estacionamento_csharp.Models
{
    public class Estacionamento{

        decimal precoHora;
        decimal precoInicial;
        public List<string> veiculos;

        public Estacionamento(Decimal precoInicial, Decimal precoHora){

            this.precoInicial = precoInicial;
            this.precoHora = precoHora;
            this.veiculos = new List<string>();

        }

        public void AdicionarVeiculo(){
            Console.WriteLine("Digite a Placa do veículo para estacionar:");
            string? placa = Console.ReadLine();
            if(placa is not null){
            this.veiculos.Add(placa.ToUpper());
            }
            Console.WriteLine("Pressione uma tecla para continuar:");
            Console.ReadLine();
            return;
        }

        public void RemoerVeiculo(){
            Console.WriteLine("Digite a Placa do veículo para remover:");
            string? placa = Console.ReadLine();

            if(placa is not null){
                if(this.veiculos.Contains(placa.ToUpper())) {

                    Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                    int horas = Convert.ToInt32(Console.ReadLine());
                    Decimal valorTotal = horas*precoHora + precoInicial;

                    this.veiculos.Remove(placa.ToUpper());

                    Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                    Console.WriteLine("Pressione uma tecla para continuar:");
                    Console.ReadLine();
                    return;
                    } else {
                        Console.WriteLine("O veículo em questão não existe na lista.");
                        Console.WriteLine("Pressione uma tecla para continuar.");
                        Console.ReadLine();

                    }
            }
        }

        public void ListarVeiculo(){

            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:\n\n");
                foreach(string i in veiculos){
                    Console.WriteLine($"{i}\n");
                }
                Console.WriteLine("Pressione uma tecla para continuar.");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
                Console.WriteLine("Pressione uma tecla para continuar.");
                Console.ReadLine();
            }

            return;

        }

    }
}