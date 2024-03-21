namespace DesafioDiamanteXConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Desafio diamante X | Academia de Programação 2024!\n");
            InicioPrograma(obterValor<int>("Digite um número impar: "));
        }

        static Dinamica obterValor<Dinamica>(string texto)
        {
            Console.WriteLine(texto);
            Console.WriteLine("Para fechar digite ( S / s ).");

            string input = Console.ReadLine();

            try
            {
                if (input == "S" || input == "s")
                {
                    Environment.Exit(0);
                }
                return (Dinamica)Convert.ChangeType(input, typeof(Dinamica));
            }
            catch (FormatException)
            {
                Console.WriteLine("Tipo não suportado.");
                return obterValor<Dinamica>(texto);
            }
        }

        static void estruturaDiamante(int valorDiamante)
        {
            int espacoEmBranco = (valorDiamante - 1) / 2;
            int XdoDiamante = 1;

            //Topo

            for (int eixoY = 1; espacoEmBranco > 0; eixoY++)
            {
                for (int eixoX = 0; eixoX < espacoEmBranco; eixoX++)
                {
                    Console.Write(" ");
                }
                for (int eixoX = 0; eixoX < XdoDiamante; eixoX++)
                {
                    Console.Write("X");
                }
                Console.WriteLine("");

                espacoEmBranco--;

                XdoDiamante += 2;
            }

            //Meio

            for (int eixoX = 0; eixoX < valorDiamante; eixoX++)
            {
                Console.Write("X");
            }
            Console.WriteLine("");

            //Base

            for (int eixoY = 0; XdoDiamante > 0; eixoY++)
            {
                for (int eixoX = -1; eixoX < espacoEmBranco; eixoX++)
                {
                    Console.Write(" ");
                }
                for (int eixoX = 0; eixoX < XdoDiamante - 2; eixoX++)
                {
                    Console.Write("X");
                }
                Console.WriteLine("");

                espacoEmBranco++;

                XdoDiamante -= 2;
            }

            valorDiamante = obterValor<int>("Digite um número impar: ");
            InicioPrograma(valorDiamante);
        }

        static void InicioPrograma(int valorDiamante)
        {
            do
            {
                if (valorDiamante % 2 == 0)
                {

                    Console.WriteLine("O número deve ser ímpar.");
                    valorDiamante = obterValor<int>("Digite um número impar:");
                }
                else
                {
                    estruturaDiamante(valorDiamante);
                    break;
                }
            } while (valorDiamante % 2 == 0 || valorDiamante % 3 != 1 || valorDiamante == 0);
        }

    }
}