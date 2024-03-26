namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string opcao = MostrarMenu();

                if (OpcaoSaidaSelecionada(opcao))
                    break;


                else if (OpcaoInvalida(opcao))
                {
                    ExibirMenssagemErro();
                    continue;
                }
                else
                    RealizarCalculo(opcao);

                
            }
        }

        static string MostrarMenu()
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

            return operacao;
        }

        static bool OpcaoSaidaSelecionada(string opcao)
        {
            bool opcaoSeecionada = opcao == "S" || opcao == "s";

            return opcaoSeecionada;
        }

        static bool OpcaoInvalida(string opcao)
        {
            bool opcaoInvalida = opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" &&
                    opcao != "S" && opcao != "s";

            return opcaoInvalida;
        }

        private static void ExibirMenssagemErro()
        {
            Console.WriteLine("Opção invalida. Tente novamente!");
            Console.ReadLine();
        }
        static void RealizarCalculo(string opcao)
        {

            Console.WriteLine("Digite o primeiro Número: ");
            decimal primeiroNumero = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o segundo Número: ");
            decimal segundoNumero = Convert.ToDecimal(Console.ReadLine());

            decimal resultado = 0;
            switch (opcao)

            {
                case "1":
                    resultado = primeiroNumero + segundoNumero;
                    break;
                case "2":
                    resultado = primeiroNumero - segundoNumero;
                    break;
                case "3":
                    resultado = primeiroNumero * segundoNumero;
                    break;
                case "4":
                    while (segundoNumero == 0)
                    {
                        Console.WriteLine("Não é possivel faze divizão por zero ");
                        Console.WriteLine("Digite o segundo Número: ");
                        segundoNumero = Convert.ToDecimal(Console.ReadLine());
                    }
                    resultado = primeiroNumero / segundoNumero;
                    break;

            }

            ExibirResultado(resultado);

        }

        private static void ExibirResultado(decimal resultado)
        {
            Console.WriteLine("O resultado é: " + resultado);
            Console.ReadLine();
        }
    }
}
