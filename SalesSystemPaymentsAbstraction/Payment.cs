using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesSystemPaymentsAbstraction
{
    public   class Payment
    {
        public int CustomerId{ get; set; }
        public double ChargAmount{ get; set; }
        public Guid ReferenceNumber{ get; set; }
    }
}
