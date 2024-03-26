namespace ProjetoApostas
{
    internal class Program
    {

        static Random aleatorio = new Random();

        static string nome = "";
        static int saldo = 0;
        static void Main(string[] args)
        {
            int sair = 1;
            int operador = 0;
            Console.WriteLine("Qual o seu nome");
            nome = Console.ReadLine();

            do
            {
                Console.Clear();
                Console.WriteLine("Bem vindo " + nome);
                Console.WriteLine("So seu Saldo é de: " + saldo);
                Console.WriteLine("===================================");
                Console.WriteLine("Escolha uma das seguintes opções abaixo");
                Console.WriteLine("1 - Loterias");
                Console.WriteLine("2 - Raspadinhas");
                Console.WriteLine("3 - Saques/Depósitos");
                Console.WriteLine("0 - Sair");
                operador = int.Parse(Console.ReadLine());

                if (operador == 0)
                {
                    Console.WriteLine("Sessão finalizada");
                    sair = 0;
                }

                else if (operador == 1)
                {
                    Loteria();
                }

                else if (operador == 2)
                {
                    Raspadinhas();
                }

                else if (operador == 3)
                {
                    Banco();
                }

                else
                {
                    Console.WriteLine("Opção invalida");
                    Console.WriteLine("Selecione uma opção abaixo");
                }

            } while (sair == 1);

        }




        private static void Loteria()
        {



            int npremiado;
            int sair = 1;
            int operador = 0;
            int njogador;
            int valorpremio = aleatorio.Next(100, 1000);
            Console.Clear();

            npremiado = aleatorio.Next(1000, 10000);

            do
            {
                Console.Clear();
                Console.WriteLine("Bem vindo " + nome);
                Console.WriteLine("Saldo: " + saldo);
                Console.WriteLine("===================================");
                Console.WriteLine("Menu Loteria");
                Console.WriteLine("Valor do premio: " + valorpremio);
                Console.WriteLine("1 - Tentar um numero na Loteria, Custo 5 reais");
                Console.WriteLine("0 - Menu anterior");
                operador = int.Parse(Console.ReadLine());
                if (saldo > 5)
                {
                    saldo -= 5;
                    if (operador == 0)
                    {
                        Console.WriteLine("Retornando ao menu anterior, pressione Enter novamente");
                        sair = 0;
                    }

                    else if (operador == 1)
                    {
                        Console.WriteLine("Bem vindo " + nome);
                        Console.WriteLine("Saldo: " + saldo);
                        Console.WriteLine("===================================");
                        Console.WriteLine("Voce pagou 5 reais");
                        saldo -= 5;
                        Console.WriteLine("Seu saldo atual " + saldo);
                        Console.WriteLine("Numero premiado " + npremiado);
                        Console.WriteLine("Qual o numero deseja tentar na loteria entre 1000-9999");
                        njogador = int.Parse(Console.ReadLine());



                        if (njogador > 1000 && njogador < 9999)
                        {
                            Console.WriteLine("Você escolheu o numero " + njogador);
                            if (njogador == npremiado)
                            {
                                Console.WriteLine("Você venceu o 1º premio, no valor de " + valorpremio);
                                saldo = saldo + valorpremio;
                                Console.WriteLine("O seu saldo agora é de: " + saldo);
                                sair = 0;
                            }

                            else if (npremiado % 1000 == njogador % 1000)
                            {
                                valorpremio = valorpremio / 2;
                                Console.WriteLine("Você venceu o 2º premio, no valor de " + valorpremio);
                                saldo = saldo + valorpremio;
                                Console.WriteLine("O seu saldo agora é de: " + saldo);
                                sair = 0;
                            }

                            else if (npremiado % 100 == njogador % 100)
                            {
                                valorpremio = valorpremio / 3;
                                Console.WriteLine("Você venceu o 3º premio, no valor de" + valorpremio);
                                saldo = saldo + valorpremio;
                                Console.WriteLine("O seu saldo agora é de: " + saldo);
                                sair = 0;
                            }


                        }

                        else if (njogador != npremiado)
                        {
                            Console.WriteLine("Não foi dessa vez");
                            Console.WriteLine("Saldo " + saldo);
                            sair = 1;
                        }


                        else if (njogador < 1000 || njogador > 9999)
                        {
                            Console.WriteLine("Opção invalida, tente novamente");
                            sair = 1;
                        }

                        else
                        {
                            Console.WriteLine("Opção invalida");
                            sair = 0;
                        }

                    }

                    else if (operador == 2)
                    {

                    }

                    else
                    {
                        Console.WriteLine("");
                        sair = 1;
                    }

                }
                else
                {
                    Console.WriteLine("Saldo insulficiente");
                    sair = 0;
                }


            } while (sair == 1);

            Console.ReadKey();

        }



        private static void Raspadinhas()
        {
            int sair = 1;
            int operador;

            do
            {
                Console.Clear();
                Console.WriteLine("Bem vindo " + nome);
                Console.WriteLine("Saldo: " + saldo);
                Console.WriteLine("===================================");
                Console.WriteLine("Menu Raspadinha");
                Console.WriteLine("1 - Raspadinha A");
                Console.WriteLine("2 - Raspadinha B");
                Console.WriteLine("0 - Menu anterior");
                operador = int.Parse(Console.ReadLine());


                if (operador == 0)
                {
                    Console.WriteLine("Retornando ao menu anterior, pressione Enter novamente");
                    sair = 0;
                }

                else if (operador == 1)
                {
                    RaspadinhaA();
                }

                else if (operador == 2)
                {
                    RaspadinhaB();
                }

                else
                {
                    Console.WriteLine("Opção Invalida, tente novamente");
                    sair = 1;
                }


            } while (sair == 1);
        }




        private static void RaspadinhaA()
        {
            Console.Clear();
            Console.WriteLine("Bem vindo " + nome);
            Console.WriteLine("Saldo: " + saldo);
            Console.WriteLine("===================================");

            if (saldo > 5)
            {
                saldo -= 5;
                Console.WriteLine("Voce pagou 5 reais");
                Console.WriteLine("Seu saldo atual " + saldo);
                int nprincipal = aleatorio.Next(1, 10);
                int premio = 0;
                int numero1 = aleatorio.Next(1, 10); int p1 = aleatorio.Next(1, 200);
                int numero2 = aleatorio.Next(1, 10); int p2 = aleatorio.Next(1, 200);
                int numero3 = aleatorio.Next(1, 10); int p3 = aleatorio.Next(1, 200);
                int numero4 = aleatorio.Next(1, 10); int p4 = aleatorio.Next(1, 200);
                int numero5 = aleatorio.Next(1, 10); int p5 = aleatorio.Next(1, 200);

                Console.WriteLine("Numero Principal: " + nprincipal);
                Console.WriteLine("1º Numero " + numero1 + " (" + p1 + ")");
                Console.WriteLine("2º Numero " + numero2 + " (" + p2 + ")");
                Console.WriteLine("3º Numero " + numero3 + " (" + p3 + ")");
                Console.WriteLine("4º Numero " + numero4 + " (" + p4 + ")");
                Console.WriteLine("5º Numero " + numero5 + " (" + p5 + ")");


                if (numero1 == nprincipal)
                {
                    premio += p1;
                }
                if (numero2 == nprincipal)
                {
                    premio += p2;
                }
                if (numero3 == nprincipal)
                {
                    premio += p3;
                }
                if (numero4 == nprincipal)
                {
                    premio += p4;
                }
                if (numero5 == nprincipal)
                {
                    premio += p5;
                }

                Console.WriteLine("Premio: " + premio);
                saldo += premio;

                Console.WriteLine("Saldo: " + saldo);

            }
            else
            {
                Console.WriteLine("Saldo Insulficiente");
            }

            Console.ReadKey();
        }




        private static void RaspadinhaB()
        {
            Console.Clear();
            Console.WriteLine("Bem vindo " + nome);
            Console.WriteLine("Saldo: " + saldo);
            Console.WriteLine("===================================");
            if (saldo > 5)
            {
                saldo -= 5;
                Console.WriteLine("Vece pagou 5 reais");
                Console.WriteLine("Seu saldo atual " + saldo);
                int nprincipal = aleatorio.Next(1, 10);
                int premio = aleatorio.Next(1, 100);

                int n1 = aleatorio.Next(1, 10);
                int n2 = aleatorio.Next(1, 10);
                int n3 = aleatorio.Next(1, 10);
                int n4 = aleatorio.Next(1, 10);
                int n5 = aleatorio.Next(1, 10);
                int n6 = aleatorio.Next(1, 10);
                int n7 = aleatorio.Next(1, 10);
                int n8 = aleatorio.Next(1, 10);
                int n9 = aleatorio.Next(1, 10);

                int contador = 0;

                if (nprincipal == n1) contador++;
                if (nprincipal == n2) contador++;
                if (nprincipal == n3) contador++;
                if (nprincipal == n4) contador++;
                if (nprincipal == n5) contador++;
                if (nprincipal == n6) contador++;
                if (nprincipal == n7) contador++;
                if (nprincipal == n8) contador++;
                if (nprincipal == n9) contador++;

                Console.WriteLine("Numero Principal: " + nprincipal + " Premio: (" + premio + ")");

                Console.WriteLine(n1 + " " + n2 + " " + n3);
                Console.WriteLine(n4 + " " + n5 + " " + n6);
                Console.WriteLine(n7 + " " + n8 + " " + n9);

                if (contador >= 3)
                {
                    Console.WriteLine("Parabéns, ganhou o premio " + premio);
                    saldo += premio;
                    Console.WriteLine("Saldo: " + saldo);
                }

                else
                {
                    Console.WriteLine("Raspadinha não premiada.");
                }
            }
            else
            {
                Console.WriteLine("Valor insulficiente");
            }

            Console.ReadKey();

        }


        private static void Banco()
        {
            int sair = 1;
            int operador;

            do
            {
                Console.Clear();
                Console.WriteLine("Bem vindo " + nome);
                Console.WriteLine("Saldo: " + saldo);
                Console.WriteLine("===================================");
                Console.WriteLine("Menu Banco");
                Console.WriteLine("1 - Realziar Saque");
                Console.WriteLine("2 - Realizar Depositos");
                Console.WriteLine("0 - Menu anterior");
                operador = int.Parse(Console.ReadLine());

                if (operador == 0)
                {
                    Console.WriteLine("Retornando ao menu anterior, pressione Enter novamente");
                    sair = 0;
                }

                else if (operador == 1)
                {
                    Saque();
                }

                else if (operador == 2)
                {
                    Deposito();
                }

                else
                {
                    Console.WriteLine("Opção Invalida, tente novamente");
                    sair = 1;
                }


            } while (sair == 1);
        }

        private static void Saque()
        {
            Console.Clear();

            int valor;
            int operador = 0;
            int sair = 0;
            do
            {



                Console.Clear();
                Console.WriteLine("Bem vindo " + nome);
                Console.WriteLine("Saldo: " + saldo);
                Console.WriteLine("===================================");
                Console.WriteLine("Menu Saque");
                Console.WriteLine("1 - Realizar Saque");
                Console.WriteLine("0 - Menu Anterior");
                operador = int.Parse(Console.ReadLine());

                if (operador == 1)
                {
                    Console.WriteLine("Saldo atual: " + saldo);
                    Console.WriteLine("Qual o valor deseja sacar: ");
                    valor = int.Parse(Console.ReadLine());

                    if (valor < 0 || valor > 1000)
                    {
                        Console.WriteLine("Valor incorreto, digite novamente");
                    }
                    else if (saldo - valor < 0)
                    {
                        Console.WriteLine("Valor incorreto, digite novamente");
                    }

                    else
                    {
                        saldo = saldo - valor;
                        Console.WriteLine("Saque realizado");
                        Console.WriteLine("Saldo: " + saldo);

                    }
                }
                else
                {
                    sair = 0;
                }

            } while (sair == 1);
            Console.ReadKey();

            Console.ReadKey();
        }

        private static void Deposito()
        {
            int valor;
            int operador = 0;
            int sair = 0;
            do
            {



                Console.Clear();
                Console.WriteLine("Bem vindo " + nome);
                Console.WriteLine("Saldo: " + saldo);
                Console.WriteLine("===================================");
                Console.WriteLine("Menu Deposito");
                Console.WriteLine("1 - Realizar Deposito");
                Console.WriteLine("0 - Menu Anterior");
                operador = int.Parse(Console.ReadLine());

                if (operador == 1)
                {
                    Console.WriteLine("Saldo atual: " + saldo);
                    Console.WriteLine("Qual o valor deseja depositar: ");
                    valor = int.Parse(Console.ReadLine());

                    if (valor < 0 || valor > 1000)
                    {
                        Console.WriteLine("Valor incorreto, digite novamente");
                    }

                    else
                    {
                        saldo = saldo + valor;
                        Console.WriteLine("Valor depositado");
                        Console.WriteLine("Saldo: " + saldo);

                    }
                }
                else
                {
                    sair = 0;
                }

            } while (sair == 1);
            Console.ReadKey();





        }
    }
}
