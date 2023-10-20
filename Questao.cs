using System;

class Questao
{
    static void Main(string[] args)
    {
        // Solicitar o nome do cliente
        Console.Write("Digite o nome do cliente: ");
        string nomeCliente = Console.ReadLine();

        // Solicitar o valor da compra
        Console.Write("Digite o valor total da compra: ");
        double valorCompra = Convert.ToDouble(Console.ReadLine());

        // Solicitar o valor que o cliente irá pagar
        Console.Write("Digite o valor a ser pago: ");
        double valorPago = Convert.ToDouble(Console.ReadLine());

        // Calcular o troco
        double troco = valorPago - valorCompra;

        // Verificar se o valor pago é suficiente para realizar a compra
        if (troco < 0)
        {
            Console.WriteLine("Valor insuficiente para realizar a compra.");
        }
        else
        {
            // Imprimir os resultados
            Console.WriteLine("\nResumo da compra:");
            Console.WriteLine("Nome do cliente: " + nomeCliente);
            Console.WriteLine("Valor total da compra: R$" + valorCompra);
            Console.WriteLine("Valor pago: R$" + valorPago);
            Console.WriteLine("Troco a ser devolvido: R$" + troco);

            // Calcular e imprimir as notas do troco
            int[] notasPossiveis = { 100, 50, 20, 10, 5, 2, 1 };
            Console.WriteLine("\nNotas do troco:");
            foreach (int nota in notasPossiveis)
            {
                int quantidadeNotas = (int)(troco / nota);
                if (quantidadeNotas > 0)
                {
                    Console.WriteLine("Notas de R$" + nota + ": " + quantidadeNotas);
                    troco -= quantidadeNotas * nota;
                }
            }
        }
    }
}