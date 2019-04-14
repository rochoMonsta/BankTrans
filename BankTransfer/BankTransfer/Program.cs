using System;

namespace BankTransfer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть ваш Id: ");
            int id1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введіть Id іншої людини: ");
            int id2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введіть суму трансферу: ");
            int sum = Convert.ToInt32(Console.ReadLine());

            Acount acount1 = new Acount(id1) { Sum = 9000 };
            Acount acount2 = new Acount(id2) { Sum = 5000 };

            Transaction<Acount> transaction = new Transaction<Acount>
            {
                FromAcount = acount1,
                ToAcount = acount2,
                Sum = sum
            };

            transaction.Execute();

            Console.ReadLine();
        }
    }
}
