﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountTesting
{
    public class Account
    {
        private float balance;
        private string name;
        private float minBalance = 10;

        public Account()
        {
            balance = 0;
            name = string.Empty;
        }

        public Account(int value, string name)
        {
            balance = value;
            this.name = name;
            Console.WriteLine($"{name} balance is {balance}.");
        }

        public void Deposit(float amount)
        {
            balance += amount;
            Console.WriteLine($"New balance of {this.name} is {this.balance}.");
        }

        public void Withdraw(float amount)
        {
            balance -= amount;
            Console.WriteLine($"New balance of {this.name} is {this.balance}.");
        }

        public void TransferFunds(Account destination, float amount)
        {
            Console.WriteLine($"Transfering {amount} in destination: {destination.name}");
            destination.Deposit(amount);
            Withdraw(amount);
        }

        public Account TransferMinFunds(Account destination, float amount)
        {
            if (amount < 0) throw new Exception("Amount cannot have a negative value!");
            if (GetBalance - amount <= GetMinBalance) throw new NotEnoughFundsException("Not enough funds! ");

            destination.Deposit(amount);
            Withdraw(amount);

            return destination;
        }

        public float GetBalance
        {
            get { return balance; }
        }

        public float GetMinBalance
        {
            get { return minBalance; }
        }

        public string GetName
        {
            get { return name; }
        }
    }
}
