using System;
using System.Collections.Generic;

namespace FakeCompany_Application.Data.Models
{
    public partial class EmployeeSale
    {
        public int EmployeeSaleId { get; set; }
        public int? Quantity { get; set; }
        public int? EmployeeId { get; set; }

        public virtual Employee? Employee { get; set; }
    }
}
