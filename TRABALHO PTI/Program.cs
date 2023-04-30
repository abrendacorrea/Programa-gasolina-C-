class Program
{
    public static void Main(string[] args)
    {

      
        int opcao;
        do {

            {
                {
                    Console.WriteLine(" Insira aqui o valor do alcool ");
                    double alcool = double.Parse(Console.ReadLine());
                    Console.WriteLine(" Insira aqui o valor da gasolina ");
                    double gasolina = int.Parse(Console.ReadLine());

                    double resultado = alcool / gasolina;
                    Console.WriteLine(resultado = alcool / gasolina);

                    if (resultado > 0.7)
                    {
                        Console.WriteLine("é mais vantajoso você abastecer com Gasolina!");
                    }

                    else if (resultado < 0.7)
                    {
                        Console.WriteLine("é mais vantajoso você abastecer com Alcool!");
                    }

                    else
                    {
                        Console.WriteLine("Abasteça com Gasolina ou Alcool!");

                    }


                    Console.WriteLine("tecle 1 para realizar um novo calculo");
                    Console.WriteLine("tecle 0 para sair");
                }
            }
            opcao = int.Parse(Console.ReadLine());
        } 
        while (opcao != 0);
        
}
}
            




