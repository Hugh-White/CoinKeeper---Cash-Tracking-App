using CoinKeeper.Abstractions;
using Humanizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinKeeper.MVVM.Models
{
    public class Transaction : TableData
    {
        public string? Name { get; set; }
        public decimal Amount { get; set; }
        public bool IsIncome { get; set; }
        public DateTime OperationDate { get; set; }
        public string HumanDate
        {
            get
            {
                return OperationDate.Humanize();
            }
        }
    }
}
