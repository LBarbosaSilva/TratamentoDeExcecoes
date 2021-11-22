using System;
using System.Globalization;
using Seção_11___Exercicio_Proposto__excecoes_.Entitites;
using Seção_11___Exercicio_Proposto__excecoes_.Entitites.Exceptions;

namespace Seção_11___Exercicio_Proposto__excecoes_
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Fazer um programa para ler os dados de uma conta bancária e depois realizar um 
            saque nesta conta bancária, mostrando o novo saldo. Um saque não pode ocorrer 
            ou se não houver saldo na conta, ou se o valor do saque for superior ao limite de 
            saque da conta. Implemente a conta bancária conforme projeto abaixo:
            */

            Console.WriteLine("Enter account data ");
            Console.Write("Number: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial balance: ");
            double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Withdraw limit: ");
            double withdraw_limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Account account = new Account(n, holder, balance, withdraw_limit);

            Console.WriteLine();
            Console.Write("Enter amount for withdraw: ");
            double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            try
            {
                account.Withdraw(withdraw);
                Console.WriteLine("New Balance: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));

            }
            catch (DomainException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
        }
    }
}
