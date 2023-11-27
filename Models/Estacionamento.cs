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
            try
            {

                Console.WriteLine("Digite a placa do veículo para estacionar:");

                string sPLaca = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(sPLaca))
                {
                    Console.WriteLine("Placa do veiculo invalida!");
                }
                else
                {
                    veiculos.Add(sPLaca);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }

     public void RemoverVeiculo()
     {
         try
         {
             Console.WriteLine("Digite a placa do veículo para remover:");
             string placa = Console.ReadLine();
     
             if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
             {
                 Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                 if (int.TryParse(Console.ReadLine(), out int horas) && horas > 0)
                 {
                     veiculos.Remove(placa);
                     decimal valorTotal = horas * precoPorHora + precoInicial;
     
                     Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                 }
                 else
                 {
                     Console.WriteLine("Quantidade de horas inválida!");
                 }
             }
             else
             {
                 Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
             }
         }     
         catch (Exception ex)
         {
             Console.WriteLine($"Erro: {ex.Message}");
         }
     }


        public void ListarVeiculos()
        {
         try
         {
            if (veiculos.Any())
            {
                 Console.WriteLine($"Os veículos estacionados são:");
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
         catch (Exception ex)
         {
             Console.WriteLine($"Erro: {ex.Message}");
         }
         
        }
    }
}
