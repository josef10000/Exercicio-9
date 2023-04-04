namespace Exercicio_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ler valor da mercadoria
            Console.Write("Digite o valor da mercadoria: R$ ");
            double valor = double.Parse(Console.ReadLine());

            // Calcular entrada e prestações
            double entrada = valor * 0.6;
            double prestacao = (valor - entrada) / 2;

            // Exibir resultado
            Console.WriteLine("Valor da entrada: R$ {0:F2}", entrada);
            Console.WriteLine("Valor das duas prestações: R$ {0:F2}", prestacao);

            Console.ReadKey();
        }
    }
}