using System;
using Trybank.Lib;

namespace Trybank.App;

class Program
{
    static void Main(string[] args)
    {
        TrybankLib bank = new();

        while (true)
        {
            try
        {
            Console.WriteLine("Bem-vindo(a) ao Trybank!");
            Console.WriteLine("Digite o número da opção que você deseja acessar:");
            Console.WriteLine("1 - Registrar conta");
            Console.WriteLine("2 - Fazer login");
            Console.WriteLine("3 - Checar saldo");
            Console.WriteLine("4 - Fazer depósito");
            Console.WriteLine("5 - Fazer saque");
            Console.WriteLine("6 - Transferir para outra conta");
            Console.WriteLine("7 - Fazer logout");
            Console.WriteLine("0 - Sair");

            var optionEntry = Console.ReadLine();

            if (optionEntry == "0")
            {
                Console.WriteLine("Encerrando o programa...");
                break;
            }
            
            if (optionEntry == "1")
            {
                Console.WriteLine("Digite o número da agência que você recebeu por email:");
                int agencyNumber = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("Digite o número da conta que você recebeu por email:");
                int accountNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Cadastre uma senha com quatro caracteres numéricos:");
                int password = Convert.ToInt32(Console.ReadLine());

                bank.RegisterAccount(accountNumber, agencyNumber, password);
                Console.WriteLine($"Conta {agencyNumber}-{accountNumber} registrada com sucesso!");

            }
            else if (optionEntry == "2")
            {
                Console.WriteLine("Digite o número da sua agência:");
                int agencyNumber = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("Digite o número da sua conta:");
                int accountNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite sua senha:");
                int password = Convert.ToInt32(Console.ReadLine());

                bank.Login(accountNumber, agencyNumber, password);
                Console.WriteLine("Login bem-sucedido!");
            }
            else if (optionEntry == "3")
            {
                int saldo = bank.CheckBalance();
                Console.WriteLine("Saldo atual: " + saldo);
            }
            else if (optionEntry == "4")
            {
                Console.WriteLine("Digite o valor a ser depositado:");
                int depositValue = Convert.ToInt32(Console.ReadLine());
                if (depositValue > 0)
                {
                    bank.Deposit(depositValue);
                    Console.WriteLine($"Depósito de R$ {depositValue} realizado com sucesso!");
                }
                else
                {
                    Console.WriteLine("O valor do depósito deve ser maior que zero");
                }
            }
            else if (optionEntry == "5")
            {
                Console.WriteLine("Digite o valor a ser sacado:");
                int withdrawValue = Convert.ToInt32(Console.ReadLine());
                if (withdrawValue > 0)
                {
                    bank.Withdraw(withdrawValue);
                    Console.WriteLine($"Saque de R$ {withdrawValue} realizado com sucesso!");
                }
                else
                {
                    Console.WriteLine("O valor do saque deve ser maior que zero");
                }
            }
            else if (optionEntry == "6")
            {
                Console.WriteLine("Digite o número da agência da conta de destino:");
                int agencyNumber = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("Digite o número da conta de destino:");
                int accountNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite o valor a ser transferido para a conta de destino:");
                int transferredAmount = Convert.ToInt32(Console.ReadLine());

                bank.Transfer(accountNumber, agencyNumber, transferredAmount);
                Console.WriteLine($"Transferência de {transferredAmount} para conta {agencyNumber}-{accountNumber} realizada com sucesso!");
            }
            else if (optionEntry == "7")
            {
                bank.Logout();
                Console.WriteLine("Logout bem-sucedido!");
            }
            else
            {
                Console.WriteLine("Opção inválida!");
            }

            Console.WriteLine();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro: " + ex.Message);
        }
        }
    }
}
