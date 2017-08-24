using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Atm
{
    class Transaction
    {

        int[] card = new int[3] { 111, 222, 333 };
        int[] pin = new int[3] { 1111, 2222, 3333 };
        double[] balance = new double[3] { 10000, 20000, 50000 };

        int userCard ;

        public object Application { get; private set; }

        public void Start()
        {
            Console.WriteLine("\n Enter UR Card ");
            var inputCard = Int32.Parse(Console.ReadLine());

            if (!card.Contains(inputCard))
            {
                Console.WriteLine("\n No Card Found, please try again");
                Console.WriteLine();
                Start();
            }
            userCard = inputCard;
            PinChk();
            Display();
        }

        public void PinChk()
        {
            Console.WriteLine("\n Enter UR PIN ");
            var inputPin = Int32.Parse(Console.ReadLine());

            if (!pin.Contains(inputPin))
            {
                Console.WriteLine("\n Wrong PIN, please try again");
                Console.WriteLine();
                PinChk();
            }
        }

        public void Display()
        {
            Console.WriteLine("\n Enter your choise : ");
            Console.WriteLine("\n 1 Balance Check \n 2 Deposit \n 3 Withdrawal \n 0 Exit");
            var choise = Int32.Parse(Console.ReadLine());

            if(choise == 1){ BalanceChk(); }
            else if(choise == 2){ Deposit(); }
            else if(choise == 3){ Withdrawal(); }
            else if(choise == 0){ Start(); }

            Display();
        }

        public void BalanceChk()
        {
            int cardIndex = Array.IndexOf(card, userCard);
            Console.WriteLine("\n Your current Balance is : " + balance[cardIndex]);
        }

        public void Deposit()
        {
            Console.WriteLine("\n Enter your amount : ");
            double amount = Int32.Parse(Console.ReadLine());

            int cardIndex = Array.IndexOf(card, userCard);
            balance[cardIndex] += amount;
            Console.WriteLine("\n Your balance has been updated");
            BalanceChk();
        }

        public void Withdrawal()
        {
            Console.WriteLine("\n Enter your amount : ");
            double amount = Int32.Parse(Console.ReadLine());

            int cardIndex = Array.IndexOf(card, userCard);
            balance[cardIndex] -= amount;
            Console.WriteLine("\n Your balance has been updated");
            BalanceChk();
        }

    }
}
