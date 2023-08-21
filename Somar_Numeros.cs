namespace Somar_Numeros
{
    class Program
    {
        static void Main()
        {
            bool opcao = true;
            Console.WriteLine("Olá, irei realizar a soma dos numeros que me disser até desejar parar\n");
            
            while (opcao == true)
            {
                Console.Clear();

                Console.WriteLine("Digite o valor inicial:");

                float.TryParse(Console.ReadLine(), out float valorInicio);

            

                Console.WriteLine("Digite o valor que quer somar:");
                float.TryParse(Console.ReadLine(), out float valorSoma);
                valorInicio = valorInicio + valorSoma;
                Console.WriteLine("O valor somado é: {0}", valorInicio);
                Console.WriteLine("Deseja sair do programa ? 1 - sim e 2 - não");
                int.TryParse(Console.ReadLine(), out int saida);

                switch (saida)
                {
                  case 1:
                        Console.WriteLine("Entendido! Saindo do programa.");
                        opcao = false;
                        break;
                  case 2:
                        Console.WriteLine("Vamos continuar!...");
                        break;
                  default:
                        Console.WriteLine("Opção Inválida! Retornando para a soma...");
                        break;
                }
                Console.WriteLine(".");
                Thread.Sleep(1000);
                Console.WriteLine(".");
                Thread.Sleep(1000);
                Console.WriteLine(".");
                Thread.Sleep(1000);

            }
        }
    }
}