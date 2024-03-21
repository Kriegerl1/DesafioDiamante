namespace DesafioDiamanteXConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Desafio diamante X | Academia de Programação 2024!\n");

            int valorDiamante = obterValor("Digite um número impar: ");
            do
            {
                if (valorDiamante % 2 == 0)
                {

                    Console.WriteLine("O número deve ser ímpar.");
                    valorDiamante = obterValor("Digite um número impar: ");
                }
                else
                {
                    int espaco = (valorDiamante - 1) / 2;
                    int letraX = 1;
                    //Cima
                    for (int eixoY = 1; espaco > 0; eixoY++)
                    {

                        for (int i = 0; i < espaco; i++)
                        {
                            Console.Write(" ");
                        }


                        for (int i = 0; i < letraX; i++)
                        {
                            Console.Write("X");

                        }


                        Console.WriteLine("");

                        espaco--;
                        letraX += 2;
                    }
                    //Meio
                    for (int i = 0; i < valorDiamante; i++)
                    {
                        Console.Write("X");
                    }

                    Console.WriteLine("");

                    //Baixo
                    for (int eixoY = 0; letraX > 0; eixoY++)
                    {

                        for (int i = 0; i < espaco; i++)
                        {
                            Console.Write(" ");
                        }


                        for (int i = 0; i < letraX; i++)
                        {
                            Console.Write("X");

                        }


                        Console.WriteLine("");

                        espaco++;
                        letraX -= 2;
                    }
                    Console.WriteLine("");
                    valorDiamante = obterValor("Digite um número impar: ");

                }
            } while (valorDiamante % 3 != 1);



            static int obterValor(string texto)
            {
                Console.WriteLine(texto);

                int input = Convert.ToInt32(Console.ReadLine());

                return input;
            }
        }
    }
}