namespace operadoresRelacionais
{
    class Program
    {
        static void OperadoresRelacionais()
        {
            /* double nota1 = 8.0;
             double nota2 = 9.0;

             Console.WriteLine("Nota maior que 7? {0}", nota1 > 7.0);
             Console.WriteLine("Nota maior que 7? {0}", nota2 == 10.0); */

            /*
            Console.WriteLine("Digite sua nota: ");
            double.TryParse(Console.ReadLine(), out double nota);

            Console.WriteLine("Nota maior que 7 ? {0}", nota > 7.0);
            Console.WriteLine("Tirou 10 ? {0}", nota == 10.0); */

            var atividade1 = true;
            var atividade2 = false;

            var todas = atividade1 && atividade2;

            Console.WriteLine("Fez todas as atividades ? {0}", todas);

            var umaApenas = atividade1 || atividade2;

            Console.WriteLine("Fez pelo menos uma das atividades ? {0}", umaApenas);

            Console.WriteLine("Não fez nenhuma? {0}", !umaApenas);
        }
    }
}