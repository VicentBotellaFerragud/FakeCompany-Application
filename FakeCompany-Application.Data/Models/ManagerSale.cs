using System;
using System.Collections.Generic;

namespace FakeCompany_Application.Data.Models
{
    public partial class ManagerSale
    {
        public int ManagerSaleId { get; set; }
        public int? Quantity { get; set; }
        public int? ManagerId { get; set; }

        public virtual Manager? Manager { get; set; }
    }
}
