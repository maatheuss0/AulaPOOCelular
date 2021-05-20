using System;

namespace AulaPOOCelular_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular celular = new Celular();
            int escolha;
            bool Ligar;
            string ligacao;
            string mensagem;
            string pessoa;
            Ligar = false;

            do
            {
                if (Ligar == false)
                {
                    Console.WriteLine($@" 
_________________________________________
/  _____________________________________  \
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |            1 - Ligar              |  |
|  |            0 - Desligar           |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |___________________________________|  |
\_____________________O___________________/");

                    escolha = int.Parse(Console.ReadLine());
                    if (escolha == 1)
                    {
                        celular.Ligar();
                        Ligar = celular.Ligar();
                    }
                }

                else
                {
                    Console.WriteLine($@" 
_________________________________________
/  _____________________________________  \
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |        1 - Fazer Ligação          |  |
|  |        2 - Mandar mensagem        |  |
|  |        3 - Especificações         |  |
|  |        4 - Desligar               |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |                                   |  |
|  |___________________________________|  |
\_____________________O___________________/");

                    escolha = int.Parse(Console.ReadLine());

                    switch (escolha)
                    {
                        case 1:

                            Console.WriteLine("Para quem você deseja ligar?");
                            ligacao = Console.ReadLine();

                            Console.WriteLine("Ligando para: " + ligacao);
                            Console.WriteLine("Ops... Aparentemente você está sem crédito");

                            break;

                        case 2:

                            Console.WriteLine("Para quem você deseja mandar mensagem?");
                            pessoa = Console.ReadLine();

                            Console.WriteLine("Escreva sua mensagem: ");
                            mensagem = Console.ReadLine();

                            Console.WriteLine("Mensagem enviada para " + pessoa);

                            break;

                        case 3:

                            Console.WriteLine("Especificações");
                            Console.WriteLine("Modelo: " + celular.modelo);
                            Console.WriteLine("Cor : " + celular.cor);
                            Console.WriteLine("Armazenamento: " + celular.Espaço);
                            Console.WriteLine("Camêra primária: " + celular.camera);
                            Console.WriteLine("Resolução: " + celular.resolução);
                            Console.WriteLine("Tamanho: " + celular.Tamanho);
                            Console.WriteLine("Sistema operacional: " + celular.Sistema);

                            break;

                        case 4:

                            Console.WriteLine("Estendido, desligando o aparelho...");
                            celular.Desligar();
                            Ligar = celular.Desligar();
                            break;
                    }
                }

            } while (Ligar == true);
        }
    }
}
