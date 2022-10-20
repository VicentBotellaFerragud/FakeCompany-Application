using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeCompany_Application.Domain
{
    public class ManagerSale
    {
        public int ManagerSaleId { get; set; }
        public int Quantity { get; set; }
        public Manager Manager { get; set; }
        public int ManagerId { get; set; }
    }
}
