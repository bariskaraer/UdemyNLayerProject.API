using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UdemyProject.Core.Models;

namespace UdemyProject.Core.Services
{
    public interface IProductService:IService<Product>
    {

        Task<Product> GetWithCategoryByIdAsync(int productId);
        // db ile değil veritabanı ile yapılan methodlar da buraya yazılabilir servicelerin yararı bu 
        // bool ControlInnerBarcode(Product product);

    }
}
