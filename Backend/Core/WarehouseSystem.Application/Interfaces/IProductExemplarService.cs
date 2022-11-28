using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseSystem.Application.BO;

namespace WarehouseSystem.Application.Interfaces
{
    public interface IProductExemplarService
    {
        IEnumerable<ProductExemplarBO> GetProductExemplars();
    }
}
