namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static int operacaoRealizadas = 0;
        static void Main(string[] args)
        
        {

            string[] historicoOperacoes = new string[100];

            
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
                else if (opcao == "5")
                {
                    GerarTabuada();
                }
                else if (opcao == "6")
                {
                    VisualizarHIstoricoOperacoes(historicoOperacoes);
                
                }
                else
                    RealizarCalculo(opcao, historicoOperacoes);


            }
        }



        static string MostrarMenu()
        {
            Console.Clear();

            Console.WriteLine("Calculadora 2024");
            Console.WriteLine("");

            Console.WriteLine("Digite 1 para Adição");
            Console.WriteLine("Digite 2 para Subtrair");
            Console.WriteLine("Digite 3 para Multiplição");
            Console.WriteLine("Digite 4 para Divisão");
            Console.WriteLine("Digite 5 para Gerar a Tabuada");
            Console.WriteLine("Digite 6 para Historico de Operações");
            Console.WriteLine("Digite S para Sair");

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
            bool opcaoInvalida =
                opcao != "1" &&
                opcao != "2" &&
                opcao != "3" &&
                opcao != "4" &&
                opcao != "5" &&
                opcao != "6" &&
                opcao != "S" &&
                opcao != "s";

            return opcaoInvalida;
        }

        private static void ExibirMenssagemErro()
        {
            Console.WriteLine("Opção invalida. Tente novamente!");
            Console.ReadLine();
        }

        static void RealizarCalculo(string opcao, string[] historicoOperacoes)
        {

            Console.WriteLine("Digite o primeiro Número: ");
            decimal primeiroNumero = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o segundo Número: ");
            decimal segundoNumero = Convert.ToDecimal(Console.ReadLine());

            decimal resultado = 0;
            string operador = "";
            switch (opcao)

            {
                case "1":
                    resultado = primeiroNumero + segundoNumero;
                    operador = "+";
                    break;
                case "2":
                    resultado = primeiroNumero - segundoNumero;
                    operador = "-";
                    break;
                case "3":
                    resultado = primeiroNumero * segundoNumero;
                    operador = "x";
                    break;
                case "4":
                    resultado = Dividir(primeiroNumero, ref segundoNumero);
                    operador = "/";
                    break;


            }

            historicoOperacoes[operacaoRealizadas] = $"{primeiroNumero} {operador} {segundoNumero} = {resultado}";
            operacaoRealizadas++;
            ExibirResultado(resultado);

        }

        private static decimal Dividir(decimal primeiroNumero, ref decimal segundoNumero)
        {
            decimal resultado;
            while (segundoNumero == 0)
            {
                Console.WriteLine("Não é possivel faze divizão por zero ");
                Console.WriteLine("Digite o segundo Número: ");
                segundoNumero = Convert.ToDecimal(Console.ReadLine());
            }
            resultado = primeiroNumero / segundoNumero;
            return resultado;
        }

        private static void ExibirResultado(decimal resultado)
        {
            Console.WriteLine("O resultado é: " + resultado);
            Console.ReadLine();
        }
        private static void GerarTabuada()
        {
            Console.Clear();
            Console.WriteLine("Digite um numero inteito;");
            int numeroDigitado = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Tabuado do numero: {numeroDigitado}");
            Console.WriteLine();

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{numeroDigitado} x {i} = {numeroDigitado * i}");
            }
            Console.ReadLine();
        }

         static void VisualizarHIstoricoOperacoes(string[] historicoOperacoes)
        {
            Console.WriteLine("Exibir Historico de Operações");
            Console.WriteLine("-------------------------------");

            for (int operacao = 0; operacao < historicoOperacoes.Length; operacao++)
            {
                if (historicoOperacoes[operacao] != null)
                Console.WriteLine(historicoOperacoes[operacao]);
            }


            Console.WriteLine("Digite ENTER para continuar");

            Console.WriteLine();
        }

    }
}
