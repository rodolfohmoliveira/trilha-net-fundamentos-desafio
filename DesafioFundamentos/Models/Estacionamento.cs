namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial;
        private decimal precoPorHora;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // Implementado
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            // Lê a placa do veículo fornecida pelo usuário
            string placaVeiculo = Console.ReadLine();
            // Adiciona a placa do veículo à lista
            if (veiculos.Contains(placaVeiculo.ToUpper()))
            {
                Console.WriteLine("Erro: A placa já consta no estacionamento. Não é possível adicionar o veículo.");
            }
            else
            {
                // Adiciona a placa do veículo à lista
                veiculos.Add(placaVeiculo.ToUpper());

                // Mensagem indicando que o veículo foi adicionado com sucesso
                Console.WriteLine("Veículo adicionado com sucesso!");
            }
        }


        public void RemoverVeiculo()
        {   // Implementado
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado
                int horas = Convert.ToInt32(Console.ReadLine());

                // Definir preços
                decimal precoInicial = 5; // Preço inicial de estacionamento
                decimal precoPorHora = 2; // Preço por hora de estacionamento

                // Calcular o valor total
                decimal valorTotal = precoInicial + (precoPorHora * horas);

                // Remover a placa digitada da lista de veículos
                veiculos.Remove(placa.ToUpper());

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                // Laço de repetição para exibir os veículos estacionados
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
