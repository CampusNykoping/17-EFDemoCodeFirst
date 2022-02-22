using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDemoCodeFirst
{
    public class OrderDetail
    {
        [Key]
        public int Id { get; set; }
        public int OrderId { get; set; }

        //TODO: Gör till vanlig int när vi lägger till tabell Products
        public int? ProductId { get; set; }
        public int Quantity { get; set; }

        //[ForeignKey("OrderId")]
        public Order Order { get; set; }
    }
}