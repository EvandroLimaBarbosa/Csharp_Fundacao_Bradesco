namespace Calculo_de_nota
{
    class Program
    {
        static void Calculo_de_Nota()
        {
            while (true) {
                Console.Clear();
                float notaDeCorte = 60;            
            
                Console.WriteLine("Olá bem vindo ao programa de cálculo de média!\n");

                Console.WriteLine("Irei auxiliar você a calcular a média do seu aluno\n");

                Console.WriteLine("Digite a primeira nota: ");
                int.TryParse(Console.ReadLine(), out int nota1);

                Console.WriteLine("Digite a segunda nota: ");
                int.TryParse(Console.ReadLine(), out int nota2);

                Console.WriteLine("Digite a tercdeira nota: ");
                int.TryParse(Console.ReadLine(), out int nota3);

                float media = (nota1 + nota2 + nota3) / 3;

                Console.WriteLine("Sua media é de {0} e a nota de corte é de {1}...\n", media, notaDeCorte);

                if (media < 0)
                {
                    Console.WriteLine("Kkk não tem como estar com nota abaixo de 0\n");
                }
                else if (media < notaDeCorte)
                {
                    Console.WriteLine("Está com nota vermelha!\n");
                }
                else if (media >= notaDeCorte && media <= 100)
                {
                    Console.WriteLine("Está com nota azul, Parabéns!!\n");
                }
                else if (media > 100)
                {
                    Console.WriteLine("Kkk professora deu nota a mais ? está acima de 100 seu loco\n");
                }


                Console.WriteLine("Quer reiniciar o calculo da nota ? (digite Sim ou Não)");
                string reiniciar = Console.ReadLine();
                if (reiniciar.ToLower() == "sim")
                {
                    Console.WriteLine("Ok, reiniciando\n");
                }
                 else if (reiniciar.ToLower() == "não")
                {
                    Console.WriteLine("Ok, finalizando... obrigado!\n");
                    break;
                }
                else 
                {
                    Console.WriteLine("Não entendi, vou finalizar! obrigado!\n");
                    break;
                }
            }
        }
    }
}