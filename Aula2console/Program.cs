using System;

namespace Aula2console
{
    class Program
    {
        static void Main(string[] args)
        {
            //Um diretor de uma empresa quer saber se os seus funcionarios estao gostando da empresa, porem caso alguem nao goste 
            //saber o motivo. APENAS UM FUNCIONARIO.

            string situacaoDofuncionario;
            string respostaSeNao;

            Console.WriteLine("Voce esta gostando de trabalhar aqui na Iaudit? (sim ou nao)");
            situacaoDofuncionario = Console.ReadLine();

            if (situacaoDofuncionario.ToLower() == "sim")
            {
                Console.WriteLine("Que legal, muito bom saber que voce gosta de trabalhar aqui!");
            }
            else
            { 
                if (situacaoDofuncionario.ToLower() == "nao")
                {
                    Console.WriteLine("Mas porque voce nao gosta de trabalhar aqui?");
                    respostaSeNao = Console.ReadLine();
                    Console.WriteLine("Esta certo sobre sua resposta? : " + respostaSeNao);
                }
            }
            Console.ReadKey();
        }
    }
}
