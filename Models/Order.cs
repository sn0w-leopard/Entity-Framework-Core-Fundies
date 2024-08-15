using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_Core_Fundies.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public DateTime OrderPlaced { get; set; }
        public DateTime? OrderFulFilled { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;
        public ICollection<OrderDetail> OrderDetails { get; set; } = null!;
    }
}
