using System;
using System.Collections.Generic;
using System.Text;

namespace Enumeracoes.Entities.Enums
{
    public enum OrderStatus : int
    {
        PendingPament = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
