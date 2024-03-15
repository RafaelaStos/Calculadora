namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("Calculadora 2024");
                Console.WriteLine("");

                Console.WriteLine("Digite 1 para Adição");
                Console.WriteLine("Digite 2 para Subtrair");
                Console.WriteLine("Digite 3 para multiplição");
                Console.WriteLine("Digite 4 para Divisão");
                Console.WriteLine("Digite S para sair");

                string operacao = Console.ReadLine();
                Console.WriteLine("");

                if (operacao == "1" || operacao == "2" || operacao == "3" || operacao == "4" ||
                    operacao == "S" || operacao == "s")
                {
                    if (operacao == "S" || operacao == "s")
                        break;

                    Console.WriteLine("Digite o primeiro Número: ");
                    string primeiroNumeroString = "";
                    primeiroNumeroString = Console.ReadLine();
                    decimal primeiroNumero = Convert.ToDecimal(primeiroNumeroString);

                    Console.WriteLine("Digite o segundo Número: ");
                    string segundoNumeroString = "";
                    segundoNumeroString = Console.ReadLine();
                    decimal segundoNumero = Convert.ToDecimal(segundoNumeroString);

                    decimal resultado = 0;

                    if (operacao == "1")

                        resultado = primeiroNumero + segundoNumero;

                    else if (operacao == "2")

                        resultado = primeiroNumero - segundoNumero;

                    else if (operacao == "3")

                        resultado = primeiroNumero * segundoNumero;

                    else if (operacao == "4")
                    {

                        while (segundoNumero == 0)
                        {
                            Console.WriteLine("Não é possivel faze divizão por zero ");
                            Console.WriteLine("Digite o segundo Número: ");
                            segundoNumeroString = Console.ReadLine();
                            segundoNumero = Convert.ToDecimal(segundoNumeroString);
                        }
                        resultado = primeiroNumero / segundoNumero;
                    }
                    Console.WriteLine("");
                    Console.WriteLine("O resultado é: " + resultado);

                }
                else
                    Console.WriteLine("Opção invalida. Tente novamente!");
                Console.ReadLine();

            }
        }
    }
}
