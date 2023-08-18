namespace if_else
{
    class Program
    {
        static void If_Else()
        {
            var n1 = 5;
            var n2 = 9;
            var n3 = 10;

            if(n1 < n2)
            {
                Console.WriteLine("Condição 1 deu boa!.");
                Console.WriteLine("Resultado da soma é {0}", n1 + n2);
            }
            if (n3 < n2)
            {
                Console.WriteLine(n2 + n3);
            }
            else
            {
                Console.WriteLine("Condição 2 não deu boa!.");
            }
        }
    }
}