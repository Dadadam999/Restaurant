using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    [Serializable]
    public class Client
    {
        public Guid Id { get; }
        public string Type { get; set; }
        public string UtmSource { get; set; }
        public string FrirstName { get; set; }
        public string LastName { get; set; }
        public string Sex { get; set; }
        public Decimal CostAll { get { return DataSet.Database.Orders.Where(x => x.IdClient == Id).Sum(x => x.Amount); } } 
        public Decimal CostMounth { get { return DataSet.Database.Orders.Where(x => x.IdClient == Id && x.isArchive).Sum(x => x.Amount); } }
        public Decimal Sales { get; set; } = 0;
        public int VisitCount { get { return DataSet.Database.Orders.Where(x => x.IdClient == Id).Count(); } }
        public string LastVisit { get; set; }
        
        public Client()
        {
            Id = Guid.NewGuid();
        }
    }
}
