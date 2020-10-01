using Enumeracoes.Entities.Enums;
using System;
using System.Reflection.Metadata.Ecma335;

namespace Enumerações
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus StatusOrder { get; set; }

        public override string ToString()
        {
            return Id 
                + ", "
                +Moment
                + ", "
                + StatusOrder;

        }
    }
}
