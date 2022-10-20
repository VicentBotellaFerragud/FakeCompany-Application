using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeCompany_Application.Domain
{
    public class EmployeeSale
    {
        public int EmployeeSaleId { get; set; }
        public int Quantity { get; set; }
        public Employee Employee { get; set; }
        public int EmployeeId { get; set; }
    }
}
