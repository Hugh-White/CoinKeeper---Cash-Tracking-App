using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoinKeeper.MVVM.Models;

namespace CoinKeeper.MVVM.ViewModels
{
    public class TransactionsViewModel
    {
        public Transaction Transaction { get; set; } = new Transaction
        {
            OperationDate = DateTime.Now,
        };

        public string SaveTransaction()
        {
            App.TransactionsRepo.SaveItem(Transaction);

            return App.TransactionsRepo.StatusMessage;
        }
    }
}
