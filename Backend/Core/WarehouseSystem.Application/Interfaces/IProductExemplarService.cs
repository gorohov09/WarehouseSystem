using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseSystem.Domain;

namespace WarehouseSystem.Application.Interfaces
{
    public interface IProductExemplarService
    {
        IEnumerable<ProductExemplar> GetProductExemplars();
    }
}
