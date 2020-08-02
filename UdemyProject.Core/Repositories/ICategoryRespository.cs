using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UdemyProject.Core.Models;

namespace UdemyProject.Core.Repositories
{
    public interface ICategoryRespository:IRepository<Category>
    {
        Task<Category> GetWithProductsByIdAsync(int categoryId);

    }
}
