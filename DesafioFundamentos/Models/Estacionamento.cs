namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
{
    while (true)
    {
        Console.WriteLine("Digite a placa do veículo para estacionar:");
        string placa = Console.ReadLine();
        veiculos.Add(placa);
        Console.WriteLine($"Veículo com placa {placa} adicionado com sucesso!");

        string resposta;
        while (true)
        {
            Console.WriteLine("Deseja adicionar mais um veículo? (S/N)");
            resposta = Console.ReadLine().Trim().ToUpper();

            if (resposta == "S")
                break; 

            if (resposta == "N")
            {
               return; 
            }

            Console.WriteLine("Resposta inválida. Por favor, digite S para sim ou N para não.");
            
        }
    }
}
    

        
        public void RemoverVeiculo()
        {
            while (true)
            {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas;
                while (!int.TryParse(Console.ReadLine(), out horas) || horas < 0)
                {
                    Console.WriteLine("Por favor, digite um número válido de horas:");
                }
            decimal valorTotal = precoInicial + precoPorHora * horas;

            veiculos.RemoveAll(x => x.ToUpper() == placa.ToUpper());

            Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente.");
            }

            string responder;
            while (true)
            {
            Console.WriteLine("Deseja remover mais um veículo? (S/N)");
            responder = Console.ReadLine().Trim().ToUpper();

            if (responder == "S")
                break; 

            if (responder == "N")
                return;

            Console.WriteLine("Resposta inválida. Por favor, digite S para sim ou N para não.");
        }
    }
}


        public void ListarVeiculos()
        {
            
            if (veiculos.Any())
            {

                if (veiculos.Any())
                {
                    Console.WriteLine("Os veículos estacionados são:");
                    foreach (var v in veiculos)
                    {
                        Console.WriteLine(v);
                    }
                }
                else
                {
                    Console.WriteLine("Não há veículos estacionados.");
                }
            }

            Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
            Console.ReadKey();
        }
    }
}
