using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labosi_6
{//zadatak 4
    class BankAccountMemento
    {
        public string OwnerName
        {
            get; private set;
        }
        public string OwnerAddress
        {
            get; private set;
        }
        public decimal Balance
        {
            get; private set;
        }

        public BankAccountMemento(string ownerName, string ownerAddress, decimal balance)
        {
            this.OwnerAddress = ownerAddress;
            this.OwnerAddress = ownerAddress;
            this.Balance = balance;
        }


    }
}
