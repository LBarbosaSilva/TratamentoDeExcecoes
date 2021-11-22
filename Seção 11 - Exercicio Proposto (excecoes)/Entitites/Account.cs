using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Seção_11___Exercicio_Proposto__excecoes_.Entitites.Exceptions;

namespace Seção_11___Exercicio_Proposto__excecoes_.Entitites
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit{ get; set; }


        //Construtores
        public Account()
        {

        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }


        //Métodos
        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new DomainException("O valor excede o limite de saque");
            }
            if (amount > Balance)
            {
                throw new DomainException("Deve haver saldo na conta!");
            }

            Balance -= amount;
        }
    }
}
