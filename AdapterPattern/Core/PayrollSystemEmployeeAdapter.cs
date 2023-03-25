using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Core
{
    public class PayrollSystemEmployeeAdapter
    {
        private readonly IEnumerable<PayrollSystemPayItemAdapter> _payItems;
        private readonly Employee _employee;
        public PayrollSystemEmployeeAdapter(Employee employee)
        {
            _employee = employee;
            _payItems=employee.PayItems.Select(p=>new PayrollSystemPayItemAdapter(p)).ToList();

        }

        public string FullName=> _employee.FullName;
        public IEnumerable<PayrollSystemPayItemAdapter> PayItems=> _payItems;

    }
}
