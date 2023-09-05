using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPDM.DLL.Enums
{
    public enum WorkOrderStatus
    {
        Placed = 1,
        InProduction,
        //ReadyForStock,
        InStock,
        Sold,
        Recevied
    }
}
