using System;
namespace BankTransfer
{
    public class Acount
    {
        public Acount(){ }

        public int Id { get; private set; }

        public int Sum { get; set; }

        public Acount(int id) { Id = id; }
    }
}
