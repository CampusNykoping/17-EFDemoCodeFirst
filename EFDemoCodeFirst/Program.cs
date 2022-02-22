
using EFDemoCodeFirst;

using Microsoft.EntityFrameworkCore;

using (var context = new EFDemoDbContext())
{
    var list = context.Orders.ToList();

    var orderDetails = context.OrderDetails.Include(o => o.Order).ToList();

    var order1 = new Order()
    {
        CustomerId = 1
        // NO OrderDate here!
    };

    var order2 = new Order()
    {
        CustomerId = 2,
        OrderDate = new DateTime(1999, 1, 2)
    };

    context.Orders.Add(order1);
    context.Orders.Add(order2);
    context.SaveChanges();

    var customers = new List<Customer>()
    {
        new Customer() {
            FirstName ="Claes",
            LastName = "Engelin",
            Address="Storgatan 1",
            Created=new DateTime(1999,1,3,8, 9, 10)
        },
        new Customer() {
            FirstName ="Patrik",
            LastName="Beijar",
            Address="Lillgatan 99"
        }
    };
    context.Customers.AddRange(customers);
    context.SaveChanges();

   
}

Console.ReadKey();
