using System;
using System.Collections.Generic;
using System.Text;
using EnumDefinicao.Entities.Enums;

namespace EnumDefinicao.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment{ get; set; }
        public OrderStatus Status { get; set; }
        public override string ToString()
        {
            return this.Id + ", " + this.Moment + ", " + this.Status;
        }
    }
}
