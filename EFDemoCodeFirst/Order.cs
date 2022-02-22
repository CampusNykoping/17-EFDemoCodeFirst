using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemoCodeFirst
{
    public class Order
    {
        public int Id { get; set; }

        //TODO: Gör till vanlig int när vi lägger till tabell Employees
        public int CustomerId { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
