namespace operadoresUnarios
{
    class Program
    {
        static void OperadoresUnarios()
        {
            var X = false;
            var n1 = 6;
            var n2 = 5;
            var n3 = 7;
            var n4 = 8;

            Console.WriteLine(!X);
            n3++;
            Console.WriteLine(n3);
            n4--;
            Console.WriteLine(n4);

            Console.WriteLine(n2 == --n1);
            Console.WriteLine(n2-- == ++n1);
        }
    }
}