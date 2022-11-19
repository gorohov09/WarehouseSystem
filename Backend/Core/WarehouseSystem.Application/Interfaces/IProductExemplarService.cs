using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseSystem.Application.DTO;
using WarehouseSystem.Domain;

namespace WarehouseSystem.Application.Interfaces
{
    public interface IProductExemplarService
    {
        IEnumerable<ProductExemplarDTO> GetProductExemplars();
    }
}
