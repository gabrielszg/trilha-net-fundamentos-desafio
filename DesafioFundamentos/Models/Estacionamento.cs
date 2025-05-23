namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<Veiculo> veiculos = new List<Veiculo>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            Veiculo veiculo = new Veiculo();
            veiculo.Placa = Console.ReadLine();

            this.veiculos.Add(veiculo);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            if (veiculos.Any(item => item.Placa.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                string horasString = Console.ReadLine();
                int horas;
                bool sucessoConversao = int.TryParse(horasString, out horas);

                decimal valorTotal = 0;
                if (sucessoConversao)
                {
                    valorTotal = this.precoInicial + this.precoPorHora * horas;
                }
                else
                {
                    Console.WriteLine("Digite um horário válido");
                    return;
                }

                Veiculo veiculo = this.veiculos.Find(item => item.Placa == placa);
                this.veiculos.Remove(veiculo);

                Console.WriteLine($"O veículo {veiculo.Placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Count != 0)
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (var veiculo in this.veiculos)
                {
                    Console.WriteLine(veiculo.Placa);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
