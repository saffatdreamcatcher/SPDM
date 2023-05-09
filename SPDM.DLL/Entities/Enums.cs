using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPDM.DLL.Entities
{
    public enum WorkOrderStatus
    {
        Placed = 0,
        InProduction,
        ReadyForStock,
        InStock,
        Delivered,
        Recevied
    }
}
