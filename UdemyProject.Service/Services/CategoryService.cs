using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UdemyProject.Core.Models;
using UdemyProject.Core.Repositories;
using UdemyProject.Core.Services;
using UdemyProject.Core.UnitOfWorks;

namespace UdemyProject.Service.Services
{
    public class CategoryService : Service<Category>, ICategoryService
    {
        public CategoryService(IUnitOfWork unitOfWork, IRepository<Category> repository) : base(unitOfWork, repository)
        {
        }

        public async Task<Category> GetWithProductsByIdAsync(int categoryId)
        {
           return await _unitOfWork.Categories.GetWithProductsByIdAsync(categoryId);
        }
    }
}
