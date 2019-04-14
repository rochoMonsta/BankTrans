using System;
namespace BankTransfer
{
    public class Transaction<T> where T: Acount
    {
        public Transaction(){ }

        public T FromAcount { get; set; }
        public T ToAcount { get; set; }
        public int Sum { get; set; }

        public void Execute()
        {
            if (FromAcount.Sum > Sum)
            {
                FromAcount.Sum -= Sum;
                ToAcount.Sum += Sum;
                Console.WriteLine($"Рахунок {FromAcount.Id}: {FromAcount.Sum}\n" +
                    $"Рахунок {ToAcount.Id}: {ToAcount.Sum}");
            }
            else
            {
                Console.WriteLine($"Недостатньо коштів на рахунку: {FromAcount.Id}");
            }
        }
    }
}
