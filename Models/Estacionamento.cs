namespace SistemaEstacionamento.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> carros = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarCarro()
        {
            Console.WriteLine("Digite a placa do Carro para estacionar:");
            carros.Add(Console.ReadLine());
        }

        public void RemoverCarro()
        {
            Console.WriteLine("Digite a placa do Carro para remover:");
            string placa = Console.ReadLine();

            if (carros.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o Carro permaneceu estacionado:");

                int horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = precoInicial+precoPorHora*horas; 

                carros.Remove(placa);

                Console.WriteLine($"O Carro {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse Carro não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarCarro()
        {
            if (carros.Any())
            {
                Console.WriteLine("Os Carros estacionados são:");

                foreach(string carro in carros) 
                {
                Console.WriteLine(carro);                    
                }
            }
            else
            {
                Console.WriteLine("Não há carros estacionados.");
            }
        }
    }
}
