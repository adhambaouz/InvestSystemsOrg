using System;
using InvSys.Shared.Core.State;

namespace InvSys.Financials.Core.Models
{
    public class BalanceSheet : IEntity<Guid>
    {
        public Guid Id { get; set; }

        public Guid CompanyId { get; set; }
        public string CompanySymbol { get; set; }
        public DateTime Year { get; set; }

        public decimal Equity { get; set; } // Book value or Net worth
        public decimal Debt { get; set; }
    }
}
